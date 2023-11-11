using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınavçalışma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            const double TIP = 0.15;
            const double KDV = 0.08;
            double toplamucret;

            double yemekucreti = double.Parse(textBox1.Text);

            toplamucret = yemekucreti + yemekucreti * KDV + yemekucreti * TIP;


            listBox1.Items.Add("Yemek: \t" + yemekucreti.ToString("C")); // Currency : para birimi
            listBox1.Items.Add("KDV: \t" + KDV.ToString("P")); //percentage : yüzde
            listBox1.Items.Add("Küver: \t" + TIP.ToString("P"));
            listBox1.Items.Add("Toplam Ödenecek Ücret: " + toplamucret.ToString("C"));
        }
    }
    
}
