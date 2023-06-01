namespace 名簿_機能追加
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
            this.radioButton_Woman = new System.Windows.Forms.RadioButton();
            this.textBox_FamilyName = new System.Windows.Forms.TextBox();
            this.radioButton_Man = new System.Windows.Forms.RadioButton();
            this.label_name = new System.Windows.Forms.Label();
            this.label_family = new System.Windows.Forms.Label();
            this.label_first = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_gender2 = new System.Windows.Forms.Label();
            this.label_familyname = new System.Windows.Forms.Label();
            this.listBox_Display = new System.Windows.Forms.ListBox();
            this.button_Set = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(31, 60);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(48, 25);
            this.label_gender.TabIndex = 0;
            this.label_gender.Text = "性別";
            // 
            // radioButton_Woman
            // 
            this.radioButton_Woman.AutoSize = true;
            this.radioButton_Woman.Location = new System.Drawing.Point(122, 83);
            this.radioButton_Woman.Name = "radioButton_Woman";
            this.radioButton_Woman.Size = new System.Drawing.Size(73, 29);
            this.radioButton_Woman.TabIndex = 1;
            this.radioButton_Woman.Text = "女性";
            this.radioButton_Woman.UseVisualStyleBackColor = true;
            // 
            // textBox_FamilyName
            // 
            this.textBox_FamilyName.Location = new System.Drawing.Point(132, 162);
            this.textBox_FamilyName.Name = "textBox_FamilyName";
            this.textBox_FamilyName.Size = new System.Drawing.Size(150, 31);
            this.textBox_FamilyName.TabIndex = 2;
            // 
            // radioButton_Man
            // 
            this.radioButton_Man.AutoSize = true;
            this.radioButton_Man.Checked = true;
            this.radioButton_Man.Location = new System.Drawing.Point(122, 33);
            this.radioButton_Man.Name = "radioButton_Man";
            this.radioButton_Man.Size = new System.Drawing.Size(73, 29);
            this.radioButton_Man.TabIndex = 1;
            this.radioButton_Man.TabStop = true;
            this.radioButton_Man.Text = "男性";
            this.radioButton_Man.UseVisualStyleBackColor = true;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(31, 182);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(48, 25);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "氏名";
            // 
            // label_family
            // 
            this.label_family.AutoSize = true;
            this.label_family.Location = new System.Drawing.Point(96, 162);
            this.label_family.Name = "label_family";
            this.label_family.Size = new System.Drawing.Size(30, 25);
            this.label_family.TabIndex = 4;
            this.label_family.Text = "姓";
            // 
            // label_first
            // 
            this.label_first.AutoSize = true;
            this.label_first.Location = new System.Drawing.Point(96, 207);
            this.label_first.Name = "label_first";
            this.label_first.Size = new System.Drawing.Size(30, 25);
            this.label_first.TabIndex = 5;
            this.label_first.Text = "名";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(132, 207);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(150, 31);
            this.textBox_Name.TabIndex = 6;
            // 
            // label_gender2
            // 
            this.label_gender2.AutoSize = true;
            this.label_gender2.Location = new System.Drawing.Point(31, 266);
            this.label_gender2.Name = "label_gender2";
            this.label_gender2.Size = new System.Drawing.Size(48, 25);
            this.label_gender2.TabIndex = 7;
            this.label_gender2.Text = "性別";
            // 
            // label_familyname
            // 
            this.label_familyname.AutoSize = true;
            this.label_familyname.Location = new System.Drawing.Point(96, 266);
            this.label_familyname.Name = "label_familyname";
            this.label_familyname.Size = new System.Drawing.Size(48, 25);
            this.label_familyname.TabIndex = 8;
            this.label_familyname.Text = "氏名";
            // 
            // listBox_Display
            // 
            this.listBox_Display.FormattingEnabled = true;
            this.listBox_Display.ItemHeight = 25;
            this.listBox_Display.Location = new System.Drawing.Point(31, 309);
            this.listBox_Display.Name = "listBox_Display";
            this.listBox_Display.Size = new System.Drawing.Size(493, 129);
            this.listBox_Display.TabIndex = 9;
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(366, 207);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(112, 34);
            this.button_Set.TabIndex = 10;
            this.button_Set.Text = "登録";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(366, 257);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(112, 34);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "削除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_Set);
            this.Controls.Add(this.listBox_Display);
            this.Controls.Add(this.label_familyname);
            this.Controls.Add(this.label_gender2);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_first);
            this.Controls.Add(this.label_family);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_FamilyName);
            this.Controls.Add(this.radioButton_Man);
            this.Controls.Add(this.radioButton_Woman);
            this.Controls.Add(this.label_gender);
            this.Name = "Form_Main";
            this.Text = "名簿_機能追加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_gender;
        private RadioButton radioButton_Woman;
        private TextBox textBox_FamilyName;
        private RadioButton radioButton_Man;
        private Label label_name;
        private Label label_family;
        private Label label_first;
        private TextBox textBox_Name;
        private Label label_gender2;
        private Label label_familyname;
        private ListBox listBox_Display;
        private Button button_Set;
        private Button button_delete;
    }
}