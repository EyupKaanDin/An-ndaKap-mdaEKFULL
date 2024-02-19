using eyupkaan1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;


namespace eyupkaan1
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        int toplam = 0;
       public static string baglantıKod = "Data Source=.\\SQLEXPRESS;Initial Catalog=giris;Integrated Security=True";
        SqlConnection baglantı = new SqlConnection(baglantıKod);


        private void button1_Click(object sender, EventArgs e)
        {
           if (doyuranK.Checked && doyurankovaN.Value > 0)
            {
                int ucret = Convert.ToInt32(doyurankovaN.Value) * 72;
                listbox.Items.Add(" Doyuran Kova Menu X " + doyurankovaN.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();
            }
            if (ortaMenu.Checked && ortaMenuNu.Value > 0)
            {
                int ucret = Convert.ToInt32(ortaMenuNu.Value) * 65;
                listbox.Items.Add(" 3 Ortalı  Menü  X " + ortaMenuNu.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();


            }
            if (proGamer.Checked && proGamerNum.Value > 0)
            {
                int ucret = Convert.ToInt32(proGamerNum.Value) * 94;
                listbox.Items.Add(" Pro Gamer Tavuklu X " + proGamerNum.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();


            }
            if (UstaLahmacun.Checked && UstasındanLahmacunNum.Value > 0)
            {
                int ucret = Convert.ToInt32(UstasındanLahmacunNum.Value) * 125;
                listbox.Items.Add(" Ustasından Lahmacun ( Usta Pideci ) X  " + UstasındanLahmacunNum.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (partiÇiğ.Checked && partiÇigNume.Value > 0)
            {
                int ucret = Convert.ToInt32(partiÇigNume.Value) * 120;
                listbox.Items.Add(" Doyuran Kova Menu X " + partiÇigNume.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();


            }

            if (ekoDoner.Checked && ekobageTavukNum.Value > 0)
            {
                int ucret = Convert.ToInt32(ekobageTavukNum.Value) * 135;
                listbox.Items.Add(" Eko Doner Tavuk  " + ekobageTavukNum.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();
            }
            if (ekoetdoner.Checked && etDonerNum.Value > 0)
            {
                int ucret = Convert.ToInt32(etDonerNum.Value > 0) * 65;
                listbox.Items.Add(" Parti Çigkofte  " + etDonerNum.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();
            }
            if (kofteMenu.Checked && kofteNum.Value > 0)
            {
                int ucret = Convert.ToInt32(etDonerNum.Value > 0) * 80;
                listbox.Items.Add("  Kofte Menu " + kofteNum.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (indirimradio.Checked == true)
                {
                    int etiketFiyati;
                    double indirimliFiyat;
                    etiketFiyati = Convert.ToInt32(odeme.Text);
                    indirimliFiyat = etiketFiyati - etiketFiyati * 0.10;
                     fiyat.Text = indirimliFiyat.ToString();    
                    MessageBox.Show("odenecek tutar = " + indirimliFiyat.ToString());
                }
            }
            catch (Exception msg )
            {

                MessageBox.Show("İndirimden yararlanmak için alışveriş yap ! " + msg);
            }

            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Odenecek Tutar " + toplam.ToString());
                }
                else
                {
                    MessageBox.Show("Bir yol seç");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            odeme.Clear();
        }

        private void partiÇiğ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void partiÇigNume_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void kofteNum_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void etDonerNum_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ekobageTavukNum_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void doyurankovaN_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void ortaMenuNu_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void proGamerNum_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void UstasındanLahmacunNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void indirimradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pb_str5_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.sarıyıldız;
            pb_str2.Image = Resources.sarıyıldız;
            pb_str3.Image = Resources.sarıyıldız;
            pb_str4.Image = Resources.sarıyıldız;
            pb_str5.Image = Resources.sarıyıldız;
            lbl_puanı.Text = " 5 ";
        }

        private void pb_str1_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.sarıyıldız;
            pb_str2.Image = Resources.beyazyıldız;
            pb_str3.Image = Resources.beyazyıldız;
            pb_str4.Image = Resources.beyazyıldız;
            pb_str5.Image = Resources.beyazyıldız;
            lbl_puanı.Text = " 1 ";
        }

        private void pb_str4_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.sarıyıldız;
            pb_str2.Image = Resources.sarıyıldız;
            pb_str3.Image = Resources.sarıyıldız;
            pb_str4.Image = Resources.sarıyıldız;
            pb_str5.Image = Resources.beyazyıldız;
            lbl_puanı.Text = " 4 ";
        }

        private void pb_str3_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.sarıyıldız;
            pb_str2.Image = Resources.sarıyıldız;
            pb_str3.Image = Resources.sarıyıldız;
            pb_str4.Image = Resources.beyazyıldız;
            pb_str5.Image = Resources.beyazyıldız;
            lbl_puanı.Text = " 3 ";
        }

        private void pb_str2_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.sarıyıldız;
            pb_str2.Image = Resources.sarıyıldız;
            pb_str3.Image = Resources.beyazyıldız;
            pb_str4.Image = Resources.beyazyıldız;
            pb_str5.Image = Resources.beyazyıldız;
            lbl_puanı.Text = " 2 ";
        }

        private void pb_star5_Click(object sender, EventArgs e)
        {
            pb_star5.Image = Resources.sarıyıldız;
            pb_star6.Image = Resources.beyazyıldız;
            pb_star7.Image = Resources.beyazyıldız;
            pb_star8.Image = Resources.beyazyıldız;
            pb_star9.Image = Resources.beyazyıldız;
            puanLBL2.Text = "1";
        }

        private void pb_star6_Click(object sender, EventArgs e)
        {
            pb_star5.Image = Resources.sarıyıldız;
            pb_star6.Image = Resources.sarıyıldız;
            pb_star7.Image = Resources.beyazyıldız;
            pb_star8.Image = Resources.beyazyıldız;
            pb_star9.Image = Resources.beyazyıldız;
            puanLBL2.Text = "2";
        }

        private void pb_star7_Click(object sender, EventArgs e)
        {
            pb_star5.Image = Resources.sarıyıldız;
            pb_star6.Image = Resources.sarıyıldız;
            pb_star7.Image = Resources.sarıyıldız;
            pb_star8.Image = Resources.beyazyıldız;
            pb_star9.Image = Resources.beyazyıldız;
            puanLBL2.Text = "3";
        }

        private void pb_star8_Click(object sender, EventArgs e)
        {
            pb_star5.Image = Resources.sarıyıldız;
            pb_star6.Image = Resources.sarıyıldız;
            pb_star7.Image = Resources.sarıyıldız;
            pb_star8.Image = Resources.sarıyıldız;
            pb_star9.Image = Resources.beyazyıldız;
            puanLBL2.Text = "4";
        }

        private void pb_star9_Click(object sender, EventArgs e)
        {
            pb_star5.Image = Resources.sarıyıldız;
            pb_star6.Image = Resources.sarıyıldız;
            pb_star7.Image = Resources.sarıyıldız;
            pb_star8.Image = Resources.sarıyıldız;
            pb_star9.Image = Resources.sarıyıldız;
            puanLBL2.Text = "5";
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pb_star10.Image = Resources.sarıyıldız;
            pb_star11.Image = Resources.beyazyıldız;
            pb_star12.Image = Resources.beyazyıldız;
            pb_star13.Image = Resources.beyazyıldız;
            pb_star14.Image = Resources.beyazyıldız;
            puanLBL34.Text = "1";
        }

        private void pb_star11_Click(object sender, EventArgs e)
        {
            pb_star10.Image = Resources.sarıyıldız;
            pb_star11.Image = Resources.sarıyıldız;
            pb_star12.Image = Resources.beyazyıldız;
            pb_star13.Image = Resources.beyazyıldız;
            pb_star14.Image = Resources.beyazyıldız;
            puanLBL34.Text = " 2 ";
        }

        private void pb_star12_Click(object sender, EventArgs e)
        {
            pb_star10.Image = Resources.sarıyıldız;
            pb_star11.Image = Resources.sarıyıldız;
            pb_star12.Image = Resources.sarıyıldız;
            pb_star13.Image = Resources.beyazyıldız;
            pb_star14.Image = Resources.beyazyıldız;
            puanLBL34.Text = " 3 ";
        }

        private void pb_star13_Click(object sender, EventArgs e)
        {
            pb_star10.Image = Resources.sarıyıldız;
            pb_star11.Image = Resources.sarıyıldız;
            pb_star12.Image = Resources.sarıyıldız;
            pb_star13.Image = Resources.sarıyıldız;
            pb_star14.Image = Resources.beyazyıldız;
            puanLBL34.Text = " 4 ";
        }

        private void pb_star14_Click(object sender, EventArgs e)
        {
            pb_star10.Image = Resources.sarıyıldız;
            pb_star11.Image = Resources.sarıyıldız;
            pb_star12.Image = Resources.sarıyıldız;
            pb_star13.Image = Resources.sarıyıldız;
            pb_star14.Image = Resources.sarıyıldız;
            puanLBL34.Text = " 5 ";
        }

        private void pb_star15_Click(object sender, EventArgs e)
        {
            pb_star15.Image = Resources.sarıyıldız;
            pb_star16.Image = Resources.beyazyıldız;
            pb_star17.Image = Resources.beyazyıldız;
            pb_star18.Image = Resources.beyazyıldız;
            pb_star19.Image = Resources.beyazyıldız;
            puanLBL4.Text = " 1 ";
        }

        private void pb_star16_Click(object sender, EventArgs e)
        {
            pb_star15.Image = Resources.sarıyıldız;
            pb_star16.Image = Resources.sarıyıldız;
            pb_star17.Image = Resources.beyazyıldız;
            pb_star18.Image = Resources.beyazyıldız;
            pb_star19.Image = Resources.beyazyıldız;
            puanLBL4.Text = " 2 ";
        }

        private void pb_star17_Click(object sender, EventArgs e)
        {
            pb_star15.Image = Resources.sarıyıldız;
            pb_star16.Image = Resources.sarıyıldız;
            pb_star17.Image = Resources.sarıyıldız;
            pb_star18.Image = Resources.beyazyıldız;
            pb_star19.Image = Resources.beyazyıldız;
            puanLBL4.Text = " 3 ";
        }

        private void pb_star18_Click(object sender, EventArgs e)
        {
            pb_star15.Image = Resources.sarıyıldız;
            pb_star16.Image = Resources.sarıyıldız;
            pb_star17.Image = Resources.sarıyıldız;
            pb_star18.Image = Resources.sarıyıldız;
            pb_star19.Image = Resources.beyazyıldız;
            puanLBL4.Text = " 4 ";
        }

        private void pb_star19_Click(object sender, EventArgs e)
        {
            pb_star15.Image = Resources.sarıyıldız;
            pb_star16.Image = Resources.sarıyıldız;
            pb_star17.Image = Resources.sarıyıldız;
            pb_star18.Image = Resources.sarıyıldız;
            pb_star19.Image = Resources.sarıyıldız;
            puanLBL4.Text = " 5 ";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pb_star32.Image = Resources.sarıyıldız;
            pb_star31.Image = Resources.beyazyıldız;
            pb_star30.Image = Resources.beyazyıldız;
            pb_star29.Image = Resources.beyazyıldız;
            pb_star28.Image = Resources.beyazyıldız;
            puan1.Text = " 1 ";
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pb_star32.Image = Resources.sarıyıldız;
            pb_star31.Image = Resources.sarıyıldız;
            pb_star30.Image = Resources.sarıyıldız;
            pb_star29.Image = Resources.beyazyıldız;
            pb_star28.Image = Resources.beyazyıldız;
            puan1.Text = " 3 ";

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pb_star32.Image = Resources.sarıyıldız;
            pb_star31.Image = Resources.sarıyıldız;
            pb_star30.Image = Resources.beyazyıldız;
            pb_star29.Image = Resources.beyazyıldız;
            pb_star28.Image = Resources.beyazyıldız;
            puan1.Text = "2";
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pb_star32.Image = Resources.sarıyıldız;
            pb_star31.Image = Resources.sarıyıldız;
            pb_star30.Image = Resources.sarıyıldız;
            pb_star29.Image = Resources.sarıyıldız;
            pb_star28.Image = Resources.beyazyıldız;
            puan1.Text = " 4 ";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (krediKartı.Checked == true )
            {
                KrediKartı kredikartı = new KrediKartı();
                kredikartı.Show();
               
            }
            else
            {
                MessageBox.Show("Lütfen işaretleyiniz.");
            }
        }

        private void ekoetdoner_CheckedChanged(object sender, EventArgs e)
        {
            if (ekoetdoner.Checked)
            {
                ekobageTavukNum.Visible = true;
            }
            else
            {
                ekobageTavukNum.Value = 0;
                ekobageTavukNum.Visible =false;
            }


        }

        private void fiyat_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void pictureBox27_Click_1(object sender, EventArgs e)
        {

            
        }

        private void pb_star26_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            yorum yorum = new yorum();
            yorum.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (krallezzetCheck.Checked && kralNumeric.Value > 0)
            {
                int ucret = Convert.ToInt32(kralNumeric.Value) * 115;
                listbox.Items.Add(" Kral Lezzet Menüsü  " + kralNumeric.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();
            }

            if (takoChc.Checked && takoNum.Value > 0)
            {
                int ucret = Convert.ToInt32(takoNum.Value) * 13;
                listbox.Items.Add(" Tako Çiğkofte" + takoNum.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();
            }

            if (kokoreçChc.Checked && kokoreçNum.Value > 0)
            {
                int ucret = Convert.ToInt32(kokoreçNum.Value) * 60;
                listbox.Items.Add(" Eko Doner Tavuk  " + kokoreçNum.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();
            }

            if (tantuniChc.Checked && tantuniNum.Value > 0)
            {
                int ucret = Convert.ToInt32(tantuniNum.Value) * 135;
                listbox.Items.Add(" Eko Doner Tavuk  " + tantuniNum.Value.ToString());
                toplam = toplam + ucret;
                odeme.Text = toplam.ToString();
                fiyat.Text = toplam.ToString();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string kod = "INSERT INTO Basvurular (IsYeriAdi, IsletmeTuru, AdSoyad, Eposta, Telefon, SubeSayisi) " +
               "VALUES (@IsYeriAdi, @IsletmeTuru, @AdSoyad, @Eposta, @Telefon, @SubeSayisi)";
            SqlCommand komut = new SqlCommand(kod, baglantı);
            komut.Parameters.AddWithValue("@IsYeriAdi", textBoxIsYeriAdi.Text);
            komut.Parameters.AddWithValue("@IsletmeTuru", comboBoxIsletmeTuru.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@AdSoyad", textBoxAdSoyad.Text);
            komut.Parameters.AddWithValue("@Eposta", textBoxEposta.Text);
            komut.Parameters.AddWithValue("@Telefon", textBoxTelefon.Text);
            komut.Parameters.AddWithValue("@SubeSayisi", Convert.ToInt32(textBoxSubeSayisi.Text));

            baglantı.Open();
            int satır = komut.ExecuteNonQuery();
            baglantı.Close();

            if (satır > 0)
            {
                MessageBox.Show("başvurunuz tamamlandı teşekkürler. Yoneticimizden yanıt bekleyin","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void pb_star28_Click(object sender, EventArgs e)
        {
            pb_star32.Image = Resources.sarıyıldız;
            pb_star31.Image = Resources.sarıyıldız;
            pb_star30.Image = Resources.sarıyıldız;
            pb_star29.Image = Resources.sarıyıldız;
            pb_star28.Image = Resources.sarıyıldız;
            puanLBL4.Text = " 5 ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            kapıda kapıda = new kapıda();
            kapıda.Show();
        }
    }
}
