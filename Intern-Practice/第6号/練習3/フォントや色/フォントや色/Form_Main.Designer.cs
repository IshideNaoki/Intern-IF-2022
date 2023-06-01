namespace フォントや色
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
            this.button_display = new System.Windows.Forms.Button();
            this.label_font = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_display
            // 
            this.button_display.BackColor = System.Drawing.Color.Black;
            this.button_display.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_display.ForeColor = System.Drawing.Color.White;
            this.button_display.Location = new System.Drawing.Point(302, 141);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(112, 49);
            this.button_display.TabIndex = 0;
            this.button_display.Text = "表示";
            this.button_display.UseVisualStyleBackColor = false;
            // 
            // label_font
            // 
            this.label_font.AutoSize = true;
            this.label_font.BackColor = System.Drawing.Color.Brown;
            this.label_font.Font = new System.Drawing.Font("ＭＳ 明朝", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_font.ForeColor = System.Drawing.Color.Orange;
            this.label_font.Location = new System.Drawing.Point(245, 68);
            this.label_font.Name = "label_font";
            this.label_font.Size = new System.Drawing.Size(248, 56);
            this.label_font.TabIndex = 1;
            this.label_font.Text = "フォント";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_font);
            this.Controls.Add(this.button_display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_display;
        private Label label_font;
    }
}