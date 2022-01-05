using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using LaundryManagement.ViewModel;
using LaundryManagement.Control;

namespace LaundryManagement.Command
{
    public class AddPaketCommand : ICommand
    {
        private readonly AddPaketViewModel _addPaket;
        public AddPaketCommand(AddPaketViewModel addPaket)
        {
            _addPaket = addPaket;

            _addPaket.PropertyChanged += ViewModel_PropertyChanged;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_addPaket.PaketName) &&
                !string.IsNullOrEmpty(_addPaket.SatuanPaket) &&
                !string.IsNullOrEmpty(_addPaket.HargaPaket);
        }

        public void Execute(object parameter)
        {
            Database db = new Database();
            int rand = new Random().Next(100, 1000);
            db.AddPaket($"PL{rand}", _addPaket.PaketName, _addPaket.SatuanPaket, double.Parse(_addPaket.HargaPaket));
            MessageBox.Show($"Paket Sukses di Tambahkan!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}