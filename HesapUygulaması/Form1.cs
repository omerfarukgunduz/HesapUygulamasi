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
            int cay, oralet,kusburnu, tost, menemen, hesap;
            cay = Convert.ToInt16(cayTxt.Text);
            oralet= Convert.ToInt16(oraletTxt.Text);
            tost= Convert.ToInt16(tostTxt.Text);
            menemen= Convert.ToInt16(menemenTxt.Text);
            kusburnu= Convert.ToInt16(kusburnuTxt.Text);

            hesap = cay * 2 + oralet * 2 + tost * 20 + menemen * 30 + kusburnu *2 ;

            kazanc = kazanc + hesap;

            label11.Text = hesap.ToString() + " TL";

            label13.Text = kazanc.ToString() + " TL";

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cayTxt.Text = "0";
            oraletTxt.Text = "0";
            tostTxt.Text = "0";
            menemenTxt.Text = "0";
            kusburnuTxt.Text = "0";

        }

        private void HesapUygulaması_Load(object sender, EventArgs e)
        {
            cayTxt.Text = "0";
            oraletTxt.Text = "0";
            tostTxt.Text = "0";
            menemenTxt.Text = "0";
            kusburnuTxt.Text = "0";
        }
    }
}
