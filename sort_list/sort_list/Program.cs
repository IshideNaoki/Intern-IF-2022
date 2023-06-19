using System;
using System.Collections.Generic;
using System.Text;


namespace sort_list
{
    class sort_list
    {
        //プログラムの説明
        //1.ListのSizeを入力します
        //2.Listに要素(数字)を追加します
        //3.昇順もしくは降順を選択しListを並べ替える
        //4.並べ替えたListを出力します


        public static void Main(string[] args)
        {
            List<int> array = new List<int>();//Listの宣言

            string count_num;//ListのSizeを入力する変数

            //1.ListのSizeを入力
            //その際、数字かどうか判断する
            while (true)
            {
                Console.Write("ListのSize(自然数)を入力してください =>");
                count_num = Console.ReadLine();

                int check_num;

                if (count_num == "0")//0を入力した場合
                {
                    Console.WriteLine("0を入力しないでください");
                }
                else if(count_num == "")//空白を入力した場合
                {
                    Console.WriteLine("数字を入力してください");
                }
                else if (int.TryParse(count_num, out check_num))//1以上の数を入力した場合
                {
                    break;
                }
                else//文字を入力した場合
                {
                    Console.WriteLine("{0}は数字ではありません", count_num);
                }
            }

            Console.WriteLine();


            string input_num;
            //2.Listに要素を追加する
            for (int i = 0; i < int.Parse(count_num); i++)
            {

                while (true)
                {
                    Console.Write("Listに追加する数字(整数)を入力してください =>");
                    input_num = Console.ReadLine();

                    int check_num;

                    if (input_num == "")//空白を入力した場合
                    {
                        Console.WriteLine("整数を入力してください");
                    }
                    else if (int.TryParse(input_num, out check_num))//整数を入力した場合
                    {
                        array.Add(int.Parse(input_num));
                        break;
                    }
                    else//文字を入力した場合
                    {
                        Console.WriteLine("{0}は整数ではありません", input_num);
                    }
                }   
            }

            Console.WriteLine();

            List<int> array_sort = new List<int>();

            //3.昇順or降順に並べ替える
            while (true)
            {
                Console.WriteLine("Listを昇順 or 降順に並べ替えます");
                Console.Write("昇順 or 降順を入力してください =>");
                string select_sort = Console.ReadLine();

                if (select_sort == "昇順")
                {
                    //昇順sortメソッド
                    array_sort = asc_sort(array);
                    break;

                }
                else if (select_sort == "降順")
                {
                    //降順sortメソッド
                    array_sort = desc_sort(array);
                    break;
                }
                else//昇順 or 降順を入力した場合
                {
                    Console.WriteLine("昇順、降順以外を入力しないでください!!");
                }
                Console.WriteLine();
            }
           

            //4.並べ替えたListを出力
            Console.Write("Sort=>");
            for (int i = 0; i < array_sort.Count; i++)
            {
                Console.Write(array_sort[i] + " ");
            }

            Console.ReadLine();

        }

        //昇順sortメソッド
        private static List<int> asc_sort(List<int> num_array)
        {
            for (int i = 0; i < num_array.Count; i++)
            {
                for (int j = num_array.Count - 1; j > i; j--)
                {
                    if (num_array[j] < num_array[j - 1])
                    {
                        int tmp = num_array[j - 1];
                        num_array[j - 1] = num_array[j];
                        num_array[j] = tmp;
                    }
                }
            }
            return num_array;
        }

        //降順sortメソッド
        private static List<int> desc_sort(List<int> num_array)
        {
            for (int i = 0; i < num_array.Count; i++)
            {
                for (int j = num_array.Count - 1; j > i; j--)
                {
                    if (num_array[j] > num_array[j - 1])
                    {
                        int tmp = num_array[j - 1];
                        num_array[j - 1] = num_array[j];
                        num_array[j] = tmp;
                    }
                }
            }
            return num_array;
        }
    }
}



