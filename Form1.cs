namespace CalculadoraBase
{
    public partial class Form1 : Form
    {
        double v1, v2, resp;
        bool virgula = false;
        int operacao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void bvirgula_Click(object sender, EventArgs e)
        {
            if (!virgula)
            {
                display.Text = display.Text + ",";
                virgula = true;
            }
        }

        private void bsoma_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 1;
                    v1 = Double.Parse(display.Text);
                    display.Text = "";
                    virgula = false;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Erro no formato do número");

                }
            }
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            if (operacao == 1)
            {
                v2 = Double.Parse(display.Text);
                resp = v1 + v2;
                display.Text = resp.ToString();
                if ((int)resp < resp)
                {
                    virgula = true;
                }
                else
                {
                    virgula = false;
                }
            }
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            virgula = false;
            v1 = 0;
            v2 = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click_1(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }
    }
}
