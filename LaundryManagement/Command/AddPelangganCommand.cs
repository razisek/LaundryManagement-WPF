using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using LaundryManagement.ViewModel;
using LaundryManagement.Control;

namespace LaundryManagement.Command
{
    public class AddPelangganCommand : ICommand
    {
        private readonly AddPelangganViewModel _pelanggan;
        public AddPelangganCommand(AddPelangganViewModel pelanggan)
        {
            _pelanggan = pelanggan;

            _pelanggan.PropertyChanged += ViewModel_PropertyChanged;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_pelanggan.NamePelanggan) &&
                !string.IsNullOrEmpty(_pelanggan.TelpPelanggan);
        }

        public void Execute(object parameter)
        {
            Database db = new Database();
            int rand = new Random().Next(100, 1000);
            db.AddPelanggan($"PG{rand}", _pelanggan.NamePelanggan, _pelanggan.TelpPelanggan, _pelanggan.SelectedKelamin.kelaminName, _pelanggan.StatusCustomer.status);
            MessageBox.Show($"Paket Sukses di Tambahkan!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
