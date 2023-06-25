namespace sort_item_data
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        //1.表示ボタンを押し商品データ.txtを選択する
        //2.商品データ.txtの内容をListViewに表示させる
        //3.コンボボックスで昇順もしくは降順を選択する
        //3-1 昇順なら合計をキーとして昇順に並べ替える(商品名、単価、個数、合計)
        //3-2 降順なら合計をキーとして降順に並べ替える(商品名、単価、個数、合計)
        //3-3 昇順、降順以外の内容をコンボボックスで入力するとMessageBoxでエラーであると知らせる

        private List<string[]> products = new List<string[]>();

        //1.表示ボタンを押し商品データ.txtを選択する
        private void button_Display_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            readData(this.openFileDialog.FileName);

            this.comboBox_sort_select.Visible = true;
            this.button_sort.Visible= true;

            displayData();
        }

        private void readData(string fileName) 
        {
            this.products.Clear();
            
            StreamReader sr = new StreamReader(fileName);

            while(-1 < sr.Peek())
            {
                string[] prouct = sr.ReadLine().Split(' ');

                this.products.Add(prouct);
            }

            sr.Close();
        }
        //2.商品データ.txtの内容をListViewに表示させる
        private void displayData() 
        { 
            this.listView_Display.Items.Clear();

            for(int i = 0;i < this.products.Count;i++) 
            {
                string[] product = this.products[i];
                
                int total = int.Parse(product[1]) * int.Parse(product[2]);

                string[] displayProducts = { product[0], product[1], product[2], total.ToString() };

                ListViewItem item = new ListViewItem(displayProducts);

                this.listView_Display.Items.Add(item);
            }
        }
        //3.コンボボックスで昇順もしくは降順を選択する
        private void button_sort_Click(object sender, EventArgs e)
        {
            if(this.comboBox_sort_select.Text == "昇順")
            {
                List_Data_asc();
                
            }else if(this.comboBox_sort_select.Text == "降順")
            {
                List_Data_desc();
            }
            else //コンボボックス内に文字を入力することができるため
                //昇順、降順以外を入力したまbutton_sortを押された際にエラーボックスを表示する
            {
                MessageBox.Show("昇順もしくは降順を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayData();
        }

        //昇順ソート
        private void List_Data_asc()
        {
            for(int i = 0; i < this.products.Count;i++) 
            { 
                for(int j = this.products.Count -1; j > i; j--)
                {
                    int total1 = int.Parse(products[j][1]) * int.Parse(products[j][2]);
                    int total2 = int.Parse(products[j - 1][1]) * int.Parse(products[j - 1][2]);

                    if (total1 < total2)
                    {
                        string[] tmp = this.products[j - 1];
                        this.products[j - 1] = this.products[j];
                        this.products[j] = tmp;
                    }
                }
            }
        }

        //降順ソート
        private void List_Data_desc()
        {
            for (int i = 0; i < this.products.Count; i++)
            {
                for (int j = this.products.Count - 1; j > i; j--)
                {
                    int total1 = int.Parse(products[j][1]) * int.Parse(products[j][2]);
                    int total2 = int.Parse(products[j - 1][1]) * int.Parse(products[j - 1][2]);

                    if (total1 > total2)
                    {
                        string[] tmp = this.products[j - 1];
                        this.products[j - 1] = this.products[j];
                        this.products[j] = tmp;
                    }
                }
            }
        }
    }
}