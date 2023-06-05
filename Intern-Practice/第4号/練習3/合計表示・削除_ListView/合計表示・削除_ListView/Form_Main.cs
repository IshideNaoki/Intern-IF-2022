using System.Collections;

namespace 合計表示_削除_ListView
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        ArrayList arrayList= new ArrayList();

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
                arrayList.Clear();

            StreamReader sr = new StreamReader(fileName);

            while(-1 < sr.Peek())
            {
                string[] product = sr.ReadLine().Split(' ');
                arrayList.Add(product);
            }
            sr.Close();
        }

        private void displayData() 
        {
            listView_Display.Items.Clear();
            for(int i=0; i<arrayList.Count; i++)
            {
                string[] product = (string[])arrayList[i];

                int total = int.Parse(product[1]) * int.Parse(product[2]);

                string[] displayProduct = { product[0], product[1], product[2], total.ToString() };

                ListViewItem item = new ListViewItem(displayProduct);

                listView_Display.Items.Add(item);
            
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if(listView_Display.SelectedIndices.Count == 0)
            {
                MessageBox.Show("削除する項目を選択してください");
                return;
            }

            int index = listView_Display.SelectedIndices[0];

            arrayList.RemoveAt(index);
            displayData();
        }
    }
}