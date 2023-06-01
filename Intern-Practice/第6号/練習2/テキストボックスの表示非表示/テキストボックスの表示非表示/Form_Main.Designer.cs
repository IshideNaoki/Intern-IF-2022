namespace テキストボックスの表示非表示
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
            this.textBox_target = new System.Windows.Forms.TextBox();
            this.button_display = new System.Windows.Forms.Button();
            this.button_hidden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_target
            // 
            this.textBox_target.Location = new System.Drawing.Point(293, 109);
            this.textBox_target.Name = "textBox_target";
            this.textBox_target.Size = new System.Drawing.Size(150, 31);
            this.textBox_target.TabIndex = 0;
            this.textBox_target.Visible = false;
            // 
            // button_display
            // 
            this.button_display.Location = new System.Drawing.Point(230, 159);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(112, 34);
            this.button_display.TabIndex = 1;
            this.button_display.Text = "表示";
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // button_hidden
            // 
            this.button_hidden.Location = new System.Drawing.Point(379, 159);
            this.button_hidden.Name = "button_hidden";
            this.button_hidden.Size = new System.Drawing.Size(112, 34);
            this.button_hidden.TabIndex = 2;
            this.button_hidden.Text = "非表示";
            this.button_hidden.UseVisualStyleBackColor = true;
            this.button_hidden.Click += new System.EventHandler(this.button_hidden_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_hidden);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.textBox_target);
            this.Name = "Form_Main";
            this.Text = "テキストボックスの表示非表示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_target;
        private Button button_display;
        private Button button_hidden;
    }
}