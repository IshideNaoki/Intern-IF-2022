namespace 問題作成ツール
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_addQ = new System.Windows.Forms.Button();
            this.textBox_ans1 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox_question = new System.Windows.Forms.TextBox();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_clearAll = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_q1 = new System.Windows.Forms.Label();
            this.button_check1 = new System.Windows.Forms.Button();
            this.button_ans1 = new System.Windows.Forms.Button();
            this.label_valid1 = new System.Windows.Forms.Label();
            this.label_valid2 = new System.Windows.Forms.Label();
            this.button_ans2 = new System.Windows.Forms.Button();
            this.button_check2 = new System.Windows.Forms.Button();
            this.label_q2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ans2 = new System.Windows.Forms.TextBox();
            this.label_valid3 = new System.Windows.Forms.Label();
            this.button_ans3 = new System.Windows.Forms.Button();
            this.button_check3 = new System.Windows.Forms.Button();
            this.label_q3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ans3 = new System.Windows.Forms.TextBox();
            this.label_valid4 = new System.Windows.Forms.Label();
            this.button_ans4 = new System.Windows.Forms.Button();
            this.button_check4 = new System.Windows.Forms.Button();
            this.label_q4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_ans4 = new System.Windows.Forms.TextBox();
            this.label_valid5 = new System.Windows.Forms.Label();
            this.button_ans5 = new System.Windows.Forms.Button();
            this.button_check5 = new System.Windows.Forms.Button();
            this.label_q5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_ans5 = new System.Windows.Forms.TextBox();
            this.label_valid6 = new System.Windows.Forms.Label();
            this.button_ans6 = new System.Windows.Forms.Button();
            this.button_check6 = new System.Windows.Forms.Button();
            this.label_q6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_ans6 = new System.Windows.Forms.TextBox();
            this.button_individual_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題";
            // 
            // button_addQ
            // 
            this.button_addQ.Location = new System.Drawing.Point(422, 41);
            this.button_addQ.Name = "button_addQ";
            this.button_addQ.Size = new System.Drawing.Size(112, 34);
            this.button_addQ.TabIndex = 1;
            this.button_addQ.Text = "問題追加";
            this.button_addQ.UseVisualStyleBackColor = true;
            this.button_addQ.Click += new System.EventHandler(this.button_addQ_Click);
            // 
            // textBox_ans1
            // 
            this.textBox_ans1.Location = new System.Drawing.Point(209, 172);
            this.textBox_ans1.Multiline = true;
            this.textBox_ans1.Name = "textBox_ans1";
            this.textBox_ans1.Size = new System.Drawing.Size(150, 52);
            this.textBox_ans1.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox.Location = new System.Drawing.Point(635, 8);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(59, 33);
            this.comboBox.TabIndex = 3;
            // 
            // textBox_question
            // 
            this.textBox_question.Location = new System.Drawing.Point(12, 44);
            this.textBox_question.Multiline = true;
            this.textBox_question.Name = "textBox_question";
            this.textBox_question.Size = new System.Drawing.Size(150, 42);
            this.textBox_question.TabIndex = 2;
            // 
            // textBox_answer
            // 
            this.textBox_answer.Location = new System.Drawing.Point(209, 44);
            this.textBox_answer.Multiline = true;
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(150, 42);
            this.textBox_answer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "答え";
            // 
            // button_clearAll
            // 
            this.button_clearAll.Location = new System.Drawing.Point(582, 41);
            this.button_clearAll.Name = "button_clearAll";
            this.button_clearAll.Size = new System.Drawing.Size(112, 34);
            this.button_clearAll.TabIndex = 6;
            this.button_clearAll.Text = "全問題削除";
            this.button_clearAll.UseVisualStyleBackColor = true;
            this.button_clearAll.Click += new System.EventHandler(this.button_clearAll_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(12, 92);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(112, 34);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "問題スタート";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "第1問";
            // 
            // label_q1
            // 
            this.label_q1.AutoSize = true;
            this.label_q1.Location = new System.Drawing.Point(21, 175);
            this.label_q1.Name = "label_q1";
            this.label_q1.Size = new System.Drawing.Size(0, 25);
            this.label_q1.TabIndex = 9;
            // 
            // button_check1
            // 
            this.button_check1.Location = new System.Drawing.Point(209, 124);
            this.button_check1.Name = "button_check1";
            this.button_check1.Size = new System.Drawing.Size(90, 34);
            this.button_check1.TabIndex = 10;
            this.button_check1.Text = "答え合せ";
            this.button_check1.UseVisualStyleBackColor = true;
            this.button_check1.Click += new System.EventHandler(this.button_check1_Click);
            // 
            // button_ans1
            // 
            this.button_ans1.Location = new System.Drawing.Point(316, 124);
            this.button_ans1.Name = "button_ans1";
            this.button_ans1.Size = new System.Drawing.Size(76, 34);
            this.button_ans1.TabIndex = 11;
            this.button_ans1.Text = "解答";
            this.button_ans1.UseVisualStyleBackColor = true;
            this.button_ans1.Click += new System.EventHandler(this.button_ans1_Click);
            // 
            // label_valid1
            // 
            this.label_valid1.AutoSize = true;
            this.label_valid1.Location = new System.Drawing.Point(393, 178);
            this.label_valid1.Name = "label_valid1";
            this.label_valid1.Size = new System.Drawing.Size(58, 25);
            this.label_valid1.TabIndex = 12;
            this.label_valid1.Text = "評価1";
            // 
            // label_valid2
            // 
            this.label_valid2.AutoSize = true;
            this.label_valid2.Location = new System.Drawing.Point(393, 296);
            this.label_valid2.Name = "label_valid2";
            this.label_valid2.Size = new System.Drawing.Size(58, 25);
            this.label_valid2.TabIndex = 18;
            this.label_valid2.Text = "評価2";
            // 
            // button_ans2
            // 
            this.button_ans2.Location = new System.Drawing.Point(316, 242);
            this.button_ans2.Name = "button_ans2";
            this.button_ans2.Size = new System.Drawing.Size(76, 34);
            this.button_ans2.TabIndex = 17;
            this.button_ans2.Text = "解答";
            this.button_ans2.UseVisualStyleBackColor = true;
            this.button_ans2.Click += new System.EventHandler(this.button_ans2_Click);
            // 
            // button_check2
            // 
            this.button_check2.Location = new System.Drawing.Point(209, 242);
            this.button_check2.Name = "button_check2";
            this.button_check2.Size = new System.Drawing.Size(90, 34);
            this.button_check2.TabIndex = 16;
            this.button_check2.Text = "答え合せ";
            this.button_check2.UseVisualStyleBackColor = true;
            this.button_check2.Click += new System.EventHandler(this.button_check2_Click);
            // 
            // label_q2
            // 
            this.label_q2.AutoSize = true;
            this.label_q2.Location = new System.Drawing.Point(21, 293);
            this.label_q2.Name = "label_q2";
            this.label_q2.Size = new System.Drawing.Size(0, 25);
            this.label_q2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "第2問";
            // 
            // textBox_ans2
            // 
            this.textBox_ans2.Location = new System.Drawing.Point(209, 290);
            this.textBox_ans2.Multiline = true;
            this.textBox_ans2.Name = "textBox_ans2";
            this.textBox_ans2.Size = new System.Drawing.Size(150, 51);
            this.textBox_ans2.TabIndex = 13;
            // 
            // label_valid3
            // 
            this.label_valid3.AutoSize = true;
            this.label_valid3.Location = new System.Drawing.Point(393, 417);
            this.label_valid3.Name = "label_valid3";
            this.label_valid3.Size = new System.Drawing.Size(58, 25);
            this.label_valid3.TabIndex = 24;
            this.label_valid3.Text = "評価3";
            // 
            // button_ans3
            // 
            this.button_ans3.Location = new System.Drawing.Point(316, 363);
            this.button_ans3.Name = "button_ans3";
            this.button_ans3.Size = new System.Drawing.Size(76, 34);
            this.button_ans3.TabIndex = 23;
            this.button_ans3.Text = "解答";
            this.button_ans3.UseVisualStyleBackColor = true;
            this.button_ans3.Click += new System.EventHandler(this.button_ans3_Click);
            // 
            // button_check3
            // 
            this.button_check3.Location = new System.Drawing.Point(209, 363);
            this.button_check3.Name = "button_check3";
            this.button_check3.Size = new System.Drawing.Size(90, 34);
            this.button_check3.TabIndex = 22;
            this.button_check3.Text = "答え合せ";
            this.button_check3.UseVisualStyleBackColor = true;
            this.button_check3.Click += new System.EventHandler(this.button_check3_Click);
            // 
            // label_q3
            // 
            this.label_q3.AutoSize = true;
            this.label_q3.Location = new System.Drawing.Point(21, 414);
            this.label_q3.Name = "label_q3";
            this.label_q3.Size = new System.Drawing.Size(0, 25);
            this.label_q3.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "第3問";
            // 
            // textBox_ans3
            // 
            this.textBox_ans3.Location = new System.Drawing.Point(209, 411);
            this.textBox_ans3.Multiline = true;
            this.textBox_ans3.Name = "textBox_ans3";
            this.textBox_ans3.Size = new System.Drawing.Size(150, 45);
            this.textBox_ans3.TabIndex = 19;
            // 
            // label_valid4
            // 
            this.label_valid4.AutoSize = true;
            this.label_valid4.Location = new System.Drawing.Point(875, 184);
            this.label_valid4.Name = "label_valid4";
            this.label_valid4.Size = new System.Drawing.Size(58, 25);
            this.label_valid4.TabIndex = 30;
            this.label_valid4.Text = "評価4";
            // 
            // button_ans4
            // 
            this.button_ans4.Location = new System.Drawing.Point(798, 130);
            this.button_ans4.Name = "button_ans4";
            this.button_ans4.Size = new System.Drawing.Size(76, 34);
            this.button_ans4.TabIndex = 29;
            this.button_ans4.Text = "解答";
            this.button_ans4.UseVisualStyleBackColor = true;
            this.button_ans4.Click += new System.EventHandler(this.button_ans4_Click);
            // 
            // button_check4
            // 
            this.button_check4.Location = new System.Drawing.Point(691, 130);
            this.button_check4.Name = "button_check4";
            this.button_check4.Size = new System.Drawing.Size(101, 34);
            this.button_check4.TabIndex = 28;
            this.button_check4.Text = "答え合せ";
            this.button_check4.UseVisualStyleBackColor = true;
            this.button_check4.Click += new System.EventHandler(this.button_check4_Click);
            // 
            // label_q4
            // 
            this.label_q4.AutoSize = true;
            this.label_q4.Location = new System.Drawing.Point(503, 181);
            this.label_q4.Name = "label_q4";
            this.label_q4.Size = new System.Drawing.Size(0, 25);
            this.label_q4.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(503, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "第4問";
            // 
            // textBox_ans4
            // 
            this.textBox_ans4.Location = new System.Drawing.Point(691, 178);
            this.textBox_ans4.Multiline = true;
            this.textBox_ans4.Name = "textBox_ans4";
            this.textBox_ans4.Size = new System.Drawing.Size(150, 46);
            this.textBox_ans4.TabIndex = 25;
            // 
            // label_valid5
            // 
            this.label_valid5.AutoSize = true;
            this.label_valid5.Location = new System.Drawing.Point(875, 302);
            this.label_valid5.Name = "label_valid5";
            this.label_valid5.Size = new System.Drawing.Size(58, 25);
            this.label_valid5.TabIndex = 36;
            this.label_valid5.Text = "評価5";
            // 
            // button_ans5
            // 
            this.button_ans5.Location = new System.Drawing.Point(798, 248);
            this.button_ans5.Name = "button_ans5";
            this.button_ans5.Size = new System.Drawing.Size(76, 34);
            this.button_ans5.TabIndex = 35;
            this.button_ans5.Text = "解答";
            this.button_ans5.UseVisualStyleBackColor = true;
            this.button_ans5.Click += new System.EventHandler(this.button_ans5_Click);
            // 
            // button_check5
            // 
            this.button_check5.Location = new System.Drawing.Point(691, 248);
            this.button_check5.Name = "button_check5";
            this.button_check5.Size = new System.Drawing.Size(92, 34);
            this.button_check5.TabIndex = 34;
            this.button_check5.Text = "答え合せ";
            this.button_check5.UseVisualStyleBackColor = true;
            this.button_check5.Click += new System.EventHandler(this.button_check5_Click);
            // 
            // label_q5
            // 
            this.label_q5.AutoSize = true;
            this.label_q5.Location = new System.Drawing.Point(503, 299);
            this.label_q5.Name = "label_q5";
            this.label_q5.Size = new System.Drawing.Size(0, 25);
            this.label_q5.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(503, 253);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 25);
            this.label17.TabIndex = 32;
            this.label17.Text = "第5問";
            // 
            // textBox_ans5
            // 
            this.textBox_ans5.Location = new System.Drawing.Point(691, 296);
            this.textBox_ans5.Multiline = true;
            this.textBox_ans5.Name = "textBox_ans5";
            this.textBox_ans5.Size = new System.Drawing.Size(150, 45);
            this.textBox_ans5.TabIndex = 31;
            // 
            // label_valid6
            // 
            this.label_valid6.AutoSize = true;
            this.label_valid6.Location = new System.Drawing.Point(875, 423);
            this.label_valid6.Name = "label_valid6";
            this.label_valid6.Size = new System.Drawing.Size(58, 25);
            this.label_valid6.TabIndex = 42;
            this.label_valid6.Text = "評価6";
            // 
            // button_ans6
            // 
            this.button_ans6.Location = new System.Drawing.Point(798, 369);
            this.button_ans6.Name = "button_ans6";
            this.button_ans6.Size = new System.Drawing.Size(76, 34);
            this.button_ans6.TabIndex = 41;
            this.button_ans6.Text = "解答";
            this.button_ans6.UseVisualStyleBackColor = true;
            this.button_ans6.Click += new System.EventHandler(this.button_ans6_Click);
            // 
            // button_check6
            // 
            this.button_check6.Location = new System.Drawing.Point(691, 369);
            this.button_check6.Name = "button_check6";
            this.button_check6.Size = new System.Drawing.Size(92, 34);
            this.button_check6.TabIndex = 40;
            this.button_check6.Text = "答え合せ";
            this.button_check6.UseVisualStyleBackColor = true;
            this.button_check6.Click += new System.EventHandler(this.button_check6_Click);
            // 
            // label_q6
            // 
            this.label_q6.AutoSize = true;
            this.label_q6.Location = new System.Drawing.Point(503, 420);
            this.label_q6.Name = "label_q6";
            this.label_q6.Size = new System.Drawing.Size(0, 25);
            this.label_q6.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(503, 374);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 25);
            this.label20.TabIndex = 38;
            this.label20.Text = "第6問";
            // 
            // textBox_ans6
            // 
            this.textBox_ans6.Location = new System.Drawing.Point(691, 417);
            this.textBox_ans6.Multiline = true;
            this.textBox_ans6.Name = "textBox_ans6";
            this.textBox_ans6.Size = new System.Drawing.Size(150, 39);
            this.textBox_ans6.TabIndex = 37;
            // 
            // button_individual_clear
            // 
            this.button_individual_clear.Location = new System.Drawing.Point(716, 44);
            this.button_individual_clear.Name = "button_individual_clear";
            this.button_individual_clear.Size = new System.Drawing.Size(112, 34);
            this.button_individual_clear.TabIndex = 43;
            this.button_individual_clear.Text = "個別問題削除";
            this.button_individual_clear.UseVisualStyleBackColor = true;
            this.button_individual_clear.Click += new System.EventHandler(this.button_individual_clear_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 521);
            this.Controls.Add(this.button_individual_clear);
            this.Controls.Add(this.label_valid6);
            this.Controls.Add(this.button_ans6);
            this.Controls.Add(this.button_check6);
            this.Controls.Add(this.label_q6);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox_ans6);
            this.Controls.Add(this.label_valid5);
            this.Controls.Add(this.button_ans5);
            this.Controls.Add(this.button_check5);
            this.Controls.Add(this.label_q5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox_ans5);
            this.Controls.Add(this.label_valid4);
            this.Controls.Add(this.button_ans4);
            this.Controls.Add(this.button_check4);
            this.Controls.Add(this.label_q4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_ans4);
            this.Controls.Add(this.label_valid3);
            this.Controls.Add(this.button_ans3);
            this.Controls.Add(this.button_check3);
            this.Controls.Add(this.label_q3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_ans3);
            this.Controls.Add(this.label_valid2);
            this.Controls.Add(this.button_ans2);
            this.Controls.Add(this.button_check2);
            this.Controls.Add(this.label_q2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_ans2);
            this.Controls.Add(this.label_valid1);
            this.Controls.Add(this.button_ans1);
            this.Controls.Add(this.button_check1);
            this.Controls.Add(this.label_q1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_clearAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox_question);
            this.Controls.Add(this.textBox_ans1);
            this.Controls.Add(this.button_addQ);
            this.Controls.Add(this.label1);
            this.Name = "Form_Main";
            this.Text = "問題作成ツール";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button_addQ;
        private TextBox textBox_ans1;
        private ComboBox comboBox;
        private TextBox textBox_question;
        private TextBox textBox_answer;
        private Label label2;
        private Button button_clearAll;
        private Button button_Start;
        private Label label3;
        private Label label_q1;
        private Button button_check1;
        private Button button_ans1;
        private Label label_valid1;
        private Label label_valid2;
        private Button button_ans2;
        private Button button_check2;
        private Label label_q2;
        private Label label8;
        private TextBox textBox_ans2;
        private Label label_valid3;
        private Button button_ans3;
        private Button button_check3;
        private Label label_q3;
        private Label label11;
        private TextBox textBox_ans3;
        private Label label_valid4;
        private Button button_ans4;
        private Button button_check4;
        private Label label_q4;
        private Label label14;
        private TextBox textBox_ans4;
        private Label label_valid5;
        private Button button_ans5;
        private Button button_check5;
        private Label label_q5;
        private Label label17;
        private TextBox textBox_ans5;
        private Label label_valid6;
        private Button button_ans6;
        private Button button_check6;
        private Label label_q6;
        private Label label20;
        private TextBox textBox_ans6;
        private Button button_individual_clear;
    }
}