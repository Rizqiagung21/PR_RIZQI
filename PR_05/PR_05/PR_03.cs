using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace PR_05
{
    class PR_03 : LogicBase
    {
        public PR_03(int n)
        {
            JumlahBaris = n * 2 + 1;
            JumlahKolom = n * 2 + (n * 2 - 1);
            Array2d = new string[JumlahBaris, JumlahKolom];
            isiArray(n);
            FunctionBase.CetakArray();
        }

        private void isiArray(int n)
        {
            for (int bgn = 0; bgn < n; bgn++)
            {
          
                int sKolom = bgn*2;

                int eBaris = JumlahBaris - 1 - bgn*2;
                int eKolom = JumlahKolom - 1 - sKolom;
                int angka = 1;
                int nAngka = (eBaris) * 2 + (eKolom - sKolom) + 1;
                for (int b = 0; b <= eBaris; b++)
                {
                    for (int k = sKolom; k <= eKolom; k++)
                    {
                        if (b == eBaris || k == sKolom)
                            Array2d[b, k] = "" + angka++;
                        else if (k==eKolom){
                            Array2d[b, k] = "" + nAngka--;
                        }
                    }
                }
            }
        }

    }
}
