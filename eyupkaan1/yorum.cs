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
// Data Source=.\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True
namespace eyupkaan1
{
    public partial class yorum : Form
    {
        private string baglantı = "Data Source=.\\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True";
        private string tabloAdi = "Yorumlar";
        public yorum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string yorum = txtYorum.Text;
            using (SqlConnection connection = new SqlConnection(baglantı))
            {
                connection.Open();

                string kod = "INSERT INTO " + tabloAdi + " (Ad, Soyad, Yorum) VALUES (@Ad, @Soyad, @Yorum)";

                SqlCommand komut1 = new SqlCommand(kod, connection);
                komut1.Parameters.AddWithValue("@Ad", ad);
                komut1.Parameters.AddWithValue("@Soyad", soyad);
                komut1.Parameters.AddWithValue("@Yorum", yorum);

                komut1.ExecuteNonQuery();
            }

            MessageBox.Show("Yorumunuz kaydedildi.");

           // Temizliyor.
            txtYorum.Text = string.Empty;


        }

        private void yorum_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Ad", "Ad");
            dataGridView1.Columns.Add("Soyad", "Soyad");
            dataGridView1.Columns.Add("Yorum", "Yorum");

        }



        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(baglantı))
            {
                connection.Open();

                string kod2 = "SELECT * FROM " + tabloAdi;

                SqlCommand komut = new SqlCommand(kod2, connection);
                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    string ad = reader["Ad"].ToString();
                    string soyad = reader["Soyad"].ToString();
                    string yorum = reader["Yorum"].ToString();

                    dataGridView1.Rows.Add(ad, soyad, yorum);
                }

                reader.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seciliOge = comboBox1.Text;
            txtYorum.Text = seciliOge;
        }
    }
    }
    

    




