using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuasDanKelilingBangun2Dimensi.Models;

namespace LuasDanKelilingBangun2Dimensi.Shapes
{
    public class PersegiPanjang:BangunDatar
    {
        public double panjang, lebar;
        public PersegiPanjang(double panjang, double lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }
        public override double HitungLuas()
        {
            return panjang * lebar;
        }
        public override double HitungKeliling()
        {
            return 2*(panjang+lebar);
        }
    }
}
