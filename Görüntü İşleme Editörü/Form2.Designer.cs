namespace Görüntü_İşleme_Editörü
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.labelUzunluk = new System.Windows.Forms.Label();
            this.labelYukseklik = new System.Windows.Forms.Label();
            this.textBoxUzunluk = new System.Windows.Forms.TextBox();
            this.textBoxYukseklik = new System.Windows.Forms.TextBox();
            this.numericUpDownGenislik = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYukseklik = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYukseklik)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTamam
            // 
            this.btnTamam.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Location = new System.Drawing.Point(420, 12);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(80, 30);
            this.btnTamam.TabIndex = 0;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(420, 48);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 30);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // labelUzunluk
            // 
            this.labelUzunluk.AutoSize = true;
            this.labelUzunluk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUzunluk.Location = new System.Drawing.Point(19, 17);
            this.labelUzunluk.Name = "labelUzunluk";
            this.labelUzunluk.Size = new System.Drawing.Size(57, 13);
            this.labelUzunluk.TabIndex = 5;
            this.labelUzunluk.Text = "Genişlik:";
            // 
            // labelYukseklik
            // 
            this.labelYukseklik.AutoSize = true;
            this.labelYukseklik.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYukseklik.Location = new System.Drawing.Point(19, 48);
            this.labelYukseklik.Name = "labelYukseklik";
            this.labelYukseklik.Size = new System.Drawing.Size(66, 13);
            this.labelYukseklik.TabIndex = 6;
            this.labelYukseklik.Text = "Yükseklik:";
            // 
            // textBoxUzunluk
            // 
            this.textBoxUzunluk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUzunluk.Location = new System.Drawing.Point(91, 14);
            this.textBoxUzunluk.Name = "textBoxUzunluk";
            this.textBoxUzunluk.ReadOnly = true;
            this.textBoxUzunluk.Size = new System.Drawing.Size(70, 21);
            this.textBoxUzunluk.TabIndex = 7;
            // 
            // textBoxYukseklik
            // 
            this.textBoxYukseklik.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxYukseklik.Location = new System.Drawing.Point(91, 45);
            this.textBoxYukseklik.Name = "textBoxYukseklik";
            this.textBoxYukseklik.ReadOnly = true;
            this.textBoxYukseklik.Size = new System.Drawing.Size(70, 21);
            this.textBoxYukseklik.TabIndex = 8;
            // 
            // numericUpDownGenislik
            // 
            this.numericUpDownGenislik.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownGenislik.Location = new System.Drawing.Point(167, 13);
            this.numericUpDownGenislik.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownGenislik.Name = "numericUpDownGenislik";
            this.numericUpDownGenislik.Size = new System.Drawing.Size(71, 23);
            this.numericUpDownGenislik.TabIndex = 12;
            // 
            // numericUpDownYukseklik
            // 
            this.numericUpDownYukseklik.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownYukseklik.Location = new System.Drawing.Point(167, 44);
            this.numericUpDownYukseklik.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownYukseklik.Name = "numericUpDownYukseklik";
            this.numericUpDownYukseklik.Size = new System.Drawing.Size(71, 23);
            this.numericUpDownYukseklik.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelUzunluk);
            this.groupBox1.Controls.Add(this.numericUpDownYukseklik);
            this.groupBox1.Controls.Add(this.labelYukseklik);
            this.groupBox1.Controls.Add(this.numericUpDownGenislik);
            this.groupBox1.Controls.Add(this.textBoxUzunluk);
            this.groupBox1.Controls.Add(this.textBoxYukseklik);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 109);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 129);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boyutlandır";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYukseklik)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label labelUzunluk;
        private System.Windows.Forms.Label labelYukseklik;
        private System.Windows.Forms.TextBox textBoxUzunluk;
        private System.Windows.Forms.TextBox textBoxYukseklik;
        private System.Windows.Forms.NumericUpDown numericUpDownGenislik;
        private System.Windows.Forms.NumericUpDown numericUpDownYukseklik;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}