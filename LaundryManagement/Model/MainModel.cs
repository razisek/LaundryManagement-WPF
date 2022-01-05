using System;
using System.Collections.ObjectModel;
using LaundryManagement.Command;

namespace LaundryManagement.Model
{
    // Main Menu Items
    public class MenuItems
    {
        public string MenuName { get; set; }
        public string MenuImage { get; set; }
    }

    // Home Page
    public class HomeItems
    {
        public string TotalPaket { get; set; }
        public string TotalPelanggan { get; set; }
        public string TotalTransaksi { get; set; }
    }

    // Paket Page
    public class PaketItems
    {
        public DeletePaketCommand ButtonDeletePaket { get; set; }

        public PaketItems()
        {
            ButtonDeletePaket = new DeletePaketCommand(this);
        }
        public string ID { get; set; }
        public int Number { get; set; }
        public string NamePaket { get; set; }
        public string SatuanPaket { get; set; }
        public string PricePaket { get; set; }
    }
    public class PelangganModel
    {
        public string ID { get; set; }
        public int Number { get; set; }
        public string NamaPelanggan { get; set; }
        public string Telepon { get; set; }
        public string Kelamin { get; set; }
        public string Status { get; set; }
    }

    public class JK
    {
        public string kelaminName { get; set; }
    }
    public class JenisKelamin
    {
        public JK jenisKelamin { get; set; }
    }

    public class ActiveCustm
    {
        public string status { get; set; }
    }
    public class CustomerActive
    {
        public ActiveCustm statusPelanggan { get; set; }
    }

    public class TransaksiModel
    {
        public int Number { get; set; }
        public string ID { get; set; }
        public string NamaPelanggan { get; set; }
        public string Telepon { get; set; }
        public string JenisPaket { get; set; }
        public int Berat { get; set; }
        public string Harga { get; set; }
        public string Tanggal { get; set; }
    }
}