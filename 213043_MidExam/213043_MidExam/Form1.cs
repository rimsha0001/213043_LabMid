namespace _213043_MidExam
{
    public partial class Form1 : Form
    {
        //int sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            int sum = 0;
            if (checkBox1.Checked == true)
            {
                int salaad = 150;
                sum = sum + 150;
            }
            if(checkBox2.Checked == true)
            {
                int  Wedges= 200;
                sum = sum+ 200;
            }
            if(checkBox3.Checked == true)
            {
                int soup = 500;
                sum = sum + 500;
            }
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            string msg1 = "";
            if (checkBox3.Checked == true)
            {
                int Chiken = 1000;
            }
            if (checkBox4.Checked == true)
            {
                int Rice = 2000;
            }
            if (checkBox5.Checked == true)
            {
                int chowmein = 1500;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sum;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            string msg2 = "";
            if (checkBox6.Checked == true)
            {
                int Cream = 150;
            }
            if (checkBox7.Checked == true)
            {
                int brownie = 300;
            }
            if (checkBox8.Checked == true)
            {
                int kulfi = 400;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(" ", sum);
        }
       private  void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total" + sum);
        }

    }
}
/