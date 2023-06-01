
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
            string[] text = {"メソッド","で", "文字", "を", "連結させました" };
            string word = search_max(text);

            Console.WriteLine(word);
           


        }

        private static string search_max(string[] array_num)
        {
            string return_text="";
            for(int i= 0; i<array_num.Length;i++)
            {
                return_text += array_num[i];
            }

            return return_text ;
        }

    }
}





