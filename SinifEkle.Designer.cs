namespace FinalOdev2
{
    partial class SinifEkle
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
            Sinifkayit = new Button();
            txtSinifkon = new TextBox();
            txtSinifadi = new TextBox();
            lblSinifkon = new Label();
            lblSinifadi = new Label();
            SuspendLayout();
            // 
            // Sinifkayit
            // 
            Sinifkayit.Location = new Point(343, 227);
            Sinifkayit.Name = "Sinifkayit";
            Sinifkayit.Size = new Size(125, 29);
            Sinifkayit.TabIndex = 16;
            Sinifkayit.Text = "Sınıfı Kaydet";
            Sinifkayit.UseVisualStyleBackColor = true;
            Sinifkayit.Click += Sinifkayit_Click;
            // 
            // txtSinifkon
            // 
            txtSinifkon.Location = new Point(343, 164);
            txtSinifkon.Name = "txtSinifkon";
            txtSinifkon.Size = new Size(125, 27);
            txtSinifkon.TabIndex = 15;
            txtSinifkon.TextChanged += txtSinifkon_TextChanged;
            // 
            // txtSinifadi
            // 
            txtSinifadi.Location = new Point(343, 124);
            txtSinifadi.Name = "txtSinifadi";
            txtSinifadi.Size = new Size(125, 27);
            txtSinifadi.TabIndex = 14;
            txtSinifadi.TextChanged += txtSinifadi_TextChanged;
            // 
            // lblSinifkon
            // 
            lblSinifkon.AutoSize = true;
            lblSinifkon.Location = new Point(258, 171);
            lblSinifkon.Name = "lblSinifkon";
            lblSinifkon.Size = new Size(79, 20);
            lblSinifkon.TabIndex = 13;
            lblSinifkon.Text = "Kontenjan:";
            lblSinifkon.Click += lblSinifkon_Click;
            // 
            // lblSinifadi
            // 
            lblSinifadi.AutoSize = true;
            lblSinifadi.Location = new Point(273, 131);
            lblSinifadi.Name = "lblSinifadi";
            lblSinifadi.Size = new Size(64, 20);
            lblSinifadi.TabIndex = 12;
            lblSinifadi.Text = "SınıfAdı:";
            lblSinifadi.Click += lblSinifadi_Click;
            // 
            // SinifEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sinifkayit);
            Controls.Add(txtSinifkon);
            Controls.Add(txtSinifadi);
            Controls.Add(lblSinifkon);
            Controls.Add(lblSinifadi);
            Name = "SinifEkle";
            Text = "SinifEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Sinifkayit;
        private TextBox txtSinifkon;
        private TextBox txtSinifadi;
        private Label lblSinifkon;
        private Label lblSinifadi;
    }
}