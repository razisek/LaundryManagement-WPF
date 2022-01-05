using System.Collections.ObjectModel;
using System.Windows.Input;
using LaundryManagement.Model;
using LaundryManagement.Control;

namespace LaundryManagement.ViewModel
{
    public class PelangganViewModel : MainViewModel
    {
        public ObservableCollection<PelangganModel> PelangganList { get; private set; }
        private Controller kontrol;

        public PelangganViewModel()
        {
            kontrol = new Controller();

            PelangganList = new ObservableCollection<PelangganModel>();
            PelangganList = kontrol.GetPelanggan();
        }

    }
}
