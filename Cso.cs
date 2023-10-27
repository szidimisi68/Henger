using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cso : Henger
    {
        double falVastagsag;
        public Cso(double sugar, double magassag, double falVastagsag = 1) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public double FalVastagsag { get => falVastagsag; }

        public override double Terfogat()
        {
            return GetSugar*GetSugar* Math.PI * GetMagassag - (GetSugar-FalVastagsag) * Math.PI * (GetSugar - FalVastagsag) * GetMagassag ;
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Math.Round(Terfogat(), 2)}; sugár:{GetSugar}; magasság:{GetMagassag}; falvastagság:{FalVastagsag}";
        }
    }
}
