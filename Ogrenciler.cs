using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev
{
    internal class Ogrenciler
    {
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public string SinifId { get; set; }

        public override string ToString()
        {
            return $"OğrenciId{this.OgrenciId}-Ad:{this.Ad}-Soyad:{this.Soyad}-Numara:{this.Numara}-SınıfId:{this.SinifId}";
        }
    }
}
