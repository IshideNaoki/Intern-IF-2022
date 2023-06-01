namespace ストップウォッチ2
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_display = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.listBox_LapTime = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Lap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_display
            // 
            this.label_display.AutoSize = true;
            this.label_display.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_display.Location = new System.Drawing.Point(36, 47);
            this.label_display.Name = "label_display";
            this.label_display.Size = new System.Drawing.Size(234, 106);
            this.label_display.TabIndex = 0;
            this.label_display.Text = "00:00";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(12, 167);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(112, 34);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // listBox_LapTime
            // 
            this.listBox_LapTime.FormattingEnabled = true;
            this.listBox_LapTime.ItemHeight = 25;
            this.listBox_LapTime.Location = new System.Drawing.Point(321, 47);
            this.listBox_LapTime.Name = "listBox_LapTime";
            this.listBox_LapTime.Size = new System.Drawing.Size(286, 229);
            this.listBox_LapTime.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(143, 167);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(112, 34);
            this.button_Stop.TabIndex = 3;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(12, 242);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(112, 34);
            this.button_Reset.TabIndex = 4;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Lap
            // 
            this.button_Lap.Location = new System.Drawing.Point(143, 242);
            this.button_Lap.Name = "button_Lap";
            this.button_Lap.Size = new System.Drawing.Size(112, 34);
            this.button_Lap.TabIndex = 5;
            this.button_Lap.Text = "Lap";
            this.button_Lap.UseVisualStyleBackColor = true;
            this.button_Lap.Click += new System.EventHandler(this.button_Lap_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Lap);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.listBox_LapTime);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_display);
            this.Name = "Form_Main";
            this.Text = "ストップウォッチ2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_display;
        private Button button_Start;
        private ListBox listBox_LapTime;
        private System.Windows.Forms.Timer timer;
        private Button button_Stop;
        private Button button_Reset;
        private Button button_Lap;
    }
}