namespace ストップウォッチ2
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private DateTime countTimer = DateTime.Parse("00:00:00");

        private List<string> list = new List<string>();
    
        private void button_Start_Click(object sender, EventArgs e)
        {
            timer.Enabled= true;

            button_Stop.Enabled= true;
            button_Lap.Enabled= true;
            button_Reset.Enabled = false;
            button_Start.Enabled = false;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;

            button_Start.Enabled = true;
            button_Reset.Enabled = true;
            button_Stop.Enabled = false;
            button_Lap.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countTimer = countTimer.AddSeconds(1.0);
            label_display.Text = countTimer.ToString("mm:ss");
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            countTimer = DateTime.Parse("00:00:00");
            label_display.Text = countTimer.ToString("mm:ss");
            listBox_LapTime.Items.Clear();
        }

        private void button_Lap_Click(object sender, EventArgs e)
        {
            
            listBox_LapTime.Items.Add(label_display.Text);
        }
    }
}