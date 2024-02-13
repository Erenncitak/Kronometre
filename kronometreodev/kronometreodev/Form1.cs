using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometreodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int salise = 0;
        int saniye = 0;
        int dakika = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_basla_Click(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            salise++;

            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }


            lbl_salisesay.Text = salise.ToString();
            lbl_saniyesay.Text = saniye.ToString();
            lbl_dakikasay.Text = dakika.ToString();

            // Hocam timerın intervalini 1 yapmama rağmen saliseyi tam olarak doğru almıyor çözümünü bulamadım.

        }

        private void btn_tur_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dakika + ":" + saniye + "." + salise);
        }

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            salise = 0;
            saniye = 0;
            dakika = 0;

            lbl_salisesay.Text = salise.ToString();
            lbl_saniyesay.Text = saniye.ToString();
            lbl_dakikasay.Text = dakika.ToString();
            listBox1.Items.Clear();
        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
