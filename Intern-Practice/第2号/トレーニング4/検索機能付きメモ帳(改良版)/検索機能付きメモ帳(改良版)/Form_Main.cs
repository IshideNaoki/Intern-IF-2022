namespace 検索機能付きメモ帳_改良版_
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }
        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string text = readData(this.openFileDialog.FileName);
            displayData(text);

        }
        private static string readData(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);

            string text = sr.ReadToEnd();
            sr.Close();

            return text;
        }
        private void displayData(string text)
        {
            textBox_display.Text = text;
        }


        private void button_search_Click(object sender, EventArgs e)
        {
            string text = readData(this.openFileDialog.FileName);

            bool result = search(text, textBox_search.Text);

            if (result)
            {
                MessageBox.Show("「" + textBox_search.Text + "」は見つかりました。");
            }
            else
            {
                MessageBox.Show("「" + textBox_search.Text + "」は見つかりませんでした。");
            }
        }
        private static bool search(string text, string search_word)
        {
            int index = 0;
            index = text.IndexOf(search_word);

            if (-1 < index)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            saveData(this.saveFileDialog.FileName+".txt", textBox_display.Text);
          
        }
        private void saveData(string fileName, string save_word) 
        { 
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(save_word);
            sw.Close();
        }
    }
}