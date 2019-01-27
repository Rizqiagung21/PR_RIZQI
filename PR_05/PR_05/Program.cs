using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string pilihan = "y";
            while (pilihan.ToLower() == "y")
            {
                Console.WriteLine("1. Soal 10");
                Console.WriteLine("2. PostTest");
                Console.WriteLine("3. PR 03");
                Console.WriteLine("Pilih Angka ");
                int nomor = int.Parse(Console.ReadLine());

                Console.WriteLine("Masukan Angka");
                int n = int.Parse(Console.ReadLine());
                switch (nomor)
                {
                    case 1:
                        Soal10 s10 = new Soal10(n);
                        break;
                    case 2:
                        PostTest post = new PostTest(n);
                        break;
                    case 3:
                        PR_03 pr = new PR_03(n);
                        break;
                    default:
                        break;
                }
                Console.Write("Lanjutkan? (Y/N");
                pilihan = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
