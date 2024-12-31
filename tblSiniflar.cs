using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev
{
    internal class tblSiniflar
    {

        public int SinifId { get; set; }
        public string SinifAd { get; set; }
        public int Kontenjan { get; set; }
        public override string ToString()
        {
            return $"SinifId{this.SinifId}-SinifAd:{this.SinifAd}-Kontenjan:{this.Kontenjan}";
        }

    }

}
