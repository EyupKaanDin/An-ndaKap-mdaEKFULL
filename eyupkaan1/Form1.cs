using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eyupkaan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = giris; Integrated Security = True");

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(kayıtS.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kayıtS.PasswordChar == '*')
            {
                button4.BringToFront();
                kayıtS.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kayıtS.PasswordChar == '\0')
            {
                button3.BringToFront();
                kayıtS.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gmailtext.Text))
            {
                MessageBox.Show("Gmail Kısmını boş bırakma !");
            }
            else
            {
                string sorgu = "insert into kayit(kul_ad,sifre,gmail) values (@kul_ad,@sifre,@gmail)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("kul_ad", textBox1.Text);
                komut.Parameters.AddWithValue("sifre", kayıtS.Text);
                komut.Parameters.AddWithValue("gmail", gmailtext.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarılı bir şekilde tamamlandı");
                textBox1.Clear();
                kayıtS.Clear();
                baglanti.Close();
            }
            }

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            giris form2 = new giris();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admingiris admng = new admingiris();
            admng.Show();
        }
    }
}
