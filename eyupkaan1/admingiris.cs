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
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = giris; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kayit where kul_ad = '" + textBox1.Text + "'and sifre = '" + textBox2.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                button5 adminf = new button5();
                adminf.Show();
            }
            baglanti.Close();
        }
    }
}
