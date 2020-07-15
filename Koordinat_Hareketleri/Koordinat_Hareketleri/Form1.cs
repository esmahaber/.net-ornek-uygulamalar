using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koordinat_Hareketleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public void baslangic()
        {
            pictureBox1.Location = new Point(45, 333);
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            baslangic();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;

            if(pictureBox1.Top <= 25)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 665)
            {
                timer2.Stop();
                timer3.Start();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 333)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 510)
            {
                timer4.Stop();
                timer5.Start();
                
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;

            if (pictureBox1.Top <= 222)
            {
                timer5.Stop();
                timer6.Start();
            }
            
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 194)
            {
                timer6.Stop();
                timer7.Start();

            }

        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;

            if (pictureBox1.Top <= 130)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 425)
            {
                timer8.Stop();
                DialogResult secenek = MessageBox.Show("Yeniden başlatmak istiyor musunuz?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    baslangic();
                }
                else if (secenek == DialogResult.No)
                {
                    Application.Exit();
                }

            }
        }
    }
}
