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
            Console.WriteLine(args.Length);
            int PilihBangun, PilihOperasi;
            BangunDatar bangun = null;


            TampilkanMenuBangun();
            while (true)
            {
            PilihBangun = InputAngka();
                if (PilihBangun >0 && PilihBangun<7)
                {
                    Console.WriteLine("");
                    switch (PilihBangun)
                    {
                        case 1:
                            Console.WriteLine("selamat datang ke operasi hitung persegi");
                            Console.Write("tolong masukkan variable sisi : ");
                            double s = double.Parse(Console.ReadLine());
                            bangun = new Persegi(s);
                            break;
                        case 2:
                            Console.WriteLine("selamat datang ke operasi hitung persegi Panjang");
                            Console.Write("tolong masukkan variable panjang : ");
                            double p = double.Parse(Console.ReadLine());
                            Console.Write("tolong masukkan variable lebar : ");
                            double l = double.Parse(Console.ReadLine());
                            bangun = new PersegiPanjang(p, l);
                            break;
                        case 3:
                            Console.WriteLine("selamat datang ke operasi hitung segi tiga");
                            Console.Write("tolong masukkan variable alas : ");
                            double a = double.Parse(Console.ReadLine());
                            Console.Write("tolong masukkan variable tinggi : ");
                            double t = double.Parse(Console.ReadLine());
                            bangun = new Segitiga(a,t);
                            break;
                        case 4:
                            Console.WriteLine("selamat datang ke operasi hitung lingkaran");
                            Console.Write("tolong masukkan jari-jarinya");
                            double r =double.Parse(Console.ReadLine());
                            bangun = new Lingkaran(r);
                            break;
                    }

                    Console.Clear();
                    break;  
                }
                else
                {
                    Console.WriteLine("Bangun datar yang anda pilih tidak ada tolong pilih kembali : ");
                }
            }

            
            TampilkanMenuOperasi();
            Console.WriteLine("");

            while (true)
            {
                PilihOperasi = InputAngka();
                if (PilihOperasi == 1 || PilihOperasi == 2)
                {
                    if (PilihOperasi == 1)
                    {
                        Console.WriteLine("luasnya adalah : " + bangun.HitungLuas());
                    }
                    else if (PilihOperasi == 2)
                    {
                        Console.WriteLine("kelilingnya adalah : " + bangun.HitungKeliling());
                    }
                    break;
                }
                else
                {
                    Console.Write("operasi hitung invalid, tolong pilih kembali operasi hitung (1. luas / 2. keliling) : ");
                }
            }


        }
        static int InputAngka()
        {
            int angka;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out angka) && angka > 0)
                {
                    return angka;

                }
                Console.WriteLine("pilihan tidak valid");

            }
        }





        static void TampilkanMenuOperasi()
        {
            Console.WriteLine(new string('-', 55));
            Console.WriteLine("pilih operasi hitung (luas/keliling)");
            Console.WriteLine("1. Luas");
            Console.WriteLine("2. Keliling");
            Console.WriteLine(new string('-', 55));
        }
        static void TampilkanMenuBangun()
        {
            Console.WriteLine(new string('-', 55));
            Console.WriteLine("pilih operasi hitung (luas/keliling)");
            Console.WriteLine("1. persegi");
            Console.WriteLine("2. persegi panjang");
            Console.WriteLine(new string('-', 55));
        }

    }

}
