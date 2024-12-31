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
    public partial class SinifEkle : Form
    {
        tblSiniflar snf;
        public SinifEkle()
        {
            InitializeComponent();
        }

        private void Sinifkayit_Click(object sender, EventArgs e)
        {
            try
            {

                using (var context = new OdevDbContext())
                {

                    var snf = new tblSiniflar()
                    {
                        SinifAd = txtSinifadi.Text,
                        Kontenjan = int.Parse(txtSinifkon.Text)


                    };
                    context.tblSiniflars.Add(snf);
                    context.SaveChanges();
                    MessageBox.Show("SINIF Kaydedildi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu..");


            }
        }

        private void txtSinifkon_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSinifadi_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblSinifkon_Click(object sender, EventArgs e)
        {
        }

        private void lblSinifadi_Click(object sender, EventArgs e)
        {
        }
    }
}
