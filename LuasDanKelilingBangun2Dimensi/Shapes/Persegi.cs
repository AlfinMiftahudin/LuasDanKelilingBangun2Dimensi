using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuasDanKelilingBangun2Dimensi.Models;


namespace LuasDanKelilingBangun2Dimensi.Shapes
{
    public class Persegi:BangunDatar
    {
        public double Sisi;
        public Persegi(double sisi)
        {
            this.Sisi = sisi;
        }

        public override double HitungLuas()
        {
            return Sisi*Sisi;
        }
        public override double HitungKeliling()
        {
            return 4 * Sisi;
        }
    }
}
