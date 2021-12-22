using AutoMapper;
using EProdajaRacunarskeOpreme.WebApi.Database;
using EProdajaRacunarskeOpreme.WebApi.IRepository;
using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EProdajaRacunarskeOpreme.WebApi.Repository
{
    public class RepositoryRecommended : IRepositoryRecommended
    {
        private readonly MojDbContext _context;
        private readonly IMapper _mapper;
        public RepositoryRecommended(MojDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        Dictionary<int, List<Database.Ocjene>> proizvodi = new Dictionary<int, List<Database.Ocjene>>();
     
        private List<Database.Proizvodi> LoadSimilar(int proizvodid)
        {
            LoadOtherProduct(proizvodid);
            List<Database.Ocjene> ratingOfCurrent = _context.Ocjene.Where(x => x.ProizvodId == proizvodid).OrderBy(x => x.KlijentId).ToList();

            List<Database.Ocjene> ratings1 = new List<Database.Ocjene>();
            List<Database.Ocjene> ratings2 = new List<Database.Ocjene>();
            List<Database.Proizvodi> recommendedProduct = new List<Database.Proizvodi>();

            foreach (var product in proizvodi)
            {
                foreach (Database.Ocjene rating in ratingOfCurrent)
                {
                    if (product.Value.Where(w => w.KlijentId == rating.KlijentId).Count() > 0)
                    {
                        ratings1.Add(rating);
                        ratings2.Add(product.Value.Where(w => w.KlijentId == rating.KlijentId).First());
                    }
                }
                double similarity = GetSimilarity(ratings1, ratings2);
                if (similarity > 0.5)
                {
                    recommendedProduct.Add(_context.Proizvodi.Where(w => w.ProizvodId == product.Key).FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }
            return recommendedProduct;
        }

        private double GetSimilarity(List<Database.Ocjene> ratings1, List<Database.Ocjene> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }
            double x = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < ratings1.Count; i++)
            {
                x += ratings1[i].Ocjena * ratings2[i].Ocjena;
                y1 += ratings1[i].Ocjena * ratings1[i].Ocjena;
                y2 += ratings2[i].Ocjena * ratings2[i].Ocjena;
            }
            y1 = Math.Sqrt(y1);
            y2 = Math.Sqrt(y2);

            double y = y1 * y2;
            if (y == 0)
                return 0;
            return x / y;
        }
        private void LoadOtherProduct(int proizvodid)
        {
            List<Database.Proizvodi> list = _context.Proizvodi.Where(w => w.ProizvodId != proizvodid).ToList();
            List<Database.Ocjene> ratings = new List<Database.Ocjene>();
            foreach (var item in list)
            {
                ratings = _context.Ocjene.Where(w => w.ProizvodId == item.ProizvodId).OrderBy(w => w.ProizvodId).ToList();
                if (ratings.Count > 0)
                {
                    proizvodi.Add(item.ProizvodId, ratings);
                }
            }

        }

        public List<Prodaja.Model.Proizvodi> RecommendedProduct(int proizvodid)
        {
            
                var tmp = LoadSimilar(proizvodid);
                return _mapper.Map<List<Prodaja.Model.Proizvodi>>(tmp);
            
        }
    }
}
