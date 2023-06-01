namespace 表示非表示
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
            this.label_display = new System.Windows.Forms.Label();
            this.label_invisible = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_display
            // 
            this.label_display.AutoSize = true;
            this.label_display.Location = new System.Drawing.Point(347, 109);
            this.label_display.Name = "label_display";
            this.label_display.Size = new System.Drawing.Size(48, 25);
            this.label_display.TabIndex = 0;
            this.label_display.Text = "表示";
            // 
            // label_invisible
            // 
            this.label_invisible.AutoSize = true;
            this.label_invisible.Location = new System.Drawing.Point(338, 172);
            this.label_invisible.Name = "label_invisible";
            this.label_invisible.Size = new System.Drawing.Size(66, 25);
            this.label_invisible.TabIndex = 1;
            this.label_invisible.Text = "非表示";
            this.label_invisible.Visible = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_invisible);
            this.Controls.Add(this.label_display);
            this.Name = "Form_Main";
            this.Text = "表示非表示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_display;
        private Label label_invisible;
    }
}