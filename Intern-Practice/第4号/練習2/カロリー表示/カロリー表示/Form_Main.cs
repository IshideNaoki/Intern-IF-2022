namespace カロリー表示
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_dislay_Click(object sender, EventArgs e)
        {
            string[] array = new string[4];

            array[0] = this.textBox_item_name.Text;
            array[1]= this.textBox_kcal.Text;
            array[2] =  this.comboBox_count.Text;
            array[3] = (int.Parse(array[1]) * int.Parse(array[2])).ToString();

            ListViewItem item = new ListViewItem(array);
            this.listView1.Items.Add(item);
        }
    }
}