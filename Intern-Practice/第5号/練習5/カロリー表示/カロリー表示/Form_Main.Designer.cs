namespace カロリー表示
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
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.radioButton_500k = new System.Windows.Forms.RadioButton();
            this.radioButton_300k = new System.Windows.Forms.RadioButton();
            this.button_display = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Checked = true;
            this.radioButton_all.Location = new System.Drawing.Point(28, 29);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(68, 29);
            this.radioButton_all.TabIndex = 0;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "全て";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // radioButton_500k
            // 
            this.radioButton_500k.AutoSize = true;
            this.radioButton_500k.Location = new System.Drawing.Point(28, 99);
            this.radioButton_500k.Name = "radioButton_500k";
            this.radioButton_500k.Size = new System.Drawing.Size(133, 29);
            this.radioButton_500k.TabIndex = 1;
            this.radioButton_500k.Text = "500kcal以上";
            this.radioButton_500k.UseVisualStyleBackColor = true;
            // 
            // radioButton_300k
            // 
            this.radioButton_300k.AutoSize = true;
            this.radioButton_300k.Location = new System.Drawing.Point(28, 64);
            this.radioButton_300k.Name = "radioButton_300k";
            this.radioButton_300k.Size = new System.Drawing.Size(133, 29);
            this.radioButton_300k.TabIndex = 1;
            this.radioButton_300k.Text = "300kcal以上";
            this.radioButton_300k.UseVisualStyleBackColor = true;
            // 
            // button_display
            // 
            this.button_display.Location = new System.Drawing.Point(488, 96);
            this.button_display.Name = "button_display";
            this.button_display.Size = new System.Drawing.Size(112, 34);
            this.button_display.TabIndex = 2;
            this.button_display.Text = "表示";
            this.button_display.UseVisualStyleBackColor = true;
            this.button_display.Click += new System.EventHandler(this.button_display_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(28, 146);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(572, 292);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ジャンル";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "カロリー";
            this.columnHeader3.Width = 200;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_display);
            this.Controls.Add(this.radioButton_300k);
            this.Controls.Add(this.radioButton_500k);
            this.Controls.Add(this.radioButton_all);
            this.Name = "Form_Main";
            this.Text = "カロリー表示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButton_all;
        private RadioButton radioButton_500k;
        private RadioButton radioButton_300k;
        private Button button_display;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private OpenFileDialog openFileDialog;
    }
}