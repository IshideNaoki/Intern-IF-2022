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
            this.timer.Enabled= true;

            this.button_Stop.Enabled= true;
            this.button_Lap.Enabled= true;
            this.button_Reset.Enabled = false;
            this.button_Start.Enabled = false;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;

            this.button_Start.Enabled = true;
            this.button_Reset.Enabled = true;
            this.button_Stop.Enabled = false;
            this.button_Lap.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.countTimer = this.countTimer.AddSeconds(1.0);
            this.label_display.Text = this.countTimer.ToString("mm:ss");
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            this.countTimer = DateTime.Parse("00:00:00");
            this.label_display.Text = this.countTimer.ToString("mm:ss");
        }

        private void button_Lap_Click(object sender, EventArgs e)
        {
            
            this.listBox_LapTime.Items.Add(label_display.Text);
        }
    }
}