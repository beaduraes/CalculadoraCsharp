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

        private void bVirgula_Click(object sender, EventArgs e)
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
            // Verifica se o valor digitado pode ser convertido para número
            if (!double.TryParse(display.Text, out double v2))
            {
                MessageBox.Show("Entrada inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Executa a operação com base no código salvo em 'operacao'
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
                case 5: // Porcentagem
                    if (v1 == 0)
                    {
                        MessageBox.Show("Valor base igual a zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resp = Math.Round((v1 / 100) * v2, 5);
                    break;
                case 6: // Exponenciação
                    if (v1 < 0)
                    {
                        MessageBox.Show("Base negativa não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (v2 < 0)
                    {
                        MessageBox.Show("Expoente negativo não é permitido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    resp = (v1 == 0 && v2 == 0) ? 1 : Math.Pow(v1, v2); // 0^0 definido como 1
                    break;
                case 7: // Radiciação

                    if (v1 < 0 && v2 % 2 == 0)
                    {
                        MessageBox.Show("Raiz de número negativo não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (v2 == 0)
                    {
                        MessageBox.Show("Raiz de zero não é permitida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    resp = (v1 == 0 && v2 == 0) ? 1 : Math.Pow(v1, 1.0 / v2);
                    if (v1 == 0 && v2 == 0) resp = 1;
                    break;
                default:
                    MessageBox.Show("Operação não reconhecida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            display.Text = $"{resp}";
            virgula = (resp % 1) != 0;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            virgula = false;
            v1 = 0;
            v2 = 0;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
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

        private void bMult_Click(object sender, EventArgs e)
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

        private void bDivisao_Click(object sender, EventArgs e)
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

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreditos formCreditos = new FormCreditos();
            formCreditos.ShowDialog();
        }

        private void bPorcento_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 5;
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

        private void bQuadrado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    v1 = Double.Parse(display.Text);
                    resp = Math.Pow(v1, 2);
                    display.Text = $"{resp}";
                    virgula = false;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Erro no formato do número");

                }
            }

        }

        private void bPotenciacao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 6;



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

        private void bRaiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    operacao = 7;
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

        private void bFatoracao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    v1 = Double.Parse(display.Text);

                    if (v1 < 0)
                    {
                        MessageBox.Show("Fatorial de número negativo não é permitido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (v1 % 1 != 0)
                    {
                        MessageBox.Show("Fatorial de número não inteiro não é permitido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (v1 == 0)
                    {
                        resp = 1;
                    }

                    else
                    {
                        resp = 1;
                        for (int i = 1; i <= v1; i++)
                        {
                            resp *= i;
                        }
                    }

                    display.Text = $"{resp}";
                    virgula = false;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Erro no formato do número");

                }
            }
        }

        private void bAbsolute_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    resp = Double.Parse(display.Text);
                    resp = Math.Abs(resp);
                    display.Text = $"{resp}";
                    virgula = false;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Erro no formato do número");

                }
            }
        }

        private void bNegpos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    resp = Double.Parse(display.Text);
                    display.Text = $"{resp * -1}";
                    virgula = false;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Erro no formato do número");

                }
            }
        }

        private void bBackspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(display.Text))
            {
                try
                {
                    resp = Double.Parse(display.Text);
                    String stringResp = resp.ToString();
                    display.Text = $"{stringResp.Remove(stringResp.Length - 1)}";
                    virgula = false;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Erro no formato do número");

                }
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
