using LuasDanKelilingBangun2Dimensi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasDanKelilingBangun2Dimensi.Shapes
{
    public class Lingkaran:BangunDatar
    {
        public double JariJari;
        public Lingkaran(double JariJari)
        {
            this.JariJari = JariJari ;
        }
        public override double HitungLuas()
        {
            return (22/7)*Math.Pow(JariJari, 2);
        }
        public override double HitungKeliling()
        {
            return 2 * (22 / 7) * JariJari;
        }
    }
}
