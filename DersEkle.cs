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
    public partial class DersEkle : Form
    {
        tblDersler drs;

        public DersEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DersKayit_Click(object sender, EventArgs e)
        {
            try
            {

                using (var context = new OdevDbContext())
                {

                    var drs = new tblDersler()
                    {
                        DersAd = txtDersadi.Text,
                        DersKod = int.Parse(txtDerskod.Text),


                    };
                    context.tblDersler.Add(drs);
                    context.SaveChanges();
                    MessageBox.Show("Ders Kaydedildi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu..");


            }
        }

        private void txtDersadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
