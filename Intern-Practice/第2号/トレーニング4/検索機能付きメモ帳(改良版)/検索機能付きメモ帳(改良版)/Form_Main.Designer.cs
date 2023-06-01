namespace 検索機能付きメモ帳_改良版_
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
            this.textBox_display = new System.Windows.Forms.TextBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_display = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox_display
            // 
            this.textBox_display.Location = new System.Drawing.Point(42, 48);
            this.textBox_display.Multiline = true;
            this.textBox_display.Name = "textBox_display";
            this.textBox_display.Size = new System.Drawing.Size(469, 250);
            this.textBox_display.TabIndex = 0;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(361, 304);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(150, 31);
            this.textBox_search.TabIndex = 1;
            // 
            // button_display
            // 
            this.button_display.Location = new System.Drawing.Point(42, 304);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(112, 34);
            this.button_display.TabIndex = 2;
            this.button_display.Text = "読込";
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(192, 304);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(112, 34);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "書込";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(399, 359);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(112, 34);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "検索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.textBox_display);
            this.Name = "Form_Main";
            this.Text = "検索機能付きメモ帳(改良版)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_display;
        private TextBox textBox_search;
        private Button button_display;
        private Button button_add;
        private Button button_search;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}