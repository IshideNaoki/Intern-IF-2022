namespace 合計表示_削除_ListView
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
            this.button_Display = new System.Windows.Forms.Button();
            this.listView_Display = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(48, 52);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(112, 34);
            this.button_Display.TabIndex = 0;
            this.button_Display.Text = "表示";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
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
            this.listView_Display.Location = new System.Drawing.Point(31, 113);
            this.listView_Display.Name = "listView_Display";
            this.listView_Display.Size = new System.Drawing.Size(371, 146);
            this.listView_Display.TabIndex = 1;
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "空文字";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(221, 52);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(112, 34);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "削除";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.listView_Display);
            this.Controls.Add(this.button_Display);
            this.Name = "Form_Main";
            this.Text = "合計表示・削除_ListView";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_Display;
        private ListView listView_Display;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private OpenFileDialog openFileDialog;
        private Button button_Delete;
    }
}