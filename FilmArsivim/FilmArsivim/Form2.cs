using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmArsivim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string url;
            string videoId = "rUwXlle4MGE";
            url = "https//www.youtube.com/embed/UJ53Js0YKZM";

            webBrowser1.Navigate(url);
        }
    }
}
