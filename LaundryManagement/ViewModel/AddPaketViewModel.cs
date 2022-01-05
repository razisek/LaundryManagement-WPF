using System.Windows.Input;
using System.Windows;
using LaundryManagement.Model;
using LaundryManagement.Command;

namespace LaundryManagement.ViewModel
{
    public class AddPaketViewModel : MainViewModel
    {
        public ICommand ButtonAddPaketCommand { get; }

        public AddPaketViewModel()
        {
            ButtonAddPaketCommand = new AddPaketCommand(this);
        }

        private string namaPaket;
        private string satuanPaket;
        private string hargaPaket;
        public string PaketName
        {
            get => namaPaket;
            set
            {
                namaPaket = value;
                OnPropertyChanged("namaPaket");
            }
        }

        public string SatuanPaket
        {
            get => satuanPaket;
            set
            {
                satuanPaket = value;
                OnPropertyChanged("namaPaket");
            }
        }

        public string HargaPaket
        {
            get => hargaPaket;
            set
            {
                hargaPaket = value;
                OnPropertyChanged("namaPaket");
            }
        }
    }
}