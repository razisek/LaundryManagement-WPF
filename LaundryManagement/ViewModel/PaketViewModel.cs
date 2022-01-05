using System.Collections.ObjectModel;
using System.Windows.Input;
using LaundryManagement.Model;
using LaundryManagement.Control;
using LaundryManagement.Command;
using System.Windows;

namespace LaundryManagement.ViewModel
{
    public class PaketViewModel : MainViewModel
    {
        public ObservableCollection<PaketItems> PaketList { get; private set; }

        private Controller kontrol;

        private PaketItems selectedValue;
        public PaketItems getData { get; private set; }

        public PaketItems SelectionValue
        {
            get => selectedValue;
            set
            {
                selectedValue = value;
                OnPropertyChanged(nameof(SelectionValue));
            }
        }

        public PaketItems SelectedData
        {
            get => getData;
            set
            {
                getData = value;
                OnPropertyChanged(nameof(SelectedData));
            }
        }

        public PaketViewModel()
        {
            OnPropertyChanged("PaketList");

            getData = new PaketItems();
            selectedValue = new PaketItems();
            kontrol = new Controller();

            PaketList = new ObservableCollection<PaketItems>();
            PaketList = kontrol.GetPaket();
        }
    }
}