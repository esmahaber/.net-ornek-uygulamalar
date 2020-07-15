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
    public partial class FrmOgrenciDetay : Form
    {
        //
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        public String ogrNo;

        //SQL bağlantisi
        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=dbNotKayit;Integrated Security=True");

       

        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            LblOgrNo.Text = ogrNo;

            //bağlantı aç
            baglanti.Open();
            //sorgu oluştur
            SqlCommand ogrenciSorgu = new SqlCommand("Select * From TBL_DERS where OGRNUMARA=@p1", baglanti);
            //istenilen değişkenleri atama
            ogrenciSorgu.Parameters.AddWithValue("@p1", ogrNo);
            //veri okuyucu
            SqlDataReader dr = ogrenciSorgu.ExecuteReader();

            while (dr.Read())
            {
                LblAdSoyad.Text = dr[2].ToString() + " "+ dr[3].ToString();
                LblOgrNo.Text = dr[1].ToString();
                LblSinav1.Text = dr[4].ToString();
                LblSinav2.Text = dr[5].ToString();
                LblSinav3.Text = dr[6].ToString();
                LblOrtalama.Text = dr[7].ToString();
                LblDurum.Text = dr[8].ToString();

            }
            baglanti.Close();

        }
    }
}
