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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        public string hesapNo;


        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=bankaSimulasyon;Integrated Security=True");

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            labelHesapNo.Text = hesapNo;

            

            //Musteri bilgileri
            baglanti.Open();
            SqlCommand bilgilerSorgu = new SqlCommand("SELECT *FROM MusteriBilgileri WHERE HESAPNO=@HESAPNO", baglanti);
            bilgilerSorgu.Parameters.AddWithValue("@HESAPNO", hesapNo);
            SqlDataReader dr = bilgilerSorgu.ExecuteReader();
            if (dr.Read())
            {
                labelAdSoyad.Text = dr[1] + " " + dr[2];
                labelTel.Text = dr[4].ToString();
                labelTcNo.Text = dr[3].ToString();
            }
            baglanti.Close();
            BakiyeBilgisiGetir();

        }

        private void BakiyeBilgisiGetir()
        {
            // bakiye bilgisi
            baglanti.Open();
            SqlCommand bakiyeSorgu = new SqlCommand("SELECT *FROM HesapBilgileri WHERE HESAPNO=@HESAPNO", baglanti);
            bakiyeSorgu.Parameters.AddWithValue("@HESAPNO", hesapNo);
            SqlDataReader dr2 = bakiyeSorgu.ExecuteReader();
            if (dr2.Read())
            {
                labelBakiye.Text = dr2[2].ToString();

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParaTransferBilgileriniKaydet();
            BakiyeBilgileriniGuncelle();
            BakiyeBilgisiGetir();
        }

        private void BakiyeBilgileriniGuncelle()
        {
            baglanti.Open();

            try
            {
                SqlCommand paraGonderSorgu = new SqlCommand("Update HesapBilgileri Set BAKIYE=BAKIYE-@TUTAR where HESAPNO=@HESAPNO ", baglanti);
                SqlCommand aliciBakiyeSorgu = new SqlCommand("Update HesapBilgileri Set BAKIYE=BAKIYE+@TUTAR where HESAPNO=@ALICIHESAPNO ", baglanti);

                paraGonderSorgu.Parameters.AddWithValue("@TUTAR", decimal.Parse(textBoxTutar.Text));
                paraGonderSorgu.Parameters.AddWithValue("@HESAPNO", hesapNo);

                aliciBakiyeSorgu.Parameters.AddWithValue("@TUTAR", decimal.Parse(textBoxTutar.Text));
                aliciBakiyeSorgu.Parameters.AddWithValue("@ALICIHESAPNO", maskedTextBoxAlici.Text);

                paraGonderSorgu.ExecuteNonQuery();
                aliciBakiyeSorgu.ExecuteNonQuery();

                MessageBox.Show("Para Transfer İşlemi Başarılı Bir Şekilde Gerçekleşti");

            }
            catch
            {
                MessageBox.Show("Bir sorun oluştu");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void ParaTransferBilgileriniKaydet()
        {
            baglanti.Open();

            try
            {
                SqlCommand paraGonderSorgu = new SqlCommand("Insert Into IslemBilgileri(GONDEREN, ALICI, TUTAR) Values (@GONDEREN, @ALICI, @TUTAR)", baglanti);
                paraGonderSorgu.Parameters.AddWithValue("@GONDEREN", hesapNo);
                paraGonderSorgu.Parameters.AddWithValue("@ALICI", maskedTextBoxAlici.Text);
                paraGonderSorgu.Parameters.AddWithValue("@TUTAR", decimal.Parse(textBoxTutar.Text));
                MessageBox.Show(hesapNo + " hesabından, " + maskedTextBoxAlici.Text + "nolu hesaba" + decimal.Parse(textBoxTutar.Text) + "TL Gönderildi");
                paraGonderSorgu.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Bir sorun oluştu");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonGecmis_Click(object sender, EventArgs e)
        {
            GecmisHareketler gecmisHareketler = new GecmisHareketler();
            gecmisHareketler.hesapNo = hesapNo.ToString();
            gecmisHareketler.Show();
        }
    }
}
