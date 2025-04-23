namespace CalculadoraBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			display = new TextBox();
			b1 = new Button();
			bsoma = new Button();
			bigual = new Button();
			bvirgula = new Button();
			bclear = new Button();
			SuspendLayout();
			// 
			// display
			// 
			display.Location = new Point(14, 34);
			display.Name = "display";
			display.ReadOnly = true;
			display.Size = new Size(153, 27);
			display.TabIndex = 0;
			// 
			// b1
			// 
			b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			b1.Location = new Point(109, 170);
			b1.Name = "b1";
			b1.Size = new Size(36, 29);
			b1.TabIndex = 1;
			b1.Text = "1";
			b1.UseVisualStyleBackColor = true;
			b1.Click += b1_Click;
			// 
			// bsoma
			// 
			bsoma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			bsoma.Location = new Point(166, 67);
			bsoma.Name = "bsoma";
			bsoma.Size = new Size(36, 29);
			bsoma.TabIndex = 2;
			bsoma.Text = "+";
			bsoma.TextAlign = ContentAlignment.BottomCenter;
			bsoma.UseVisualStyleBackColor = true;
			bsoma.Click += bsoma_Click;
			// 
			// bigual
			// 
			bigual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			bigual.Location = new Point(166, 170);
			bigual.Name = "bigual";
			bigual.Size = new Size(36, 29);
			bigual.TabIndex = 3;
			bigual.Text = "=";
			bigual.TextAlign = ContentAlignment.BottomCenter;
			bigual.UseVisualStyleBackColor = true;
			bigual.Click += bigual_Click;
			// 
			// bvirgula
			// 
			bvirgula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			bvirgula.Location = new Point(166, 135);
			bvirgula.Name = "bvirgula";
			bvirgula.Size = new Size(36, 29);
			bvirgula.TabIndex = 4;
			bvirgula.Text = ",";
			bvirgula.TextAlign = ContentAlignment.BottomCenter;
			bvirgula.UseVisualStyleBackColor = true;
			bvirgula.Click += bvirgula_Click;
			// 
			// bclear
			// 
			bclear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			bclear.Location = new Point(166, 32);
			bclear.Name = "bclear";
			bclear.Size = new Size(36, 29);
			bclear.TabIndex = 5;
			bclear.Text = "C";
			bclear.TextAlign = ContentAlignment.BottomCenter;
			bclear.UseVisualStyleBackColor = true;
			bclear.Click += bclear_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(314, 288);
			Controls.Add(bclear);
			Controls.Add(bvirgula);
			Controls.Add(bigual);
			Controls.Add(bsoma);
			Controls.Add(b1);
			Controls.Add(display);
			Name = "Form1";
			Text = "Calculadora Base";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox display;
		private Button b1;
		private Button bsoma;
		private Button bigual;
		private Button bvirgula;
		private Button bclear;
	}
}
