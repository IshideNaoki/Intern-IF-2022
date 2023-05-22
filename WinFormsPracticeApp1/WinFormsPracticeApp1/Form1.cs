namespace WinFormsPracticeApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string[]> members = new List<string[]>();

        private void button_register_Click(object sender, EventArgs e)
        {
            string Date = DateTime.Now.ToString("yyyy-MM-dd");

            string[] s = new string[5];
            s[0] = Date;

            s[1] = textBox_item.Text;
            s[2] = textBox_price.Text;
            s[3] =textBox_quantity.Text;
            s[4] = (int.Parse(textBox_price.Text) * int.Parse(textBox_quantity.Text)).ToString();

            this.members.Add(s);

            displayDate();
        }


        private void displayDate()
        {
            this.ListView.Items.Clear();

            for(int i = 0; i< this.members.Count; i++)
            {
                string[] s = members[i];
                ListViewItem items = new ListViewItem(s);

                this.ListView.Items.Add(items);
            }
        }
        private void button_remove_Click(object sender, EventArgs e)
        {
            if(this.ListView.SelectedItems.Count == 0) 
            {
                MessageBox.Show("íœ‚·‚é€–Ú‚ð‘I‘ð‚µ‚Ä‚­‚¾‚³‚¢!!",
                    "ƒGƒ‰[",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int index = this.ListView.SelectedIndices[0];
            this.members.RemoveAt(index);
            displayDate();
        }

        
    }
}