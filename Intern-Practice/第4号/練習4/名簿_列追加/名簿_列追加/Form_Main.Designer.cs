namespace 名簿_列追加
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
            this.label_gender = new System.Windows.Forms.Label();
            this.label_furigana = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_sei = new System.Windows.Forms.Label();
            this.label_sei_huri = new System.Windows.Forms.Label();
            this.label_man = new System.Windows.Forms.Label();
            this.label_sai = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_mei = new System.Windows.Forms.Label();
            this.label_mei_huri = new System.Windows.Forms.Label();
            this.textBox_simei = new System.Windows.Forms.TextBox();
            this.textBox_simei_huri = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_mei = new System.Windows.Forms.TextBox();
            this.textBox_mei_huri = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.button_Entry = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.listView_Display = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_FeMale = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(32, 45);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(52, 25);
            this.label_gender.TabIndex = 0;
            this.label_gender.Text = "性別:";
            // 
            // label_furigana
            // 
            this.label_furigana.AutoSize = true;
            this.label_furigana.Location = new System.Drawing.Point(32, 144);
            this.label_furigana.Name = "label_furigana";
            this.label_furigana.Size = new System.Drawing.Size(69, 25);
            this.label_furigana.TabIndex = 1;
            this.label_furigana.Text = "フリガナ:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(32, 98);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(52, 25);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "氏名:";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(32, 187);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(52, 25);
            this.label_age.TabIndex = 2;
            this.label_age.Text = "年齢:";
            // 
            // label_sei
            // 
            this.label_sei.AutoSize = true;
            this.label_sei.Location = new System.Drawing.Point(99, 98);
            this.label_sei.Name = "label_sei";
            this.label_sei.Size = new System.Drawing.Size(30, 25);
            this.label_sei.TabIndex = 3;
            this.label_sei.Text = "姓";
            // 
            // label_sei_huri
            // 
            this.label_sei_huri.AutoSize = true;
            this.label_sei_huri.Location = new System.Drawing.Point(99, 144);
            this.label_sei_huri.Name = "label_sei_huri";
            this.label_sei_huri.Size = new System.Drawing.Size(30, 25);
            this.label_sei_huri.TabIndex = 4;
            this.label_sei_huri.Text = "姓";
            // 
            // label_man
            // 
            this.label_man.AutoSize = true;
            this.label_man.Location = new System.Drawing.Point(99, 187);
            this.label_man.Name = "label_man";
            this.label_man.Size = new System.Drawing.Size(30, 25);
            this.label_man.TabIndex = 5;
            this.label_man.Text = "満";
            // 
            // label_sai
            // 
            this.label_sai.AutoSize = true;
            this.label_sai.Location = new System.Drawing.Point(226, 187);
            this.label_sai.Name = "label_sai";
            this.label_sai.Size = new System.Drawing.Size(30, 25);
            this.label_sai.TabIndex = 6;
            this.label_sai.Text = "歳";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(279, 190);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(88, 25);
            this.label_phone.TabIndex = 7;
            this.label_phone.Text = "電話番号:";
            // 
            // label_mei
            // 
            this.label_mei.AutoSize = true;
            this.label_mei.Location = new System.Drawing.Point(329, 98);
            this.label_mei.Name = "label_mei";
            this.label_mei.Size = new System.Drawing.Size(30, 25);
            this.label_mei.TabIndex = 8;
            this.label_mei.Text = "名";
            // 
            // label_mei_huri
            // 
            this.label_mei_huri.AutoSize = true;
            this.label_mei_huri.Location = new System.Drawing.Point(329, 144);
            this.label_mei_huri.Name = "label_mei_huri";
            this.label_mei_huri.Size = new System.Drawing.Size(30, 25);
            this.label_mei_huri.TabIndex = 9;
            this.label_mei_huri.Text = "名";
            // 
            // textBox_simei
            // 
            this.textBox_simei.Location = new System.Drawing.Point(135, 98);
            this.textBox_simei.Name = "textBox_simei";
            this.textBox_simei.Size = new System.Drawing.Size(150, 31);
            this.textBox_simei.TabIndex = 10;
            // 
            // textBox_simei_huri
            // 
            this.textBox_simei_huri.Location = new System.Drawing.Point(135, 141);
            this.textBox_simei_huri.Name = "textBox_simei_huri";
            this.textBox_simei_huri.Size = new System.Drawing.Size(150, 31);
            this.textBox_simei_huri.TabIndex = 11;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(135, 184);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(85, 31);
            this.textBox_age.TabIndex = 12;
            // 
            // textBox_mei
            // 
            this.textBox_mei.Location = new System.Drawing.Point(365, 95);
            this.textBox_mei.Name = "textBox_mei";
            this.textBox_mei.Size = new System.Drawing.Size(150, 31);
            this.textBox_mei.TabIndex = 13;
            // 
            // textBox_mei_huri
            // 
            this.textBox_mei_huri.Location = new System.Drawing.Point(365, 141);
            this.textBox_mei_huri.Name = "textBox_mei_huri";
            this.textBox_mei_huri.Size = new System.Drawing.Size(150, 31);
            this.textBox_mei_huri.TabIndex = 14;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(365, 190);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(150, 31);
            this.textBox_phone.TabIndex = 15;
            // 
            // button_Entry
            // 
            this.button_Entry.Location = new System.Drawing.Point(566, 57);
            this.button_Entry.Name = "button_Entry";
            this.button_Entry.Size = new System.Drawing.Size(112, 34);
            this.button_Entry.TabIndex = 16;
            this.button_Entry.Text = "登録";
            this.button_Entry.UseVisualStyleBackColor = true;
            this.button_Entry.Click += new System.EventHandler(this.button_Entry_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(566, 119);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(112, 34);
            this.button_Delete.TabIndex = 17;
            this.button_Delete.Text = "削除";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // listView_Display
            // 
            this.listView_Display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Display.FullRowSelect = true;
            this.listView_Display.GridLines = true;
            this.listView_Display.Location = new System.Drawing.Point(12, 238);
            this.listView_Display.Name = "listView_Display";
            this.listView_Display.Size = new System.Drawing.Size(666, 146);
            this.listView_Display.TabIndex = 18;
            this.listView_Display.UseCompatibleStateImageBehavior = false;
            this.listView_Display.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "性別";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "氏名";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "フリガナ";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "年齢";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "電話番号";
            this.columnHeader6.Width = 150;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Checked = true;
            this.radioButton_Male.Location = new System.Drawing.Point(110, 41);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(73, 29);
            this.radioButton_Male.TabIndex = 19;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "男性";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_FeMale
            // 
            this.radioButton_FeMale.AutoSize = true;
            this.radioButton_FeMale.Location = new System.Drawing.Point(183, 41);
            this.radioButton_FeMale.Name = "radioButton_FeMale";
            this.radioButton_FeMale.Size = new System.Drawing.Size(73, 29);
            this.radioButton_FeMale.TabIndex = 20;
            this.radioButton_FeMale.Text = "女性";
            this.radioButton_FeMale.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton_FeMale);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.listView_Display);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Entry);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_mei_huri);
            this.Controls.Add(this.textBox_mei);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_simei_huri);
            this.Controls.Add(this.textBox_simei);
            this.Controls.Add(this.label_mei_huri);
            this.Controls.Add(this.label_mei);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_sai);
            this.Controls.Add(this.label_man);
            this.Controls.Add(this.label_sei_huri);
            this.Controls.Add(this.label_sei);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_furigana);
            this.Controls.Add(this.label_gender);
            this.Name = "Form_Main";
            this.Text = "名簿_列追加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_gender;
        private Label label_furigana;
        private Label label_name;
        private Label label_age;
        private Label label_sei;
        private Label label_sei_huri;
        private Label label_man;
        private Label label_sai;
        private Label label_phone;
        private Label label_mei;
        private Label label_mei_huri;
        private TextBox textBox_simei;
        private TextBox textBox_simei_huri;
        private TextBox textBox_age;
        private TextBox textBox_mei;
        private TextBox textBox_mei_huri;
        private TextBox textBox_phone;
        private Button button_Entry;
        private Button button_Delete;
        private ListView listView_Display;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private RadioButton radioButton_Male;
        private RadioButton radioButton_FeMale;
    }
}