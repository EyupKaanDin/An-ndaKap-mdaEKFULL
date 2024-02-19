using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eyupkaan1
{
    public partial class KrediKartı : Form
    {
        public KrediKartı()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelAdSoy.Text = textBox1.Text;
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            labelKart.Text = maskedTextBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSKT.Text = comboBox1.Text + " / " + comboBox2.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSKT.Text = comboBox1.Text + " / " + comboBox2.Text;
        }

        private void maskedTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            labelCVV.Text = maskedTextBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ad soyad giriniz.");
            }
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("Kart No giriniz.");
            }
            if (string.IsNullOrEmpty(maskedTextBox4.Text)) 
            {
                MessageBox.Show("CVV giriniz");
            }
           if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show(" SKT Seçiniz");
            }
             if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Ay / Yıl Seç");
            }
            else
            {
                DialogResult cevap = MessageBox.Show("Bu odemeyi onaylıyormusun ? ", " Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    MessageBox.Show("Ödeme yapıldı ");
                }
                else if (cevap == DialogResult.No)
                {
                    MessageBox.Show("işlem iptal edildi.");
                 
                }
            }






        }

        private void KrediKartı_Load(object sender, EventArgs e)
        {
            int ay;
            int yil;
            for (ay = 1; ay < 13; ay++)
            {
                comboBox1.Items.Add(ay);
            }
            for (yil = 21; yil < 30; yil++)
            {
                comboBox2.Items.Add(yil);
            }
        }
    }
}
