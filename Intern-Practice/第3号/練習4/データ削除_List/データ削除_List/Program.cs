using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace データ削除_List
{
    class データ削除_List
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("文字を入力して、Enterキーを押してください");
            for (int i = 0; i < 5; i++)
            {
                string text = Console.ReadLine();

                list.Add(text);
            }

            Console.WriteLine("削除後のデータを表示");
            for (int i = 0; i < 5; i++)
            {
                if ((list[i] != "List") && (list[i] != "Delete"))
                {
                    Console.WriteLine(list[i]);
                }
            }



        }



    }
}
