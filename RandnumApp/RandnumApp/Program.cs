using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandNum_App
{
    class RandNum_App
    {
        //レベルに応じてランダムな数を作成する関数
        public static int Create_RandNum(string problem_level)
        {
            int check_num = 0;
            if (problem_level == "E")
            {
                check_num = new Random().Next(1, 31);
            }
            else if (problem_level == "H")
            {
                check_num = new Random().Next(1, 61);
            }
            else if (problem_level == "VH")
            {
                check_num = new Random().Next(1, 101);
            }
            return check_num;
        }

        //レベルに応じて入力する範囲を教えてくれる関数
        public static void Call_InputNum(string Input_Level)
        {
            switch (Input_Level)
            {
                case "E":
                    Console.WriteLine("1～30の中から数字を一つ選んで入力してください");
                    break;
                case "H":
                    Console.WriteLine("1～60の中から数字を一つ選んで入力してください");
                    break;
                case "VH":
                    Console.WriteLine("1～100の中から数字を一つ選んで入力してください");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            string Input_Level;
            Console.WriteLine("数字当てゲームです。");
            Console.WriteLine("以下から問題のレベルを選択してください");
            Console.WriteLine("EASY->E, HARD->H, VERYHARD->VH");
            while (true)
            {

                Input_Level = Console.ReadLine();//レベルを入力する

                if (Input_Level == "E" || Input_Level == "H" || Input_Level == "VH")//E, H, VHを入力した場合
                {
                    break;
                }
                else//E, H, VH以外の文字を入力した場合
                {
                    Console.WriteLine("E H VHのどれかを入力してください");
                    continue;
                }
            }

            //レベルに応じてランダムな数(正解)を生成する
            int true_num = Create_RandNum(Input_Level);

            //レベルに応じて入力する範囲を教えます
            Call_InputNum(Input_Level);

            int ans_count = 1;
            while (true)
            {

                string input_num = Console.ReadLine();//予測した数字を入力する
                int result_num;
                //
                if (!int.TryParse(input_num, out result_num))
                {
                    Console.WriteLine("数値を入力してください。");
                    continue;
                }

                //レベルに応じて入力した数字がオーバーしていないかを確認
                if (Input_Level == "E")
                {
                    if (result_num < 1 || result_num > 30)
                    {
                        Console.WriteLine("1から30までを入力してください。");
                        Console.WriteLine();
                        continue;
                    }
                }
                else if (Input_Level == "H")
                {
                    if (result_num < 1 || result_num > 60)
                    {
                        Console.WriteLine("1から60までを入力してください。");
                        Console.WriteLine();
                        continue;
                    }
                }
                if (Input_Level == "VH")
                {
                    if (result_num < 1 || result_num > 100)
                    {
                        Console.WriteLine("1から100までを入力してください。");
                        Console.WriteLine();
                        continue;
                    }
                }


                //入力した数字が答えと等しいのか小さいのか大きいのか
                if (true_num == result_num)
                {

                    if (ans_count == 1)
                    {
                        Console.WriteLine("一回目で当たりました。勘が鋭いですね。");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("正解です、おめでとうございます！" + ans_count + "回目で当たりました。");
                        break;
                    }
                }
                else if (result_num < true_num)
                {
                    Console.WriteLine(result_num + "は正解より小さいです");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(result_num + "は正解より大きいです");
                    Console.WriteLine();
                }
                ans_count++;
            }
            Console.WriteLine("正解は" + true_num + "です");
        }
    }
}