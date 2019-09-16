using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görüntü_İşleme_Editörü
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

        private Bitmap olcekle(Bitmap bmp)
        {
            frm1.yeni[frm1.sayici] = new Bitmap(frm1.pictureBoxPanel.Image, Convert.ToInt32(numericUpDownGenislik.Value), Convert.ToInt32(numericUpDownYukseklik.Value));
            
            return frm1.yeni[frm1.sayici];
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxUzunluk.Text = Convert.ToString(frm1.yeni[frm1.sayici].Width);
            textBoxYukseklik.Text = Convert.ToString(frm1.yeni[frm1.sayici].Height);
            numericUpDownGenislik.Value = frm1.yeni[frm1.sayici].Width;
            numericUpDownYukseklik.Value = frm1.yeni[frm1.sayici].Height;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            frm1.sayici++;
            frm1.resimler[frm1.sayici] = new Bitmap(frm1.pictureBoxPanel.Image);
            Bitmap olceklenmis = olcekle(frm1.resimler[frm1.sayici]);

            frm1.pictureBoxPanel.Image = olceklenmis;
            frm1.btnGeri.Enabled = true;
            frm1.btnIleri.Enabled = false;
            frm1.btnReopen.Enabled = true;
            frm1.textBoxCozunurluk.Text = Convert.ToString(frm1.yeni[frm1.sayici].Width) + " x " + Convert.ToString(frm1.yeni[frm1.sayici].Height);
            this.Hide();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
