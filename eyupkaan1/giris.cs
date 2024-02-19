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

namespace eyupkaan1
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = giris; Integrated Security = True");
        int gkod;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                Form1 form1 = new Form1();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (giriss.PasswordChar == '*')
            {
                button6.BringToFront();
                giriss.PasswordChar = '\0';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (giriss.PasswordChar == '\0')
            {
                button5.BringToFront();
                giriss.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from kayit where kul_ad = '" + textBox3.Text + "'and sifre = '" + giriss.Text +  "'" , baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {

                }
                if (gkod == Convert.ToInt32(textBox1.Text))
                {
                    AnaSayfa ansasafya = new AnaSayfa();
                    ansasafya.ShowDialog();

                }
                else
                {
                    MessageBox.Show("güvenlik kodu yanlış.");
                }
            }
            catch (Exception )
            { 
            baglanti.Close();
        }
        }
       
        private void giris_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            gkod = random.Next(0, 999);
            güvenliklabel.Text = gkod.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
