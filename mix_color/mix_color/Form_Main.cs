namespace mix_color
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        //1.スタートボタンを押すとランダムで二色表示される(赤、青、緑)
        //2.二色をまぜた結果何色になるかをRadioButtonを一つ選び解答ボタンを押す
        //2-1 正解なら正解となる色の正方形が表示される
        //2-2 間違いなら間違いであることをMessageBoxで表示する
        //3　正解ボタンを押すと正解となる色の正方形が表示される

        //スタート
        private void button_start_Click(object sender, EventArgs e)
        {

            List<Color> color_labels = new List<Color> { Color.Red, Color.Blue, Color.Green };

            this.label_color_result.Visible = false;
            this.label_result.Text = "何色?";
            this.label_tf.Text = "";
            this.button_answer.Visible = true;

            Random random = new Random();
            int rnd1 = random.Next(color_labels.Count);
            this.label_color1.BackColor = color_labels[rnd1];
            color_labels.RemoveAt(rnd1);

            if (this.label_color1.BackColor == Color.Red)
            {
                this.label_color1_name.Text = "赤色";
            }
            else if (this.label_color1.BackColor == Color.Blue)
            {
                this.label_color1_name.Text = "青色";
            }
            else if (this.label_color1.BackColor == Color.Green)
            {
                this.label_color1_name.Text = "緑色";
            }

            int rnd2 = random.Next(color_labels.Count);
            this.label_color2.BackColor = color_labels[rnd2];

            if (this.label_color2.BackColor == Color.Red)
            {
                this.label_color2_name.Text = "赤色";
            }
            else if (this.label_color2.BackColor == Color.Blue)
            {
                this.label_color2_name.Text = "青色";
            }
            else if (this.label_color2.BackColor == Color.Green)
            {
                this.label_color2_name.Text = "緑色";
            }
        }

        //解答ボタン
        private void button_answer_Click(object sender, EventArgs e)
        {
            //赤+青=紫
            if ((this.label_color1.BackColor == Color.Red) && (this.label_color2.BackColor == Color.Blue) && (this.radioButton_select_purple.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Purple;
                this.label_tf.Text = "正解";
                this.label_result.Text = "紫色";
            }
            //赤+緑=黄
            else if ((this.label_color1.BackColor == Color.Red) && (this.label_color2.BackColor == Color.Green) && (this.radioButton_select_yellow.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Yellow;
                this.label_tf.Text = "正解";
                this.label_result.Text = "黄色";
            }
            //青+赤=紫
            else if ((this.label_color1.BackColor == Color.Blue) && (this.label_color2.BackColor == Color.Red) && (this.radioButton_select_purple.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Purple;
                this.label_tf.Text = "正解";
                this.label_result.Text = "紫色";
            }
            //青+緑=水
            else if ((this.label_color1.BackColor == Color.Blue) && (this.label_color2.BackColor == Color.Green) && (this.radioButton_select_lightblue.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.LightBlue;
                this.label_tf.Text = "正解";
                this.label_result.Text = "水色";
            }
            //緑+赤=黄
            else if ((this.label_color1.BackColor == Color.Green) && (this.label_color2.BackColor == Color.Red) && (this.radioButton_select_yellow.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Yellow;
                this.label_tf.Text = "正解";
                this.label_result.Text = "黄色";
            }
            //緑+青=水
            else if ((this.label_color1.BackColor == Color.Green) && (this.label_color2.BackColor == Color.Blue) && (this.radioButton_select_lightblue.Checked))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.LightBlue;
                this.label_tf.Text = "正解";
                this.label_result.Text = "水色";
            }
            else
            {
                MessageBox.Show("間違いです", "間違い", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.label_tf.Text = "不正解";
            }
        }
        //正解ボタン
        private void button_result_Click(object sender, EventArgs e)
        {
            this.label_tf.Text = "正解↓";
            this.button_answer.Visible = false;

            //赤+青=紫
            if ((this.label_color1.BackColor == Color.Red) && (this.label_color2.BackColor == Color.Blue))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Purple;
                this.label_result.Text = "紫色";
            }
            //赤　緑　黄
            else if ((this.label_color1.BackColor == Color.Red) && (this.label_color2.BackColor == Color.Green))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Yellow;
                this.label_result.Text = "黄色";
            }
            //青+赤=紫
            else if ((this.label_color1.BackColor == Color.Blue) && (this.label_color2.BackColor == Color.Red))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Purple;
                this.label_result.Text = "紫色";
            }
            //青+緑=水
            else if ((this.label_color1.BackColor == Color.Blue) && (this.label_color2.BackColor == Color.Green))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.LightBlue;
                this.label_result.Text = "水色";
            }
            //緑+赤=黄
            else if ((this.label_color1.BackColor == Color.Green) && (this.label_color2.BackColor == Color.Red))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.Yellow;
                this.label_result.Text = "黄色";
            }
            //緑+青=水
            else if ((this.label_color1.BackColor == Color.Green) && (this.label_color2.BackColor == Color.Blue))
            {
                this.label_color_result.Visible = true;
                this.label_color_result.BackColor = Color.LightBlue;
                this.label_result.Text = "水色";
            }
        }
    }
}