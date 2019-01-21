using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "Y";
            while (y.ToLower() == "y")
            {
                Console.Write("Masukan N1");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Pilih Soal(9/10)");
                int soal = int.Parse(Console.ReadLine());
                switch (soal)
                {
                    case 1:
                        Soal01 s1 = new Soal01(n);
                        break;
                    case 2:
                        Soal02 s2 = new Soal02(n);
                        break;
                    default:
                        break;
                }
                Console.Write("Apakah Anda Mau Melanjutkan(y/t)");
                y = Console.ReadLine();
            }
        }
    }
}
