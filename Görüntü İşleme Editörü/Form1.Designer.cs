namespace Görüntü_İşleme_Editörü
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxPanel = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.btnGriSkala = new System.Windows.Forms.Button();
            this.btnNegatif = new System.Windows.Forms.Button();
            this.btnSagaCevir = new System.Windows.Forms.Button();
            this.btnSolaCevir = new System.Windows.Forms.Button();
            this.textBoxCozunurluk = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnAynalama = new System.Windows.Forms.Button();
            this.btnAynalama2 = new System.Windows.Forms.Button();
            this.btnOlcekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxFiltre = new System.Windows.Forms.GroupBox();
            this.btnSepya = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnReopen = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pictureBoxHistogram = new System.Windows.Forms.PictureBox();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.labelmax = new System.Windows.Forms.Label();
            this.labelmaxRGB = new System.Windows.Forms.Label();
            this.labelRGB0 = new System.Windows.Forms.Label();
            this.groupBoxRenkKanallari = new System.Windows.Forms.GroupBox();
            this.checkBoxRenkleriGoster = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).BeginInit();
            this.groupBoxRenkKanallari.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPanel
            // 
            this.pictureBoxPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxPanel.InitialImage = null;
            this.pictureBoxPanel.Location = new System.Drawing.Point(418, 48);
            this.pictureBoxPanel.Name = "pictureBoxPanel";
            this.pictureBoxPanel.Size = new System.Drawing.Size(550, 550);
            this.pictureBoxPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPanel.TabIndex = 0;
            this.pictureBoxPanel.TabStop = false;
            this.pictureBoxPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPanel_MouseDown);
            // 
            // btnResimSec
            // 
            this.btnResimSec.BackColor = System.Drawing.SystemColors.Control;
            this.btnResimSec.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimSec.Location = new System.Drawing.Point(12, 12);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(80, 30);
            this.btnResimSec.TabIndex = 1;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = false;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnGriSkala
            // 
            this.btnGriSkala.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGriSkala.Location = new System.Drawing.Point(6, 20);
            this.btnGriSkala.Name = "btnGriSkala";
            this.btnGriSkala.Size = new System.Drawing.Size(80, 30);
            this.btnGriSkala.TabIndex = 2;
            this.btnGriSkala.Text = "Gri Skala";
            this.btnGriSkala.UseVisualStyleBackColor = true;
            this.btnGriSkala.Click += new System.EventHandler(this.btnGriSkala_Click);
            // 
            // btnNegatif
            // 
            this.btnNegatif.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNegatif.Location = new System.Drawing.Point(6, 56);
            this.btnNegatif.Name = "btnNegatif";
            this.btnNegatif.Size = new System.Drawing.Size(80, 30);
            this.btnNegatif.TabIndex = 3;
            this.btnNegatif.Text = "Negatif";
            this.btnNegatif.UseVisualStyleBackColor = true;
            this.btnNegatif.Click += new System.EventHandler(this.btnNegatif_Click);
            // 
            // btnSagaCevir
            // 
            this.btnSagaCevir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSagaCevir.Image = ((System.Drawing.Image)(resources.GetObject("btnSagaCevir.Image")));
            this.btnSagaCevir.Location = new System.Drawing.Point(42, 39);
            this.btnSagaCevir.Name = "btnSagaCevir";
            this.btnSagaCevir.Size = new System.Drawing.Size(30, 30);
            this.btnSagaCevir.TabIndex = 4;
            this.btnSagaCevir.UseVisualStyleBackColor = true;
            this.btnSagaCevir.Click += new System.EventHandler(this.btnSagaCevir_Click);
            // 
            // btnSolaCevir
            // 
            this.btnSolaCevir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSolaCevir.Image = ((System.Drawing.Image)(resources.GetObject("btnSolaCevir.Image")));
            this.btnSolaCevir.Location = new System.Drawing.Point(6, 39);
            this.btnSolaCevir.Name = "btnSolaCevir";
            this.btnSolaCevir.Size = new System.Drawing.Size(30, 30);
            this.btnSolaCevir.TabIndex = 5;
            this.btnSolaCevir.UseVisualStyleBackColor = true;
            this.btnSolaCevir.Click += new System.EventHandler(this.btnSolaCevir_Click);
            // 
            // textBoxCozunurluk
            // 
            this.textBoxCozunurluk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCozunurluk.Location = new System.Drawing.Point(418, 604);
            this.textBoxCozunurluk.Name = "textBoxCozunurluk";
            this.textBoxCozunurluk.ReadOnly = true;
            this.textBoxCozunurluk.Size = new System.Drawing.Size(136, 21);
            this.textBoxCozunurluk.TabIndex = 6;
            // 
            // btnGeri
            // 
            this.btnGeri.Enabled = false;
            this.btnGeri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(686, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(80, 30);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri al";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Enabled = false;
            this.btnIleri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIleri.Location = new System.Drawing.Point(772, 12);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(80, 30);
            this.btnIleri.TabIndex = 8;
            this.btnIleri.Text = "İleri al";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnAynalama
            // 
            this.btnAynalama.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAynalama.Image = ((System.Drawing.Image)(resources.GetObject("btnAynalama.Image")));
            this.btnAynalama.Location = new System.Drawing.Point(78, 39);
            this.btnAynalama.Name = "btnAynalama";
            this.btnAynalama.Size = new System.Drawing.Size(30, 30);
            this.btnAynalama.TabIndex = 10;
            this.btnAynalama.UseVisualStyleBackColor = true;
            this.btnAynalama.Click += new System.EventHandler(this.btnAynalama_Click);
            // 
            // btnAynalama2
            // 
            this.btnAynalama2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAynalama2.Image = ((System.Drawing.Image)(resources.GetObject("btnAynalama2.Image")));
            this.btnAynalama2.Location = new System.Drawing.Point(114, 39);
            this.btnAynalama2.Name = "btnAynalama2";
            this.btnAynalama2.Size = new System.Drawing.Size(30, 30);
            this.btnAynalama2.TabIndex = 11;
            this.btnAynalama2.UseVisualStyleBackColor = true;
            this.btnAynalama2.Click += new System.EventHandler(this.btnAynalama2_Click);
            // 
            // btnOlcekle
            // 
            this.btnOlcekle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlcekle.Location = new System.Drawing.Point(92, 111);
            this.btnOlcekle.Name = "btnOlcekle";
            this.btnOlcekle.Size = new System.Drawing.Size(80, 30);
            this.btnOlcekle.TabIndex = 12;
            this.btnOlcekle.Text = "Ölçeklendir";
            this.btnOlcekle.UseVisualStyleBackColor = true;
            this.btnOlcekle.Click += new System.EventHandler(this.btnOlcekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnHistogram);
            this.groupBox1.Controls.Add(this.btnSolaCevir);
            this.groupBox1.Controls.Add(this.groupBoxFiltre);
            this.groupBox1.Controls.Add(this.btnOlcekle);
            this.groupBox1.Controls.Add(this.btnSagaCevir);
            this.groupBox1.Controls.Add(this.btnAynalama2);
            this.groupBox1.Controls.Add(this.btnAynalama);
            this.groupBox1.Enabled = false;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 153);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxFiltre
            // 
            this.groupBoxFiltre.Controls.Add(this.btnSepya);
            this.groupBoxFiltre.Controls.Add(this.btnGriSkala);
            this.groupBoxFiltre.Controls.Add(this.btnNegatif);
            this.groupBoxFiltre.Enabled = false;
            this.groupBoxFiltre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxFiltre.Location = new System.Drawing.Point(302, 19);
            this.groupBoxFiltre.Name = "groupBoxFiltre";
            this.groupBoxFiltre.Size = new System.Drawing.Size(92, 128);
            this.groupBoxFiltre.TabIndex = 24;
            this.groupBoxFiltre.TabStop = false;
            this.groupBoxFiltre.Text = "Filtreler";
            // 
            // btnSepya
            // 
            this.btnSepya.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepya.Location = new System.Drawing.Point(6, 92);
            this.btnSepya.Name = "btnSepya";
            this.btnSepya.Size = new System.Drawing.Size(80, 30);
            this.btnSepya.TabIndex = 25;
            this.btnSepya.Text = "Sepya";
            this.btnSepya.UseVisualStyleBackColor = true;
            this.btnSepya.Click += new System.EventHandler(this.btnSepya_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBlue.Location = new System.Drawing.Point(178, 19);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(80, 30);
            this.btnBlue.TabIndex = 15;
            this.btnBlue.Text = "Mavi";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGreen.Location = new System.Drawing.Point(92, 19);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(80, 30);
            this.btnGreen.TabIndex = 14;
            this.btnGreen.Text = "Yeşil";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRed
            // 
            this.btnRed.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRed.Location = new System.Drawing.Point(6, 19);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(80, 30);
            this.btnRed.TabIndex = 13;
            this.btnRed.Text = "Kırmızı";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnReopen
            // 
            this.btnReopen.Enabled = false;
            this.btnReopen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReopen.Location = new System.Drawing.Point(858, 12);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(110, 30);
            this.btnReopen.TabIndex = 14;
            this.btnReopen.Text = "Tümünü geri al";
            this.btnReopen.UseVisualStyleBackColor = true;
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxR.Location = new System.Drawing.Point(586, 604);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.ReadOnly = true;
            this.textBoxR.Size = new System.Drawing.Size(43, 21);
            this.textBoxR.TabIndex = 15;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelR.Location = new System.Drawing.Point(560, 607);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(20, 13);
            this.labelR.TabIndex = 16;
            this.labelR.Text = "R:";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelG.Location = new System.Drawing.Point(635, 607);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(21, 13);
            this.labelG.TabIndex = 18;
            this.labelG.Text = "G:";
            // 
            // textBoxG
            // 
            this.textBoxG.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxG.Location = new System.Drawing.Point(662, 604);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.ReadOnly = true;
            this.textBoxG.Size = new System.Drawing.Size(43, 21);
            this.textBoxG.TabIndex = 17;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelB.Location = new System.Drawing.Point(711, 607);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(20, 13);
            this.labelB.TabIndex = 20;
            this.labelB.Text = "B:";
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxB.Location = new System.Drawing.Point(737, 604);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(43, 21);
            this.textBoxB.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(947, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 21);
            this.panel1.TabIndex = 21;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(98, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 30);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pictureBoxHistogram
            // 
            this.pictureBoxHistogram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxHistogram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHistogram.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxHistogram.InitialImage = null;
            this.pictureBoxHistogram.Location = new System.Drawing.Point(12, 207);
            this.pictureBoxHistogram.Name = "pictureBoxHistogram";
            this.pictureBoxHistogram.Size = new System.Drawing.Size(350, 300);
            this.pictureBoxHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHistogram.TabIndex = 23;
            this.pictureBoxHistogram.TabStop = false;
            // 
            // btnHistogram
            // 
            this.btnHistogram.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHistogram.Location = new System.Drawing.Point(6, 111);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(80, 30);
            this.btnHistogram.TabIndex = 25;
            this.btnHistogram.Text = "Histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // labelmax
            // 
            this.labelmax.AutoSize = true;
            this.labelmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelmax.Location = new System.Drawing.Point(32, 237);
            this.labelmax.Name = "labelmax";
            this.labelmax.Size = new System.Drawing.Size(24, 7);
            this.labelmax.TabIndex = 24;
            this.labelmax.Text = "label1";
            this.labelmax.Visible = false;
            // 
            // labelmaxRGB
            // 
            this.labelmaxRGB.AutoSize = true;
            this.labelmaxRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelmaxRGB.Location = new System.Drawing.Point(312, 494);
            this.labelmaxRGB.Name = "labelmaxRGB";
            this.labelmaxRGB.Size = new System.Drawing.Size(16, 7);
            this.labelmaxRGB.TabIndex = 25;
            this.labelmaxRGB.Text = "255";
            this.labelmaxRGB.Visible = false;
            // 
            // labelRGB0
            // 
            this.labelRGB0.AutoSize = true;
            this.labelRGB0.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRGB0.Location = new System.Drawing.Point(62, 494);
            this.labelRGB0.Name = "labelRGB0";
            this.labelRGB0.Size = new System.Drawing.Size(8, 7);
            this.labelRGB0.TabIndex = 26;
            this.labelRGB0.Text = "0";
            this.labelRGB0.Visible = false;
            // 
            // groupBoxRenkKanallari
            // 
            this.groupBoxRenkKanallari.Controls.Add(this.checkBoxRenkleriGoster);
            this.groupBoxRenkKanallari.Controls.Add(this.btnRed);
            this.groupBoxRenkKanallari.Controls.Add(this.btnGreen);
            this.groupBoxRenkKanallari.Controls.Add(this.btnBlue);
            this.groupBoxRenkKanallari.Enabled = false;
            this.groupBoxRenkKanallari.Location = new System.Drawing.Point(12, 513);
            this.groupBoxRenkKanallari.Name = "groupBoxRenkKanallari";
            this.groupBoxRenkKanallari.Size = new System.Drawing.Size(350, 85);
            this.groupBoxRenkKanallari.TabIndex = 27;
            this.groupBoxRenkKanallari.TabStop = false;
            this.groupBoxRenkKanallari.Text = "Renk Kanalları";
            // 
            // checkBoxRenkleriGoster
            // 
            this.checkBoxRenkleriGoster.AutoSize = true;
            this.checkBoxRenkleriGoster.Location = new System.Drawing.Point(6, 55);
            this.checkBoxRenkleriGoster.Name = "checkBoxRenkleriGoster";
            this.checkBoxRenkleriGoster.Size = new System.Drawing.Size(180, 17);
            this.checkBoxRenkleriGoster.TabIndex = 17;
            this.checkBoxRenkleriGoster.Text = "Kanallar içerisinde renkleri göster";
            this.checkBoxRenkleriGoster.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 637);
            this.Controls.Add(this.groupBoxRenkKanallari);
            this.Controls.Add(this.labelRGB0);
            this.Controls.Add(this.labelmaxRGB);
            this.Controls.Add(this.labelmax);
            this.Controls.Add(this.pictureBoxHistogram);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.btnReopen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.textBoxCozunurluk);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBoxPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntü İşleme Editörü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPanel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxFiltre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).EndInit();
            this.groupBoxRenkKanallari.ResumeLayout(false);
            this.groupBoxRenkKanallari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Button btnGriSkala;
        private System.Windows.Forms.Button btnNegatif;
        private System.Windows.Forms.Button btnSolaCevir;
        private System.Windows.Forms.Button btnSagaCevir;
        private System.Windows.Forms.Button btnAynalama;
        private System.Windows.Forms.Button btnAynalama2;
        private System.Windows.Forms.Button btnOlcekle;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox pictureBoxPanel;
        public System.Windows.Forms.Button btnGeri;
        public System.Windows.Forms.Button btnIleri;
        public System.Windows.Forms.TextBox textBoxCozunurluk;
        public System.Windows.Forms.Button btnReopen;
        public System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        public System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label labelB;
        public System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.GroupBox groupBoxFiltre;
        private System.Windows.Forms.Button btnSepya;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.PictureBox pictureBoxHistogram;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.Label labelmax;
        private System.Windows.Forms.Label labelmaxRGB;
        private System.Windows.Forms.Label labelRGB0;
        private System.Windows.Forms.GroupBox groupBoxRenkKanallari;
        private System.Windows.Forms.CheckBox checkBoxRenkleriGoster;
    }
}

