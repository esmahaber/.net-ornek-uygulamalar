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

namespace FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=FilmArsivim;Integrated Security=True");


        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorguFilmEkle = new SqlCommand ("INSERT INTO TBLFILMLER(AD, LINK, KATEGORI) VALUES (@P1,@P2, @P3)", baglanti);

            sorguFilmEkle.Parameters.AddWithValue("@P1", textBoxFilmAd.Text);
            sorguFilmEkle.Parameters.AddWithValue("@P2", textBoxLink.Text);
            sorguFilmEkle.Parameters.AddWithValue("@P3", textBoxTur.Text);
            sorguFilmEkle.ExecuteNonQuery();
            baglanti.Close();
            filmleriListele();


            MessageBox.Show("Film başarılı bir şekilde eklendi.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmleriListele();

        }

        private void filmleriListele()
        {
            SqlDataAdapter sorguFilmGetir = new SqlDataAdapter("SELECT *FROM TBLFILMLER", baglanti);
            //Tablo Nesnesi
            DataTable dt = new DataTable();
            sorguFilmGetir.Fill(dt); //Verileri Doldur
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            webBrowser1.Navigate(link);
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonTamEkran_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            form.Show();
        }
    }
}
