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
            nums.Add(textBox_input.Text);

            displayData();
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            this.listViewDisplay.Items.Clear();

            foreach (var num in nums)
            {
                int result = int.Parse(num) * int.Parse(num);

                string[] strings = { num, result.ToString() };
                ListViewItem item = new ListViewItem(strings);

                this.listViewDisplay.Items.Add(item);

            }
        }
        private void displayData()
        {
            this.listViewDisplay.Items.Clear();
            for (int i = 0; i < this.nums.Count; i++)
            {
                string s = nums[i];

                ListViewItem item = new ListViewItem(s);

                this.listViewDisplay.Items.Add(item);
            }
        }
    }
}