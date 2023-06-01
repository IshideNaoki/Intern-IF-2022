
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> arrayList = new List<int>();
            int total = 0;
            for (int i = 1; i <= 100; i++)
            {
                arrayList.Add(i);
            }
            for (int i = 0; i < 50; i++)
            {
                arrayList.Remove(2 * i + 1);
            }
            for (int i = 0; i < arrayList.Count; i++)
            {
                total += (int)arrayList[i];
            }
            Console.WriteLine("1～100の偶数合計:" + total);



        }



    }
}



