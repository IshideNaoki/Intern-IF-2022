namespace 名簿_列追加
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private List<string[]> members = new List<string[]>();

        private void button_Entry_Click(object sender, EventArgs e)
        {
            string nextNumber = getNextNumber();

            string[] s = new string[6];
            s[0]  = nextNumber;

            if(radioButton_Male.Checked )
            {
                s[1] = "男性";
            }
            else
            {
                s[1] = "女性";
            }

            s[2] = textBox_simei.Text + textBox_mei.Text;
            s[3] = textBox_simei_huri.Text + textBox_mei_huri.Text;

            s[4] = textBox_age.Text;
            s[5] = textBox_phone.Text;

            members.Add(s);

            displayData();
        }

        private string getNextNumber() 
        {
            int nextNo = 1;
            if(members.Count == 0)
            {
                return nextNo.ToString();

            }

            string[] s = members[members.Count - 1];
            nextNo = int.Parse(s[0]) + 1;

            return nextNo.ToString();
        }

        private void displayData()
        {
            listView_Display.Items.Clear();
            for(int i = 0;i<members.Count;i++) 
            {
                string[] s = members[i];

                ListViewItem item = new ListViewItem(s);

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
            members.RemoveAt(index);

            displayData();
        }
    }
}