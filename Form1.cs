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
            if (!double.TryParse(display.Text, out double v2))
            {
                MessageBox.Show("Entrada inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (operacao)
            {
                case 1: // Soma
                    resp = v1 + v2;
                    break;

                case 2: // Subtração
                    resp = v1 - v2;
                    break;

                case 3: // Multiplicação
                    resp = v1 * v2;
                    break;

                case 4: // Divisão
                    if (v2 == 0)
                    {
                        MessageBox.Show("Divisão por zero não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resp = v1 / v2;
                    break;

                default:
                    MessageBox.Show("Operação não reconhecida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            display.Text = resp.ToString();
            virgula = (resp % 1) != 0;
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

        private void bsub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 2;
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

        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 3;
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

        private void button12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 4;
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

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreditos formCreditos = new FormCreditos();
            formCreditos.ShowDialog();
        }
    }
}
