using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace コマンドライン引数で合計計算
{
    class コマンドライン引数で合計計算
    {
        public static void Main(string[] args)
        {

            total_sum(args);

        }

        private static void total_sum(string[] array_num)
        {
            int sum = 0;
            for (int i = 0; i < array_num.Length; i++)
            {
                sum += int.Parse(array_num[i]);
            }
            Console.WriteLine("1～7の合計値:" + sum);
        }

    }
}