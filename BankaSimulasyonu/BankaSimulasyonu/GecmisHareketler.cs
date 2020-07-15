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
    public partial class GecmisHareketler : Form
    {
        public GecmisHareketler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=bankaSimulasyon;Integrated Security=True");
        

        public string hesapNo;


        private void GecmisHareketler_Load(object sender, EventArgs e)
        {         
            SqlDataAdapter gecmisSorgu = new SqlDataAdapter("Select  IslemBilgileri.ID, (GONDERENMB.AD + ' '+GONDERENMB.SOYAD)as GONDEREN, (ALICIMB.AD + ' '+ ALICIMB.SOYAD) as ALICI, TUTAR from IslemBilgileri inner join MusteriBilgileri as GONDERENMB on IslemBilgileri.GONDEREN = GONDERENMB.HESAPNO inner join MusteriBilgileri as ALICIMB on IslemBilgileri.ALICI = ALICIMB.HESAPNO where gonderen="+hesapNo+ "or alıcı="+hesapNo, baglanti);
            DataTable dt = new DataTable();
            gecmisSorgu.Fill(dt);

            dataGridView1.DataSource = dt;

        }
    }
}
