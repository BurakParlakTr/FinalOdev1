using Azure.Core.Pipeline;
using FinalOdev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOdev2
{
    public partial class DersSecimi : Form
    {
        DersEkle drs;
        Ogrenciler ogr;
        public string adbilgi { get; set; }
        public string soyadbilgi { get; set; }
        public string numarabilgi { get; set; }
        public string sinifbilgi { get; set; }







        public DersSecimi()
        {
            InitializeComponent();


        }
        DataTable tablo = new DataTable();

        private void DersSecimi_Load(object sender, EventArgs e)
        {


            using (var context = new OdevDbContext())
            {
                try
                {

                    var drs = new tblDersler();


                    Adilbl.Text = adbilgi;
                    Soyadilbl.Text = soyadbilgi;
                    Numaralbl.Text = numarabilgi;
                    Sinifilbl.Text = sinifbilgi;



                    var dersler = context.tblDersler
                        .Select(d => new { d.DersId, d.DersAd, d.DersKod })
                        .ToList();

                    dataGridView1.DataSource = dersler;


                    dataGridView1.Columns["DersId"].Visible = false;
                }
                catch (Exception ex)
                {


                }
            }
        }




        private void Adilbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {

            using (var context = new OdevDbContext())
            {
                try
                {
                  
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                       
                        if (row.Cells["Sec"].Value != null && (bool)row.Cells["Sec"].Value == true)
                        {
                           
                            int dersId = Convert.ToInt32(row.Cells["DersId"].Value);
                            string dersAdi = row.Cells["DersAd"].Value.ToString();
                            int dersKod = Convert.ToInt32(row.Cells["DersKod"].Value);

                            MessageBox.Show($"Seçilen Ders: {dersAdi} (Kod: {dersKod})");

                            var yeniDers = new tblOgrenciDers()
                            {
                                OgrenciId = dersId,
                        




                            };
                                
                                


                       
                            context.tblOgrenciDers.Add(yeniDers);
                        }
                    }

                   
                    context.SaveChanges();
                    MessageBox.Show("Seçilen dersler başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
