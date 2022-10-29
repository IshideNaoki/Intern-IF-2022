using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Array_App
{
    class Array_App
    {
        public static void Main(string[] args)
        {
            //教科数を5教科に指定する
            string[][] student_score =
            {
                new string[]{"教科名", "点数", "合格点", "合否"},
                new string[]{"教科名", "点数", "合格点", "合否"},
                new string[]{"教科名", "点数", "合格点", "合否"},
                new string[]{"教科名", "点数", "合格点", "合否"},
                new string[]{"教科名", "点数", "合格点", "合否"},
            };

            //配列の中の中身を入力する
            Console.WriteLine("成績の処理を行います。");
            int student_count = 0;
            int student_count_inner;

            while (student_count < student_score.Length)
            {
                student_count_inner = 0;
                while (student_count_inner < student_score[student_count].Length - 1)//合否は点数とボーダーラインから求めるのでループは教科名からボーダーラインまで
                {
                    Console.Write(student_score[student_count][student_count_inner] + "を入力してください->");
                    string input_text = Console.ReadLine();

                    int number_true;//入力した値が数字であるか判断する際に使う

                    //数字を入力したいところの処理
                    if (student_score[student_count][student_count_inner] == "点数" || student_score[student_count][student_count_inner] == "ボーダーライン")
                    {
                        if (string.IsNullOrEmpty(input_text))//空入力をしたとき
                        {
                            Console.WriteLine("空白です、何か入力してください");
                            continue;
                        }
                        else if (!int.TryParse(input_text, out number_true))//文字を入力したとき
                        {
                            Console.WriteLine("数値を入力してください。");
                            continue;
                        }
                        else//それ以外
                        {
                            student_score[student_count][student_count_inner] = number_true.ToString();
                        }
                    }
                    else  //それ以外の入力の処理
                    {
                        if (string.IsNullOrEmpty(input_text))//空入力をしたとき
                        {
                            Console.WriteLine("空白です。何か入力してください");
                            continue;
                        }
                        else if (int.TryParse(input_text, out number_true))//文字を入力したとき
                        {
                            Console.WriteLine("数字が入力されています。文字を入力してください!!");
                            continue;
                        }
                        else
                        {
                            student_score[student_count][student_count_inner] = input_text;
                        }
                    }
                    student_count_inner++;
                }
                Console.WriteLine();//入力する内容が見やすくなるように改行する
                student_count++;
            }

            //合否の判断
            for (int i = 0; i < student_score.Length; i++)
            {
                if (int.Parse(student_score[i][1]) > int.Parse(student_score[i][2]))//点数が合格点より大きければ合格とする
                {
                    student_score[i][3] = "合";
                }
                else
                {
                    student_score[i][3] = "不";
                }
            }

            //ソート処理
            while (true)
            {
                Console.WriteLine("点数で並べ替えます");
                Console.WriteLine("昇順なら->a, 降順なら->d,変えないなら->nを入力してください");
                string text = Console.ReadLine();

                if (text == "a")//昇順
                {
                    Array.Sort(student_score, (x, y) => int.Parse(x[1]) - int.Parse(y[1]));
                    break;
                }
                else if (text == "d")//降順
                {
                    Array.Sort(student_score, (x, y) => int.Parse(y[1]) - int.Parse(x[1]));
                    break;
                }
                else if (text == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("入力内容が当てはまりません、入力し直してください");
                    continue;
                }
            }            
        }
    }
}




