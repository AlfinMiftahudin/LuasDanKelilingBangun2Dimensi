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
        static void Main()
        {
            int PilihBangun, PilihOperasi;
            BangunDatar bangun = null;


            while (true)
            {
                TampilkanMenuBangun();
                while (true)
                {
                    PilihBangun = InputAngka();
                    if (PilihBangun > 0 && PilihBangun < 6)
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
                                bangun = new Segitiga(a, t);
                                break;
                            case 4:
                                Console.WriteLine("selamat datang ke operasi hitung lingkaran");
                                Console.Write("tolong masukkan jari-jarinya : ");
                                double r = double.Parse(Console.ReadLine());
                                bangun = new Lingkaran(r);
                                break;
                            case 5:
                                Console.WriteLine("selamat datang ke operasi hitung trapesium");
                                Console.Write("masukkan sisi ke-1 : ");
                                double s1 = double.Parse(Console.ReadLine());
                                Console.Write("masukkan sisi ke-2 : ");
                                double s2 = double.Parse(Console.ReadLine());
                                Console.Write("masukkan sisi tinggi : ");
                                double ts = double.Parse(Console.ReadLine());
                                Console.Write("masukkan sisi ke-3 : ");
                                string s3Temp = Console.ReadLine();
                                double s3 = double.TryParse(s3Temp, out double hasil) ?hasil:0 ;
                            

                                bangun = new Trapesium(s1, s2, s3, ts);
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


                if (!UlangProgram())
                {
                    break;
                }
                Console.Clear();
            }
        }
        static int InputAngka()
        {

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int angka) && angka > 0)
                {
                    return angka;

                }
                Console.WriteLine("pilihan tidak valid");

            }
        }
        static bool UlangProgram()
        {
            Console.Write("apakah anda ingin mengulang program (y/n) ? ");
            ConsoleKeyInfo Key = Console.ReadKey(true);
            char ulang = char.ToLower(Key.KeyChar);
            return ulang == 'y';
        }



        static void TampilkanMenuBangun()
        {
            Console.WriteLine(new string('-', 55));
            Console.WriteLine("pilih operasi hitung (luas/keliling)");
            Console.WriteLine("1. persegi");
            Console.WriteLine("2. persegi panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. Lingkaran");
            Console.WriteLine("5. Trapesium");
            Console.WriteLine(new string('-', 55));
        }


        static void TampilkanMenuOperasi()
        {
            Console.WriteLine(new string('-', 55));
            Console.WriteLine("pilih operasi hitung (luas/keliling)");
            Console.WriteLine("1. Luas");
            Console.WriteLine("2. Keliling");
            Console.WriteLine(new string('-', 55));
        }

    }

}
