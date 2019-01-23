using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace PR_04
{
    class PR_01 : LogicBase
    {
        public PR_01(int n)
        {
            JumlahBaris = 2 * n + (2 + n);
            JumlahKolom = JumlahBaris;
            Console.WriteLine(JumlahKolom);
            Array2d = new string[JumlahBaris, JumlahKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2d);
        }

        private void isiArray(int n)
        {
            for (int b = 0; b < n; b++)
            {
                int sKolom = n;
                int eKolom = sKolom + n + 1;

                for (int k = sKolom; k <= eKolom; k++)
                {
                    if (b + k - sKolom >= (eKolom - sKolom) / 2 && k - sKolom - b <= (eKolom - sKolom ) / 2)
                    {

                        Array2d[b, k] = "*";
                        Array2d[JumlahBaris - 1 - b, k] = "*";
                        Array2d[k, b] = "*";
                        Array2d[k, JumlahKolom - 1 - b] = "*";
                    }
                }
            }
        }
    }
}
