using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace データ操作_List
{
    class データ操作_List
    {
        public static void Main(string[] args)
        {

            List<string> list = new List<string>();
           
            list.Add("0");
            list.Add("1");
            list.Add("2");

            list.Clear();

            list.Add("あ");
            list.Add("い");
            list.Add("う");
            list.Add("え");
            list.Add("お");

            list.Remove("え");
            list.RemoveAt(0);

            for (int i = 0; i <list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }



    }
}
