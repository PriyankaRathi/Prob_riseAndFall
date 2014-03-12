using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Prob_riseAndFall
{
    class Program
    {
        static void Main(string[] args)
        {

            int T = Convert.ToInt32(Console.ReadLine());
            string[,] arr = new string[T, 2];
            for (int i = 0; i < T; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                double n = Convert.ToDouble(s[0]);
                int k = Convert.ToInt32(s[1]);
                double power = Math.Pow(n, n);
                string pow = Math.Round(power).ToString();
                if (k < pow.Length)
                {
                    arr[i, 0] = pow.Substring(0, k);
                    arr[i, 1] = pow.Substring(pow.Length - k, k);
                }
            }

            for (int i = 0; i < T; i++)
                if (i + 1 == T)
                    Console.Write(arr[i, 0] + " " + arr[i, 1]);
                else
                    Console.WriteLine(arr[i, 0] + " " + arr[i, 1]);
        }
    }
}


/*
Example

Input
2
4 2
9 3

Output
25 56
387 489
*/