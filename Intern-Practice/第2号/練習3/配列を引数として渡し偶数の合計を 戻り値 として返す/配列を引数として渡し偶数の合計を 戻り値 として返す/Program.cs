using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 配列を引数として渡し偶数の合計を戻り値として返す
{
    class 配列を引数として渡し偶数の合計を戻り値として返す
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = total(numbers);
            Console.WriteLine("偶数の合計:" + result);

        }

        private static int total(int[] array_num)
        {
            int sum = 0;
            for (int i = 0; i < array_num.Length; i++)
            {
                if (array_num[i] % 2 == 0)
                    sum += array_num[i];
            }
            return sum;
        }

    }
}