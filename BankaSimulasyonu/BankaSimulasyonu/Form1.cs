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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=bankaSimulasyon;Integrated Security=True");

        private void linkLabelKaydol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            baglanti.Open();
            SqlCommand girisSorgu = new SqlCommand("Select *from MusteriBilgileri where HESAPNO=@HESAPNO and SIFRE=@SIFRE", baglanti);

            girisSorgu.Parameters.AddWithValue("@HESAPNO", maskedTextBoxHesapNo.Text);
            girisSorgu.Parameters.AddWithValue("@SIFRE", textBoxSifre.Text);

            SqlDataReader dr = girisSorgu.ExecuteReader();

            if (dr.Read())
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.hesapNo = maskedTextBoxHesapNo.Text;
                anasayfa.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Kontrol Edin");

            }

            baglanti.Close();
        }
    }
}
