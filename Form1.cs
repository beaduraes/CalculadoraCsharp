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
				catch(System.FormatException exp){
					MessageBox.Show("Erro no formato do número!");

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
			virgula=false;
			v1 = 0;
			v2 = 0;
		}
	}
}
