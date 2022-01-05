using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using LaundryManagement.Model;

namespace LaundryManagement.ViewModel
{
    class NavigationViewModel : DependencyObject, INotifyPropertyChanged
    {
        private CollectionViewSource MenuItemsCollection;
        public ICollectionView SourceCollection => MenuItemsCollection.View;

        public NavigationViewModel()
        {
            ObservableCollection<MenuItems> menuItems = new ObservableCollection<MenuItems>
            {
                new MenuItems { MenuName = "Home", MenuImage = @"Assets/Home_Icon.png" },
                new MenuItems { MenuName = "Paket", MenuImage = @"Assets/Paket_Icon.png" },
                new MenuItems { MenuName = "Pelanggan", MenuImage = @"Assets/User_Icon.png" },
                new MenuItems { MenuName = "Transaksi", MenuImage = @"Assets/Wash_Icon.png" }
            };

            MenuItemsCollection = new CollectionViewSource { Source = menuItems };

            // Set Startup Page
            SelectedViewModel = new HomeViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private string filterText;

        public string FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                MenuItemsCollection.View.Refresh();
                OnPropertyChanged("FilterText");
            }
        }

        private object _selectedViewModel;
        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set { _selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }

        // Switch Views
        public void SwitchViews(object parameter)
        {
            switch (parameter)
            {
                case "Home":
                    SelectedViewModel = new HomeViewModel();
                    break;
                case "Paket":
                    SelectedViewModel = new PaketViewModel();
                    break;
                case "Pelanggan":
                    SelectedViewModel = new PelangganViewModel();
                    break;
                case "Transaksi":
                    SelectedViewModel = new TransaksiViewModal();
                    break;
                default:
                    SelectedViewModel = new HomeViewModel();
                    break;
            }
        }

        // Menu Button Command
        private ICommand _menucommand;
        public ICommand MenuCommand
        {
            get
            {
                if (_menucommand == null)
                {
                    _menucommand = new RelayCommand(param => SwitchViews(param));
                }
                return _menucommand;
            }
        }

        private void PageAddPaket()
        {
            SelectedViewModel = new AddPaketViewModel();
        }

        private void PageAddPelanggan()
        {
            SelectedViewModel = new AddPelangganViewModel();
        }

        private ICommand commandTambahPelanggan;
        public ICommand GoToAddPelanggan
        {
            get
            {
                if (commandTambahPelanggan == null)
                {
                    commandTambahPelanggan = new RelayCommand(param => PageAddPelanggan());
                }
                return commandTambahPelanggan;
            }
        }

        public void ShowPelanggan()
        {
            SelectedViewModel = new PelangganViewModel();
        }

        // Back button Command
        private ICommand commandBackPagePelanggan;
        public ICommand BackPagePelanggan
        {
            get
            {
                if (commandBackPagePelanggan == null)
                {
                    commandBackPagePelanggan = new RelayCommand(p => ShowPelanggan());
                }
                return commandBackPagePelanggan;
            }
        }

        private ICommand commandTambahPaket;
        public ICommand GoToAddPaket
        {
            get
            {
                if (commandTambahPaket == null)
                {
                    commandTambahPaket = new RelayCommand(param => PageAddPaket());
                }
                return commandTambahPaket;
            }
        }

        public void ShowPaketPage()
        {
            SelectedViewModel = new PaketViewModel();
        }

        // Back button Command
        private ICommand commandBackPagePaket;
        public ICommand BackPagePaket
        {
            get
            {
                if (commandBackPagePaket == null)
                {
                    commandBackPagePaket = new RelayCommand(p => ShowPaketPage());
                }
                return commandBackPagePaket;
            }
        }

        // Close App
        public void CloseApp(object obj)
        {
            MainWindow win = obj as MainWindow;
            win.Close();
        }

        // Close App Command
        private ICommand _closeCommand;
        public ICommand CloseAppCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(p => CloseApp(p));
                }
                return _closeCommand;
            }
        }

        private ICommand _MinimizeCommand;
        public ICommand MinimizeAppCommand
        {
            get
            {
                _MinimizeCommand = new RelayCommand(p => this.MinimizeApp());
                return _MinimizeCommand;
            }
        }
        private void MinimizeApp()
        {
            foreach(Window window in Application.Current.Windows)
            {
                if(window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).WindowState = WindowState.Minimized;
                }
            }
        }
    }
}