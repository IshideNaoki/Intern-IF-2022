using System.Diagnostics.PerformanceData;

namespace 名簿_機能追加
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private List<string[]> members = new List<string[]>();
        private void button_Set_Click(object sender, EventArgs e)
        {
            setData(textBox_FamilyName.Text, textBox_Name.Text);

            showData();
        }

        private void setData(string familyName, string name)
        {
            string[] personalData = new string[2];
            if(radioButton_Man.Checked)
            {
                personalData[0] = "男性";
            }
            else
            {
                personalData[0] = "女性";
            }

            personalData[1] = familyName + " "+name;
            members.Add(personalData);
        }
        private void showData()
        {
            listBox_Display.Items.Clear();
            for(int i = 0; i < members.Count; i++)
            {
                string[] data = members[i];

                string displayString = data[0] + "\t" + data[1];
                listBox_Display.Items.Add(displayString);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(listBox_Display.SelectedIndices.Count == 0) 
            {
                MessageBox.Show("削除する項目を選択してください。");
            }

            int index = listBox_Display.SelectedIndices[0];
            members.RemoveAt(index);
            showData();
        }
    }
}