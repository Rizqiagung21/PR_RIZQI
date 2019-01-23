using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace PR_04
{
    class PR_02 : LogicBase
    {
        public PR_02(int n)
        {
            JumlahBaris = n + 2;
            JumlahKolom = 3 * n + (n * (n - 1)/2);
            Array2d = new string[JumlahBaris, JumlahKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2d);
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
                int sBaris = n - bgn - 1;
                int sKolom = JumlahKolom - 1 - (bgn * 3 + (bgn * (bgn - 1) / 2)) - (bgn + 2);
                int eBaris = n + 1;
                int eKolom = sKolom + 2 + bgn;
                for (int b = sBaris; b <= eBaris; b++)
                {
                    int angka = (bgn * 3 + (bgn * (bgn - 1) / 2)) + (bgn + 2)+1;
                    for (int k = sKolom; k <= eKolom; k++)
                    {
                        if((b-sBaris)+(k-sKolom)==eKolom-sKolom || b==sBaris || k==sKolom)
                        Array2d[b, k] = (angka-k+sKolom).ToString();
                    }
                }
            }
        }
    }
}
