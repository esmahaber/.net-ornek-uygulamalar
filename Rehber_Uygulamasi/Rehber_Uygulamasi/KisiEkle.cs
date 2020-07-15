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
using System.IO;

namespace Rehber_Uygulamasi
{
    public partial class KisiEkle : Form
    {
        public KisiEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=REHBER;Integrated Security=True");
        String resimYolu;
        Rehber rehber = new Rehber();



        void dialog()
        {
            openFileDialogResim.Title = "Kişi resmini seçiniz";
            openFileDialogResim.Filter = "Jpeg Dosyalari(*.jpg)|*.jpg|Png dosyalari(*.png)|*.png";
        }


        private void buttonRehber_Click(object sender, EventArgs e)
        {
            rehber.Show();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (resimYolu == null)
                MessageBox.Show("Lütfen bir resim seçin");
            else
            {
                FileStream fsResim = new FileStream(resimYolu, FileMode.Open, FileAccess.Read);
                BinaryReader brResim = new BinaryReader(fsResim);
                byte[] resim = brResim.ReadBytes((int)fsResim.Length);
                brResim.Close();
                fsResim.Close();
                SqlCommand sorguKaydet = new SqlCommand("INSERT INTO KISILER(ad,soyad,telefon,resim) VALUES (@P1, @P2, @P3, @P4) ", baglanti);
                sorguKaydet.Parameters.AddWithValue("@P1", textBoxAd.Text);
                sorguKaydet.Parameters.AddWithValue("@P2", textBoxSoyad.Text);
                sorguKaydet.Parameters.AddWithValue("@P3", maskedTextBoxTel.Text);
                sorguKaydet.Parameters.Add("@P4", SqlDbType.Image, resim.Length).Value = resim;
                sorguKaydet.ExecuteNonQuery();
            }
               
            
         
            try
            {          
                MessageBox.Show("Kişi Kaydedildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void buttonResimSec_Click(object sender, EventArgs e)
        {
            if (openFileDialogResim.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialogResim.FileName); /* Drawing isim uzayinda yer alan Image sinifinin FromFile metodunu kullanarak belirtilen adresteki dosya PictureBox kontrolü içine çizilir. */

                resimYolu = openFileDialogResim.FileName.ToString();
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            maskedTextBoxTel.Text = "";
            pictureBox1.Image = null;
        }


        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorguGuncelle = new SqlCommand("UPDATE KISILER SET ad = @P1, soyad = @P2, telefon=@P3 WHERE ID= @P4", baglanti);
            sorguGuncelle.Parameters.AddWithValue("@P1", textBoxAd.Text);
            sorguGuncelle.Parameters.AddWithValue("@P2", textBoxSoyad.Text);
            sorguGuncelle.Parameters.AddWithValue("@P3", maskedTextBoxTel.Text);
            sorguGuncelle.Parameters.AddWithValue("@P4", labelID.Text);


            try
            {
                rehber.listele();
                sorguGuncelle.ExecuteNonQuery();
                MessageBox.Show("Kişi Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                baglanti.Close();
            }

        }
    }
}
