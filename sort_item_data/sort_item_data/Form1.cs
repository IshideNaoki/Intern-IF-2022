namespace sort_item_data
{
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        //1.�\���{�^�����������i�f�[�^.txt��I������
        //2.���i�f�[�^.txt�̓��e��ListView�ɕ\��������
        //3.�R���{�{�b�N�X�ŏ����������͍~����I������
        //3-1 �����Ȃ獇�v���L�[�Ƃ��ď����ɕ��בւ���(���i���A�P���A���A���v)
        //3-2 �~���Ȃ獇�v���L�[�Ƃ��č~���ɕ��בւ���(���i���A�P���A���A���v)
        //3-3 �����A�~���ȊO�̓��e���R���{�{�b�N�X�œ��͂����MessageBox�ŃG���[�ł���ƒm�点��

        private List<string[]> products = new List<string[]>();

        //1.�\���{�^�����������i�f�[�^.txt��I������
        private void button_Display_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            readData(this.openFileDialog.FileName);

            this.comboBox_sort_select.Visible = true;
            this.button_sort.Visible= true;

            displayData();
        }

        private void readData(string fileName) 
        {
            this.products.Clear();
            
            StreamReader sr = new StreamReader(fileName);

            while(-1 < sr.Peek())
            {
                string[] prouct = sr.ReadLine().Split(' ');

                this.products.Add(prouct);
            }

            sr.Close();
        }
        //2.���i�f�[�^.txt�̓��e��ListView�ɕ\��������
        private void displayData() 
        { 
            this.listView_Display.Items.Clear();

            for(int i = 0;i < this.products.Count;i++) 
            {
                string[] product = this.products[i];
                
                int total = int.Parse(product[1]) * int.Parse(product[2]);

                string[] displayProducts = { product[0], product[1], product[2], total.ToString() };

                ListViewItem item = new ListViewItem(displayProducts);

                this.listView_Display.Items.Add(item);
            }
        }
        //3.�R���{�{�b�N�X�ŏ����������͍~����I������
        private void button_sort_Click(object sender, EventArgs e)
        {
            if(this.comboBox_sort_select.Text == "����")
            {
                List_Data_asc();
                
            }else if(this.comboBox_sort_select.Text == "�~��")
            {
                List_Data_desc();
            }
            else //�R���{�{�b�N�X���ɕ�������͂��邱�Ƃ��ł��邽��
                //�����A�~���ȊO����͂�����button_sort�������ꂽ�ۂɃG���[�{�b�N�X��\������
            {
                MessageBox.Show("�����������͍~����I�����Ă��������B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayData();
        }

        //�����\�[�g
        private void List_Data_asc()
        {
            for(int i = 0; i < this.products.Count;i++) 
            { 
                for(int j = this.products.Count -1; j > i; j--)
                {
                    int total1 = int.Parse(products[j][1]) * int.Parse(products[j][2]);
                    int total2 = int.Parse(products[j - 1][1]) * int.Parse(products[j - 1][2]);

                    if (total1 < total2)
                    {
                        string[] tmp = this.products[j - 1];
                        this.products[j - 1] = this.products[j];
                        this.products[j] = tmp;
                    }
                }
            }
        }

        //�~���\�[�g
        private void List_Data_desc()
        {
            for (int i = 0; i < this.products.Count; i++)
            {
                for (int j = this.products.Count - 1; j > i; j--)
                {
                    int total1 = int.Parse(products[j][1]) * int.Parse(products[j][2]);
                    int total2 = int.Parse(products[j - 1][1]) * int.Parse(products[j - 1][2]);

                    if (total1 > total2)
                    {
                        string[] tmp = this.products[j - 1];
                        this.products[j - 1] = this.products[j];
                        this.products[j] = tmp;
                    }
                }
            }
        }
    }
}