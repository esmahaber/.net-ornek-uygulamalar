using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankaSimulasyonu
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=bankaSimulasyon;Integrated Security=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            try
            {
                SqlCommand kaydetSorgu = new SqlCommand("Insert Into MusteriBilgileri VALUES (@AD, @SOYAD, @TC, @TELEFON, @HESAPNO, @SIFRE)", baglanti);

                kaydetSorgu.Parameters.AddWithValue("@AD", textBoxAd.Text);
                kaydetSorgu.Parameters.AddWithValue("@SOYAD", textBoxSoyad.Text);
                kaydetSorgu.Parameters.AddWithValue("@TC", maskedTextBoxTcNo.Text);
                kaydetSorgu.Parameters.AddWithValue("@TELEFON", maskedTextBoxTel.Text);
                kaydetSorgu.Parameters.AddWithValue("@HESAPNO", maskedTextBoxHesapNo.Text);
                kaydetSorgu.Parameters.AddWithValue("@SIFRE", textBoxSifre.Text);
                kaydetSorgu.ExecuteNonQuery();
                MessageBox.Show("Kayıt İşlemi Başarılı");
            }catch
            {
                MessageBox.Show("Bir Sorun Oluştu");
            }
            finally
            {
                baglanti.Close();
            }    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
        Tekrar:
            int sayi = RandomHesapNoUret();
            SqlCommand hesapNoSorgu = new SqlCommand("Select *from MusteriBilgileri Where HESAPNO=" + sayi, baglanti);
            SqlDataReader dr = hesapNoSorgu.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                goto Tekrar;
            }
            else
                maskedTextBoxHesapNo.Text = sayi.ToString();
            

            baglanti.Close();
        }

    
        private int RandomHesapNoUret()
        {
            Random rnd = new Random();

            int sayi = rnd.Next(99999, 1000000);
            maskedTextBoxHesapNo.Text = sayi.ToString();
            return sayi;
        }
    }
}
