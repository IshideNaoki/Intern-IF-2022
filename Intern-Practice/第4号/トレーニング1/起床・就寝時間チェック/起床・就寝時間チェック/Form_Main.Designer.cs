namespace 起床_就寝時間チェック
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
            this.label_date = new System.Windows.Forms.Label();
            this.label_wakeup = new System.Windows.Forms.Label();
            this.label_sleep = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_wakeup = new System.Windows.Forms.TextBox();
            this.textBox_sleep = new System.Windows.Forms.TextBox();
            this.button_display = new System.Windows.Forms.Button();
            this.listView_Display = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(35, 22);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(48, 25);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "日付";
            // 
            // label_wakeup
            // 
            this.label_wakeup.AutoSize = true;
            this.label_wakeup.Location = new System.Drawing.Point(35, 106);
            this.label_wakeup.Name = "label_wakeup";
            this.label_wakeup.Size = new System.Drawing.Size(84, 25);
            this.label_wakeup.TabIndex = 1;
            this.label_wakeup.Text = "起床時間";
            // 
            // label_sleep
            // 
            this.label_sleep.AutoSize = true;
            this.label_sleep.Location = new System.Drawing.Point(163, 106);
            this.label_sleep.Name = "label_sleep";
            this.label_sleep.Size = new System.Drawing.Size(84, 25);
            this.label_sleep.TabIndex = 2;
            this.label_sleep.Text = "就寝時間";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(35, 60);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(150, 31);
            this.textBox_date.TabIndex = 3;
            // 
            // textBox_wakeup
            // 
            this.textBox_wakeup.Location = new System.Drawing.Point(35, 146);
            this.textBox_wakeup.Name = "textBox_wakeup";
            this.textBox_wakeup.Size = new System.Drawing.Size(84, 31);
            this.textBox_wakeup.TabIndex = 4;
            // 
            // textBox_sleep
            // 
            this.textBox_sleep.Location = new System.Drawing.Point(163, 146);
            this.textBox_sleep.Name = "textBox_sleep";
            this.textBox_sleep.Size = new System.Drawing.Size(92, 31);
            this.textBox_sleep.TabIndex = 5;
            // 
            // button_display
            // 
            this.button_display.Location = new System.Drawing.Point(293, 116);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(112, 34);
            this.button_display.TabIndex = 6;
            this.button_display.Text = "表示";
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // listView_Display
            // 
            this.listView_Display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Display.GridLines = true;
            this.listView_Display.Location = new System.Drawing.Point(12, 205);
            this.listView_Display.Name = "listView_Display";
            this.listView_Display.Size = new System.Drawing.Size(486, 146);
            this.listView_Display.TabIndex = 7;
            this.listView_Display.UseCompatibleStateImageBehavior = false;
            this.listView_Display.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "日付";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "起床時間";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "就寝時間";
            this.columnHeader3.Width = 100;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.listView_Display);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.textBox_sleep);
            this.Controls.Add(this.textBox_wakeup);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.label_sleep);
            this.Controls.Add(this.label_wakeup);
            this.Controls.Add(this.label_date);
            this.Name = "Form_Main";
            this.Text = "起床・就寝時間チェック";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_date;
        private Label label_wakeup;
        private Label label_sleep;
        private TextBox textBox_date;
        private TextBox textBox_wakeup;
        private TextBox textBox_sleep;
        private Button button_display;
        private ListView listView_Display;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}