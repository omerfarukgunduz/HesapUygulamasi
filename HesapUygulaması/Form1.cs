using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapUygulaması
{
    public partial class HesapUygulaması : Form
    {
        public HesapUygulaması()
        {
            InitializeComponent();
            
        }

        

        // bunu başa yazıyorum her yeni hesapta sıfırın üstüne ekleyeceğiz
        int kazanc = 0;

           
        private void btnHesap_Click(object sender, EventArgs e)
        {
            int cay, oralet, tost, menemen, hesap;
            cay = Convert.ToInt16(textBox1.Text);
            oralet= Convert.ToInt16(textBox2.Text);
            tost= Convert.ToInt16(textBox3.Text);
            menemen= Convert.ToInt16(textBox4.Text);

            hesap = cay * 2 + oralet * 2 + tost * 20 + menemen * 30;
            kazanc = kazanc + hesap;

            label11.Text = hesap.ToString() + " TL";

            label13.Text = kazanc.ToString() + " TL";

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";

        }

        private void HesapUygulaması_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";

        }
    }
}
