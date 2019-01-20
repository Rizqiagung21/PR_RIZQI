using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace PR_02
{
    class Soal09 : LogicBase
    {
        public Soal09(int n, int b)
        {
            JumlahBaris = n;
            JumlahKolom = (n * b) - (b - 1);
            Array2d = new string[JumlahBaris, JumlahKolom];
            isiArray(b);
            FunctionBase.CetakArray(Array2d);
        }
        private void isiArray(int x)
        {
            for (int i = 0; i < x; i++)
            {

                for (int b = 0; b < JumlahBaris; b++)
                {
                    int angka = 1;
                    for (int k = 0; k < JumlahKolom; k++)
                    {
                        if (b + k >= JumlahBaris / 2 && k - b <= JumlahBaris / 2 && b <= JumlahBaris / 2)
                        {
                            Array2d[b, k + ((JumlahBaris - 1) * i)] = angka.ToString();
                            Array2d[JumlahBaris - b - 1, k + ((JumlahBaris - 1) * i)] = angka.ToString();

                            if (k < JumlahBaris / 2)
                            {
                                angka += 2;
                            }
                            else
                            {
                                angka -= 2;
                            }
                        }
                    }
                }
            }

        }
    }
}
