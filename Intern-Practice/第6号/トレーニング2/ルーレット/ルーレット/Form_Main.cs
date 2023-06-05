namespace ルーレット
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private DateTime countTimer = DateTime.Parse("00:00:00");
        private void button_start_Click(object sender, EventArgs e)
        {

            timer.Enabled= true;
            button_start.Enabled = false;
            button_stop.Enabled = true;

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer.Enabled= false;
            button_start.Enabled = true;
            button_stop.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            countTimer = countTimer.AddSeconds(1.0);


            int count_num = int.Parse(countTimer.ToString("ss")) % 12;
            switch(count_num) 
            {
                case 0:
                    label12.BackColor = Color.Black;
                    label12.ForeColor = Color.Black;


                    label1.BackColor = Color.White;
                    label1.ForeColor = Color.White;
                    break;
                case 1:
                    label1.BackColor = Color.Black;
                    label1.ForeColor = Color.Black;

                    label2.BackColor = Color.White;
                    label2.ForeColor = Color.White;
                    break;
                case 2:
                    label2.BackColor = Color.Black;
                    label2.ForeColor = Color.Black;

                    label3.BackColor = Color.White;
                    label3.ForeColor = Color.White;
                    break;
                case 3:
                    label3.BackColor = Color.Black;
                    label3.ForeColor = Color.Black;

                    label4.BackColor = Color.White;
                    label4.ForeColor = Color.White;
                    break;
                case 4:
                    label4.BackColor = Color.Black;
                    label4.ForeColor = Color.Black;

                    label5.BackColor = Color.White;
                    label5.ForeColor = Color.White;
                    break;
                case 5:
                    label5.BackColor = Color.Black;
                    label5.ForeColor = Color.Black;

                    label6.BackColor = Color.White;
                    label6.ForeColor = Color.White;
                    break;
                case 6:
                    label6.BackColor = Color.Black;
                    label6.ForeColor = Color.Black;

                    label7.BackColor = Color.White;
                    label7.ForeColor = Color.White;
                    break;
                case 7:
                    label7.BackColor = Color.Black;
                    label7.ForeColor = Color.Black;

                    label8.BackColor = Color.White;
                    label8.ForeColor = Color.White;
                    break;
                case 8:
                    label8.BackColor = Color.Black;
                    label8.ForeColor = Color.Black;

                    label9.BackColor = Color.White;
                    label9.ForeColor = Color.White;
                    break;
                case 9:
                    label9.BackColor = Color.Black;
                    label9.ForeColor = Color.Black;

                    label10.BackColor = Color.White;
                    label10.ForeColor = Color.White;
                    break;
                case 10:
                    label10.BackColor = Color.Black;
                    label10.ForeColor = Color.Black;

                    label11.BackColor = Color.White;
                    label11.ForeColor = Color.White;
                    break;
                case 11:
                    label11.BackColor = Color.Black;
                    label11.ForeColor = Color.Black;

                    label12.BackColor = Color.White;
                    label12.ForeColor = Color.White;
                    break;

            }
            
            // % 12でテキスト表示を変える
            //クロに変えるのと　代に変える　switch (c+1)
            //　白　クロを二つづつ
        }
    }
}