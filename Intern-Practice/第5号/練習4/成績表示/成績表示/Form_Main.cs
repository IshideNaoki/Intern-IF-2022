namespace 成績表示
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private List<string[]> students = new List<string[]>();
        private void button_Display_Click(object sender, EventArgs e)
        {
            readData();
            displayData();
        }
        private void readData() 
        { 
            students.Clear();
            
            
            StreamReader sr1 = new StreamReader("C:\\Users\\admin\\source\\repos\\Intern-IF-2022\\Intern-Practice\\第5号\\練習4\\成績表示\\成績表示\\生徒名.txt");
            StreamReader sr2 = new StreamReader("C:\\Users\\admin\\source\\repos\\Intern-IF-2022\\Intern-Practice\\第5号\\練習4\\成績表示\\成績表示\\成績.txt");




            while ((-1 < sr1.Peek())&&(-1<sr2.Peek()))
            {
                string[] s1 = sr1.ReadLine().Split(' ');
                string[] s2 = sr2.ReadLine().Split(' ');

                string[] product = { s1[0], s1[1], s2[1], s2[2], s2[3] };
                students.Add(product);
            }
            sr1.Close();
            
            
        }
        private void displayData() 
        { 
            listView1.Items.Clear();
            for(int i = 0; i < students.Count; i++) 
            {
                string[] product = students[i];
                int total = int.Parse(product[2]) + int.Parse(product[3]) + int.Parse(product[4]);
                string[] displayProduct = { product[0], product[1], product[2], product[3], product[4], total.ToString()};

                ListViewItem item = new ListViewItem(displayProduct);
                listView1.Items.Add(item);
            
            }
        }
    }
}