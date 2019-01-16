using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal04
{
    class Soal05
    {
        public Soal05()
        {
            Console.Write("Masukan Angka : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == 0 || j == n - 1 || i == n - 1 || i == j || i + j == n - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
