namespace 問題作成ツール
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private List<string[]> questions = new List<string[]>();

        private void button_addQ_Click(object sender, EventArgs e)
        {
            if (questions.Count < 6)
            {
                string[] s = new string[2];
                s[0] = textBox_question.Text;
                s[1] = textBox_answer.Text;

                this.questions.Add(s);
            }
            else
            {
                MessageBox.Show("問題が全て登録されています");
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {


            //TextBox
            Label[] targetArray= { label_q1, label_q2, label_q3, label_q4, label_q5, label_q6 };
            for (int i = 0; i < questions.Count; i++)
            {
                targetArray[i].Text = questions[i][0].ToString();
            
            }
        }


        //個別削除
        private void button_individual_clear_Click(object sender, EventArgs e)
        {
            int del_num = int.Parse(comboBox.Text);

            questions.RemoveAt(del_num - 1);


            //末尾に""
            string[] s = new string[2];
            s[0] = "";
            s[1] = "";
            questions.Add(s);
            
            Label[] questionArray = { label_q1, label_q2, label_q3, label_q4, label_q5, label_q6 };
            TextBox[] boxArray = { textBox_ans1, textBox_ans2, textBox_ans3, textBox_ans4, textBox_ans5, textBox_ans6 };

            Label[] validArray = { label_valid1, label_valid2, label_valid3, label_valid4, label_valid5, label_valid6 };

            for (int i = 0; i < questions.Count; i++)
            {
                questionArray[i].Text = questions[i][0].ToString();
                boxArray[i].Text = questions[i][1].ToString();

                if (questions[i][0] == "")
                {
                    validArray[i].Text = "評価" + (i + 1).ToString();
                }
                
                //問題がない奴だけ評価を戻す
            }

        }


        //前問題削除 clear and for
        private void button_clearAll_Click(object sender, EventArgs e)
        {
            int count_num = questions.Count;
            this.questions.Clear();

            Label[] questionArray = { label_q1, label_q2, label_q3, label_q4, label_q5, label_q6 };
            TextBox[] boxansArray = { textBox_ans1, textBox_ans2, textBox_ans3, textBox_ans4, textBox_ans5, textBox_ans6 };
            Label[] labelArray = { label_valid1, label_valid2, label_valid3, label_valid4, label_valid5, label_valid6 };


            for (int i = 0; i < count_num; i++)
            {
                questionArray[i].Text = "";
                boxansArray[i].Text = "";
                labelArray[i].Text = "評価"+(i+1).ToString();


            }
        }

        private void button_check1_Click(object sender, EventArgs e)
        {
           

            if(textBox_ans1.Text == questions[0][1].ToString())
            {
                label_valid1.Text = "正解☆";
            }
            else
            {
                label_valid1.Text = "不正解☆";
            }
        }

        private void button_ans1_Click(object sender, EventArgs e)
        {
            textBox_ans1.Text = questions[0][1].ToString();
        }

        private void button_check2_Click(object sender, EventArgs e)
        {
            if(textBox_ans2.Text == questions[1][1].ToString())
            {
                label_valid2.Text = "正解☆";
            }
            else
            {
                label_valid2.Text = "不正解☆";
            }
        }

        private void button_ans2_Click(object sender, EventArgs e)
        {
            textBox_ans2.Text = questions[1][1].ToString();
        }

        private void button_check3_Click(object sender, EventArgs e)
        {
            if (textBox_ans3.Text == questions[2][1].ToString())
            {
                label_valid3.Text = "正解☆";
            }
            else
            {
                label_valid3.Text = "不正解☆";
            }
        }

        private void button_ans3_Click(object sender, EventArgs e)
        {
            textBox_ans3.Text = questions[2][1].ToString();
        }

        private void button_check4_Click(object sender, EventArgs e)
        {
            if (textBox_ans4.Text == questions[3][1].ToString())
            {
                label_valid4.Text = "正解☆";
            }
            else
            {
                label_valid4.Text = "不正解☆";
            }
        }

        private void button_ans4_Click(object sender, EventArgs e)
        {
            textBox_ans4.Text = questions[3][1].ToString();
        }

        private void button_check5_Click(object sender, EventArgs e)
        {
            if (textBox_ans5.Text == questions[4][1].ToString())
            {
                label_valid5.Text = "正解☆";
            }
            else
            {
                label_valid5.Text = "不正解☆";
            }
        }

        private void button_ans5_Click(object sender, EventArgs e)
        {
            textBox_ans5.Text = questions[4][1].ToString();
        }

        private void button_check6_Click(object sender, EventArgs e)
        {
            if (textBox_ans6.Text == questions[5][1].ToString())
            {
                label_valid6.Text = "正解☆";
            }
            else
            {
                label_valid6.Text = "不正解☆";
            }
        }

        private void button_ans6_Click(object sender, EventArgs e)
        {
            textBox_ans6.Text = questions[5][1].ToString();
        }
    }
}