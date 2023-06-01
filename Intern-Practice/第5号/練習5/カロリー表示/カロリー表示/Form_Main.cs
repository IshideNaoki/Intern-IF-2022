using System.Diagnostics.PerformanceData;

namespace カロリー表示
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private List<string[]> menus = new List<string[]>();
        
      

        private void button_display_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog.ShowDialog() != DialogResult.OK) 
            {
                return;
            }


            List<string[]> list = readData(this.openFileDialog.FileName);
            List<int> menu_kcal = countData(list);//方法はこれしかない int[]はダメ


            setData(list, menu_kcal); //データをセット

            //ここまでOK
            //displayData();
            
            if(radioButton_all.Checked ==true) 
            {
                displayData(0);
            }else if(radioButton_300k.Checked == true) 
            {
                displayData(300);
            }else if(radioButton_500k.Checked == true)
            {
                displayData(500);
            }

            
        }
        private List<string[]> readData(string filename)
        {
            List<string[]> list = new List<string[]>();

            StreamReader sr = new StreamReader(filename);
            
            while(-1<sr.Peek())
            {
                string[] menu = sr.ReadLine().Split(' ');
                list.Add(menu);
            }
            sr.Close();
            return list;
        }


        
        private List<int> countData(List<string[]> list)
        {
            List<int> count = new List<int>();
            foreach (string[] order in list)
            {
                
                    switch (order[1]) 
                    {
                        case "牛カルビ弁当":
                            count.Add(780);
                            break;

                        case "のり弁当":
                            count.Add(720);
                            break;
                        case "ビール大瓶":
                            count.Add(252);
                            break;
                        case "キムチ鍋":
                            count.Add(321);
                            break;
                        case "豚丼":
                            count.Add(745);
                            break;
                        case "ソースカツ丼":
                            count.Add(1153);
                            break;
                        case "ねぎとろ丼":
                            count.Add(662);
                            break;

                        case "しょうゆラーメン":
                            count.Add(319);
                            break;
                        case "カレーラーメン":
                            count.Add(460);
                            break;
                        case "天ぷらうどん":
                            count.Add(746);
                            break;

                        case "ハンバーガー":
                            count.Add(260);
                            break;
                        case "ポテトM":
                            count.Add(278);
                            break;
                        case "肉じゃが":
                            count.Add(290);
                            break;
                        case "ハンバーグ(ドミグラス)":
                            count.Add(793);
                            break;
                }
                
            }
            return count;
        }
        

        
        private void setData(List<string[]> list, List<int> countArray)
        {
            for(int i = 0; i<countArray.Count; i++) 
            {
                string[] s = new string[3];
                s[0] = list[i][0];
                s[1] = list[i][1];
                s[2] = countArray[i].ToString();

                this.menus.Add(s);
            }
        }
        
        private void displayData(int kcal)
        {
            this.listView1.Items.Clear();
            foreach (string[] data in this.menus) 
            {
                if (int.Parse(data[2]) > kcal)
                {
                    ListViewItem item = new ListViewItem(data);
                    this.listView1.Items.Add(item);
                }
                
            }

        }

   
    }
}