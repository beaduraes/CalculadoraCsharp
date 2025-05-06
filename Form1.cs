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
                    display.Text += " + ";
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
            string text = display.Text.Trim();

            // Caso especial: √(n)
            if (text.StartsWith("√(") && text.EndsWith(")"))
            {
                // Extrai o que está dentro dos parênteses
                string inside = text.Substring(2, text.Length - 3);
                if (!double.TryParse(inside, out v1))
                {
                    MessageBox.Show("Não foi possível converter o valor dentro de √().",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Cálculo da raiz quadrada
                if (v1 < 0)
                {
                    MessageBox.Show("Raiz quadrada de número negativo não é permitida.", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                resp = Math.Sqrt(v1);
                display.Text = resp.ToString();
                virgula = (resp % 1) != 0;
                return;
            }

            // Se não for √, segue o fluxo normal de "num operador num"
            var partes = text.Split(' ');
            if (partes.Length != 3)
            {
                MessageBox.Show("Formato inválido. Use: número [espaço] operador [espaço] número",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(partes[0], out v1) ||
                !double.TryParse(partes[2], out v2))
            {
                MessageBox.Show("Não foi possível converter um dos operandos para número.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string op = partes[1];
            switch (op)
            {
                case "+":
                    resp = v1 + v2;
                    break;
                case "-":
                    resp = v1 - v2;
                    break;
                case "x":
                case "*":
                    resp = v1 * v2;
                    break;
                case "÷":
                case "/":
                    if (v2 == 0)
                    {
                        MessageBox.Show("Divisão por zero não é permitida.", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resp = v1 / v2;
                    break;
                case "%":
                    resp = Math.Round((v1 / 100) * v2, 5);
                    break;
                case "^":
                    resp = Math.Pow(v1, v2);
                    break;
                default:
                    MessageBox.Show($"Operador '{op}' não reconhecido.", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            display.Text = resp.ToString();
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
                    display.Text += " - ";
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
                    display.Text += " x ";
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
                    display.Text += " ÷ ";
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
            // Só procede se o display contiver um número válido
            if (double.TryParse(display.Text, out v1))
            {
                operacao = 5;
                display.Text += " % ";  // adiciona o operador com espaços
                virgula = false;
            }
            else
            {
                MessageBox.Show("Erro no formato do número", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bExponenciacao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(display.Text, out v1))
            {
                if (v1 == 0)
                {
                    // Zero elevado a algo pode dar erro, dependendo do expoente depois
                    MessageBox.Show("Cuidado: 0 elevado a 0 ou expoente negativo é indefinido ou infinito.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (v1 < 0)
                {
                    MessageBox.Show("Aviso: potências com base negativa podem gerar resultados inválidos se o expoente for fracionário.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                operacao = 6;
                display.Text += " ^ ";
                virgula = false;
            }
            else
            {
                MessageBox.Show("Erro no formato do número", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void bRaiz_Click(object sender, EventArgs e)
        {
            double value = 0;

            // Se o display não estiver vazio, tenta converter para número
            if (!string.IsNullOrWhiteSpace(display.Text))
            {
                if (!double.TryParse(display.Text, out value))
                {
                    MessageBox.Show("Erro no formato do número", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Agora 'value' é 0 se estava vazio, ou o número que o usuário digitou
            operacao = 7;
            v1 = value;

            // Exibe √(v1)
            display.Text = $"√({v1})";

            // Reset da vírgula
            virgula = false;
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
            var text = display.Text;
            if (string.IsNullOrWhiteSpace(text))
                return;

            // Divide em partes separadas por espaço
            var parts = text.Split(' ');

            if (parts.Length == 1)
            {
                // Caso simples: só um número
                if (double.TryParse(parts[0], out double val))
                {
                    val = -val;
                    display.Text = val.ToString();
                    virgula = (val % 1) != 0;
                }
            }
            else if (parts.Length == 3)
            {
                // Já existe operador e segundo operando: inverte sinal do segundo
                string op = parts[1];
                if (double.TryParse(parts[2], out double val2))
                {
                    val2 = -val2;
                    display.Text = $"{parts[0]} {op} {val2}";
                    virgula = (val2 % 1) != 0;
                }
            }
            else if (text.EndsWith(" "))
            {
                // Acabou de inserir o operador, começa expoente negativo
                display.Text += "-";
                virgula = false;
            }
        }


        private void bBackspace_Click(object sender, EventArgs e)
        {
                var text = display.Text;
            if (string.IsNullOrEmpty(text))
                return;

            // Se terminar num espaço, é sinal de que sobrou " <op> ",
            // então removemos esses 3 caracteres de uma vez
            if (text.Length >= 3 && text.EndsWith(" "))
            {
                display.Text = text.Substring(0, text.Length - 3);
            }
            else
            {
                // senão, apaga apenas o último caractere
                display.Text = text.Substring(0, text.Length - 1);
            }

            // Atualiza a flag de vírgula: se ainda existir ',' no texto
            virgula = display.Text.Contains(",");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
