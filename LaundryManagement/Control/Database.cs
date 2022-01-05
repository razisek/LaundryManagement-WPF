using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows;
using LaundryManagement.Model;
using System.Globalization;

namespace LaundryManagement.Control
{
    public class Database
    {
        private readonly MySqlConnection connection;
        public Database()
        {
            string connectionString = "SERVER=localhost;DATABASE=laundry;UID=root;";

            connection = new MySqlConnection(connectionString);
        }

        private bool getConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        _ = MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        _ = MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        _ = MessageBox.Show("Cannot connect to the server, make sure the server is active!");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                _ = MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<PaketItems> GetListPaket()
        {
            string query = "SELECT * FROM paket";
            List<PaketItems> list = new List<PaketItems>();

            if (getConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                int count = 0;
                while (data.Read())
                {
                    count++;
                    string harga = string.Format(CultureInfo.CreateSpecificCulture("id-ID"), "{0:C}", double.Parse(data["harga_paket"].ToString()));
                    list.Add(new PaketItems()
                    {
                        ID = data["id_paket"].ToString(),
                        NamePaket = data["nama_paket"].ToString(),
                        SatuanPaket = data["satuan"].ToString(),
                        PricePaket = harga,
                        Number = count
                    });
                }

                data.Close();

                _ = CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }

        public void AddPaket(string ID, string Nama, string Satuan, double harga)
        {
            if (getConnection())
            {
                string query = "INSERT INTO paket(id_paket, nama_paket, satuan, harga_paket) VALUES(@Id, @Nama, @Satuan, @Harga)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                _ = cmd.Parameters.AddWithValue("@Id", ID);
                _ = cmd.Parameters.AddWithValue("@Nama", Nama);
                _ = cmd.Parameters.AddWithValue("@Satuan", Satuan);
                _ = cmd.Parameters.AddWithValue("@Harga", harga);
                _ = cmd.ExecuteNonQuery();

                _ = CloseConnection();
            }
        }

        public void DeletePaket(string ID)
        {
            if (getConnection())
            {
                string query = "DELETE FROM paket WHERE id_paket=@Id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                _ = cmd.Parameters.AddWithValue("@Id", ID);
                _ = cmd.ExecuteNonQuery();

                _ = CloseConnection();
            }
        }
        public List<PelangganModel> GetListPelanggan()
        {
            string query = "SELECT * FROM pelanggan";
            List<PelangganModel> list = new List<PelangganModel>();

            if (getConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                int count = 0;
                while (data.Read())
                {
                    count++;
                    list.Add(new PelangganModel()
                    {
                        ID = data["id_pelanggan"].ToString(),
                        NamaPelanggan = data["nama"].ToString(),
                        Telepon = data["no_telepon"].ToString(),
                        Kelamin = data["jenis_kelamin"].ToString() == "L" ? "Laki-laki" : "Perempuan",
                        Status = int.Parse(data["status"].ToString()) == 1 ? "Aktif" : "Tidak Aktif",
                        Number = count
                    });
                }

                data.Close();

                _ = CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }
        public void AddPelanggan(string ID, string Nama, string Telp, string kelamin, string status)
        {
            if (getConnection())
            {
                string query = "INSERT INTO pelanggan(id_pelanggan, nama, no_telepon, jenis_kelamin, status) VALUES(@Id, @Nama, @Telp, @Kelamin, @Status)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string JK = kelamin == "Perempuan" ? "P" : "L";
                int getStatus = status == "Aktif" ? 1 : 0;
                _ = cmd.Parameters.AddWithValue("@Id", ID);
                _ = cmd.Parameters.AddWithValue("@Nama", Nama);
                _ = cmd.Parameters.AddWithValue("@Telp", Telp);
                _ = cmd.Parameters.AddWithValue("@Kelamin", JK);
                _ = cmd.Parameters.AddWithValue("@Status", getStatus);
                _ = cmd.ExecuteNonQuery();

                _ = CloseConnection();
            }
        }
        public List<TransaksiModel> GetListTransaksi()
        {
            string query = "SELECT * FROM transaksi INNER JOIN pelanggan ON transaksi.id_pelanggan = pelanggan.id_pelanggan INNER JOIN paket ON transaksi.id_paket = paket.id_paket";
            List<TransaksiModel> list = new List<TransaksiModel>();

            if (getConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader data = cmd.ExecuteReader();
                int count = 0;
                while (data.Read())
                {
                    count++;
                    string harga = string.Format(CultureInfo.CreateSpecificCulture("id-ID"), "{0:C}", double.Parse(data["harga"].ToString()));
                    list.Add(new TransaksiModel()
                    {
                        ID = data["id_transaksi"].ToString(),
                        NamaPelanggan = data["nama"].ToString(),
                        Telepon = data["no_telepon"].ToString(),
                        JenisPaket = data["nama_paket"].ToString(),
                        Berat = int.Parse(data["berat_paket"].ToString()),
                        Harga = harga,
                        Tanggal = data["tanggal_pesan"].ToString(),
                        Number = count
                    });
                }

                data.Close();

                _ = CloseConnection();

                return list;
            }
            else
            {
                return list;
            }
        }

        public HomeItems getHomeList()
        {
            HomeItems home = new HomeItems();
            string query1 = "SELECT COUNT(id_transaksi) AS jumlah_transaksi FROM transaksi";
            if (getConnection())
            { 
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader data1 = cmd1.ExecuteReader();
                while (data1.Read())
                { 
                    home.TotalTransaksi = data1["jumlah_transaksi"].ToString();
                }
                data1.Close();
                string query2 = "SELECT COUNT(id_paket) AS jumlah_paket FROM paket";
                cmd1 = new MySqlCommand(query2, connection);
                data1 = cmd1.ExecuteReader();
                while (data1.Read())
                {
                    home.TotalPaket = data1["jumlah_paket"].ToString();
                }
                data1.Close();
                string query3 = "SELECT COUNT(id_pelanggan) AS jumlah_pelanggan FROM pelanggan";
                cmd1 = new MySqlCommand(query3, connection);
                data1 = cmd1.ExecuteReader();
                while (data1.Read())
                {
                    home.TotalPelanggan = data1["jumlah_pelanggan"].ToString();
                }
            }

            _ = CloseConnection();


            return home;
        }
    }
}