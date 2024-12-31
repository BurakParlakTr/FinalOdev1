namespace FinalOdev2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDersSecimi = new Button();
            btnBul = new Button();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            grpOgrenci = new GroupBox();
            SinifCombobox = new ComboBox();
            lblSinif = new Label();
            Numaratxt = new TextBox();
            Soyadtxt = new TextBox();
            Adlabel = new Label();
            Soyadlabel = new Label();
            Adtxt = new TextBox();
            Numaralabel = new Label();
            dersekle = new Button();
            btnSinifekle = new Button();
            grpOgrenci.SuspendLayout();
            SuspendLayout();
            // 
            // btnDersSecimi
            // 
            btnDersSecimi.Location = new Point(298, 367);
            btnDersSecimi.Name = "btnDersSecimi";
            btnDersSecimi.Size = new Size(194, 38);
            btnDersSecimi.TabIndex = 15;
            btnDersSecimi.Text = "Ders Seçimi";
            btnDersSecimi.UseVisualStyleBackColor = true;
            btnDersSecimi.Click += btnDersSecimi_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(494, 289);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(108, 38);
            btnBul.TabIndex = 14;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(344, 289);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(108, 38);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(199, 289);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(108, 38);
            btnGuncelle.TabIndex = 12;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // grpOgrenci
            // 
            grpOgrenci.Controls.Add(SinifCombobox);
            grpOgrenci.Controls.Add(lblSinif);
            grpOgrenci.Controls.Add(Numaratxt);
            grpOgrenci.Controls.Add(Soyadtxt);
            grpOgrenci.Controls.Add(Adlabel);
            grpOgrenci.Controls.Add(Soyadlabel);
            grpOgrenci.Controls.Add(Adtxt);
            grpOgrenci.Controls.Add(Numaralabel);
            grpOgrenci.Location = new Point(263, 45);
            grpOgrenci.Name = "grpOgrenci";
            grpOgrenci.Size = new Size(302, 225);
            grpOgrenci.TabIndex = 11;
            grpOgrenci.TabStop = false;
            grpOgrenci.Text = "Öğrenci";
            // 
            // SinifCombobox
            // 
            SinifCombobox.FormattingEnabled = true;
            SinifCombobox.Location = new Point(134, 175);
            SinifCombobox.Name = "SinifCombobox";
            SinifCombobox.Size = new Size(151, 28);
            SinifCombobox.TabIndex = 7;
            SinifCombobox.SelectedIndexChanged += SinifCombobox_SelectedIndexChanged;
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(20, 178);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(88, 20);
            lblSinif.TabIndex = 6;
            lblSinif.Text = "Sınıf Seçiniz";
            // 
            // Numaratxt
            // 
            Numaratxt.Location = new Point(143, 125);
            Numaratxt.Name = "Numaratxt";
            Numaratxt.Size = new Size(125, 27);
            Numaratxt.TabIndex = 4;
            // 
            // Soyadtxt
            // 
            Soyadtxt.Location = new Point(143, 82);
            Soyadtxt.Name = "Soyadtxt";
            Soyadtxt.Size = new Size(125, 27);
            Soyadtxt.TabIndex = 5;
            // 
            // Adlabel
            // 
            Adlabel.AutoSize = true;
            Adlabel.Location = new Point(35, 40);
            Adlabel.Name = "Adlabel";
            Adlabel.Size = new Size(28, 20);
            Adlabel.TabIndex = 0;
            Adlabel.Text = "Ad";
            // 
            // Soyadlabel
            // 
            Soyadlabel.AutoSize = true;
            Soyadlabel.Location = new Point(35, 82);
            Soyadlabel.Name = "Soyadlabel";
            Soyadlabel.Size = new Size(50, 20);
            Soyadlabel.TabIndex = 1;
            Soyadlabel.Text = "Soyad";
            // 
            // Adtxt
            // 
            Adtxt.Location = new Point(143, 40);
            Adtxt.Name = "Adtxt";
            Adtxt.Size = new Size(125, 27);
            Adtxt.TabIndex = 3;
            Adtxt.TextChanged += Adtxt_TextChanged;
            // 
            // Numaralabel
            // 
            Numaralabel.AutoSize = true;
            Numaralabel.Location = new Point(35, 125);
            Numaralabel.Name = "Numaralabel";
            Numaralabel.Size = new Size(62, 20);
            Numaralabel.TabIndex = 2;
            Numaralabel.Text = "Numara";
            // 
            // dersekle
            // 
            dersekle.Location = new Point(676, 45);
            dersekle.Name = "dersekle";
            dersekle.Size = new Size(94, 29);
            dersekle.TabIndex = 16;
            dersekle.Text = "Ders Ekle";
            dersekle.UseVisualStyleBackColor = true;
            dersekle.Click += dersekle_Click;
            // 
            // btnSinifekle
            // 
            btnSinifekle.Location = new Point(676, 85);
            btnSinifekle.Name = "btnSinifekle";
            btnSinifekle.Size = new Size(94, 29);
            btnSinifekle.TabIndex = 17;
            btnSinifekle.Text = "Sınıf Ekle";
            btnSinifekle.UseVisualStyleBackColor = true;
            btnSinifekle.Click += btnSinifekle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSinifekle);
            Controls.Add(dersekle);
            Controls.Add(btnDersSecimi);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(grpOgrenci);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpOgrenci.ResumeLayout(false);
            grpOgrenci.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDersSecimi;
        private Button btnBul;
        private Button btnKaydet;
        private Button btnGuncelle;
        private GroupBox grpOgrenci;
        private TextBox Numaratxt;
        private TextBox Soyadtxt;
        private Label Adlabel;
        private Label Soyadlabel;
        private TextBox Adtxt;
        private Label Numaralabel;
        private ComboBox SinifCombobox;
        private Label lblSinif;
        private Button dersekle;
        private Button btnSinifekle;
    }
}