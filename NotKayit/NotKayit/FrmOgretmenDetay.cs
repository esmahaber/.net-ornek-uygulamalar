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

namespace NotKayit
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=dbNotKayit;Integrated Security=True");


        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayitDataSet.TBL_DERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorguOgrenciEkle = new SqlCommand("INSERT INTO TBL_DERS (OGRAD, OGRSOYAD, OGRNUMARA) VALUES (@P1, @P2, @P3)", baglanti);
            sorguOgrenciEkle.Parameters.AddWithValue("@P1", txtAd.Text.ToUpper());
            sorguOgrenciEkle.Parameters.AddWithValue("@P2", txtSoyad.Text.ToUpper());
            sorguOgrenciEkle.Parameters.AddWithValue("@P3", maskedTxtOgrNo.Text);
            //sorguyu çalıştır
            sorguOgrenciEkle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Kayıt Edildi");
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTxtOgrNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            String durum;

            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            s3 = Convert.ToDouble(txtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;

            if (ortalama <= 50)
                durum = "False";
            else
                durum = "True";

            lblOrtalama.Text = ortalama.ToString();

            baglanti.Open();

            SqlCommand sorguSinavGuncelle = new SqlCommand("UPDATE TBL_DERS SET OGRS1=@P1, OGRS2=@P2, OGRS3=@P3, ORTALAMA=@P4, DURUM=@P5 WHERE OGRNUMARA=@P6", baglanti);
            sorguSinavGuncelle.Parameters.AddWithValue("@P1", txtSinav1.Text);
            sorguSinavGuncelle.Parameters.AddWithValue("@P2", txtSinav2.Text);
            sorguSinavGuncelle.Parameters.AddWithValue("@P3", txtSinav3.Text);
            sorguSinavGuncelle.Parameters.AddWithValue("@P4", decimal.Parse(lblOrtalama.Text));
            sorguSinavGuncelle.Parameters.AddWithValue("@P5", durum);
            sorguSinavGuncelle.Parameters.AddWithValue("@P6", maskedTxtOgrNo.Text);

            sorguSinavGuncelle.ExecuteNonQuery();

            baglanti.Close();

            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);

            MessageBox.Show("Öğrenci Sınav Bilgileri Güncellendi");


        }
    }
}
