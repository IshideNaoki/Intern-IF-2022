using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace デバッカで計算途中を表示する
{
    class デバッカで計算途中を表示する
    {
         static void Main(string[] args)
        {
            int total = 0;

            Console.WriteLine("繰り返す回数を入力して、Enterキーを押して下さい");

            string number = Console.ReadLine();

            for(int i= 0; i <=int.Parse(number); i++) 
            {
                total += i * i;
            }

            Console.WriteLine("1～" + number + "までの二乗の合計"+total.ToString());

            Console.ReadLine();
        }

    }
}