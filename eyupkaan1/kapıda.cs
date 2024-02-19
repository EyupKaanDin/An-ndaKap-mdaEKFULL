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

namespace eyupkaan1
{
    public partial class kapıda : Form
    {
        public kapıda()
        {
            InitializeComponent();

        }
        private SqlConnection baglanti;
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True";
        private Random rastgele = new Random();

        private void kargo_Load(object sender, EventArgs e)
        {

        }

        private void kargo_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string takipNumarasi = TakipNumarasiTextBox.Text;
            string durum = DurumTextBox.Text;
            string adres = textBox1.Text;
            DateTime teslimTarihi = TeslimTarihiDateTimePicker.Value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string kod = "INSERT INTO Gonderimler (TakipNumarasi, Durum, TeslimTarihi,Adres) VALUES (@TakipNumarasi, @Durum, @TeslimTarihi,@Adres)";
                SqlCommand command = new SqlCommand(kod, connection);
                command.Parameters.AddWithValue("@TakipNumarasi", takipNumarasi);
                command.Parameters.AddWithValue("@Durum", durum);
                command.Parameters.AddWithValue("@TeslimTarihi", teslimTarihi);
                command.Parameters.AddWithValue("@Adres", adres);

                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Kargo bilgileri başarıyla kaydedildi.");
            }

        }

        private void DurumTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string takipNumarasi = TakipNumarasiTextBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT GonderimID, TakipNumarasi, Durum, TeslimTarihi , Adres FROM Gonderimler WHERE TakipNumarasi = @TakipNumarasi";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TakipNumarasi", takipNumarasi);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int gonderimID = Convert.ToInt32(reader["GonderimID"]);
                    string durum = reader["Durum"].ToString();
                    string Adres = reader["Adres"].ToString();
                    DateTime teslimTarihi = Convert.ToDateTime(reader["TeslimTarihi"]);

                    MessageBox.Show($"Kargo bilgileri:\nGönderim ID: {gonderimID}\nDurum: {durum}\nTeslim Tarihi: {teslimTarihi}\n Adres : {Adres} ");
                }
                else
                {
                    MessageBox.Show("Belirtilen takip numarasına ait kargo bulunamadı.");
                }

                reader.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SayiUret()
        {
            int rastgeleSayi = rastgele.Next(1000, 9999);
            string sayiMetni = rastgeleSayi.ToString();
            TakipNumarasiTextBox.Text = sayiMetni;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SayiUret();
        }
    }
}







