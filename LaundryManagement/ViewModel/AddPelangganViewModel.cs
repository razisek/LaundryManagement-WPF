using System;
using System.Collections.Generic;
using System.Windows.Input;
using LaundryManagement.Model;
using LaundryManagement.Command;

namespace LaundryManagement.ViewModel
{
    public class AddPelangganViewModel : MainViewModel
    {
        public ICommand ButtonAddPelangganCommand { get; }
        private string NameCustomer;
        private string TelpCustomer;
        public AddPelangganViewModel()
        {
            ButtonAddPelangganCommand = new AddPelangganCommand(this);
        }
        public List<JenisKelamin> Kelamins
        {
            get
            {
                var list = new List<JenisKelamin>();
                list.Add(new JenisKelamin { jenisKelamin = new JK { kelaminName = "Laki-laki" } });
                list.Add(new JenisKelamin { jenisKelamin = new JK { kelaminName = "Perempuan" } });

                return list;
            }
        }

        public List<CustomerActive> StatusCus
        {
            get
            {
                var list = new List<CustomerActive>();
                list.Add(new CustomerActive { statusPelanggan = new ActiveCustm { status = "Aktif" } });
                list.Add(new CustomerActive { statusPelanggan = new ActiveCustm { status = "Tidak AKtif" } });

                return list;
            }
        }

        public JK selectJK;
        public JK SelectedKelamin
        {
            get => selectJK;
            set
            {
                selectJK = value;
            }
        }

        public ActiveCustm selectCus;
        public ActiveCustm StatusCustomer
        {
            get => selectCus;
            set
            {
                selectCus = value;
            }
        }
        public string NamePelanggan
        {
            get => NameCustomer;
            set
            {
                NameCustomer = value;
                OnPropertyChanged("NameCustomer");
            }
        }
        public string TelpPelanggan
        {
            get => TelpCustomer;
            set
            {
                TelpCustomer = value;
                OnPropertyChanged("TelpCustomer");
            }
        }
    }
}
