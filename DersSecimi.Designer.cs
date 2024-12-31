namespace FinalOdev2
{
    partial class DersSecimi
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
            components = new System.ComponentModel.Container();
            btnDersKaydet = new Button();
            dataGridView1 = new DataGridView();
            odevDBBindingSource = new BindingSource(components);
            Adilbl = new Label();
            Soyadilbl = new Label();
            Numaralbl = new Label();
            Sinifilbl = new Label();
            odevDBBindingSource1 = new BindingSource(components);
            Sec = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)odevDBBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)odevDBBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnDersKaydet
            // 
            btnDersKaydet.Location = new Point(214, 400);
            btnDersKaydet.Name = "btnDersKaydet";
            btnDersKaydet.Size = new Size(283, 28);
            btnDersKaydet.TabIndex = 0;
            btnDersKaydet.Text = "Öğrencinin Derslerini Kaydet";
            btnDersKaydet.UseVisualStyleBackColor = true;
            btnDersKaydet.Click += btnDersKaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Sec });
            dataGridView1.Location = new Point(54, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(665, 256);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // odevDBBindingSource
            // 
            odevDBBindingSource.DataSource = typeof(Migrations.OdevDB);
            // 
            // Adilbl
            // 
            Adilbl.AutoSize = true;
            Adilbl.Location = new Point(86, 11);
            Adilbl.Name = "Adilbl";
            Adilbl.Size = new Size(50, 20);
            Adilbl.TabIndex = 2;
            Adilbl.Text = "label1";
            Adilbl.Click += Adilbl_Click;
            // 
            // Soyadilbl
            // 
            Soyadilbl.AutoSize = true;
            Soyadilbl.Location = new Point(86, 40);
            Soyadilbl.Name = "Soyadilbl";
            Soyadilbl.Size = new Size(50, 20);
            Soyadilbl.TabIndex = 3;
            Soyadilbl.Text = "label2";
            // 
            // Numaralbl
            // 
            Numaralbl.AutoSize = true;
            Numaralbl.Location = new Point(86, 74);
            Numaralbl.Name = "Numaralbl";
            Numaralbl.Size = new Size(50, 20);
            Numaralbl.TabIndex = 4;
            Numaralbl.Text = "label3";
            // 
            // Sinifilbl
            // 
            Sinifilbl.AutoSize = true;
            Sinifilbl.Location = new Point(201, 40);
            Sinifilbl.Name = "Sinifilbl";
            Sinifilbl.Size = new Size(50, 20);
            Sinifilbl.TabIndex = 5;
            Sinifilbl.Text = "label4";
            // 
            // odevDBBindingSource1
            // 
            odevDBBindingSource1.DataSource = typeof(Migrations.OdevDB);
            // 
            // Sec
            // 
            Sec.DataPropertyName = "Dersler";
            Sec.HeaderText = "Sec";
            Sec.MinimumWidth = 6;
            Sec.Name = "Sec";
            Sec.Width = 125;
            // 
            // DersSecimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sinifilbl);
            Controls.Add(Numaralbl);
            Controls.Add(Soyadilbl);
            Controls.Add(Adilbl);
            Controls.Add(dataGridView1);
            Controls.Add(btnDersKaydet);
            Name = "DersSecimi";
            Text = "DersSecimi";
            Load += DersSecimi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)odevDBBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)odevDBBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDersKaydet;
        private DataGridView dataGridView1;
        private Label Adilbl;
        private Label Soyadilbl;
        private Label Numaralbl;
        private Label Sinifilbl;
        private BindingSource odevDBBindingSource;
        private BindingSource odevDBBindingSource1;
        private DataGridViewCheckBoxColumn Sec;
    }
}