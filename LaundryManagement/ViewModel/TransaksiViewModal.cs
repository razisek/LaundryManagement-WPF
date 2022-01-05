using LaundryManagement.Control;
using System.Collections.ObjectModel;
using LaundryManagement.Model;

namespace LaundryManagement.ViewModel
{
    class TransaksiViewModal : MainViewModel
    {
        public ObservableCollection<TransaksiModel> TransaksiList { get; private set; }
        private Controller kontrol;
        public TransaksiViewModal()
        {
            OnPropertyChanged("TransaksiList");

            kontrol = new Controller();

            TransaksiList = new ObservableCollection<TransaksiModel>();
            TransaksiList = kontrol.GetTransaksi();
        }
    }
}
