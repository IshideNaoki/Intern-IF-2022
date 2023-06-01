namespace ランダム足し算
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
            this.label_num1 = new System.Windows.Forms.Label();
            this.label_plus = new System.Windows.Forms.Label();
            this.label_num2 = new System.Windows.Forms.Label();
            this.label_equal = new System.Windows.Forms.Label();
            this.label_TF = new System.Windows.Forms.Label();
            this.textBox_ans = new System.Windows.Forms.TextBox();
            this.button_question = new System.Windows.Forms.Button();
            this.button_ans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_num1
            // 
            this.label_num1.AutoSize = true;
            this.label_num1.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_num1.Location = new System.Drawing.Point(12, 123);
            this.label_num1.Name = "label_num1";
            this.label_num1.Size = new System.Drawing.Size(0, 106);
            this.label_num1.TabIndex = 0;
            // 
            // label_plus
            // 
            this.label_plus.AutoSize = true;
            this.label_plus.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_plus.Location = new System.Drawing.Point(139, 146);
            this.label_plus.Name = "label_plus";
            this.label_plus.Size = new System.Drawing.Size(50, 54);
            this.label_plus.TabIndex = 1;
            this.label_plus.Text = "+";
            // 
            // label_num2
            // 
            this.label_num2.AutoSize = true;
            this.label_num2.Font = new System.Drawing.Font("Yu Gothic UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_num2.Location = new System.Drawing.Point(189, 123);
            this.label_num2.Name = "label_num2";
            this.label_num2.Size = new System.Drawing.Size(0, 106);
            this.label_num2.TabIndex = 2;
            // 
            // label_equal
            // 
            this.label_equal.AutoSize = true;
            this.label_equal.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_equal.Location = new System.Drawing.Point(321, 146);
            this.label_equal.Name = "label_equal";
            this.label_equal.Size = new System.Drawing.Size(50, 54);
            this.label_equal.TabIndex = 3;
            this.label_equal.Text = "=";
            // 
            // label_TF
            // 
            this.label_TF.AutoSize = true;
            this.label_TF.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TF.Location = new System.Drawing.Point(377, 123);
            this.label_TF.Name = "label_TF";
            this.label_TF.Size = new System.Drawing.Size(0, 54);
            this.label_TF.TabIndex = 4;
            // 
            // textBox_ans
            // 
            this.textBox_ans.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_ans.Location = new System.Drawing.Point(377, 175);
            this.textBox_ans.Multiline = true;
            this.textBox_ans.Name = "textBox_ans";
            this.textBox_ans.Size = new System.Drawing.Size(150, 54);
            this.textBox_ans.TabIndex = 5;
            this.textBox_ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_question
            // 
            this.button_question.Location = new System.Drawing.Point(533, 146);
            this.button_question.Name = "button_question";
            this.button_question.Size = new System.Drawing.Size(112, 34);
            this.button_question.TabIndex = 6;
            this.button_question.Text = "問題表示";
            this.button_question.UseVisualStyleBackColor = true;
            this.button_question.Click += new System.EventHandler(this.button_question_Click);
            // 
            // button_ans
            // 
            this.button_ans.Location = new System.Drawing.Point(533, 195);
            this.button_ans.Name = "button_ans";
            this.button_ans.Size = new System.Drawing.Size(112, 34);
            this.button_ans.TabIndex = 7;
            this.button_ans.Text = "答え合わせ";
            this.button_ans.UseVisualStyleBackColor = true;
            this.button_ans.Click += new System.EventHandler(this.button_ans_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ans);
            this.Controls.Add(this.button_question);
            this.Controls.Add(this.textBox_ans);
            this.Controls.Add(this.label_TF);
            this.Controls.Add(this.label_equal);
            this.Controls.Add(this.label_num2);
            this.Controls.Add(this.label_plus);
            this.Controls.Add(this.label_num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_num1;
        private Label label_plus;
        private Label label_num2;
        private Label label_equal;
        private Label label_TF;
        private TextBox textBox_ans;
        private Button button_question;
        private Button button_ans;
    }
}