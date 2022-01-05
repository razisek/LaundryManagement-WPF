
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using LaundryManagement.Model;
using LaundryManagement.Control;

namespace LaundryManagement.ViewModel
{
    public class HomeViewModel : MainViewModel
    {
        public ObservableCollection<HomeItems> HomeList { get; private set; }
        public string JmlTransaksi { get; set; }
        public string JmlPaket { get; set; }
        public string JmlPelanggan { get; set; }
        public HomeViewModel()
        {
            Database db = new Database();
            HomeItems homeItems = db.getHomeList();
            JmlTransaksi = homeItems.TotalTransaksi;
            JmlPaket = homeItems.TotalPaket;
            JmlPelanggan = homeItems.TotalPelanggan;
            OnPropertyChanged("JmlTransaksi");
            OnPropertyChanged("JmlPaket");
            OnPropertyChanged("JmlPelanggan");
        }
    }
}