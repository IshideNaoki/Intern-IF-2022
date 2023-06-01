using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 数値表示_ArrayList
{
    class 数値表示_ArrayList
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 1; i <= 10; i++)
            {
                arrayList.Add(i);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

        }


    }
}
