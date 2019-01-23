using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "Y";
            while (y.ToLower() == "y")
            {
                Console.Write("Masukan N");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Pilih Soal");
                Console.WriteLine("1.  PR No 01");
                Console.WriteLine("2.  PR No 02");
                Console.WriteLine("10. Soal no 10");
                int soal = int.Parse(Console.ReadLine());
                switch (soal)
                {
                    case 1:
                        PR_01 s9 = new PR_01(n);
                        break;
                    case 2:
                        PR_02 s2 = new PR_02(n);
                        break;
                    case 10:
                        Soal10 s10 = new Soal10(n);
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
