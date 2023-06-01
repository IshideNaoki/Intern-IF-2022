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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.comboBox_count = new System.Windows.Forms.ComboBox();
            this.textBox_item_name = new System.Windows.Forms.TextBox();
            this.textBox_kcal = new System.Windows.Forms.TextBox();
            this.button_dislay = new System.Windows.Forms.Button();
            this.label_item = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label_kcal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 178);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(680, 272);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "カロリー(kcal/個)";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "個数";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "合計カロリー";
            this.columnHeader4.Width = 100;
            // 
            // comboBox_count
            // 
            this.comboBox_count.FormattingEnabled = true;
            this.comboBox_count.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_count.Location = new System.Drawing.Point(181, 128);
            this.comboBox_count.Name = "comboBox_count";
            this.comboBox_count.Size = new System.Drawing.Size(182, 33);
            this.comboBox_count.TabIndex = 1;
            // 
            // textBox_item_name
            // 
            this.textBox_item_name.Location = new System.Drawing.Point(12, 128);
            this.textBox_item_name.Name = "textBox_item_name";
            this.textBox_item_name.Size = new System.Drawing.Size(150, 31);
            this.textBox_item_name.TabIndex = 2;
            // 
            // textBox_kcal
            // 
            this.textBox_kcal.Location = new System.Drawing.Point(369, 130);
            this.textBox_kcal.Name = "textBox_kcal";
            this.textBox_kcal.Size = new System.Drawing.Size(150, 31);
            this.textBox_kcal.TabIndex = 3;
            // 
            // button_dislay
            // 
            this.button_dislay.Location = new System.Drawing.Point(573, 131);
            this.button_dislay.Name = "button_dislay";
            this.button_dislay.Size = new System.Drawing.Size(112, 34);
            this.button_dislay.TabIndex = 4;
            this.button_dislay.Text = "表示";
            this.button_dislay.UseVisualStyleBackColor = true;
            this.button_dislay.Click += new System.EventHandler(this.button_dislay_Click);
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Location = new System.Drawing.Point(12, 100);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(66, 25);
            this.label_item.TabIndex = 5;
            this.label_item.Text = "商品名";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(181, 100);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(48, 25);
            this.label_count.TabIndex = 6;
            this.label_count.Text = "個数";
            // 
            // label_kcal
            // 
            this.label_kcal.AutoSize = true;
            this.label_kcal.Location = new System.Drawing.Point(369, 100);
            this.label_kcal.Name = "label_kcal";
            this.label_kcal.Size = new System.Drawing.Size(63, 25);
            this.label_kcal.TabIndex = 7;
            this.label_kcal.Text = "カロリー";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "kcal";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_kcal);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_item);
            this.Controls.Add(this.button_dislay);
            this.Controls.Add(this.textBox_kcal);
            this.Controls.Add(this.textBox_item_name);
            this.Controls.Add(this.comboBox_count);
            this.Controls.Add(this.listView1);
            this.Name = "Form_Main";
            this.Text = "カロリー表示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ComboBox comboBox_count;
        private TextBox textBox_item_name;
        private TextBox textBox_kcal;
        private Button button_dislay;
        private Label label_item;
        private Label label_count;
        private Label label_kcal;
        private Label label3;
    }
}