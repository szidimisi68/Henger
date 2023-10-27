using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TomorHenger : Henger
    {
        double fajsuly;

        public TomorHenger(double magassag, double sugar, double fajsuly = 7.87) : base (magassag, sugar)
        {
            this.fajsuly = fajsuly;
        }

        public double GetFajsuly { get => fajsuly; }
        public double Suly { get => fajsuly * base.Terfogat(); }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{Math.Round(Terfogat(), 2)}; sugár:{GetSugar}; magasság:{GetMagassag}; fajsúly:{GetFajsuly}";
        }
    }
}
