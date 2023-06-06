
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
            Console.Write("じゃんけんをする回数を入力してください => ");
            
            while (true)
            {
                string count_num = Console.ReadLine();
                if(int.Parse(count_num) == 0)
                {
                    Console.WriteLine("じゃんけんゲームを終了します。");
                    break;
                }


                int win_num = 0, draw_num = 0, lost_num = 0;

                for (int i = 0; i < int.Parse(count_num); i++)
                {
                    Console.WriteLine("第" + (i+1).ToString() + "回戦目");

                    Console.Write("じゃんけんぽん!(1:グー 2:チョキ 3:パー)=>");
                    string user_select = Console.ReadLine();

                    int cpu_select = CPU_Select();

                    string result = judge(int.Parse(user_select), cpu_select);

                    if ((result == "勝ちです")||(result == "負けです"))
                    {
                        Console.WriteLine("あなたの" + result);
                    }
                    else
                    {
                        Console.WriteLine(result);
                    }
                    
                    



                        //CPU
                    if (cpu_select == 1)
                    {
                        Console.WriteLine("コンピュータ:グー");
                    }
                    else if (cpu_select == 2)
                    {
                        Console.WriteLine("コンピュータ:チョキ");
                    }
                    else if (cpu_select == 3)
                    {
                        Console.WriteLine("コンピュータ:パー");
                    }


                    //あなた
                    if (user_select == "1")
                    {
                        Console.WriteLine("あなた:グー");
                    }
                    else if (user_select == "2")
                    {
                        Console.WriteLine("あなた:チョキ");
                    }
                    else if (user_select == "3")
                    {
                        Console.WriteLine("あなた:パー");
                    }



                    //成績
                    if (result == "あいこです")
                    {
                        draw_num++;
                    }
                    else if (result == "勝ちです")
                    {
                        win_num++;
                    }
                    else if (result == "負けです")
                    {
                        lost_num++;
                    }
                    Console.WriteLine("成績:"+win_num+"勝"+lost_num+"敗"+draw_num+"引き分け");
                    Console.WriteLine();
                }
                Console.WriteLine("じゃんけんゲームを終了しますか?");
                Console.WriteLine("続ける場合は、じゃんけんする回数を入力してください。");
                Console.WriteLine("終了する場合は0を入力してください。");
                Console.Write("回数:");
                
            }

        }
        private static int CPU_Select()
        {
            Random rnd = new Random();
            int cpu_num = rnd.Next(1, 3);

            return cpu_num;

        }

        private static string judge(int user, int cpu)
        {
            string result = "";
            if ((user == 1) && (cpu == 1))
            {
                result = "あいこです";
            }
            else if ((user == 1) && (cpu == 2))
            {
                result = "勝ちです";
            }
            else if ((user == 1) && (cpu == 3))
            {
                result = "負けです";
            }

            else if ((user == 2) && (cpu == 1))
            {
                result = "負けです";
            }
            else if ((user == 2) && (cpu == 2))
            {
                result = "あいこです";

            }
            else if ((user == 2) && (user == 3))
            {
                result = "勝ちです";
            }

            else if ((user == 3) && (cpu == 1))
            {
                result = "勝ちです";
            }
            else if ((user == 3) && (cpu == 2))
            {
                result = "負けです";
            }
            else if ((user == 3) && (user == 3))
            {
                result = "あいこです";
            }

            return result;


        }

    }       

}

