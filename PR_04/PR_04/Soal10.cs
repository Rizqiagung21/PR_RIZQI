using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace PR_04
{
    class Soal10 : LogicBase
    {
        public Soal10(int n)
        {
            JumlahBaris = n;
            JumlahKolom = n;
            Array2d = new string[JumlahBaris, JumlahKolom];
            isiArray(n);
            FunctionBase.CetakArray(Array2d);
        }

        private void isiArray(int n)
        {
            for (int b = 0; b < n; b++)
            {
                int sKolom = b % 2 == 0 ? 0 : JumlahBaris - 1 - b;
                int eKolom = sKolom + b;
                for (int k = sKolom; k <= eKolom; k++)
                {
                    Array2d[b, k] = (b+1).ToString();
                }
            }
        }
    }
}
