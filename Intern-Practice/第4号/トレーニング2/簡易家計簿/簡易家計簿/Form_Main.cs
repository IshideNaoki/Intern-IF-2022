namespace 簡易家計簿
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private List<string[]> members = new List<string[]>();

        private void button_register_Click(object sender, EventArgs e)
        {
            string[] s = new string[5];

            s[0] = textBox_date.Text;
            s[1] = textBox_income.Text;
            s[2] = textBox_submission.Text;
            s[3] =  textBox_money.Text;
            int total = int.Parse(textBox_income.Text) - int.Parse(textBox_money.Text);
            s[4] = total.ToString();


            members.Add(s);
            displayData();

            
        }
        private void displayData() 
        { 
            listView_display.Items.Clear();
            for(int i = 0; i<members.Count; i++) 
            {
                
                if (i == 0)
                {
                    string[] product = members[i];
                    string[] s = { product[0], product[1] + "円", product[2], product[3] + "円", product[4] + "円" };

                    ListViewItem item = new ListViewItem(s);

                    listView_display.Items.Add(item);
                }
                else
                {
                  
                    string[] product = members[i];

                    int total = int.Parse(members[i - 1][4])+int.Parse(product[1]) - int.Parse(product[3]);
                    members[i][4] = total.ToString();

                    string[] s = { product[0], product[1]+"円", product[2], product[3]+"円",  total.ToString()+"円"};
                    ListViewItem item = new ListViewItem(s);

                    listView_display.Items.Add(item);
                }
                    
                
            }
        }

        private void button_del_Individual_Click(object sender, EventArgs e)
        {
            if(listView_display.SelectedIndices.Count == 0) 
            {
                MessageBox.Show("削除する項目を選択してください。");
                return;
            }

            int index = listView_display.SelectedIndices[0];
            members.RemoveAt(index);
            displayData();
        }

        private void button_allclear_Click(object sender, EventArgs e)
        {
            members.Clear();
            displayData();
        }
    }
}