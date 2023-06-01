namespace ランダム足し算
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_question_Click(object sender, EventArgs e)
        {
            Random rand_num = new Random();
            int num1;
            int num2;

            do
            {
                num1 = rand_num.Next(10, 99);
                num2 = rand_num.Next(10, 99);
                
            }
            while (num1 + num2 < 150);
            label_num1.Text = num1.ToString();
            label_num2.Text = num2.ToString();

        }

        private void button_ans_Click(object sender, EventArgs e)
        {
            int answer = 0;
            answer = int.Parse(label_num1.Text) + int.Parse(label_num2.Text);
            if (int.Parse(textBox_ans.Text) == answer)
            {
                label_TF.Text = "正解☆";
            }
            else
            {
                label_TF.Text = "不正解!";
            }
        }
    }
}