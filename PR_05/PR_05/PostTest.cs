using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace PR_05
{
    class PostTest : LogicBase
    {
        public PostTest(int n)
        {
            JumlahBaris = n * n;
            JumlahKolom = JumlahBaris;
            Array2d = new string[JumlahBaris, JumlahKolom];
            isiArray(n);
            FunctionBase.CetakArray();
        }

        private void isiArray(int n)
        {
            int[] fibo = FunctionBase.Fibonacci(n * n);
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk)
                    {
                        int angka = 0;
                        int nAngka = n * 2 + (n - 2) * 2-1;
                        int sBaris = bb * n;
                        int sKolom = bk * n;
                        int eBaris = sBaris + n - 1;
                        int eKolom = sKolom + n - 1;
                        for (int b = sBaris; b <= eBaris; b++)
                        {
                            for (int k = sKolom; k <= eKolom; k++)
                            {
                                if (b==sBaris || k==eKolom)
                                    Array2d[b, k] = "" + fibo[angka++];
                                else if(b==eBaris || k==sKolom)
                                    Array2d[b, k] = "" + fibo[nAngka--];
                            }
                        }
                    }
                }
            }
        }

    }
}
