namespace sort_item_data
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
            this.listView_Display = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.button_Display = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBox_sort_select = new System.Windows.Forms.ComboBox();
            this.button_sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_Display
            // 
            this.listView_Display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Display.FullRowSelect = true;
            this.listView_Display.GridLines = true;
            this.listView_Display.Location = new System.Drawing.Point(80, 145);
            this.listView_Display.Name = "listView_Display";
            this.listView_Display.Size = new System.Drawing.Size(527, 303);
            this.listView_Display.TabIndex = 4;
            this.listView_Display.UseCompatibleStateImageBehavior = false;
            this.listView_Display.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "単価";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "個数";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "合計";
            this.columnHeader4.Width = 100;
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(80, 88);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(112, 34);
            this.button_Display.TabIndex = 3;
            this.button_Display.Text = "表示";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // comboBox_sort_select
            // 
            this.comboBox_sort_select.FormattingEnabled = true;
            this.comboBox_sort_select.Items.AddRange(new object[] {
            "昇順",
            "降順"});
            this.comboBox_sort_select.Location = new System.Drawing.Point(498, 49);
            this.comboBox_sort_select.Name = "comboBox_sort_select";
            this.comboBox_sort_select.Size = new System.Drawing.Size(109, 33);
            this.comboBox_sort_select.TabIndex = 5;
            this.comboBox_sort_select.Visible = false;
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(464, 88);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(143, 34);
            this.button_sort.TabIndex = 6;
            this.button_sort.Text = "並べ替え(合計)";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Visible = false;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.comboBox_sort_select);
            this.Controls.Add(this.listView_Display);
            this.Controls.Add(this.button_Display);
            this.Name = "Form_Main";
            this.Text = "sort_item_data";
            this.ResumeLayout(false);

        }

        #endregion
        private ListView listView_Display;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button_Display;
        private OpenFileDialog openFileDialog;
        private ComboBox comboBox_sort_select;
        private Button button_sort;
    }
}