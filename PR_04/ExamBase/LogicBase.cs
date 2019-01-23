﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamBase
{
    public class LogicBase
    {
        public int JumlahBaris { get; set; }
        public int JumlahKolom { get; set; }
        public String[,] Array2d { get; set; }

    }
    public class FunctionBase
    {
        public static void CetakArray(String[,] Array2d)
        {
            for (int b = 0; b < Array2d.GetLength(0); b++)
            {
                for (int k = 0; k < Array2d.GetLength(1); k++)
                {
                    Console.Write("{0}\t", Array2d[b, k]);
                }
                Console.WriteLine("\n");
            }
        }
        public static int[] Fibonacci(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos < 2)
                {
                    result[pos] = 1;
                }
                else
                {
                    result[pos] = result[pos - 1] + result[pos - 2];
                }
            }
            return result;
        }
        public static int[] Tribonacci(int n)
        {
            int[] result = new int[n];
            for (int pos = 0; pos < n; pos++)
            {
                if (pos <= 2)
                {
                    result[pos] = 1;
                }
                else
                {
                    result[pos] = result[pos - 1] + result[pos - 2] + result[pos - 3];
                }
            }
            return result;
        }
    }
}
