namespace リストビュー表示
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        

        private void display(object sender, EventArgs e)
        {
            string[] array = new string[4];
            array[0] = "ホラー";
            array[1] = "サンプル";
            array[2] = "サンプル";
            array[3] = "2022";

            ListViewItem item = new ListViewItem(array);

            this.listView1.Items.Add(item);
        }
    }
}