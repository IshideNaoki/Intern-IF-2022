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
            openFileDialog.ShowDialog();
        }
        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            readData(openFileDialog.FileName);
            displayData();
        }

        private void readData(string fileName) 
        { 
            products.Clear();
            StreamReader sr = new StreamReader(fileName);

            while(-1 < sr.Peek())
            {
                string[] product = sr.ReadLine().Split(" ");
                products.Add(product);
            }
            sr.Close();
        }
        private void displayData() 
        { 
            listView_display.Items.Clear();
            for(int i = 0; i < products.Count; i++)
            {
                string[] product = products[i];

                int total = int.Parse(product[1]) * int.Parse(product[2]);

                string[] displayProduct = { product[0], product[1], product[2]
                                ,total.ToString()};
                ListViewItem item = new ListViewItem(displayProduct);

                listView_display.Items.Add(item);

            
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(listView_display.SelectedIndices.Count == 0)
            {
                MessageBox.Show("削除する項目を選択してください。");
                return;
            }
            int index = listView_display.SelectedIndices[0];
            products.RemoveAt(index);

            displayData();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            saveData(saveFileDialog.FileName);
        }
        private void saveData(string fileNema)
        {
            StreamWriter sw = new StreamWriter(fileNema);
            for (int i = 0; i < products.Count; i++)
            {
                string[] product = products[i];
                sw.WriteLine(product[0]+" "+product[1]+" "+ product[2]);
            }


            
            sw.Close();
        }

    }
}