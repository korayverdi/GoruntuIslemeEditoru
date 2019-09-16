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
    public partial class Form1 : Form
    {
        public Form2 frm2;

        public Form1()
        {
            frm2 = new Form2();
            InitializeComponent();
            frm2.frm1 = this;
        }

        public int sayici = 0;
        public Bitmap[] resimler = new Bitmap[100];
        public Bitmap[] yeni = new Bitmap[100];
        OpenFileDialog file = new OpenFileDialog();
        SaveFileDialog kaydet = new SaveFileDialog();

        int[] R = new int[256];
        int[] G = new int[256];
        int[] B = new int[256];
        int maxR, maxG, maxB;

        Boolean durum = false;

        private Bitmap orjinal(Bitmap bmp)
        {
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color renk;
                    renk = Color.FromArgb(bmp.GetPixel(x, y).R, bmp.GetPixel(x, y).G, bmp.GetPixel(x, y).B);
                    bmp.SetPixel(x, y, renk);
                }
            }
     
            return bmp;
        }

        private Bitmap yatayAyna(Bitmap bmp)
        {
            yeni[sayici] = new Bitmap(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color renk;
                    renk = Color.FromArgb(bmp.GetPixel(x, y).R, bmp.GetPixel(x, y).G, bmp.GetPixel(x, y).B);
                    yeni[sayici].SetPixel(x, bmp.Height - 1 - y, renk);
                }
            }
            return yeni[sayici];
        }

        private Bitmap dikeyAyna(Bitmap bmp)
        {
            yeni[sayici] = new Bitmap(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color renk;
                    renk = Color.FromArgb(bmp.GetPixel(x, y).R, bmp.GetPixel(x, y).G, bmp.GetPixel(x, y).B);
                    yeni[sayici].SetPixel(bmp.Width - x - 1,  y, renk);
                }
            }
            return yeni[sayici];
        }

        private Bitmap solaCevir(Bitmap bmp)
        {
            yeni[sayici] = new Bitmap(bmp.Height, bmp.Width);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color renk;
                    renk = Color.FromArgb(bmp.GetPixel(x, y).R, bmp.GetPixel(x, y).G, bmp.GetPixel(x, y).B);
                    yeni[sayici].SetPixel(y,bmp.Width - 1 - x, renk);
                }
            }
            return yeni[sayici];
        }

        private Bitmap sagaCevir(Bitmap bmp)
        {
            yeni[sayici] = new Bitmap(bmp.Height, bmp.Width);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color renk;
                    renk = Color.FromArgb(bmp.GetPixel(x, y).R, bmp.GetPixel(x, y).G, bmp.GetPixel(x, y).B);
                    yeni[sayici].SetPixel(bmp.Height - y - 1, x, renk);
                }
            }
            return yeni[sayici];
        }

        private Bitmap griskala(Bitmap bmp)
        {
            yeni[sayici] = new Bitmap(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for(int y = 0; y < bmp.Height; y++)
                {
                    int griDegeri = (bmp.GetPixel(x, y).R + bmp.GetPixel(x, y).G + bmp.GetPixel(x, y).B) / 3;

                    Color renk;
                    renk = Color.FromArgb(griDegeri, griDegeri, griDegeri);
                    yeni[sayici].SetPixel(x, y, renk);
                }
            }           
            return yeni[sayici];
        }

        private Bitmap negatif(Bitmap bmp)
        {
            yeni[sayici] = new Bitmap(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height ; y++)
                {
                    Color renk;
                    renk = Color.FromArgb(255 - bmp.GetPixel(x, y).R,255 - bmp.GetPixel(x, y).G,255 - bmp.GetPixel(x, y).B);
                    yeni[sayici].SetPixel(x, y, renk);
                }
            }
            return yeni[sayici];
        }

        private Bitmap kirmizi(Bitmap bmp)
        {
            Color renk;
            yeni[sayici] = new Bitmap(bmp.Width, bmp.Height);
            if (checkBoxRenkleriGoster.Checked == true)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        renk = Color.FromArgb(bmp.GetPixel(x, y).R, 0, 0);
                        yeni[sayici].SetPixel(x, y, renk);
                    }
                }
            }

            if (checkBoxRenkleriGoster.Checked == false)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        renk = Color.FromArgb(bmp.GetPixel(x, y).R, bmp.GetPixel(x, y).R, bmp.GetPixel(x, y).R);
                        yeni[sayici].SetPixel(x, y, renk);
                    }
                }
            }
            return yeni[sayici];
        }

        private Bitmap yesil(Bitmap bmp)
        {
            Color renk;
            yeni[sayici] = new Bitmap(bmp.Width, bmp.Height);
            if (checkBoxRenkleriGoster.Checked == true)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        renk = Color.FromArgb(0, bmp.GetPixel(x, y).G, 0);
                        yeni[sayici].SetPixel(x, y, renk);
                    }
                }
            }

            if (checkBoxRenkleriGoster.Checked == false)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        renk = Color.FromArgb(bmp.GetPixel(x, y).G, bmp.GetPixel(x, y).G, bmp.GetPixel(x, y).G);
                        yeni[sayici].SetPixel(x, y, renk);
                    }
                }
            }
            return yeni[sayici];
        }

        private Bitmap mavi(Bitmap bmp)
        {
            Color renk;
            yeni[sayici] = new Bitmap(bmp.Width, bmp.Height);
            if (checkBoxRenkleriGoster.Checked == true)
            {               
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        renk = Color.FromArgb(0, 0, bmp.GetPixel(x, y).B);
                        yeni[sayici].SetPixel(x, y, renk);
                    }
                }
            }             

            if (checkBoxRenkleriGoster.Checked == false)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        renk = Color.FromArgb(bmp.GetPixel(x, y).B, bmp.GetPixel(x, y).B, bmp.GetPixel(x, y).B);
                        yeni[sayici].SetPixel(x, y, renk);
                    }
                }
            }
            return yeni[sayici];
        }

        private Bitmap Sepya(Bitmap bmp)
        {
            yeni[sayici] = new Bitmap(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    float Red = bmp.GetPixel(x, y).R * 393 / 1000 + bmp.GetPixel(x, y).G * 769 / 1000 + bmp.GetPixel(x, y).B * 189 / 1000;
                    float Green = bmp.GetPixel(x, y).R * 349 / 1000 + bmp.GetPixel(x, y).G * 686 / 1000 + bmp.GetPixel(x, y).B * 168 / 1000;
                    float Blue = bmp.GetPixel(x, y).R * 272 / 1000 + bmp.GetPixel(x, y).G * 534 / 1000 + bmp.GetPixel(x, y).B * 131 / 1000;
                    if (Red > 255) { Red = 255; }
                    if (Green > 255) { Green = 255; }
                    if (Blue > 255) { Blue = 255; }
                    yeni[sayici].SetPixel(x, y, Color.FromArgb(Convert.ToInt32(Red), Convert.ToInt32(Green), Convert.ToInt32(Blue)));
                }
            }

            return yeni[sayici];
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            sayici = 0;
            for(int i = 0; i < 100; i++)
            {
                yeni[i] = null;
            }
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "Resim dosyaları (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;

            if(file.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            pictureBoxPanel.ImageLocation = file.FileName;
            
            resimler[sayici] = new Bitmap(file.FileName);
            yeni[sayici] = resimler[sayici];

            textBoxCozunurluk.Text = Convert.ToString(resimler[sayici].Width) + " x " + Convert.ToString(resimler[sayici].Height);

            groupBox1.Enabled = true;
            groupBoxFiltre.Enabled = true;
            btnGeri.Enabled = false;
            btnIleri.Enabled = false;
            btnKaydet.Enabled = true;
            groupBoxRenkKanallari.Enabled = true;
            labelRGB0.Visible = false;
            labelmaxRGB.Visible = false;
            labelmax.Visible = false;

            System.Drawing.Graphics grafiknesne;
            grafiknesne = pictureBoxHistogram.CreateGraphics();
            SolidBrush panel = new SolidBrush(System.Drawing.SystemColors.Control);
            grafiknesne.FillRectangle(panel, 0, 0, 350, 300);
        }

        private void btnGriSkala_Click(object sender, EventArgs e)
        {
            sayici++;
            
            for (int i = sayici; i < yeni.Length; i++)
            {
                if (yeni[i] != null)
                {
                    yeni[i] = null;
                }
                else
                    break;
                
            }
            
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap gri = griskala(resimler[sayici]);

            pictureBoxPanel.Image = gri;
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnNegatif_Click(object sender, EventArgs e)
        {
            sayici++;
            for(int i = sayici; i < yeni.Length; i++)
            {
                yeni[i] = null;
            }
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap nega = negatif(resimler[sayici]);

            pictureBoxPanel.Image = nega;
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnSepya_Click(object sender, EventArgs e)
        {
            sayici++;
            for (int i = sayici; i < yeni.Length; i++)
            {
                yeni[i] = null;
            }
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap sepya = Sepya(resimler[sayici]);

            pictureBoxPanel.Image = sepya;
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            sayici++;
            for (int i = sayici; i < yeni.Length; i++)
            {
                yeni[i] = null;
            }
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap red = kirmizi(resimler[sayici]);

            pictureBoxPanel.Image = red;
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            sayici++;
            for (int i = sayici; i < yeni.Length; i++)
            {
                yeni[i] = null;
            }
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap green = yesil(resimler[sayici]);

            pictureBoxPanel.Image = green;
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            sayici++;
            for (int i = sayici; i < yeni.Length; i++)
            {
                yeni[i] = null;
            }
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap blue = mavi(resimler[sayici]);

            pictureBoxPanel.Image = blue;
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnSolaCevir_Click(object sender, EventArgs e)
        {
            sayici++;
            for (int i = sayici; i < yeni.Length; i++)
            {
                yeni[i] = null;
            }
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap sag = solaCevir(resimler[sayici]);

            pictureBoxPanel.Image = sag;
            textBoxCozunurluk.Text = Convert.ToString(yeni[sayici].Width) + " x " + Convert.ToString(yeni[sayici].Height);
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnSagaCevir_Click(object sender, EventArgs e)
        {
            sayici++;
            for (int i = sayici; i < yeni.Length; i++)
            {
                yeni[i] = null;
            }
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap sol = sagaCevir(resimler[sayici]);

            pictureBoxPanel.Image = sol;
            textBoxCozunurluk.Text = Convert.ToString(yeni[sayici].Width) + " x " + Convert.ToString(yeni[sayici].Height);
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnAynalama_Click(object sender, EventArgs e)
        {
            sayici++;
            for (int i = sayici; i < yeni.Length; i++)
            {
                yeni[i] = null;
            }
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap ayna = dikeyAyna(resimler[sayici]);

            pictureBoxPanel.Image = ayna;
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnAynalama2_Click(object sender, EventArgs e)
        {
            sayici++;
            for (int i = sayici; i < yeni.Length; i++)
            {
                yeni[i] = null;
            }
            resimler[sayici] = new Bitmap(pictureBoxPanel.Image);
            Bitmap ayna2 = yatayAyna(resimler[sayici]);

            pictureBoxPanel.Image = ayna2;
            btnGeri.Enabled = true;
            btnIleri.Enabled = false;
            btnReopen.Enabled = true;
        }

        private void btnOlcekle_Click(object sender, EventArgs e)
        {
            
            frm2.ShowDialog();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            sayici--;
            pictureBoxPanel.Image = yeni[sayici];
            textBoxCozunurluk.Text = Convert.ToString(yeni[sayici].Width) + " x " + Convert.ToString(yeni[sayici].Height);
            if (sayici == 0)
            {
                btnGeri.Enabled = false;
                btnReopen.Enabled = false;
            }
            btnIleri.Enabled = true;
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            sayici++;
            pictureBoxPanel.Image = yeni[sayici];
            textBoxCozunurluk.Text = Convert.ToString(yeni[sayici].Width) + " x " + Convert.ToString(yeni[sayici].Height);

            if (yeni[sayici + 1] == null)
            {
                btnIleri.Enabled = false;
            }
            btnGeri.Enabled = true;
            btnReopen.Enabled = true;
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            sayici = 0;
            pictureBoxPanel.Image = yeni[sayici];
            textBoxCozunurluk.Text = Convert.ToString(yeni[sayici].Width) + " x " + Convert.ToString(yeni[sayici].Height);
            if (sayici == 0)
            {
                btnGeri.Enabled = false;
            }
            btnIleri.Enabled = true;
            btnReopen.Enabled = false;
        }

        private void pictureBoxPanel_MouseDown(object sender, MouseEventArgs e)
        {
            float genislik = 549 * yeni[sayici].Width / yeni[sayici].Height;
            float bosluk = (549 - genislik) / 2;

            if (yeni[sayici].Height >= yeni[sayici].Width && e.X >= bosluk && e.X < 549 - bosluk)
            {
                float sayi = yeni[sayici].Height;
                float oran = sayi / 549;

                Color color = yeni[sayici].GetPixel(Convert.ToInt16((e.X - bosluk) * oran), Convert.ToInt16(e.Y * oran));
                
                textBoxR.Text = color.R.ToString();
                textBoxG.Text = color.G.ToString();
                textBoxB.Text = color.B.ToString();

                panel1.BackColor = color;
            }
                       
            else if(yeni[sayici].Height < yeni[sayici].Width)
            {
                genislik = 549 * yeni[sayici].Height / yeni[sayici].Width;
                bosluk = (549 - genislik) / 2;

                if(e.Y >= bosluk && e.Y < 549 - bosluk)
                {
                    float sayi = yeni[sayici].Width;
                    float oran = sayi / 549;

                    Color color = yeni[sayici].GetPixel(Convert.ToInt16(e.X * oran), Convert.ToInt16((e.Y - bosluk) * oran));

                    textBoxR.Text = color.R.ToString();
                    textBoxG.Text = color.G.ToString();
                    textBoxB.Text = color.B.ToString();

                    panel1.BackColor = color;
                }                             
            }           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            kaydet.Title = "Farklı Kaydet";
            kaydet.Filter = "Resim dosyaları (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";            

            if (kaydet.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPanel.Image.Save(kaydet.FileName);
            }

            

            
            
            
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                R[i] = 0;
                G[i] = 0;
                B[i] = 0;
            }

            for (int x = 0; x < yeni[sayici].Size.Width; x++)
            {
                for (int y = 0; y < yeni[sayici].Size.Height; y++)
                {
                    Color renk = yeni[sayici].GetPixel(x, y);
                    R[renk.R]++;
                    G[renk.G]++;
                    B[renk.B]++;
                }
            }

            maxR = R[0];
            maxG = R[0];
            maxB = R[0];

            for (int i = 0; i < R.Length; i++)
            {               
                if (maxR < R[i])
                {
                    maxR = R[i];
                }
            }

            for (int i = 0; i < G.Length; i++)
            {
                if (maxG < G[i])
                {
                    maxG = G[i];
                }
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (maxB < B[i])
                {
                    maxB = B[i];
                }
            }

            float max = 0;
            if(maxR >= maxG && maxR >= maxB || (maxR == maxG && maxR == maxB))
            {
                max = maxR;
            }
            if (maxG >= maxR && maxG >= maxB || (maxR == maxG && maxR == maxB))
            {
                max = maxG;
            }
            if ((maxB >= maxG && maxB >= maxR) || (maxR == maxG && maxR == maxB))
            {
                max = maxB;
            }

            float oran = max / 250;

            labelmax.Text = max.ToString();
            labelmax.Visible = true;
            labelmaxRGB.Visible = true;
            labelRGB0.Visible = true;
            System.Drawing.Graphics grafiknesne;
            grafiknesne = pictureBoxHistogram.CreateGraphics();

            Pen line = new Pen(System.Drawing.Color.Black, 1);
            
            Pen kirmizi = new Pen(System.Drawing.Color.Red, 1);
            Pen yesil = new Pen(System.Drawing.Color.Green, 1);
            Pen mavi = new Pen(System.Drawing.Color.Blue, 1);           

            SolidBrush panel = new SolidBrush(System.Drawing.SystemColors.Control);
            grafiknesne.FillRectangle(panel, 0, 0, 350, 300);

            grafiknesne.DrawLine(line, 50, 280, 330, 280); // Yatay
            grafiknesne.DrawLine(line, 50, 280, 50, 20); // Dikey
            grafiknesne.DrawLine(line, 330, 280, 325, 285); // Yatay yön
            grafiknesne.DrawLine(line, 330, 280, 325, 275); // yatay yön
            grafiknesne.DrawLine(line, 50, 20, 45, 25); // Dikey yön
            grafiknesne.DrawLine(line, 50, 20, 55, 25); // Dikey yön
            grafiknesne.DrawLine(line, 48, 30, 52, 30);

            for (int i = 0; i <= 17; i++)
            {
                grafiknesne.DrawLine(line, 50 + (i * 15), 278, 50 + (i * 15), 282);
            }

            for (int i = 0; i < 255; i++)
            {
                if (R[i] != G[i] && R[i] != B[i])
                {
                    durum = false;
                    break;
                }
                else
                {
                    durum = true;
                }
            }

            if(durum == true)
            {
                mavi = new Pen(System.Drawing.Color.Gray, 1);
            }

            for(int i = 0; i < 255; i++)
            {
                grafiknesne.DrawLine(kirmizi, (50 + i), (280 - (R[i] / oran)), (50 + i + 1), (280 - (R[i + 1] / oran)));
                grafiknesne.DrawLine(yesil, (50 + i), (280 - (G[i] / oran)), (50 + i + 1), (280 - (G[i + 1] / oran)));
                grafiknesne.DrawLine(mavi, (50 + i), (280 - (B[i] / oran)), (50 + i + 1), (280 - (B[i + 1] / oran)));
            }
            //grafiknesne.DrawLine(line, 50, 30, 330, 30); // Yatay
        }
    }
}
