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

namespace Veri_Sifreleme
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            bilgileriGetir();

            cozumlenmisBilgileriGetir();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Initial Catalog=veriSifreleme;Integrated Security=True");

        private void bilgileriGetir()
        {

            baglanti.Open();
            SqlDataAdapter sorguBilgiGetir = new SqlDataAdapter("select *from bilgiler", baglanti);
            DataTable dt = new DataTable();
            sorguBilgiGetir.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void cozumlenmisBilgileriGetir()
        {
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "ID";
            dataGridView.Columns[1].Name = "AD";
            dataGridView.Columns[2].Name = "SOYAD";
            dataGridView.Columns[3].Name = "MAIL";
            dataGridView.Columns[4].Name = "SİFRE";
            dataGridView.Columns[5].Name = "HESAP NO";


            baglanti.Open();
            SqlCommand sorguBilgiGetir = new SqlCommand("select *from bilgiler", baglanti);
            SqlDataReader dr = sorguBilgiGetir.ExecuteReader();

            while (dr.Read())
            {
                byte[] adVeri = Convert.FromBase64String(dr[1].ToString());
                string adCozum = ASCIIEncoding.ASCII.GetString(adVeri);

                byte[] soyadVeri = Convert.FromBase64String(dr[2].ToString());
                string soyadCozum = ASCIIEncoding.ASCII.GetString(soyadVeri);

                byte[] mailVeri = Convert.FromBase64String(dr[3].ToString());
                string mailCozum = ASCIIEncoding.ASCII.GetString(mailVeri);

                string[] veriler = { dr[0].ToString(), adCozum, soyadCozum, mailCozum, dr[4].ToString(), dr[5].ToString() };
                dataGridView.Rows.Add(veriler);
                Array.Clear(veriler,0,3);
            }

            baglanti.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ad degiskeni ToBase64String ile şifrelendi
            byte[] adVeriDizi = ASCIIEncoding.ASCII.GetBytes(textBoxAd.Text);
            string adSifrele = Convert.ToBase64String(adVeriDizi);

            //soyad degiskeni ToBase64String ile şifrelendi
            byte[] soyadVeriDizi = ASCIIEncoding.ASCII.GetBytes(textBoxSoyad.Text);
            string soyadSifrele = Convert.ToBase64String(soyadVeriDizi);

            //mail degiskeni ToBase64String ile şifrelendi
            byte[] mailVeriDizi = ASCIIEncoding.ASCII.GetBytes(textBoxMail.Text);
            string mailSifrele = Convert.ToBase64String(mailVeriDizi);

            //Sifre degiskeni ToBase64String ile şifrelendi
            byte[] sifreVeriDizi = ASCIIEncoding.ASCII.GetBytes(textBoxSifre.Text);
            string sifreSifrele = Convert.ToBase64String(sifreVeriDizi);

            //HesapNo degiskeni ToBase64String ile şifrelendi
            byte[] hesapNoVeriDizi = ASCIIEncoding.ASCII.GetBytes(textBoxHesapNo.Text);
            string hesapNoSifrele = Convert.ToBase64String(hesapNoVeriDizi);

            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("Insert into bilgiler values (@AD, @SOYAD, @MAIL, @SIFRE, @HESAPNO)", baglanti);

            sorgu.Parameters.AddWithValue("@AD", adSifrele);
            sorgu.Parameters.AddWithValue("@SOYAD", soyadSifrele);
            sorgu.Parameters.AddWithValue("@MAIL", mailSifrele);
            sorgu.Parameters.AddWithValue("@SIFRE", sifreSifrele);
            sorgu.Parameters.AddWithValue("@HESAPNO", hesapNoSifrele);

            sorgu.ExecuteNonQuery();
            baglanti.Close();

            bilgileriGetir();
        }

        
        
    }
}
