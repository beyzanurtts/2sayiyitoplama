using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basit_Sayı_Toplama_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt1.Text);
            int sayi2 = Convert.ToInt32(txt2.Text);

            int sonuc = sayi1 + sayi2;

            lblSonuc.Text = sonuc.ToString();
        }
    }
}
