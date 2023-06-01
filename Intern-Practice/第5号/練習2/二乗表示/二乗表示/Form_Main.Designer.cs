namespace 二乗表示
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.button_display = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(59, 38);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(150, 31);
            this.textBox_input.TabIndex = 0;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(269, 38);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(112, 34);
            this.button_register.TabIndex = 1;
            this.button_register.Text = "値登録";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDisplay.GridLines = true;
            this.listViewDisplay.Location = new System.Drawing.Point(59, 169);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(322, 146);
            this.listViewDisplay.TabIndex = 2;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            // 
            // button_display
            // 
            this.button_display.Location = new System.Drawing.Point(269, 111);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(112, 34);
            this.button_display.TabIndex = 3;
            this.button_display.Text = "二乗表示";
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "値";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "二値した値";
            this.columnHeader2.Width = 120;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.listViewDisplay);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form_Main";
            this.Text = "二乗表示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_input;
        private Button button_register;
        private ListView listViewDisplay;
        private Button button_display;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}