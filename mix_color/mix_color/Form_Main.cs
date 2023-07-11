namespace mix_color
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        //1.�X�^�[�g�{�^���������ƃ����_���œ�F�\�������(�ԁA�A��)
        //2.��F���܂������ʉ��F�ɂȂ邩��RadioButton����I�щ𓚃{�^��������
        //2-1 �����Ȃ琳���ƂȂ�F�̐����`���\�������
        //2-2 �ԈႢ�Ȃ�ԈႢ�ł��邱�Ƃ�MessageBox�ŕ\������
        //3�@�����{�^���������Ɛ����ƂȂ�F�̐����`���\�������

        //�X�^�[�g
        private void button_start_Click(object sender, EventArgs e)
        {

            List<Color> color_labels = new List<Color> { Color.Red, Color.Blue, Color.Green };

            this.label_color_result.Visible = false;
            this.label_result.Text = "���F?";
            this.label_tf.Text = "";
            this.button_answer.Visible = true;

            Random random = new Random();
            int rnd1 = random.Next(color_labels.Count);
            this.label_color1.BackColor = color_labels[rnd1];
            color_labels.RemoveAt(rnd1);

            if (this.label_color1.BackColor == Color.Red)
            {
                this.label_color1_name.Text = "�ԐF";
            }
            else if (this.label_color1.BackColor == Color.Blue)
            {
                this.label_color1_name.Text = "�F";
            }
            else if (this.label_color1.BackColor == Color.Green)
            {
                this.label_color1_name.Text = "�ΐF";
            }

            int rnd2 = random.Next(color_labels.Count);
            this.label_color2.BackColor = color_labels[rnd2];

            if (this.label_color2.BackColor == Color.Red)
            {
                this.label_color2_name.Text = "�ԐF";
            }
            else if (this.label_color2.BackColor == Color.Blue)
            {
                this.label_color2_name.Text = "�F";
            }
            else if (this.label_color2.BackColor == Color.Green)
            {
                this.label_color2_name.Text = "�ΐF";
            }
        }

        //�𓚃{�^��
        private void button_answer_Click(object sender, EventArgs e)
        {
            //��+��=��
            if ((this.label_color1.BackColor == Color.Red) && (this.label_color2.BackColor == Color.Blue) && (this.radioButton_select_purple.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Purple;
                this.label_tf.Text = "����";
                this.label_result.Text = "���F";
            }
            //��+��=��
            else if ((this.label_color1.BackColor == Color.Red) && (this.label_color2.BackColor == Color.Green) && (this.radioButton_select_yellow.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Yellow;
                this.label_tf.Text = "����";
                this.label_result.Text = "���F";
            }
            //��+��=��
            else if ((this.label_color1.BackColor == Color.Blue) && (this.label_color2.BackColor == Color.Red) && (this.radioButton_select_purple.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Purple;
                this.label_tf.Text = "����";
                this.label_result.Text = "���F";
            }
            //��+��=��
            else if ((this.label_color1.BackColor == Color.Blue) && (this.label_color2.BackColor == Color.Green) && (this.radioButton_select_lightblue.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.LightBlue;
                this.label_tf.Text = "����";
                this.label_result.Text = "���F";
            }
            //��+��=��
            else if ((this.label_color1.BackColor == Color.Green) && (this.label_color2.BackColor == Color.Red) && (this.radioButton_select_yellow.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Yellow;
                this.label_tf.Text = "����";
                this.label_result.Text = "���F";
            }
            //��+��=��
            else if ((this.label_color1.BackColor == Color.Green) && (this.label_color2.BackColor == Color.Blue) && (this.radioButton_select_lightblue.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.LightBlue;
                this.label_tf.Text = "����";
                this.label_result.Text = "���F";
            }
            else
            {
                MessageBox.Show("�ԈႢ�ł�", "�ԈႢ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.label_tf.Text = "�s����";
            }
        }
        //�����{�^��
        private void button_result_Click(object sender, EventArgs e)
        {
            this.label_tf.Text = "������";
            this.button_answer.Visible = false;

            //��+��=��
            if ((this.label_color1.BackColor == Color.Red) && (this.label_color2.BackColor == Color.Blue))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Purple;
                this.label_result.Text = "���F";
            }
            //�ԁ@�΁@��
            else if ((this.label_color1.BackColor == Color.Red) && (this.label_color2.BackColor == Color.Green))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Yellow;
                this.label_result.Text = "���F";
            }
            //��+��=��
            else if ((this.label_color1.BackColor == Color.Blue) && (this.label_color2.BackColor == Color.Red))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Purple;
                this.label_result.Text = "���F";
            }
            //��+��=��
            else if ((this.label_color1.BackColor == Color.Blue) && (this.label_color2.BackColor == Color.Green))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.LightBlue;
                this.label_result.Text = "���F";
            }
            //��+��=��
            else if ((this.label_color1.BackColor == Color.Green) && (this.label_color2.BackColor == Color.Red))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Yellow;
                this.label_result.Text = "���F";
            }
            //��+��=��
            else if ((this.label_color1.BackColor == Color.Green) && (this.label_color2.BackColor == Color.Blue))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.LightBlue;
                this.label_result.Text = "���F";
            }
        }
    }
}