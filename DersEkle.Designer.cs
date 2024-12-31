namespace FinalOdev2
{
    partial class DersEkle
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
            DersAdi = new Label();
            DersKod = new Label();
            txtDersadi = new TextBox();
            txtDerskod = new TextBox();
            DersKayit = new Button();
            SuspendLayout();
            // 
            // DersAdi
            // 
            DersAdi.AutoSize = true;
            DersAdi.Location = new Point(283, 118);
            DersAdi.Name = "DersAdi";
            DersAdi.Size = new Size(65, 20);
            DersAdi.TabIndex = 0;
            DersAdi.Text = "DersAdi:";
            DersAdi.Click += label1_Click;
            // 
            // DersKod
            // 
            DersKod.AutoSize = true;
            DersKod.Location = new Point(279, 158);
            DersKod.Name = "DersKod";
            DersKod.Size = new Size(69, 20);
            DersKod.TabIndex = 1;
            DersKod.Text = "DersKod:";
            // 
            // txtDersadi
            // 
            txtDersadi.Location = new Point(354, 118);
            txtDersadi.Name = "txtDersadi";
            txtDersadi.Size = new Size(125, 27);
            txtDersadi.TabIndex = 3;
            txtDersadi.TextChanged += txtDersadi_TextChanged;
            // 
            // txtDerskod
            // 
            txtDerskod.Location = new Point(354, 158);
            txtDerskod.Name = "txtDerskod";
            txtDerskod.Size = new Size(125, 27);
            txtDerskod.TabIndex = 5;
            // 
            // DersKayit
            // 
            DersKayit.Location = new Point(354, 221);
            DersKayit.Name = "DersKayit";
            DersKayit.Size = new Size(125, 29);
            DersKayit.TabIndex = 6;
            DersKayit.Text = "Dersi Kaydet";
            DersKayit.UseVisualStyleBackColor = true;
            DersKayit.Click += DersKayit_Click;
            // 
            // DersEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DersKayit);
            Controls.Add(txtDerskod);
            Controls.Add(txtDersadi);
            Controls.Add(DersKod);
            Controls.Add(DersAdi);
            Name = "DersEkle";
            Text = "DersEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DersAdi;
        private Label DersKod;
        private TextBox txtDersadi;
        private TextBox txtDerskod;
        private Button DersKayit;
    }
}