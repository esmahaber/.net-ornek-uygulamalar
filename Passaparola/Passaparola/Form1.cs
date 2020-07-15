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

namespace Passaparola
{
    //Data Source=ACER-PC;Integrated Security=True
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        new SqlConnection baglanti = new SqlConnection(@"Data Source=ACER-PC;Integrated Security=True");


        int soruNo = 0, dogru = 0, yanlis = 0;

        private void textBoxCevap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //cevaplar();

            }
        }

        private void cevaplar()
        {
            if (soruNo == 1)
            {
                if (textBoxCevap.Text == "aloe vera")
                    button1.BackColor = Color.Green;
                else
                    button1.BackColor = Color.Red;
            }
            if (soruNo == 2)
                if (textBoxCevap.Text == "bellek")
                    button2.BackColor = Color.Green;
                else
                    button2.BackColor = Color.Red;
            if (soruNo == 3)
                if (textBoxCevap.Text == "cennet")
                    button19.BackColor = Color.Green;
                else
                    button19.BackColor = Color.Red;
            if (soruNo == 4)
                if (textBoxCevap.Text == "dünya")
                    button3.BackColor = Color.Green;
                else
                    button3.BackColor = Color.Red;
            if (soruNo == 5)
                if (textBoxCevap.Text == "egoizm")
                    button4.BackColor = Color.Green;
                else
                    button4.BackColor = Color.Red;
            if (soruNo == 6)
                if (textBoxCevap.Text == "fetva")
                    button5.BackColor = Color.Green;
                else
                    button5.BackColor = Color.Red;
            if (soruNo == 7)
                if (textBoxCevap.Text == "ganyan")
                    button6.BackColor = Color.Green;
                else
                    button6.BackColor = Color.Red;
            if (soruNo == 8)
                if (textBoxCevap.Text == "habeşistan")
                    button7.BackColor = Color.Green;
                else
                    button7.BackColor = Color.Red;
            if (soruNo == 9)
                if (textBoxCevap.Text == "iris")
                    button8.BackColor = Color.Green;
                else
                    button8.BackColor = Color.Red;
            if (soruNo == 10)
                if (textBoxCevap.Text == "jenga")
                    button10.BackColor = Color.Green;
                else
                    button10.BackColor = Color.Red;
            if (soruNo == 11)
                if (textBoxCevap.Text == "kül")
                    button11.BackColor = Color.Green;
                else
                    button11.BackColor = Color.Red;
            if (soruNo == 12)
                if (textBoxCevap.Text == "lakerda")
                    button20.BackColor = Color.Green;
                else
                    button20.BackColor = Color.Red;
            if (soruNo == 13)
                if (textBoxCevap.Text == "manisa")
                    button9.BackColor = Color.Green;
                else
                    button9.BackColor = Color.Red;
            if (soruNo == 14)
                if (textBoxCevap.Text == "nihale")
                    button24.BackColor = Color.Green;
                else
                    button24.BackColor = Color.Red;
            if (soruNo == 15)
                if (textBoxCevap.Text == "org")
                    button18.BackColor = Color.Green;
                else
                    button18.BackColor = Color.Red;
            if (soruNo == 16)
                if (textBoxCevap.Text == "periskop")
                    button16.BackColor = Color.Green;
                else
                    button16.BackColor = Color.Red;
            if (soruNo == 17)
                if (textBoxCevap.Text == "rafineri  ")
                    button15.BackColor = Color.Green;
                else
                    button15.BackColor = Color.Red;
            if (soruNo == 18)
                if (textBoxCevap.Text == "sedye")
                    button14.BackColor = Color.Green;
                else
                    button14.BackColor = Color.Red;
            if (soruNo == 19)
                if (textBoxCevap.Text == "talim")
                    button17.BackColor = Color.Green;
                else
                    button17.BackColor = Color.Red;
            if (soruNo == 20)
                if (textBoxCevap.Text == "sedye")
                    button22.BackColor = Color.Green;
                else
                    button22.BackColor = Color.Red;
            if (soruNo == 21)
                if (textBoxCevap.Text == "vapur")
                    button13.BackColor = Color.Green;
                else
                    button13.BackColor = Color.Red;
            if (soruNo == 22)
                if (textBoxCevap.Text == "yürütme")
                    button12.BackColor = Color.Green;
                else
                    button12.BackColor = Color.Red;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNo++;

            this.Text = ("Soru:", soruNo).ToString();
            //SwitchSoru();

            baglanti.Open();
            SqlCommand soruGetirSorgu = new SqlCommand("select * from sorular where cevap like '%@P1';", baglanti);
            soruGetirSorgu.Parameters.AddWithValue("@P0", );


        }

        private void SwitchSoru()
        {
            switch (soruNo)
            {
                case 1:
                    richTextBoxSoru.Text = "Kozmetik ürünleri de dahil olmak üzere birçok ilaç tedavisinde kullanılan bir bitki ülkemizin güney bölgelerinde, sıcak alanlarda daha çok yetişmektedir";
                    button1.BackColor = Color.Yellow;
                    break;
                case 2:
                    richTextBoxSoru.Text = "Bilgisayar veri depolama, bilgisayar bileşenlerinden oluşan ve kayıt ortamı dijital verileri korumak için kullanılan bir teknolojidir.";
                    button2.BackColor = Color.Yellow;
                    break;
                case 3:
                    richTextBoxSoru.Text = "Dinsel inanışlara göre, iyi kimselerin öldükten sonra gidecekleri yer neresidir?";
                    button19.BackColor = Color.Yellow;
                    break;
                case 4:
                    richTextBoxSoru.Text = "Güneş Sistemi'nde Güneş'e en yakın üçüncü gezegen hangisidir?";
                    button3.BackColor = Color.Yellow;
                    break;
                case 5:
                    richTextBoxSoru.Text = "Bireysel çıkarların, başkalarının çıkarlarından üstün tutulması";
                    button4.BackColor = Color.Yellow;
                    break;
                case 6:
                    richTextBoxSoru.Text = "İslam hukukunda şeyhülislam ya da müftü tarafından verilen emir yada yargı";
                    button5.BackColor = Color.Yellow;
                    break;
                case 7:
                    richTextBoxSoru.Text = "At yarışlarında kazanan at";
                    button6.BackColor = Color.Yellow;
                    break;
                case 8:
                    richTextBoxSoru.Text = "Bugünkü Etiyopya'nın eski adı";
                    button7.BackColor = Color.Yellow;
                    break;
                case 9:
                    richTextBoxSoru.Text = "Gözün renkli kısmı";
                    button8.BackColor = Color.Yellow;
                    break;
                case 10:
                    richTextBoxSoru.Text = "Bir tür denge ve konsantrasyon oyunu";
                    button10.BackColor = Color.Yellow;
                    break;
                case 11:
                    richTextBoxSoru.Text = "İyice yanmış şeylerden artakalan, toz durumunda madde";
                    button11.BackColor = Color.Yellow;
                    break;
                case 12:
                    richTextBoxSoru.Text = "Palamut, torik gibi balıklardan dilim dilim kesilerek yapılan salamura";
                    button20.BackColor = Color.Yellow;
                    break;
                case 13:
                    richTextBoxSoru.Text = "Mesir macunu ile ünlü olan ilimiz";
                    button9.BackColor = Color.Yellow;
                    break;
                case 14:
                    richTextBoxSoru.Text = "Sofrada kullanılan sahan altlığı";
                    button24.BackColor = Color.Yellow;
                    break;
                case 15:
                    richTextBoxSoru.Text = "Körükle verilen basınçlı havanın tahta veya metal borulardan geçerken içerideki hava sütunlarının titreşmesi sayesinde ses üreten bir müzik enstrümanı";
                    button18.BackColor = Color.Yellow;
                    break;
                case 16:
                    richTextBoxSoru.Text = "Denizaltılarda su yüzeyini görmeye yarayan metal boru";
                    button16.BackColor = Color.Yellow;
                    break;
                case 17:
                    richTextBoxSoru.Text = "Ham petrollerin kullanılmaya hazır ürünlere dönüştürüldüğü fabrika";
                    button15.BackColor = Color.Yellow;
                    break;
                case 18:
                    richTextBoxSoru.Text = "Hasta ya da yaralı taşımaya yarayan, katlanabilir hasta yatağı";
                    button14.BackColor = Color.Yellow;
                    break;
                case 19:
                    richTextBoxSoru.Text = "Uygulamalı olarak yapılan askerlik eğitimi";
                    button17.BackColor = Color.Yellow;
                    break;
                case 20:
                    richTextBoxSoru.Text = "Budizmi benimseyen ilk türk devleti";
                    button22.BackColor = Color.Yellow;
                    break;
                case 21:
                    richTextBoxSoru.Text = "Buhar gücüyle işleyen gemi";
                    button13.BackColor = Color.Yellow;
                    break;
                case 22:
                    richTextBoxSoru.Text = "Yasaları uygulama işi";
                    button12.BackColor = Color.Yellow;
                    break;
            }
        }
    }
}
