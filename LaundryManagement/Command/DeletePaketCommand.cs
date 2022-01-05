using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using LaundryManagement.ViewModel;
using LaundryManagement.Model;
using LaundryManagement.Control;

namespace LaundryManagement.Command
{
    public class DeletePaketCommand : ICommand
    {
        private readonly PaketItems _paket;
        public DeletePaketCommand(PaketItems Paket)
        {
            _paket = Paket;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show($"Apakah anda yakin ingin menghapus Paket {_paket.NamePaket} ?", "Konfirmasi Hapus", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                Database db = new Database();
                db.DeletePaket(_paket.ID);
                MessageBox.Show("Paket berhasil dihapus!", "Sukses", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
