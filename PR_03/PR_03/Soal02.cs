using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace PR_03
{
    class Soal02 : LogicBase
    {
        public Soal02(int n)
        {
            JumlahBaris = (n * n + n) / 2;
            JumlahKolom = n * n;
            Array2d = new string[JumlahBaris, JumlahKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2d);
        }

        private void isiArray(int n)
        {
            int[] tibo = FunctionBase.Tribonacci(n * n);
            for (int bgn = 0; bgn < n; bgn++)
            {
                int sBrs = (bgn * bgn + bgn) / 2 + (n - bgn) * bgn;
                int sKol = bgn * bgn + (n - bgn) * bgn*2;
                int angka = 0;
                int eBrs = sBrs + (n - 1 - bgn);
                int eKol = sKol + ((n - 1 - bgn) * 2);
                for (int b = sBrs; b <= eBrs; b++)
                {
                    for (int k = sKol; k <= eKol; k++)
                    {
                        if (b + k >= sKol + eBrs && k + eBrs <= b + eKol)
                        {
                            Array2d[b, k] = tibo[angka++].ToString();
                        }
                    }

                }
            }
        }

    }
}
