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
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // display
            // 
            display.BackColor = Color.Black;
            display.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(display, 5);
            display.Dock = DockStyle.Fill;
            display.ForeColor = Color.White;
            display.Location = new Point(0, 0);
            display.Margin = new Padding(0);
            display.Multiline = true;
            display.Name = "display";
            display.ReadOnly = true;
            display.Size = new Size(350, 83);
            display.TabIndex = 0;
            display.TextChanged += display_TextChanged;
            // 
            // bigual
            // 
            bigual.BackColor = Color.Black;
            bigual.Dock = DockStyle.Fill;
            bigual.FlatStyle = FlatStyle.Popup;
            bigual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bigual.ForeColor = Color.White;
            bigual.Location = new Point(280, 332);
            bigual.Margin = new Padding(0);
            bigual.Name = "bigual";
            bigual.Size = new Size(70, 86);
            bigual.TabIndex = 3;
            bigual.Text = "=";
            bigual.UseVisualStyleBackColor = false;
            bigual.Click += bigual_Click;
            // 
            // bvirgula
            // 
            bvirgula.BackColor = Color.Black;
            bvirgula.Dock = DockStyle.Fill;
            bvirgula.FlatStyle = FlatStyle.Popup;
            bvirgula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bvirgula.ForeColor = Color.White;
            bvirgula.Location = new Point(210, 332);
            bvirgula.Margin = new Padding(0);
            bvirgula.Name = "bvirgula";
            bvirgula.Size = new Size(70, 86);
            bvirgula.TabIndex = 4;
            bvirgula.Text = ",";
            bvirgula.UseVisualStyleBackColor = false;
            bvirgula.Click += bVirgula_Click;
            // 
            // b1
            // 
            b1.BackColor = Color.Black;
            b1.Dock = DockStyle.Fill;
            b1.FlatStyle = FlatStyle.Popup;
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b1.ForeColor = Color.White;
            b1.Location = new Point(0, 249);
            b1.Margin = new Padding(0);
            b1.Name = "b1";
            b1.Size = new Size(70, 83);
            b1.TabIndex = 6;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // b3
            // 
            b3.BackColor = Color.Black;
            b3.Dock = DockStyle.Fill;
            b3.FlatStyle = FlatStyle.Popup;
            b3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b3.ForeColor = Color.White;
            b3.Location = new Point(140, 249);
            b3.Margin = new Padding(0);
            b3.Name = "b3";
            b3.Size = new Size(70, 83);
            b3.TabIndex = 8;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = false;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.BackColor = Color.Black;
            b4.Dock = DockStyle.Fill;
            b4.FlatStyle = FlatStyle.Popup;
            b4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b4.ForeColor = Color.White;
            b4.Location = new Point(0, 166);
            b4.Margin = new Padding(0);
            b4.Name = "b4";
            b4.Size = new Size(70, 83);
            b4.TabIndex = 9;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = false;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.Black;
            b5.Dock = DockStyle.Fill;
            b5.FlatStyle = FlatStyle.Popup;
            b5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b5.ForeColor = Color.White;
            b5.Location = new Point(70, 166);
            b5.Margin = new Padding(0);
            b5.Name = "b5";
            b5.Size = new Size(70, 83);
            b5.TabIndex = 10;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.BackColor = Color.Black;
            b6.Dock = DockStyle.Fill;
            b6.FlatStyle = FlatStyle.Popup;
            b6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b6.ForeColor = Color.White;
            b6.Location = new Point(140, 166);
            b6.Margin = new Padding(0);
            b6.Name = "b6";
            b6.Size = new Size(70, 83);
            b6.TabIndex = 11;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += b6_Click;
            // 
            // b7
            // 
            b7.BackColor = Color.Black;
            b7.Dock = DockStyle.Fill;
            b7.FlatStyle = FlatStyle.Popup;
            b7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b7.ForeColor = Color.White;
            b7.Location = new Point(0, 83);
            b7.Margin = new Padding(0);
            b7.Name = "b7";
            b7.Size = new Size(70, 83);
            b7.TabIndex = 12;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.BackColor = Color.Black;
            b8.Dock = DockStyle.Fill;
            b8.FlatStyle = FlatStyle.Popup;
            b8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b8.ForeColor = Color.White;
            b8.Location = new Point(70, 83);
            b8.Margin = new Padding(0);
            b8.Name = "b8";
            b8.Size = new Size(70, 83);
            b8.TabIndex = 13;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.BackColor = Color.Black;
            b9.Dock = DockStyle.Fill;
            b9.FlatStyle = FlatStyle.Popup;
            b9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b9.ForeColor = Color.White;
            b9.Location = new Point(140, 83);
            b9.Margin = new Padding(0);
            b9.Name = "b9";
            b9.Size = new Size(70, 83);
            b9.TabIndex = 14;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += b9_Click;
            // 
            // bsoma
            // 
            bsoma.BackColor = Color.Black;
            bsoma.Dock = DockStyle.Fill;
            bsoma.FlatStyle = FlatStyle.Popup;
            bsoma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bsoma.ForeColor = Color.White;
            bsoma.Location = new Point(210, 83);
            bsoma.Margin = new Padding(0);
            bsoma.Name = "bsoma";
            bsoma.Size = new Size(70, 83);
            bsoma.TabIndex = 2;
            bsoma.Text = "+";
            bsoma.UseVisualStyleBackColor = false;
            bsoma.Click += bsoma_Click;
            // 
            // bsub
            // 
            bsub.BackColor = Color.Black;
            bsub.Dock = DockStyle.Fill;
            bsub.FlatStyle = FlatStyle.Popup;
            bsub.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bsub.ForeColor = Color.White;
            bsub.Location = new Point(210, 249);
            bsub.Margin = new Padding(0);
            bsub.Name = "bsub";
            bsub.Size = new Size(70, 83);
            bsub.TabIndex = 16;
            bsub.Text = "-";
            bsub.UseVisualStyleBackColor = false;
            bsub.Click += bsub_Click;
            // 
            // bmult
            // 
            bmult.BackColor = Color.Black;
            bmult.Dock = DockStyle.Fill;
            bmult.FlatStyle = FlatStyle.Popup;
            bmult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bmult.ForeColor = Color.White;
            bmult.Location = new Point(210, 166);
            bmult.Margin = new Padding(0);
            bmult.Name = "bmult";
            bmult.Size = new Size(70, 83);
            bmult.TabIndex = 17;
            bmult.Text = "*";
            bmult.UseVisualStyleBackColor = false;
            bmult.Click += bMult_Click;
            // 
            // bporcento
            // 
            bporcento.BackColor = Color.Black;
            bporcento.Dock = DockStyle.Fill;
            bporcento.FlatStyle = FlatStyle.Popup;
            bporcento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bporcento.ForeColor = Color.White;
            bporcento.Location = new Point(0, 332);
            bporcento.Margin = new Padding(0);
            bporcento.Name = "bporcento";
            bporcento.Size = new Size(70, 86);
            bporcento.TabIndex = 19;
            bporcento.Text = "%";
            bporcento.UseVisualStyleBackColor = false;
            bporcento.Click += bPorcento_Click;
            // 
            // bdiv
            // 
            bdiv.BackColor = Color.Black;
            bdiv.Dock = DockStyle.Fill;
            bdiv.FlatStyle = FlatStyle.Popup;
            bdiv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bdiv.ForeColor = Color.White;
            bdiv.Location = new Point(140, 332);
            bdiv.Margin = new Padding(0);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(70, 86);
            bdiv.TabIndex = 18;
            bdiv.Text = "/";
            bdiv.UseVisualStyleBackColor = false;
            bdiv.Click += bDivisao_Click;
            // 
            // bclear
            // 
            bclear.BackColor = Color.Black;
            bclear.Dock = DockStyle.Fill;
            bclear.FlatStyle = FlatStyle.Popup;
            bclear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bclear.ForeColor = Color.White;
            bclear.Location = new Point(350, 0);
            bclear.Margin = new Padding(0);
            bclear.Name = "bclear";
            bclear.Size = new Size(74, 83);
            bclear.TabIndex = 5;
            bclear.Text = "C";
            bclear.UseVisualStyleBackColor = false;
            bclear.Click += bClear_Click;
            // 
            // babsolute
            // 
            babsolute.BackColor = Color.Black;
            babsolute.Dock = DockStyle.Fill;
            babsolute.FlatStyle = FlatStyle.Popup;
            babsolute.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            babsolute.ForeColor = Color.White;
            babsolute.Location = new Point(350, 166);
            babsolute.Margin = new Padding(0);
            babsolute.Name = "babsolute";
            babsolute.Size = new Size(74, 83);
            babsolute.TabIndex = 20;
            babsolute.Text = "|X|";
            babsolute.UseVisualStyleBackColor = false;
            babsolute.Click += bAbsolute_Click;
            // 
            // braiz
            // 
            braiz.BackColor = Color.Black;
            braiz.Dock = DockStyle.Fill;
            braiz.FlatStyle = FlatStyle.Popup;
            braiz.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            braiz.ForeColor = Color.White;
            braiz.Location = new Point(280, 83);
            braiz.Margin = new Padding(0);
            braiz.Name = "braiz";
            braiz.Size = new Size(70, 83);
            braiz.TabIndex = 21;
            braiz.Text = "√";
            braiz.UseVisualStyleBackColor = false;
            braiz.Click += bRaiz_Click;
            // 
            // bpotencia
            // 
            bpotencia.BackColor = Color.Black;
            bpotencia.Dock = DockStyle.Fill;
            bpotencia.FlatStyle = FlatStyle.Popup;
            bpotencia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bpotencia.ForeColor = Color.White;
            bpotencia.Location = new Point(280, 166);
            bpotencia.Margin = new Padding(0);
            bpotencia.Name = "bpotencia";
            bpotencia.Size = new Size(70, 83);
            bpotencia.TabIndex = 22;
            bpotencia.Text = "xʸ";
            bpotencia.UseVisualStyleBackColor = false;
            bpotencia.Click += bExponenciacao_Click;
            // 
            // bquadrado
            // 
            bquadrado.BackColor = Color.Black;
            bquadrado.Dock = DockStyle.Fill;
            bquadrado.FlatStyle = FlatStyle.Popup;
            bquadrado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bquadrado.ForeColor = Color.White;
            bquadrado.Location = new Point(280, 249);
            bquadrado.Margin = new Padding(0);
            bquadrado.Name = "bquadrado";
            bquadrado.Size = new Size(70, 83);
            bquadrado.TabIndex = 23;
            bquadrado.Text = "x²";
            bquadrado.UseVisualStyleBackColor = false;
            bquadrado.Click += bQuadrado_Click;
            // 
            // bbackspace
            // 
            bbackspace.BackColor = Color.Black;
            bbackspace.Dock = DockStyle.Fill;
            bbackspace.FlatStyle = FlatStyle.Popup;
            bbackspace.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bbackspace.ForeColor = Color.White;
            bbackspace.Location = new Point(350, 83);
            bbackspace.Margin = new Padding(0);
            bbackspace.Name = "bbackspace";
            bbackspace.Size = new Size(74, 83);
            bbackspace.TabIndex = 15;
            bbackspace.Text = "CE";
            bbackspace.UseVisualStyleBackColor = false;
            bbackspace.Click += bBackspace_Click;
            // 
            // bfatorial
            // 
            bfatorial.BackColor = Color.Black;
            bfatorial.Dock = DockStyle.Fill;
            bfatorial.FlatStyle = FlatStyle.Popup;
            bfatorial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bfatorial.ForeColor = Color.White;
            bfatorial.Location = new Point(350, 249);
            bfatorial.Margin = new Padding(0);
            bfatorial.Name = "bfatorial";
            bfatorial.Size = new Size(74, 83);
            bfatorial.TabIndex = 24;
            bfatorial.Text = "N!";
            bfatorial.UseVisualStyleBackColor = false;
            bfatorial.Click += bFatoracao_Click;
            // 
            // bnegepos
            // 
            bnegepos.BackColor = Color.Black;
            bnegepos.Dock = DockStyle.Fill;
            bnegepos.FlatStyle = FlatStyle.Popup;
            bnegepos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bnegepos.ForeColor = Color.White;
            bnegepos.Location = new Point(350, 332);
            bnegepos.Margin = new Padding(0);
            bnegepos.Name = "bnegepos";
            bnegepos.Size = new Size(74, 86);
            bnegepos.TabIndex = 25;
            bnegepos.Text = "+/-";
            bnegepos.UseVisualStyleBackColor = false;
            bnegepos.Click += bNegpos_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.Black;
            b2.Dock = DockStyle.Fill;
            b2.FlatStyle = FlatStyle.Popup;
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b2.ForeColor = Color.White;
            b2.Location = new Point(70, 249);
            b2.Margin = new Padding(0);
            b2.Name = "b2";
            b2.Size = new Size(70, 83);
            b2.TabIndex = 7;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // b0
            // 
            b0.BackColor = Color.Black;
            b0.Dock = DockStyle.Fill;
            b0.FlatStyle = FlatStyle.Popup;
            b0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b0.ForeColor = Color.White;
            b0.Location = new Point(70, 332);
            b0.Margin = new Padding(0);
            b0.Name = "b0";
            b0.Size = new Size(70, 86);
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
            menuStrip1.Size = new Size(424, 24);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(bclear, 5, 0);
            tableLayoutPanel1.Controls.Add(bnegepos, 5, 4);
            tableLayoutPanel1.Controls.Add(b0, 1, 4);
            tableLayoutPanel1.Controls.Add(bigual, 4, 4);
            tableLayoutPanel1.Controls.Add(bvirgula, 3, 4);
            tableLayoutPanel1.Controls.Add(bdiv, 2, 4);
            tableLayoutPanel1.Controls.Add(display, 0, 0);
            tableLayoutPanel1.Controls.Add(b7, 0, 1);
            tableLayoutPanel1.Controls.Add(bporcento, 0, 4);
            tableLayoutPanel1.Controls.Add(bfatorial, 5, 3);
            tableLayoutPanel1.Controls.Add(b8, 1, 1);
            tableLayoutPanel1.Controls.Add(bquadrado, 4, 3);
            tableLayoutPanel1.Controls.Add(b9, 2, 1);
            tableLayoutPanel1.Controls.Add(babsolute, 5, 2);
            tableLayoutPanel1.Controls.Add(bpotencia, 4, 2);
            tableLayoutPanel1.Controls.Add(bsub, 3, 3);
            tableLayoutPanel1.Controls.Add(bsoma, 3, 1);
            tableLayoutPanel1.Controls.Add(b3, 2, 3);
            tableLayoutPanel1.Controls.Add(braiz, 4, 1);
            tableLayoutPanel1.Controls.Add(b2, 1, 3);
            tableLayoutPanel1.Controls.Add(bbackspace, 5, 1);
            tableLayoutPanel1.Controls.Add(b1, 0, 3);
            tableLayoutPanel1.Controls.Add(b4, 0, 2);
            tableLayoutPanel1.Controls.Add(bmult, 3, 2);
            tableLayoutPanel1.Controls.Add(b5, 1, 2);
            tableLayoutPanel1.Controls.Add(b6, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(424, 418);
            tableLayoutPanel1.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(424, 442);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(440, 460);
            Name = "Form1";
            Text = "Calculadora Base";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}
