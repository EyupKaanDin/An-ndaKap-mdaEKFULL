using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace eyupkaan1
{
    public partial class button5 : Form
    {
        public button5()
        {

            InitializeComponent();

        }
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True";
        static string constring = ("Data Source=.\\SQLEXPRESS;Initial Catalog = giris; Integrated Security = True");
        SqlConnection baglan = new SqlConnection(constring);
        string baglantıKod = "Data Source=.\\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True";
        private string ConnectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True";
        private SqlConnection conn;

        private SqlConnection baglanti;

        public void kayıtları_getir()
        {
            baglan.Open();
            string getir = " select * from kayit ";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            kayıtları_getir();
        }
        public void kayit_sil()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int sec = dataGridView1.SelectedRows[0].Index;
                int kayitID = Convert.ToInt32(dataGridView1.Rows[sec].Cells["ID"].Value);

                baglan.Open();
                string sil = "DELETE FROM kayit WHERE ID = @ID";
                SqlCommand komut = new SqlCommand(sil, baglan);
                komut.Parameters.AddWithValue("@ID", kayitID);
                komut.ExecuteNonQuery();
                baglan.Close();

                kayıtları_getir();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("GonderimID", "Gönderim ID");
            dataGridView2.Columns.Add("TakipNumarasi", "Takip Numarası");
            dataGridView2.Columns.Add("Durum", "Durum");
            dataGridView2.Columns.Add("TeslimTarihi", "Teslim Tarihi");
            dataGridView2.Columns.Add("Adres", " Adres ");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int gonderimID = Convert.ToInt32(GonderimIDTextBox.Text);
            string yeniDurum = YeniDurumTextBox.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Gonderimler SET Durum = @YeniDurum WHERE GonderimID = @GonderimID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@YeniDurum", yeniDurum);
                command.Parameters.AddWithValue("@GonderimID", gonderimID);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kargo bilgileri güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.");
                }
            }


            GonderimIDTextBox.Clear();
            YeniDurumTextBox.Clear();
        }

        private void SilButton_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {

            int gonderimID = Convert.ToInt32(GonderimIDTextBox.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string kod = "DELETE FROM Gonderimler WHERE GonderimID = @GonderimID";
                SqlCommand command = new SqlCommand(kod, connection);
                command.Parameters.AddWithValue("@GonderimID", gonderimID);

                connection.Open();
                int Sutun = command.ExecuteNonQuery();

                if (Sutun > 0)
                {
                    MessageBox.Show("Kargo bilgisi silindi.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GosterKargoBilgileri();
        }
        private void GosterKargoBilgileri()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string kod = "SELECT GonderimID, TakipNumarasi, Durum, TeslimTarihi , Adres FROM Gonderimler";
                SqlCommand command = new SqlCommand(kod, connection);

                connection.Open();

                SqlDataReader oku = command.ExecuteReader();

                while (oku.Read())
                {
                    int GonderimID = Convert.ToInt32(oku["GonderimID"]);
                    string TakipNumarasi = oku["TakipNumarasi"].ToString();
                    string Durum = oku["Durum"].ToString();
                    string Adres = oku["Adres"].ToString();
                    DateTime TeslimTarihi = Convert.ToDateTime(oku["TeslimTarihi"]);

                    dataGridView2.Rows.Add(GonderimID, TakipNumarasi, Durum, TeslimTarihi, Adres);
                }

                oku.Close();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void Kayıtlar_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglantı = new SqlConnection(baglantıKod))
            {
                string sorgu = "SELECT * FROM Basvurular";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglantı);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                dataGridView3.DataSource = dataTable;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow seçilen = dataGridView3.SelectedRows[0];
                int basvuruID = Convert.ToInt32(seçilen.Cells["BasvuruID"].Value);

                string baglantıKod = "Data Source=.\\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True";
                using (SqlConnection baglantı = new SqlConnection(baglantıKod))
                {
                    baglantı.Open();
                    string silmeSorgusu = "DELETE FROM Basvurular WHERE BasvuruID = @BasvuruID";
                    SqlCommand komut = new SqlCommand(silmeSorgusu, baglantı);
                   komut.Parameters.AddWithValue("@BasvuruID", basvuruID);
                   komut.ExecuteNonQuery();
                }

                dataGridView3.Rows.Remove(seçilen);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir başvuru seçin.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kayit_sil();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {


            string kulAd = TxtKulAd.Text;
            string sifre = TxtSifre.Text;
            string gmail = TxtGmail.Text;

            string ConnectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(ConnectionStr))
            {
                conn.Open();

                string ekleQuery = "INSERT INTO kayit (kul_ad, sifre, gmail) VALUES (@kulAd, @sifre, @gmail)";

                SqlCommand cmd = new SqlCommand(ekleQuery, conn);
                cmd.Parameters.AddWithValue("@kulAd", kulAd);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@gmail", gmail);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kayıt eklendi.");
        }
    }
    }















