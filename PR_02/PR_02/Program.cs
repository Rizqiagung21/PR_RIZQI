using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_02
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
                Console.Write("Masukan N2");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Pilih Soal(9/10)");
                int soal = int.Parse(Console.ReadLine());
                switch (soal)
                {
                    case 9:
                        Soal09 s9 = new Soal09(n, b);
                        break;
                    case 10:
                        Soal10 s10 = new Soal10(n,b);
                        break;
                    default :
                        break;
                }
                Console.Write("Apakah Anda Mau Melanjutkan(y/t)");
                y = Console.ReadLine();
            }
        }
    }
}
