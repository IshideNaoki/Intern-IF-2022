using System.Collections;

namespace データ追加_削除_List
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_display_Click(object sender, EventArgs e)
        {
           List<string> list = new List<string>();
            list.Add(textBox_Data1.Text);
            list.Add(textBox_Data2.Text);
            list.Add(textBox_Data3.Text);
            list.Add(textBox_Data4.Text);
            list.Add(textBox_Data5.Text);


            if(checkBox_clear.Checked ==true)
            {
                list.Clear();
            }


            if (checkBox_del1.Checked == true)
            {
                list.Remove(textBox_Data1.Text);
            }
            if (checkBox_del2.Checked == true)
            {
                list.Remove(textBox_Data2.Text);
            }
            if (checkBox_del3.Checked == true)
            {
                list.Remove(textBox_Data3.Text);
            }
            if (checkBox_del4.Checked == true)
            {
                list.Remove(textBox_Data4.Text);
            }
            if (checkBox_del5.Checked == true)
            {
                list.Remove(textBox_Data5.Text);
            }


            string displayData = string.Empty;

            for (int i = 0; i < list.Count; i++)
            {
                displayData += (string)list[i] + "\r\n";
            }
            label_result.Text = displayData;
        }
    }
}