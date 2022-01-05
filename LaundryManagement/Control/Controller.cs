using LaundryManagement.Model;
using System.Collections.ObjectModel;

namespace LaundryManagement.Control
{
    public class Controller
    {
        private Database db;
        public Controller()
        {
            Initialize();
        }

        private void Initialize()
        {
            db = new Database();
        }
        public ObservableCollection<PaketItems> GetPaket()
        {
            ObservableCollection<PaketItems> paketlist = new ObservableCollection<PaketItems>();

            foreach (PaketItems data in db.GetListPaket())
            {
                paketlist.Add(data);
            }
            return paketlist;
        }
        public ObservableCollection<PelangganModel> GetPelanggan()
        {
            ObservableCollection<PelangganModel> pelangganList = new ObservableCollection<PelangganModel>();

            foreach (PelangganModel data in db.GetListPelanggan())
            {
                pelangganList.Add(data);
            }
            return pelangganList;
        }
        public ObservableCollection<TransaksiModel> GetTransaksi()
        {
            ObservableCollection<TransaksiModel> TransaksiList = new ObservableCollection<TransaksiModel>();

            foreach (TransaksiModel data in db.GetListTransaksi())
            {
                TransaksiList.Add(data);
            }
            return TransaksiList;
        }
    }
}
