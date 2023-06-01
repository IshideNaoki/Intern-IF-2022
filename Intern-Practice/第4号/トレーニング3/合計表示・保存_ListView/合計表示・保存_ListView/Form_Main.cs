namespace 合計表示_保存_ListView
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private List<string[]> products= new List<string[]>();
        private void button_Display_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }
        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            readData(this.openFileDialog.FileName);
            displayData();
        }

        private void readData(string fileName) 
        { 
            this.products.Clear();
            StreamReader sr = new StreamReader(fileName);

            while(-1 < sr.Peek())
            {
                string[] product = sr.ReadLine().Split(" ");
                this.products.Add(product);
            }
            sr.Close();
        }
        private void displayData() 
        { 
            this.listView_display.Items.Clear();
            for(int i = 0; i < this.products.Count; i++)
            {
                string[] product = this.products[i];

                int total = int.Parse(product[1]) * int.Parse(product[2]);

                string[] displayProduct = { product[0], product[1], product[2]
                                ,total.ToString()};
                ListViewItem item = new ListViewItem(displayProduct);

                this.listView_display.Items.Add(item);

            
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(this.listView_display.SelectedIndices.Count == 0)
            {
                MessageBox.Show("削除する項目を選択してください。");
                return;
            }
            int index = this.listView_display.SelectedIndices[0];
            this.products.RemoveAt(index);

            displayData();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            saveData(this.saveFileDialog.FileName+".txt");
        }
        private void saveData(string fileNema)
        {
            StreamWriter sw = new StreamWriter(fileNema);
            for (int i = 0; i < this.products.Count; i++)
            {
                string[] product = this.products[i];
                sw.WriteLine(product[0]+" "+product[1]+" "+ product[2]);
            }


            
            sw.Close();
        }

    }
}