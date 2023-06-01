namespace 起床_就寝時間チェック
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private List<string[]> members = new List<string[]>();
        private void button_display_Click(object sender, EventArgs e)
        {
            string[] s = new string[3];
            s[0] = textBox_date.Text;
            s[1] = textBox_wakeup.Text;
            s[2] =textBox_sleep.Text;

            this.members.Add(s);

            displayData();


        }

        private void displayData() 
        { 
            this.listView_Display.Items.Clear();
            for(int i = 0; i < members.Count; i++) 
            {
                string[] s = members[i];

                ListViewItem item = new ListViewItem(s);

                this.listView_Display.Items.Add(item);
            }
        
        }
    }
}