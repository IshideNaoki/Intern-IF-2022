using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 合計を戻り値で返す
{
    class 合計を戻り値で返す
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            total_sum(numbers);

        }

        private static void total_sum(int[] array_num)
        {
            int sum = 0;
            for (int i = 0; i < array_num.Length; i++)
            {
                sum += array_num[i];
            }
            Console.WriteLine("配列の要素の合計:" + sum);
        }

    }
}