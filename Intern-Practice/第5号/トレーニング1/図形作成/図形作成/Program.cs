
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
            while (true)
            {
                Console.Write("図形の幅を入力してください。=>");
                string width = Console.ReadLine();
                if (width == "0")
                {
                    Console.WriteLine("終了します。");
                    break;
                }

                Console.Write("図形の高さを入力してください。=>");
                string height = Console.ReadLine();
                if (height == "0")
                {
                    Console.WriteLine("終了します。");
                    break;
                }
                for(int i = 0;i<int.Parse(height);i++) 
                {
                    for (int j = int.Parse(height); i < j;j--)
                    {
                        Console.Write(" ");
                    }
                    for (int n = 0;n<int.Parse(width)*i;n++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                    
                   

                }

            }
        }
        



    }

