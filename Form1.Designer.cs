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
            bigual = new Button();
            bvirgula = new Button();
            b1 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            bsoma = new Button();
            bsub = new Button();
            bmult = new Button();
            bporcento = new Button();
            bdiv = new Button();
            bclear = new Button();
            babsolute = new Button();
            braiz = new Button();
            bpotencia = new Button();
            bquadrado = new Button();
            bbackspace = new Button();
            bfatorial = new Button();
            bnegepos = new Button();
            b2 = new Button();
            b0 = new Button();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            créditosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.Location = new Point(8, 24);
            display.Multiline = true;
            display.Name = "display";
            display.ReadOnly = true;
            display.Size = new Size(221, 45);
            display.TabIndex = 0;
            display.TextChanged += display_TextChanged;
            // 
            // bigual
            // 
            bigual.AutoSize = true;
            bigual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bigual.Location = new Point(173, 212);
            bigual.Name = "bigual";
            bigual.Size = new Size(43, 40);
            bigual.TabIndex = 3;
            bigual.Text = "=";
            bigual.TextAlign = ContentAlignment.BottomCenter;
            bigual.UseVisualStyleBackColor = true;
            bigual.Click += bigual_Click;
            // 
            // bvirgula
            // 
            bvirgula.AutoSize = true;
            bvirgula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bvirgula.Location = new Point(131, 211);
            bvirgula.Name = "bvirgula";
            bvirgula.Size = new Size(34, 40);
            bvirgula.TabIndex = 4;
            bvirgula.Text = ",";
            bvirgula.TextAlign = ContentAlignment.BottomCenter;
            bvirgula.UseVisualStyleBackColor = true;
            bvirgula.Click += bVirgula_Click;
            // 
            // b1
            // 
            b1.AutoSize = true;
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b1.Location = new Point(8, 167);
            b1.Name = "b1";
            b1.Size = new Size(34, 40);
            b1.TabIndex = 6;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b3
            // 
            b3.AutoSize = true;
            b3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b3.Location = new Point(90, 169);
            b3.Name = "b3";
            b3.Size = new Size(34, 40);
            b3.TabIndex = 8;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.AutoSize = true;
            b4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b4.Location = new Point(8, 121);
            b4.Name = "b4";
            b4.Size = new Size(34, 40);
            b4.TabIndex = 9;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.AutoSize = true;
            b5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b5.Location = new Point(49, 121);
            b5.Name = "b5";
            b5.Size = new Size(34, 40);
            b5.TabIndex = 10;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.AutoSize = true;
            b6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b6.Location = new Point(90, 121);
            b6.Name = "b6";
            b6.Size = new Size(34, 40);
            b6.TabIndex = 11;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b7
            // 
            b7.AutoSize = true;
            b7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b7.Location = new Point(8, 76);
            b7.Name = "b7";
            b7.Size = new Size(34, 40);
            b7.TabIndex = 12;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.AutoSize = true;
            b8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b8.Location = new Point(49, 76);
            b8.Name = "b8";
            b8.Size = new Size(34, 40);
            b8.TabIndex = 13;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.AutoSize = true;
            b9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b9.Location = new Point(90, 76);
            b9.Name = "b9";
            b9.Size = new Size(34, 40);
            b9.TabIndex = 14;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // bsoma
            // 
            bsoma.AutoSize = true;
            bsoma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bsoma.Location = new Point(131, 76);
            bsoma.Name = "bsoma";
            bsoma.Size = new Size(34, 40);
            bsoma.TabIndex = 2;
            bsoma.Text = "+";
            bsoma.TextAlign = ContentAlignment.BottomCenter;
            bsoma.UseVisualStyleBackColor = true;
            bsoma.Click += bsoma_Click;
            // 
            // bsub
            // 
            bsub.AutoSize = true;
            bsub.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bsub.Location = new Point(131, 169);
            bsub.Name = "bsub";
            bsub.Size = new Size(34, 40);
            bsub.TabIndex = 16;
            bsub.Text = "-";
            bsub.TextAlign = ContentAlignment.BottomCenter;
            bsub.UseVisualStyleBackColor = true;
            bsub.Click += bsub_Click;
            // 
            // bmult
            // 
            bmult.AutoSize = true;
            bmult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bmult.Location = new Point(131, 121);
            bmult.Name = "bmult";
            bmult.Size = new Size(34, 40);
            bmult.TabIndex = 17;
            bmult.Text = "*";
            bmult.TextAlign = ContentAlignment.BottomCenter;
            bmult.UseVisualStyleBackColor = true;
            bmult.Click += bMult_Click;
            // 
            // bporcento
            // 
            bporcento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bporcento.Location = new Point(8, 212);
            bporcento.Name = "bporcento";
            bporcento.Size = new Size(34, 40);
            bporcento.TabIndex = 19;
            bporcento.Text = "%";
            bporcento.TextAlign = ContentAlignment.BottomCenter;
            bporcento.UseVisualStyleBackColor = true;
            bporcento.Click += bPorcento_Click;
            // 
            // bdiv
            // 
            bdiv.AutoSize = true;
            bdiv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bdiv.Location = new Point(90, 211);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(34, 40);
            bdiv.TabIndex = 18;
            bdiv.Text = "/";
            bdiv.TextAlign = ContentAlignment.BottomCenter;
            bdiv.UseVisualStyleBackColor = true;
            bdiv.Click += bDivisao_Click;
            // 
            // bclear
            // 
            bclear.AutoSize = true;
            bclear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bclear.Location = new Point(231, 25);
            bclear.Name = "bclear";
            bclear.Size = new Size(47, 40);
            bclear.TabIndex = 5;
            bclear.Text = "C";
            bclear.TextAlign = ContentAlignment.BottomCenter;
            bclear.UseVisualStyleBackColor = true;
            bclear.Click += bClear_Click;
            // 
            // babsolute
            // 
            babsolute.AutoSize = true;
            babsolute.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            babsolute.Location = new Point(231, 125);
            babsolute.Name = "babsolute";
            babsolute.Size = new Size(47, 40);
            babsolute.TabIndex = 20;
            babsolute.Text = "|X|";
            babsolute.TextAlign = ContentAlignment.BottomCenter;
            babsolute.UseVisualStyleBackColor = true;
            babsolute.Click += bAbsolute_Click;
            // 
            // braiz
            // 
            braiz.AutoSize = true;
            braiz.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            braiz.Location = new Point(173, 76);
            braiz.Name = "braiz";
            braiz.Size = new Size(43, 40);
            braiz.TabIndex = 21;
            braiz.Text = "√";
            braiz.TextAlign = ContentAlignment.BottomCenter;
            braiz.UseVisualStyleBackColor = true;
            braiz.Click += bRaiz_Click;
            // 
            // bpotencia
            // 
            bpotencia.AutoSize = true;
            bpotencia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bpotencia.Location = new Point(173, 121);
            bpotencia.Name = "bpotencia";
            bpotencia.Size = new Size(43, 40);
            bpotencia.TabIndex = 22;
            bpotencia.Text = "xʸ";
            bpotencia.TextAlign = ContentAlignment.BottomCenter;
            bpotencia.UseVisualStyleBackColor = true;
            bpotencia.Click += bExponenciacao_Click;
            // 
            // bquadrado
            // 
            bquadrado.AutoSize = true;
            bquadrado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bquadrado.Location = new Point(173, 167);
            bquadrado.Name = "bquadrado";
            bquadrado.Size = new Size(43, 40);
            bquadrado.TabIndex = 23;
            bquadrado.Text = "x²";
            bquadrado.TextAlign = ContentAlignment.BottomCenter;
            bquadrado.UseVisualStyleBackColor = true;
            bquadrado.Click += bQuadrado_Click;
            // 
            // bbackspace
            // 
            bbackspace.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bbackspace.Location = new Point(231, 80);
            bbackspace.Name = "bbackspace";
            bbackspace.Size = new Size(47, 40);
            bbackspace.TabIndex = 15;
            bbackspace.Text = "CE";
            bbackspace.TextAlign = ContentAlignment.BottomCenter;
            bbackspace.UseVisualStyleBackColor = true;
            bbackspace.Click += bBackspace_Click;
            // 
            // bfatorial
            // 
            bfatorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bfatorial.Location = new Point(227, 171);
            bfatorial.Name = "bfatorial";
            bfatorial.Size = new Size(47, 40);
            bfatorial.TabIndex = 24;
            bfatorial.Text = "N!";
            bfatorial.TextAlign = ContentAlignment.BottomCenter;
            bfatorial.UseVisualStyleBackColor = true;
            bfatorial.Click += bFatoracao_Click;
            // 
            // bnegepos
            // 
            bnegepos.AutoSize = true;
            bnegepos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bnegepos.Location = new Point(227, 216);
            bnegepos.Name = "bnegepos";
            bnegepos.Size = new Size(47, 40);
            bnegepos.TabIndex = 25;
            bnegepos.Text = "+/-";
            bnegepos.TextAlign = ContentAlignment.BottomCenter;
            bnegepos.UseVisualStyleBackColor = true;
            bnegepos.Click += bNegpos_Click;
            // 
            // b2
            // 
            b2.AutoSize = true;
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b2.Location = new Point(49, 169);
            b2.Name = "b2";
            b2.Size = new Size(34, 40);
            b2.TabIndex = 7;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b0
            // 
            b0.AutoSize = true;
            b0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b0.Location = new Point(49, 213);
            b0.Name = "b0";
            b0.Size = new Size(34, 40);
            b0.TabIndex = 26;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(290, 30);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { créditosToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(62, 24);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // créditosToolStripMenuItem
            // 
            créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            créditosToolStripMenuItem.Size = new Size(224, 26);
            créditosToolStripMenuItem.Text = "Créditos";
            créditosToolStripMenuItem.Click += creditosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(290, 277);
            Controls.Add(b0);
            Controls.Add(bnegepos);
            Controls.Add(bfatorial);
            Controls.Add(bquadrado);
            Controls.Add(bpotencia);
            Controls.Add(braiz);
            Controls.Add(babsolute);
            Controls.Add(bporcento);
            Controls.Add(bdiv);
            Controls.Add(bmult);
            Controls.Add(bsub);
            Controls.Add(bbackspace);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(bclear);
            Controls.Add(bvirgula);
            Controls.Add(bigual);
            Controls.Add(bsoma);
            Controls.Add(display);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculadora Base";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
		private Button bigual;
		private Button bvirgula;
        private Button b1;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button bsoma;
        private Button bsub;
        private Button bmult;
        private Button bporcento;
        private Button bdiv;
        private Button bclear;
        private Button babsolute;
        private Button braiz;
        private Button bpotencia;
        private Button bquadrado;
        private Button bbackspace;
        private Button bfatorial;
        private Button bnegepos;
        private Button b2;
        private Button b0;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem créditosToolStripMenuItem;
    }
}
