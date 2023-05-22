namespace WinFormsPracticeApp1
{
    partial class Form1
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
            this.label_item = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.textBox_item = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Location = new System.Drawing.Point(119, 51);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(66, 25);
            this.label_item.TabIndex = 0;
            this.label_item.Text = "商品名";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(12, 120);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(48, 25);
            this.label_price.TabIndex = 4;
            this.label_price.Text = "値段";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(269, 120);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(48, 25);
            this.label_quantity.TabIndex = 6;
            this.label_quantity.Text = "個数";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(544, 39);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(112, 34);
            this.button_register.TabIndex = 8;
            this.button_register.Text = "登録";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(544, 115);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(112, 34);
            this.button_remove.TabIndex = 9;
            this.button_remove.Text = "削除";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // textBox_item
            // 
            this.textBox_item.Location = new System.Drawing.Point(202, 48);
            this.textBox_item.Name = "textBox_item";
            this.textBox_item.Size = new System.Drawing.Size(150, 31);
            this.textBox_item.TabIndex = 12;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(332, 115);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(150, 31);
            this.textBox_quantity.TabIndex = 13;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(83, 115);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(150, 31);
            this.textBox_price.TabIndex = 14;
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.Location = new System.Drawing.Point(2, 177);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(714, 274);
            this.ListView.TabIndex = 15;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "日付";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "値段";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "個数";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "合計";
            this.columnHeader5.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_quantity);
            this.Controls.Add(this.textBox_item);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_item);
            this.Name = "Form1";
            this.Text = "RegisterItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_item;
        private Label label_price;
        private Label label_quantity;
        private Button button_register;
        private Button button_remove;
        private TextBox textBox_item;
        private TextBox textBox_quantity;
        private TextBox textBox_price;
        private ListView ListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}