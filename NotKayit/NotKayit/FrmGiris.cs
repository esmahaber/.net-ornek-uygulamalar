using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

      
        private void giris_btn_Click(object sender, EventArgs e)
        {
            FrmOgrenciDetay ogrenciForm = new FrmOgrenciDetay();
            ogrenciForm.ogrNo = ogr_no_maskedTextBox.Text;
            ogrenciForm.Show();
        }

        //metin değiştiği anda
        private void ogr_no_maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if(ogr_no_maskedTextBox.Text == "0000")
            {
                FrmOgretmenDetay fr = new FrmOgretmenDetay();
                fr.Show();
            }
        }
    }
}
