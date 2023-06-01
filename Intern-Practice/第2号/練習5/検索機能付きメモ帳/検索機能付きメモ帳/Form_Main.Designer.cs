namespace 検索機能付きメモ帳
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
            this.button_read = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.textBox_display = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(47, 328);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(112, 34);
            this.button_read.TabIndex = 0;
            this.button_read.Text = "読込";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(278, 393);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(112, 34);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "検索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(240, 331);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(150, 31);
            this.textBox_search.TabIndex = 2;
            // 
            // textBox_display
            // 
            this.textBox_display.Location = new System.Drawing.Point(1, 2);
            this.textBox_display.Multiline = true;
            this.textBox_display.Name = "textBox_display";
            this.textBox_display.Size = new System.Drawing.Size(395, 300);
            this.textBox_display.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "空文字";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.textBox_display);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_read);
            this.Name = "Form_Main";
            this.Text = "検索機能付きメモ帳";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_read;
        private Button button_search;
        private TextBox textBox_search;
        private TextBox textBox_display;
        private OpenFileDialog openFileDialog;
    }
}