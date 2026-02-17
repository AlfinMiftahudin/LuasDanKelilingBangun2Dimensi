using LuasDanKelilingBangun2Dimensi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasDanKelilingBangun2Dimensi.Shapes
{
    public class Segitiga : BangunDatar
    {
        public double alas, tinggi;
        public Segitiga(double alas, double tinggi)
        {
            this.alas = alas;
            this.tinggi = tinggi;
        }
        public override double HitungLuas()
        {
            return (1 / 2) * alas * tinggi;
        }
        public override double HitungKeliling()
        {
            return 3 * alas;
        }
    }
}
