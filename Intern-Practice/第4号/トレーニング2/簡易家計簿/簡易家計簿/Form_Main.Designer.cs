namespace 簡易家計簿
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
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.listView_display = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.textBox_income = new System.Windows.Forms.TextBox();
            this.label_income = new System.Windows.Forms.Label();
            this.label_yen = new System.Windows.Forms.Label();
            this.label_submission = new System.Windows.Forms.Label();
            this.label_submission_money = new System.Windows.Forms.Label();
            this.textBox_submission = new System.Windows.Forms.TextBox();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.label_yen_sub = new System.Windows.Forms.Label();
            this.button_del_Individual = new System.Windows.Forms.Button();
            this.button_allclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(21, 27);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(48, 25);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "日付";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(21, 69);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(150, 31);
            this.textBox_date.TabIndex = 1;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(415, 70);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(112, 34);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "登録";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // listView_display
            // 
            this.listView_display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_display.FullRowSelect = true;
            this.listView_display.GridLines = true;
            this.listView_display.Location = new System.Drawing.Point(12, 215);
            this.listView_display.Name = "listView_display";
            this.listView_display.Size = new System.Drawing.Size(645, 146);
            this.listView_display.TabIndex = 3;
            this.listView_display.UseCompatibleStateImageBehavior = false;
            this.listView_display.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "日付";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "収入";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "支出項目";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "支出金額";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "残額";
            this.columnHeader5.Width = 100;
            // 
            // textBox_income
            // 
            this.textBox_income.Location = new System.Drawing.Point(212, 69);
            this.textBox_income.Name = "textBox_income";
            this.textBox_income.Size = new System.Drawing.Size(150, 31);
            this.textBox_income.TabIndex = 4;
            // 
            // label_income
            // 
            this.label_income.AutoSize = true;
            this.label_income.Location = new System.Drawing.Point(212, 27);
            this.label_income.Name = "label_income";
            this.label_income.Size = new System.Drawing.Size(48, 25);
            this.label_income.TabIndex = 5;
            this.label_income.Text = "収入";
            // 
            // label_yen
            // 
            this.label_yen.AutoSize = true;
            this.label_yen.Location = new System.Drawing.Point(368, 75);
            this.label_yen.Name = "label_yen";
            this.label_yen.Size = new System.Drawing.Size(30, 25);
            this.label_yen.TabIndex = 6;
            this.label_yen.Text = "円";
            // 
            // label_submission
            // 
            this.label_submission.AutoSize = true;
            this.label_submission.Location = new System.Drawing.Point(21, 122);
            this.label_submission.Name = "label_submission";
            this.label_submission.Size = new System.Drawing.Size(84, 25);
            this.label_submission.TabIndex = 7;
            this.label_submission.Text = "差出項目";
            // 
            // label_submission_money
            // 
            this.label_submission_money.AutoSize = true;
            this.label_submission_money.Location = new System.Drawing.Point(212, 122);
            this.label_submission_money.Name = "label_submission_money";
            this.label_submission_money.Size = new System.Drawing.Size(84, 25);
            this.label_submission_money.TabIndex = 8;
            this.label_submission_money.Text = "差出金額";
            // 
            // textBox_submission
            // 
            this.textBox_submission.Location = new System.Drawing.Point(21, 150);
            this.textBox_submission.Name = "textBox_submission";
            this.textBox_submission.Size = new System.Drawing.Size(150, 31);
            this.textBox_submission.TabIndex = 9;
            // 
            // textBox_money
            // 
            this.textBox_money.Location = new System.Drawing.Point(212, 150);
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.Size = new System.Drawing.Size(150, 31);
            this.textBox_money.TabIndex = 10;
            // 
            // label_yen_sub
            // 
            this.label_yen_sub.AutoSize = true;
            this.label_yen_sub.Location = new System.Drawing.Point(368, 156);
            this.label_yen_sub.Name = "label_yen_sub";
            this.label_yen_sub.Size = new System.Drawing.Size(30, 25);
            this.label_yen_sub.TabIndex = 11;
            this.label_yen_sub.Text = "円";
            // 
            // button_del_Individual
            // 
            this.button_del_Individual.Location = new System.Drawing.Point(415, 147);
            this.button_del_Individual.Name = "button_del_Individual";
            this.button_del_Individual.Size = new System.Drawing.Size(112, 34);
            this.button_del_Individual.TabIndex = 12;
            this.button_del_Individual.Text = "個別削除";
            this.button_del_Individual.UseVisualStyleBackColor = true;
            this.button_del_Individual.Click += new System.EventHandler(this.button_del_Individual_Click);
            // 
            // button_allclear
            // 
            this.button_allclear.Location = new System.Drawing.Point(545, 147);
            this.button_allclear.Name = "button_allclear";
            this.button_allclear.Size = new System.Drawing.Size(112, 34);
            this.button_allclear.TabIndex = 13;
            this.button_allclear.Text = "全体削除";
            this.button_allclear.UseVisualStyleBackColor = true;
            this.button_allclear.Click += new System.EventHandler(this.button_allclear_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.button_allclear);
            this.Controls.Add(this.button_del_Individual);
            this.Controls.Add(this.label_yen_sub);
            this.Controls.Add(this.textBox_money);
            this.Controls.Add(this.textBox_submission);
            this.Controls.Add(this.label_submission_money);
            this.Controls.Add(this.label_submission);
            this.Controls.Add(this.label_yen);
            this.Controls.Add(this.label_income);
            this.Controls.Add(this.textBox_income);
            this.Controls.Add(this.listView_display);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.label_date);
            this.Name = "Form_Main";
            this.Text = "簡易家計簿";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_date;
        private TextBox textBox_date;
        private Button button_register;
        private ListView listView_display;
        private TextBox textBox_income;
        private Label label_income;
        private Label label_yen;
        private Label label_submission;
        private Label label_submission_money;
        private TextBox textBox_submission;
        private TextBox textBox_money;
        private Label label_yen_sub;
        private Button button_del_Individual;
        private Button button_allclear;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}