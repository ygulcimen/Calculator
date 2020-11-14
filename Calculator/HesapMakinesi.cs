using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class HesapMakinesi : Form
    {
        double deger = 0;
        string islem = "";
        bool islem_yapıldı = false;
        public HesapMakinesi()
        {
            InitializeComponent();
        }
       
  

        private void HesapMakinesi_Load(object sender, EventArgs e)
        {
            string kök = "\u221A";
            button17.Text = kök;
            button18.Text = "x\u00b2";
            button16.Text = "mod";
        }

        private void sayilar_click(object sender, EventArgs e)
        {
            if (tSonuc.Text == "0" || (islem_yapıldı))
            {
                tSonuc.Clear();
            }

            
            Button button = (Button)sender;
            tSonuc.Text += button.Text;
            islem_yapıldı = false;
            lSonuc.Text = " " + tSonuc.Text + " ";

        }

        private void bCE_Click(object sender, EventArgs e)
        {
            tSonuc.Text = "0";
        }

        private void islem_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (deger != 0)
            {
                button19.PerformClick();
                islem = button.Text;
                islem_yapıldı = true;
                lSonuc.Text = deger + " " + islem;
            }
            else
            {
                islem = button.Text;
                deger = Double.Parse(tSonuc.Text);
                islem_yapıldı = true;
                lSonuc.Text = deger + " " + islem;
            }
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            lSonuc.Text = deger + " " + islem + " " + tSonuc.Text + " "+ "= ";
            switch (islem)

            {
                case "+":
                    tSonuc.Text = (deger + double.Parse(tSonuc.Text)).ToString();
                    lSonuc.Text += tSonuc.Text;
                    break;
                case "-":
                    tSonuc.Text = (deger - double.Parse(tSonuc.Text)).ToString();
                    lSonuc.Text += tSonuc.Text;
                    break;
                case "/":
                    tSonuc.Text = (deger / double.Parse(tSonuc.Text)).ToString();
                    lSonuc.Text += tSonuc.Text;
                    break;
                case "*":
                    tSonuc.Text = (deger * double.Parse(tSonuc.Text)).ToString();
                    lSonuc.Text += tSonuc.Text;
                    break;
               
                case "x\u00b2":
                    tSonuc.Text = (deger*deger).ToString();
                    lSonuc.Text += tSonuc.Text;
                    break;

                case "mod":
                    tSonuc.Text = (deger % double.Parse(tSonuc.Text)).ToString();
                    lSonuc.Text += tSonuc.Text;
                    break;

                case "\u221A":
                    
                    lSonuc.Text =  " " + islem + " " + tSonuc.Text + " " + "= ";
                    tSonuc.Text = (Math.Sqrt(Double.Parse(tSonuc.Text))).ToString();
                    lSonuc.Text += tSonuc.Text;
                    break;

                default:
                    break;

            }
            deger = Double.Parse(tSonuc.Text);
            islem = "";
            
        }

       
    }
}
