namespace test004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strdent = new string[5];
            strdent[0] = "นิเขต";
            strdent[1] = "นิปอ";
            strdent[2] = "นิหนวด";
            strdent[3] = "นิบิว";
            strdent[4] = "นิอ้วน";
            string test_1 = "";
            int n = strdent.Length;
            for (int i = 0; i < n; i++)
            {
                test_1 += strdent[i] + Environment.NewLine;
            }
            MessageBox.Show(test_1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "ส้ม", "กล้วย" };
            string myFruits = "";
            foreach (string str in Fruits)
            {
                myFruits += str + ", ";

            }
            MessageBox.Show(myFruits);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data_1 = textBox1.Lines; //Linesคือข้อมูลแต่ละบรรบัด
            string result = "";

            foreach (string str in data_1)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }
            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data_2 = textBox1.Lines;
            string result = "";
            int sum_2 = 0;

            foreach (string str in data_2)
            {
                int a = 0;
                if (int.TryParse(str, out a))
                {
                    sum_2 += a;
                    result += a.ToString() + Environment.NewLine;

                }

            }
            label1.Text = result + "ผลรวม" + sum_2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "1";
            student[0, 1] = "2";
            student[1, 0] = "3";
            student[1, 1] = "4";
            student[2, 0] = "5";
            student[2, 1] = "6";
            string ResultData = "";
            int a1 = student.GetLength(0);
            int a2 = student.GetLength(1);
            for (int i = 0; i < a1; i++)
            {
                for (int j = 0; j < a2; j++)
                {
                    ResultData += student[i, j];
                    if (j == 0)
                    {
                        ResultData += "-";
                    }
                }
                ResultData += Environment.NewLine;
            }

            MessageBox.Show(ResultData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruits = { "ส้ม", "กล้วย", "แมว" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + ")";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString() + ")";
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}
