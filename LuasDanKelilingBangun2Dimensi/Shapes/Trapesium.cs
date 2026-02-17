using LuasDanKelilingBangun2Dimensi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasDanKelilingBangun2Dimensi.Shapes
{
    public class Trapesium : BangunDatar
    {
        public double Sisi1, Sisi2, Sisi3, Tinggi;
        public Trapesium(double Sisi1, double Sisi2, double Sisi3, double Tinggi)
        {
            this.Sisi1 = Sisi1;
            this.Sisi2 = Sisi2;
            this.Sisi3 = Sisi3;
            this.Tinggi = Tinggi;
        }
        public override double HitungLuas()
        {
            return ((Sisi1 + Sisi2) * Tinggi) / 2;
        }
        public override double HitungKeliling()
        {
            return Sisi1 + Sisi2 + Sisi3 + Tinggi;
        }
    }
}
