using System.Collections;

namespace 名簿_ArrayList
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private ArrayList members = new ArrayList();  
            
        private void button_Set_Click(object sender, EventArgs e)
        {
            setData(this.textBox_FamilyName.Text, this.textBox_Name.Text);

            showData();
        }
        private void setData(string familyName, string name)
        {
            string[] personalData = new string[2];
            if (this.radioButton_Man.Checked)
            {
                personalData[0] = "男性";
            }
            else
            {
                personalData[0] = "女性";
            }

            personalData[1] = familyName + " " + name;
            this.members.Add(personalData);
        }
        private void showData()
        {
            this.listBox_Display.Items.Clear();
            for (int i = 0; i < this.members.Count; i++)
            {
                string[] data = (string[])this.members[i];

                string displayString = data[0] + "\t" + data[1];
                this.listBox_Display.Items.Add(displayString);
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (this.listBox_Display.SelectedIndices.Count == 0)
            {
                MessageBox.Show("削除する項目を選択してください。");
            }

            int index = this.listBox_Display.SelectedIndices[0];
            this.members.RemoveAt(index);
            showData();
        }
    }
}