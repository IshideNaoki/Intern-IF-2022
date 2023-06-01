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

            if(this.radioButton_Male.Checked )
            {
                s[1] = "男性";
            }
            else
            {
                s[1] = "女性";
            }

            s[2] = this.textBox_simei.Text + this.textBox_mei.Text;
            s[3] = this.textBox_simei_huri.Text + this.textBox_mei_huri.Text;

            s[4] = this.textBox_age.Text;
            s[5] = this.textBox_phone.Text;

            this.members.Add(s);

            displayData();
        }

        private string getNextNumber() 
        {
            int nextNo = 1;
            if(this.members.Count == 0)
            {
                return nextNo.ToString();

            }

            string[] s = this.members[this.members.Count - 1];
            nextNo = int.Parse(s[0]) + 1;

            return nextNo.ToString();
        }

        private void displayData()
        {
            this.listView_Display.Items.Clear();
            for(int i = 0;i<this.members.Count;i++) 
            {
                string[] s = members[i];

                ListViewItem item = new ListViewItem(s);

                this.listView_Display.Items.Add(item);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if(this.listView_Display.SelectedIndices.Count == 0)
            {
                MessageBox.Show("削除する項目を選択してください");
                return;
            }

            int index = this.listView_Display.SelectedIndices[0];
            this.members.RemoveAt(index);

            displayData();
        }
    }
}