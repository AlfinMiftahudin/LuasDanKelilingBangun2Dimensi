using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LuasDanKelilingBangun2Dimensi.Models;
using LuasDanKelilingBangun2Dimensi.Shapes;


namespace LuasDanKelilingBangun2Dimensi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BangunDatar p = new Persegi(5);
            Console.WriteLine("Luas Perseginya Adalah = " + p.HitungLuas());
            Console.WriteLine("Keliling Perseginya Adalah = " + p.HitungKeliling());
        }
    }

}
