namespace 検索機能付きメモ帳
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_read_Click(object sender, EventArgs e)
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

            if(result)
            {
                MessageBox.Show("「"+ textBox_search.Text+"」は見つかりました。");
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
            
            if(-1<index)
            {
                return true;
            }else
            {
                return false;
            }
        }

        
    }
}