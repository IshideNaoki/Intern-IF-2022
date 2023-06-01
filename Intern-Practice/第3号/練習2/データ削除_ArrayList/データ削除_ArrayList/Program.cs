using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace データ削除_ArrayList
{
    class データ削除_ArrayList
    {
        public static void Main(string[] args)
        {
            ArrayList  arrayList= new ArrayList();
            arrayList.Add(0);
            arrayList.Add(1);
            arrayList.Add(2);

            arrayList.Clear();

            arrayList.Add("あ");
            arrayList.Add("い");
            arrayList.Add("う");
            arrayList.Add("え");
            arrayList.Add("お");

            arrayList.Remove("え");
            arrayList.RemoveAt(0);

            for(int i = 0; i < arrayList.Count; i++) 
            {
                Console.WriteLine(arrayList[i]);    
            }

        }

        

    }
}
