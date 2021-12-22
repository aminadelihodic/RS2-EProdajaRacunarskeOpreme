using Prodaja.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EProdajaRacOp.MobileApp.ViewModels
{
    public class ProizvodiViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Proizvodi");
        private readonly APIService _serviceVrsteProiz = new APIService("VrsteProizvoda");
        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Proizvodi> ListaProizvoda { get; set; } = new ObservableCollection<Proizvodi>();
        public ObservableCollection<VrsteProizvoda> VrsteProizvodaList { get; set; } = new ObservableCollection<VrsteProizvoda>();
        VrsteProizvoda _selectedVrstaProizvoda = null;

        public VrsteProizvoda SelectedVrstaProizvoda
        {
            get { return _selectedVrstaProizvoda; }
            set
            {
                SetProperty(ref _selectedVrstaProizvoda, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (VrsteProizvodaList.Count == 0)
            {
                var vrsteProizvodaList = await _serviceVrsteProiz.GetAll<List<VrsteProizvoda>>(null);

                foreach (var vrsteProizvoda in vrsteProizvodaList)
                {
                    VrsteProizvodaList.Add(vrsteProizvoda);
                }

                if(SelectedVrstaProizvoda is null && VrsteProizvodaList.Count > 0)
                {
                    SelectedVrstaProizvoda = VrsteProizvodaList[0];
                }
            }

            if (SelectedVrstaProizvoda != null)
            {
                ProizvodiSearchObject searchRequest = new ProizvodiSearchObject();
                searchRequest.VrstaProizvodaId = SelectedVrstaProizvoda.VrstaProizvodaId;

                var list = await _service.GetAll<IEnumerable<Proizvodi>>(searchRequest);
                ListaProizvoda.Clear();
                foreach (var proizvod in list)
                {
                    ListaProizvoda.Add(proizvod);
                }
            }

        }
    }
}
