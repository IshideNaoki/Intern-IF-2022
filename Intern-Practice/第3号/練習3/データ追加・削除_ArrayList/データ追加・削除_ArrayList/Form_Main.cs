using System.Collections;

namespace データ追加_削除_ArrayList
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_display_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBox_Data1.Text);
            arrayList.Add(textBox_Data2.Text);
            arrayList.Add(textBox_Data3.Text);
            arrayList.Add(textBox_Data4.Text);
            arrayList.Add(textBox_Data5.Text);



            if (checkBox_del1.Checked == true)
            {
                arrayList.Remove(textBox_Data1.Text);
            }
            if (checkBox_del2.Checked == true)
            {
                arrayList.Remove(textBox_Data2.Text);
            }
            if (checkBox_del3.Checked == true)
            {
                arrayList.Remove(textBox_Data3.Text);
            }
            if (checkBox_del4.Checked == true)
            {
                arrayList.Remove(textBox_Data4.Text);
            }
            if (checkBox_del5.Checked == true)
            {
                arrayList.Remove(textBox_Data5.Text);
            }


            string displayData = string.Empty;

            for (int i = 0; i < arrayList.Count; i++)
            {
                displayData += (string)arrayList[i] + "\r\n";
            }
            label_cat_result.Text = displayData;

        }
    }
}