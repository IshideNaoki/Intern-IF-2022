using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand_num = new Random();

            int number1 = rand_num.Next(1, 20);
            int number2 = rand_num.Next(1, 20);
            int number3 = rand_num.Next(1, 20);

            int total = total_sum(number1, number2, number3);
            Console.WriteLine("合計:"+number1+"+"+number2+"+"+number3+"="+total);
        }
        private static int total_sum(int num1, int num2, int num3)
        {
            int sum = 0;

            sum += num1 + num2 + num3;


            return sum;
        }

    }
}