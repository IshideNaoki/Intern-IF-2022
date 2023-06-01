using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace デバッグ問題
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };
            int total = 0;
            for (int i = 0; i <=6; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("合計:"+total.ToString());
        }

    }
}