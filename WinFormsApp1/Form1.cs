namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int.TryParse(textBox1.Text, out int parameter1);
            int.TryParse(textBox2.Text, out int parameter2);
            Fibonacci(parameter1, parameter2 );
        }

        public void Fibonacci(int parameter1, int parameter2)
        {
            int var1 = parameter1;
            int var2 = 0;
            int var3 = 0;
            bool printFirst = false;
            while (true)
            {
                if (var1 == parameter1 && !printFirst)
                {
                    Print(var1);
                    var2 = var1 + var1;
                    Print(var2);
                    printFirst = true;
                }
                else
                {
                    var3 = var1 + var2;
                    Print(var3);
                    var1 = var2;
                    var2 = var3;
                }

                if (var3 >= parameter2)
                { break; }
            }
        }

        public void Print(int parameter)
        {
            listView1.Items.Add($"{parameter}");
        }
    }
}
