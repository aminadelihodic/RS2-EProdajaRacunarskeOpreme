using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using EProdajaRacunarskeOpreme.WebApi.IRepository;

namespace EProdajaRacunarskeOpreme.WebApi.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IRepositoryKorisnici _korisniciService;
        private readonly IRepositoryKlijenti _klijentiService;
        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IRepositoryKorisnici korisniciService, IRepositoryKlijenti klijentiService) : base(options, logger, encoder, clock)
        {
            _korisniciService = korisniciService;
            _klijentiService = klijentiService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing authorization header");
            }

            Prodaja.Model.Korisnici korisnici = null;
            Prodaja.Model.Klijenti klijenti = null;
   
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];

                try
                {
                    korisnici = await _korisniciService.Login(username, password);
                }
                catch (Exception)
                {
                    klijenti = await _klijentiService.Login(username, password);
                }
            }
            catch (Exception ex)
            {
                return AuthenticateResult.Fail("Incorrect username or password");
            }

            if (korisnici is null && klijenti is null)
                return AuthenticateResult.Fail("Invalid username or password");

            string korisnickoIme, ime;
            List<string> uloge = new List<string>();

            if (korisnici != null)
            {
                _korisniciService.SetLogiraniKorisnik(korisnici);

                korisnickoIme = korisnici.KorisnickoIme;
                ime = korisnici.Ime;

                uloge.AddRange(korisnici.KorisniciUloge.Select(x => x.Uloga.Naziv));
            }
            else
            {
                _klijentiService.SetLogiraniKlijent(klijenti);
                korisnickoIme = klijenti.KorisnickoIme;
                ime = klijenti.Ime;

                uloge.Add("Klijent");
            }

            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, korisnickoIme),
                new Claim(ClaimTypes.Name, ime),
            };

            foreach (var uloga in uloge)
            {
                claims.Add(new Claim(ClaimTypes.Role, uloga));
            }

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }


    }
}
