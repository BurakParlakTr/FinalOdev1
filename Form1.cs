using FinalOdev;
using System.Linq;


namespace FinalOdev2
{

    public partial class Form1 : Form
    {
        DersSecimi dersSecimi;
        Ogrenciler ogr;
        tblDersler drs;
        tblSiniflar snf;



        public Form1()
        {
            InitializeComponent();

            SinifCombobox.Items.Add("1");
            SinifCombobox.Items.Add("2");


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var SecilenSinif = SinifCombobox.SelectedValue;
                using (var context = new OdevDbContext())
                {
                    var selectedItem = context.SecilenSinif.Find(SecilenSinif);
                    var ogr = new Ogrenciler()
                    {

                        Ad = Adtxt.Text,
                        Soyad = Soyadtxt.Text,
                        Numara = Numaratxt.Text,
                        SinifId = SinifCombobox.Text


                    };
                    context.Ogrenciler.Add(ogr);
                    context.SaveChanges();
                    MessageBox.Show("Öðrenci Kaydedildi");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluþtu..");


            }
        }

        private void btnDersSecimi_Click(object sender, EventArgs e)
        {
            using (var ctx = new OdevDbContext())
            {

                try
                {
                    if (string.IsNullOrWhiteSpace(Numaratxt.Text) || !int.TryParse(Numaratxt.Text.Trim(), out int numara))
                    {
                        MessageBox.Show("Geçerli bir numara giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var ogr = ctx.Ogrenciler.FirstOrDefault(o => o.Numara == numara.ToString());

                    if (ogr != null)
                    {
                        Adtxt.Text = ogr.Ad;
                        Soyadtxt.Text = ogr.Soyad;
                        SinifCombobox.Text = ogr.SinifId;
                        DersSecimi bul = new DersSecimi();
                        bul.adbilgi = Adtxt.Text;
                        bul.soyadbilgi = Soyadtxt.Text;
                        bul.numarabilgi = Numaratxt.Text;
                        bul.sinifbilgi = SinifCombobox.Text;
                        bul.Show();

                    }
                    else
                    {
                        MessageBox.Show("Belirtilen numaraya sahip öðrenci bulunamadý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnBul_Click(object sender, EventArgs e)
        {

            using (var ctx = new OdevDbContext())
            {

                try
                {
                    if (string.IsNullOrWhiteSpace(Numaratxt.Text) || !int.TryParse(Numaratxt.Text.Trim(), out int numara))
                    {
                        MessageBox.Show("Geçerli bir numara giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var ogr = ctx.Ogrenciler.FirstOrDefault(o => o.Numara == numara.ToString());

                    if (ogr != null)
                    {
                        Adtxt.Text = ogr.Ad;
                        Soyadtxt.Text = ogr.Soyad;
                        SinifCombobox.Text = ogr.SinifId;


                    }
                    else
                    {
                        MessageBox.Show("Belirtilen numaraya sahip öðrenci bulunamadý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SinifCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dersekle_Click(object sender, EventArgs e)
        {
            DersEkle dersEkle = new DersEkle();
            dersEkle.Show();
        }

        private void Adtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSinifekle_Click(object sender, EventArgs e)
        {
            SinifEkle sinifEkle = new SinifEkle();
            sinifEkle.Show();
        }
    }
}