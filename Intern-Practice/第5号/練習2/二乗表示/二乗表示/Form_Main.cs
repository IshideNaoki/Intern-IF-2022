using Microsoft.VisualBasic;

namespace 二乗表示
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private List<string> nums = new List<string>();

        private void button_register_Click(object sender, EventArgs e)
        {
            string s = textBox_input.Text;
            nums.Add(s);

            ListViewItem item = new ListViewItem(s);

            listViewDisplay.Items.Add(item);
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            listViewDisplay.Items.Clear();
            foreach (var num in nums)
            {
                int double_num = int.Parse(num) * int.Parse(num);
                string[] strings = { num, double_num.ToString()};
                ListViewItem item = new ListViewItem(strings);

                listViewDisplay.Items.Add(item);

            }
        }
    }
}