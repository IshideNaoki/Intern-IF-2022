
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
            int[] numbers = {2, 12, 18, 4, 8, 27, 26, 8, 7, 1};
            int num = search_max(numbers);
            Console.WriteLine("最大値:"+num);
            

        }

        private static int search_max(int[] array_num)
        {
            int max_num = 0;
            max_num = array_num.Max();
            return max_num;
        }

    }
}





