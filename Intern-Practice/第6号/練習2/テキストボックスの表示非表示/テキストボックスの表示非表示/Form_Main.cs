namespace テキストボックスの表示非表示
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            this.textBox_target.Visible = true;
        }

        private void button_hidden_Click(object sender, EventArgs e)
        {
            this.textBox_target.Visible = false;
        }
    }
}