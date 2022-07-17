// using System.Globalization;

namespace CalculadoraSPortifolio
{
    public partial class Form1 : Form
    {

        decimal valor1 = 0;
        decimal valor2 = 0;
        decimal resultado;
        string Operacao = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void visorResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(visorResultado.Text);
            Operacao = "+";
            visorResultado.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(Operacao == "+")
            {
                valor2 = Decimal.Parse(visorResultado.Text);
                resultado = valor1 + valor2;
                visorResultado.Text = resultado.ToString();
            }
            else if(Operacao == "-")
            {
                valor2 = Decimal.Parse(visorResultado.Text);
                resultado = valor1 - valor2;
                visorResultado.Text = resultado.ToString();

            }
            else if(Operacao == "x")
            {
                valor2 = Decimal.Parse(visorResultado.Text);
                resultado = valor1 * valor2;
                visorResultado.Text = resultado.ToString();
            }else if(Operacao == "/")
            {
                valor2 = Decimal.Parse(visorResultado.Text);
                resultado = valor1 / valor2;
                visorResultado.Text = resultado.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "8";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            visorResultado.Text += "4";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            visorResultado.Text += ".";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            visorResultado.Text = "";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(visorResultado.Text);
            Operacao = "-";
            visorResultado.Text = "";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(visorResultado.Text);
            Operacao = "x";
            visorResultado.Text = "";
        }

        private void buttonDivi_Click(object sender, EventArgs e)
        {
            valor1 = Decimal.Parse(visorResultado.Text);
            Operacao = "/";
            visorResultado.Text = "";
            //look the stars tonight
        }
    }
}