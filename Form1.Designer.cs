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
            display.BackColor = Color.Black;
            display.BorderStyle = BorderStyle.FixedSingle;
            display.ForeColor = Color.White;
            display.Location = new Point(12, 22);
            display.Margin = new Padding(3, 2, 3, 2);
            display.Multiline = true;
            display.Name = "display";
            display.ReadOnly = true;
            display.Size = new Size(194, 27);
            display.TabIndex = 0;
            display.TextChanged += display_TextChanged;
            // 
            // bigual
            // 
            bigual.AutoSize = true;
            bigual.BackColor = Color.White;
            bigual.FlatStyle = FlatStyle.Popup;
            bigual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bigual.ForeColor = Color.Black;
            bigual.Location = new Point(175, 176);
            bigual.Margin = new Padding(3, 2, 3, 2);
            bigual.Name = "bigual";
            bigual.Size = new Size(38, 30);
            bigual.TabIndex = 3;
            bigual.Text = "=";
            bigual.TextAlign = ContentAlignment.BottomCenter;
            bigual.UseVisualStyleBackColor = false;
            bigual.Click += bigual_Click;
            // 
            // bvirgula
            // 
            bvirgula.AutoSize = true;
            bvirgula.BackColor = Color.White;
            bvirgula.FlatStyle = FlatStyle.Popup;
            bvirgula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bvirgula.ForeColor = Color.Black;
            bvirgula.Location = new Point(139, 176);
            bvirgula.Margin = new Padding(3, 2, 3, 2);
            bvirgula.Name = "bvirgula";
            bvirgula.Size = new Size(30, 30);
            bvirgula.TabIndex = 4;
            bvirgula.Text = ",";
            bvirgula.TextAlign = ContentAlignment.BottomCenter;
            bvirgula.UseVisualStyleBackColor = false;
            bvirgula.Click += bVirgula_Click;
            // 
            // b1
            // 
            b1.AutoSize = true;
            b1.BackColor = Color.White;
            b1.FlatStyle = FlatStyle.Popup;
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b1.ForeColor = Color.Black;
            b1.Location = new Point(12, 142);
            b1.Margin = new Padding(3, 2, 3, 2);
            b1.Name = "b1";
            b1.Size = new Size(30, 30);
            b1.TabIndex = 6;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // b3
            // 
            b3.AutoSize = true;
            b3.BackColor = Color.White;
            b3.FlatStyle = FlatStyle.Popup;
            b3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b3.Location = new Point(103, 134);
            b3.Margin = new Padding(3, 2, 3, 2);
            b3.Name = "b3";
            b3.Size = new Size(30, 30);
            b3.TabIndex = 8;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = false;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.AutoSize = true;
            b4.BackColor = Color.White;
            b4.FlatStyle = FlatStyle.Popup;
            b4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b4.Location = new Point(12, 100);
            b4.Margin = new Padding(3, 2, 3, 2);
            b4.Name = "b4";
            b4.Size = new Size(30, 30);
            b4.TabIndex = 9;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = false;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.AutoSize = true;
            b5.BackColor = Color.White;
            b5.FlatStyle = FlatStyle.Popup;
            b5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b5.Location = new Point(58, 100);
            b5.Margin = new Padding(3, 2, 3, 2);
            b5.Name = "b5";
            b5.Size = new Size(30, 30);
            b5.TabIndex = 10;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.AutoSize = true;
            b6.BackColor = Color.White;
            b6.FlatStyle = FlatStyle.Popup;
            b6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b6.Location = new Point(103, 97);
            b6.Margin = new Padding(3, 2, 3, 2);
            b6.Name = "b6";
            b6.Size = new Size(30, 30);
            b6.TabIndex = 11;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += b6_Click;
            // 
            // b7
            // 
            b7.AutoSize = true;
            b7.BackColor = Color.White;
            b7.FlatStyle = FlatStyle.Popup;
            b7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b7.ForeColor = Color.Black;
            b7.Location = new Point(12, 60);
            b7.Margin = new Padding(3, 2, 3, 2);
            b7.Name = "b7";
            b7.Size = new Size(30, 30);
            b7.TabIndex = 12;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.AutoSize = true;
            b8.BackColor = Color.White;
            b8.FlatStyle = FlatStyle.Popup;
            b8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b8.Location = new Point(58, 63);
            b8.Margin = new Padding(3, 2, 3, 2);
            b8.Name = "b8";
            b8.Size = new Size(30, 30);
            b8.TabIndex = 13;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.AutoSize = true;
            b9.BackColor = Color.White;
            b9.FlatStyle = FlatStyle.Popup;
            b9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b9.Location = new Point(103, 60);
            b9.Margin = new Padding(3, 2, 3, 2);
            b9.Name = "b9";
            b9.Size = new Size(30, 30);
            b9.TabIndex = 14;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += b9_Click;
            // 
            // bsoma
            // 
            bsoma.AutoSize = true;
            bsoma.BackColor = Color.White;
            bsoma.FlatStyle = FlatStyle.Popup;
            bsoma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bsoma.Location = new Point(139, 60);
            bsoma.Margin = new Padding(3, 2, 3, 2);
            bsoma.Name = "bsoma";
            bsoma.Size = new Size(30, 30);
            bsoma.TabIndex = 2;
            bsoma.Text = "+";
            bsoma.TextAlign = ContentAlignment.BottomCenter;
            bsoma.UseVisualStyleBackColor = false;
            bsoma.Click += bsoma_Click;
            // 
            // bsub
            // 
            bsub.AutoSize = true;
            bsub.BackColor = Color.White;
            bsub.FlatStyle = FlatStyle.Popup;
            bsub.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bsub.Location = new Point(139, 134);
            bsub.Margin = new Padding(3, 2, 3, 2);
            bsub.Name = "bsub";
            bsub.Size = new Size(30, 30);
            bsub.TabIndex = 16;
            bsub.Text = "-";
            bsub.TextAlign = ContentAlignment.BottomCenter;
            bsub.UseVisualStyleBackColor = false;
            bsub.Click += bsub_Click;
            // 
            // bmult
            // 
            bmult.AutoSize = true;
            bmult.BackColor = Color.White;
            bmult.FlatStyle = FlatStyle.Popup;
            bmult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bmult.Location = new Point(139, 97);
            bmult.Margin = new Padding(3, 2, 3, 2);
            bmult.Name = "bmult";
            bmult.Size = new Size(30, 30);
            bmult.TabIndex = 17;
            bmult.Text = "*";
            bmult.TextAlign = ContentAlignment.BottomCenter;
            bmult.UseVisualStyleBackColor = false;
            bmult.Click += bMult_Click;
            // 
            // bporcento
            // 
            bporcento.BackColor = Color.White;
            bporcento.FlatStyle = FlatStyle.Popup;
            bporcento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bporcento.ForeColor = Color.Black;
            bporcento.Location = new Point(12, 179);
            bporcento.Margin = new Padding(3, 2, 3, 2);
            bporcento.Name = "bporcento";
            bporcento.Size = new Size(30, 27);
            bporcento.TabIndex = 19;
            bporcento.Text = "%";
            bporcento.TextAlign = ContentAlignment.BottomCenter;
            bporcento.UseVisualStyleBackColor = false;
            bporcento.Click += bPorcento_Click;
            // 
            // bdiv
            // 
            bdiv.AutoSize = true;
            bdiv.BackColor = Color.White;
            bdiv.FlatStyle = FlatStyle.Popup;
            bdiv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bdiv.ForeColor = Color.Black;
            bdiv.Location = new Point(103, 176);
            bdiv.Margin = new Padding(3, 2, 3, 2);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(30, 30);
            bdiv.TabIndex = 18;
            bdiv.Text = "/";
            bdiv.TextAlign = ContentAlignment.BottomCenter;
            bdiv.UseVisualStyleBackColor = false;
            bdiv.Click += bDivisao_Click;
            // 
            // bclear
            // 
            bclear.AutoSize = true;
            bclear.BackColor = Color.White;
            bclear.FlatStyle = FlatStyle.Popup;
            bclear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bclear.ForeColor = Color.Black;
            bclear.Location = new Point(219, 18);
            bclear.Margin = new Padding(3, 2, 3, 2);
            bclear.Name = "bclear";
            bclear.Size = new Size(41, 31);
            bclear.TabIndex = 5;
            bclear.Text = "C";
            bclear.TextAlign = ContentAlignment.BottomCenter;
            bclear.UseVisualStyleBackColor = false;
            bclear.Click += bClear_Click;
            // 
            // babsolute
            // 
            babsolute.AutoSize = true;
            babsolute.BackColor = Color.White;
            babsolute.FlatStyle = FlatStyle.Popup;
            babsolute.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            babsolute.ForeColor = Color.Black;
            babsolute.Location = new Point(219, 97);
            babsolute.Margin = new Padding(3, 2, 3, 2);
            babsolute.Name = "babsolute";
            babsolute.Size = new Size(41, 30);
            babsolute.TabIndex = 20;
            babsolute.Text = "|X|";
            babsolute.TextAlign = ContentAlignment.BottomCenter;
            babsolute.UseVisualStyleBackColor = false;
            babsolute.Click += bAbsolute_Click;
            // 
            // braiz
            // 
            braiz.AutoSize = true;
            braiz.BackColor = Color.White;
            braiz.FlatStyle = FlatStyle.Popup;
            braiz.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            braiz.Location = new Point(175, 60);
            braiz.Margin = new Padding(3, 2, 3, 2);
            braiz.Name = "braiz";
            braiz.Size = new Size(38, 30);
            braiz.TabIndex = 21;
            braiz.Text = "√";
            braiz.TextAlign = ContentAlignment.BottomCenter;
            braiz.UseVisualStyleBackColor = false;
            braiz.Click += bRaiz_Click;
            // 
            // bpotencia
            // 
            bpotencia.AutoSize = true;
            bpotencia.BackColor = Color.White;
            bpotencia.FlatStyle = FlatStyle.Popup;
            bpotencia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bpotencia.Location = new Point(175, 97);
            bpotencia.Margin = new Padding(3, 2, 3, 2);
            bpotencia.Name = "bpotencia";
            bpotencia.Size = new Size(38, 30);
            bpotencia.TabIndex = 22;
            bpotencia.Text = "xʸ";
            bpotencia.TextAlign = ContentAlignment.BottomCenter;
            bpotencia.UseVisualStyleBackColor = false;
            bpotencia.Click += bExponenciacao_Click;
            // 
            // bquadrado
            // 
            bquadrado.AutoSize = true;
            bquadrado.BackColor = Color.White;
            bquadrado.FlatStyle = FlatStyle.Popup;
            bquadrado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bquadrado.ForeColor = Color.Black;
            bquadrado.Location = new Point(175, 134);
            bquadrado.Margin = new Padding(3, 2, 3, 2);
            bquadrado.Name = "bquadrado";
            bquadrado.Size = new Size(38, 30);
            bquadrado.TabIndex = 23;
            bquadrado.Text = "x²";
            bquadrado.TextAlign = ContentAlignment.BottomCenter;
            bquadrado.UseVisualStyleBackColor = false;
            bquadrado.Click += bQuadrado_Click;
            // 
            // bbackspace
            // 
            bbackspace.BackColor = Color.White;
            bbackspace.FlatStyle = FlatStyle.Popup;
            bbackspace.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bbackspace.ForeColor = Color.Black;
            bbackspace.Location = new Point(219, 60);
            bbackspace.Margin = new Padding(3, 2, 3, 2);
            bbackspace.Name = "bbackspace";
            bbackspace.Size = new Size(41, 30);
            bbackspace.TabIndex = 15;
            bbackspace.Text = "CE";
            bbackspace.TextAlign = ContentAlignment.BottomCenter;
            bbackspace.UseVisualStyleBackColor = false;
            bbackspace.Click += bBackspace_Click;
            // 
            // bfatorial
            // 
            bfatorial.BackColor = Color.White;
            bfatorial.FlatStyle = FlatStyle.Popup;
            bfatorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bfatorial.ForeColor = Color.Black;
            bfatorial.Location = new Point(219, 134);
            bfatorial.Margin = new Padding(3, 2, 3, 2);
            bfatorial.Name = "bfatorial";
            bfatorial.Size = new Size(41, 30);
            bfatorial.TabIndex = 24;
            bfatorial.Text = "N!";
            bfatorial.TextAlign = ContentAlignment.BottomCenter;
            bfatorial.UseVisualStyleBackColor = false;
            bfatorial.Click += bFatoracao_Click;
            // 
            // bnegepos
            // 
            bnegepos.AutoSize = true;
            bnegepos.BackColor = Color.White;
            bnegepos.FlatStyle = FlatStyle.Popup;
            bnegepos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bnegepos.ForeColor = Color.Black;
            bnegepos.Location = new Point(219, 176);
            bnegepos.Margin = new Padding(3, 2, 3, 2);
            bnegepos.Name = "bnegepos";
            bnegepos.Size = new Size(41, 30);
            bnegepos.TabIndex = 25;
            bnegepos.Text = "+/-";
            bnegepos.TextAlign = ContentAlignment.BottomCenter;
            bnegepos.UseVisualStyleBackColor = false;
            bnegepos.Click += bNegpos_Click;
            // 
            // b2
            // 
            b2.AutoSize = true;
            b2.BackColor = Color.White;
            b2.FlatStyle = FlatStyle.Popup;
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b2.ForeColor = Color.Black;
            b2.Location = new Point(58, 137);
            b2.Margin = new Padding(3, 2, 3, 2);
            b2.Name = "b2";
            b2.Size = new Size(30, 30);
            b2.TabIndex = 7;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // b0
            // 
            b0.AutoSize = true;
            b0.BackColor = Color.White;
            b0.FlatStyle = FlatStyle.Popup;
            b0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b0.ForeColor = Color.Black;
            b0.Location = new Point(58, 176);
            b0.Margin = new Padding(3, 2, 3, 2);
            b0.Name = "b0";
            b0.Size = new Size(30, 30);
            b0.TabIndex = 26;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = false;
            b0.Click += b0_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(278, 24);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.BackColor = Color.Black;
            sobreToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            sobreToolStripMenuItem.Checked = true;
            sobreToolStripMenuItem.CheckOnClick = true;
            sobreToolStripMenuItem.CheckState = CheckState.Checked;
            sobreToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { créditosToolStripMenuItem });
            sobreToolStripMenuItem.ForeColor = Color.White;
            sobreToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.ShowShortcutKeys = false;
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // créditosToolStripMenuItem
            // 
            créditosToolStripMenuItem.BackColor = Color.Black;
            créditosToolStripMenuItem.ForeColor = Color.White;
            créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            créditosToolStripMenuItem.Size = new Size(118, 22);
            créditosToolStripMenuItem.Text = "Créditos";
            créditosToolStripMenuItem.Click += creditosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(278, 214);
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
            ForeColor = Color.Black;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
        private ToolStripMenuItem créditosToolStripMenuItem;
        public ToolStripMenuItem sobreToolStripMenuItem;
    }
}
