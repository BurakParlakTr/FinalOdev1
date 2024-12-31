using FinalOdev2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdev
{
    

    
    internal class tblDersler 
    {
        
        public int DersId { get; set; } 
        public int DersKod { get; set; }
        public string DersAd { get; set; }
        public override string ToString()
        {
            return $"Id{this.DersId}-kod:{this.DersKod}-ad:{this.DersAd}";
        }






    }
    
}
