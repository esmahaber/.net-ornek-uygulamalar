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

namespace Rehber_Uygulamasi
{
    public partial class Rehber : Form
    {
        public Rehber()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=REHBER;Integrated Security=True");
        public string id, ad, soyad, tel, resim;
        int secilen;

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            KisiEkle kisiEkle = new KisiEkle();
            kisiEkle.labelID.Text = id;
            kisiEkle.textBoxAd.Text = ad;
            kisiEkle.textBoxSoyad.Text = soyad;
            kisiEkle.maskedTextBoxTel.Text = tel;
            kisiEkle.Show();
        }

        public void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM KISILER", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Rehber_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void buttonKisiEkle_Click(object sender, EventArgs e)
        {
            KisiEkle kisiEkle = new KisiEkle();
            kisiEkle.Show();
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           // textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            // seçilen row'un indexini tutar
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tel = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            resim = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }
    }
}
