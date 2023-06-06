namespace 予定表
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private List<string[]> members = new List<string[]>();

        private void button_append_Click(object sender, EventArgs e)
        {
            string[] s = new string[3];

            string date = dateTimePicker1.Value.ToShortDateString();
            s[0] = date;
            s[1] = textBox_reserve.Text;
            members.Add(s);
            displayData();
        }
        private void displayData()
        {
            listView_Display.Items.Clear();
            for(int i = 0; i < members.Count; i++)
            {
                string[] s = members[i];

                ListViewItem item = new ListViewItem(s);

                listView_Display.Items.Add(item);
            }
        }
    }
}