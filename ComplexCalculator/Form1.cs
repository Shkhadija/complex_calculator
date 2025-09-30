namespace ComplexCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0, num2 = 0;
        string operation = "";
        private void button14_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(richTextBox1.Text);
            double result = 0;

            if (operation == "+") result = num1 + num2;
            else if (operation == "-") result = num1 - num2;
            else if (operation == "*") result = num1 * num2;
            else if (operation == "/")
            {
                if (num2 != 0) result = num1 / num2;
                else MessageBox.Show("Cannot divide by zero");
            }
            else if (operation == "%") result = num1 % num2;
            richTextBox1.Text = result.ToString();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (richTextBox1.Text == "0")
                richTextBox1.Text = b.Text;
            else
                richTextBox1.Text += b.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            num1 = double.Parse(richTextBox1.Text);
            operation = b.Text;
            richTextBox1.Text = "0";
        }

        private void CE_button_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";

        }

        private void C_button_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            operation = "";
        }

        private void Sqr_button_Click(object sender, EventArgs e)
        {
            double n = double.Parse(richTextBox1.Text);
            richTextBox1.Text = Math.Sqrt(n).ToString();
        }
    }
}
