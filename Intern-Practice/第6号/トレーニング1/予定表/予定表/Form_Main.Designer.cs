namespace 予定表
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_reserve = new System.Windows.Forms.TextBox();
            this.label_reserve = new System.Windows.Forms.Label();
            this.button_append = new System.Windows.Forms.Button();
            this.listView_Display = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(58, 48);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(48, 25);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "日付";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 31);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBox_reserve
            // 
            this.textBox_reserve.Location = new System.Drawing.Point(58, 171);
            this.textBox_reserve.Name = "textBox_reserve";
            this.textBox_reserve.Size = new System.Drawing.Size(150, 31);
            this.textBox_reserve.TabIndex = 2;
            // 
            // label_reserve
            // 
            this.label_reserve.AutoSize = true;
            this.label_reserve.Location = new System.Drawing.Point(58, 143);
            this.label_reserve.Name = "label_reserve";
            this.label_reserve.Size = new System.Drawing.Size(48, 25);
            this.label_reserve.TabIndex = 3;
            this.label_reserve.Text = "予定";
            // 
            // button_append
            // 
            this.button_append.Location = new System.Drawing.Point(344, 168);
            this.button_append.Name = "button_append";
            this.button_append.Size = new System.Drawing.Size(112, 34);
            this.button_append.TabIndex = 4;
            this.button_append.Text = "追加";
            this.button_append.UseVisualStyleBackColor = true;
            this.button_append.Click += new System.EventHandler(this.button_append_Click);
            // 
            // listView_Display
            // 
            this.listView_Display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Display.GridLines = true;
            this.listView_Display.Location = new System.Drawing.Point(12, 247);
            this.listView_Display.Name = "listView_Display";
            this.listView_Display.Size = new System.Drawing.Size(475, 146);
            this.listView_Display.TabIndex = 5;
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
            this.columnHeader2.Text = "予定";
            this.columnHeader2.Width = 150;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.listView_Display);
            this.Controls.Add(this.button_append);
            this.Controls.Add(this.label_reserve);
            this.Controls.Add(this.textBox_reserve);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_date);
            this.Name = "Form_Main";
            this.Text = "予定表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_date;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox_reserve;
        private Label label_reserve;
        private Button button_append;
        private ListView listView_Display;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}