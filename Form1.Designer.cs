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
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button9 = new Button();
            button18 = new Button();
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
            display.Location = new Point(7, 18);
            display.Margin = new Padding(3, 2, 3, 2);
            display.Multiline = true;
            display.Name = "display";
            display.ReadOnly = true;
            display.Size = new Size(194, 35);
            display.TabIndex = 0;
            display.TextChanged += display_TextChanged;
            // 
            // bigual
            // 
            bigual.AutoSize = true;
            bigual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bigual.Location = new Point(151, 159);
            bigual.Margin = new Padding(3, 2, 3, 2);
            bigual.Name = "bigual";
            bigual.Size = new Size(38, 30);
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
            bvirgula.Location = new Point(115, 158);
            bvirgula.Margin = new Padding(3, 2, 3, 2);
            bvirgula.Name = "bvirgula";
            bvirgula.Size = new Size(30, 30);
            bvirgula.TabIndex = 4;
            bvirgula.Text = ",";
            bvirgula.TextAlign = ContentAlignment.BottomCenter;
            bvirgula.UseVisualStyleBackColor = true;
            bvirgula.Click += bvirgula_Click;
            // 
            // b1
            // 
            b1.AutoSize = true;
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b1.Location = new Point(7, 125);
            b1.Margin = new Padding(3, 2, 3, 2);
            b1.Name = "b1";
            b1.Size = new Size(30, 30);
            b1.TabIndex = 6;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click_1;
            // 
            // b3
            // 
            b3.AutoSize = true;
            b3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b3.Location = new Point(79, 127);
            b3.Margin = new Padding(3, 2, 3, 2);
            b3.Name = "b3";
            b3.Size = new Size(30, 30);
            b3.TabIndex = 8;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += button2_Click;
            // 
            // b4
            // 
            b4.AutoSize = true;
            b4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b4.Location = new Point(7, 91);
            b4.Margin = new Padding(3, 2, 3, 2);
            b4.Name = "b4";
            b4.Size = new Size(30, 30);
            b4.TabIndex = 9;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += button3_Click;
            // 
            // b5
            // 
            b5.AutoSize = true;
            b5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b5.Location = new Point(43, 91);
            b5.Margin = new Padding(3, 2, 3, 2);
            b5.Name = "b5";
            b5.Size = new Size(30, 30);
            b5.TabIndex = 10;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += button4_Click;
            // 
            // b6
            // 
            b6.AutoSize = true;
            b6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b6.Location = new Point(79, 91);
            b6.Margin = new Padding(3, 2, 3, 2);
            b6.Name = "b6";
            b6.Size = new Size(30, 30);
            b6.TabIndex = 11;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += button5_Click;
            // 
            // b7
            // 
            b7.AutoSize = true;
            b7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b7.Location = new Point(7, 57);
            b7.Margin = new Padding(3, 2, 3, 2);
            b7.Name = "b7";
            b7.Size = new Size(30, 30);
            b7.TabIndex = 12;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += button6_Click;
            // 
            // b8
            // 
            b8.AutoSize = true;
            b8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b8.Location = new Point(43, 57);
            b8.Margin = new Padding(3, 2, 3, 2);
            b8.Name = "b8";
            b8.Size = new Size(30, 30);
            b8.TabIndex = 13;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += button7_Click;
            // 
            // b9
            // 
            b9.AutoSize = true;
            b9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b9.Location = new Point(79, 57);
            b9.Margin = new Padding(3, 2, 3, 2);
            b9.Name = "b9";
            b9.Size = new Size(30, 30);
            b9.TabIndex = 14;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += button8_Click;
            // 
            // bsoma
            // 
            bsoma.AutoSize = true;
            bsoma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bsoma.Location = new Point(115, 57);
            bsoma.Margin = new Padding(3, 2, 3, 2);
            bsoma.Name = "bsoma";
            bsoma.Size = new Size(30, 30);
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
            bsub.Location = new Point(115, 127);
            bsub.Margin = new Padding(3, 2, 3, 2);
            bsub.Name = "bsub";
            bsub.Size = new Size(30, 30);
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
            bmult.Location = new Point(115, 91);
            bmult.Margin = new Padding(3, 2, 3, 2);
            bmult.Name = "bmult";
            bmult.Size = new Size(30, 30);
            bmult.TabIndex = 17;
            bmult.Text = "*";
            bmult.TextAlign = ContentAlignment.BottomCenter;
            bmult.UseVisualStyleBackColor = true;
            bmult.Click += button11_Click;
            // 
            // bporcento
            // 
            bporcento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bporcento.Location = new Point(7, 159);
            bporcento.Margin = new Padding(3, 2, 3, 2);
            bporcento.Name = "bporcento";
            bporcento.Size = new Size(30, 30);
            bporcento.TabIndex = 19;
            bporcento.Text = "%";
            bporcento.TextAlign = ContentAlignment.BottomCenter;
            bporcento.UseVisualStyleBackColor = true;
            bporcento.Click += bporcento_Click;
            // 
            // bdiv
            // 
            bdiv.AutoSize = true;
            bdiv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bdiv.Location = new Point(79, 158);
            bdiv.Margin = new Padding(3, 2, 3, 2);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(30, 30);
            bdiv.TabIndex = 18;
            bdiv.Text = "/";
            bdiv.TextAlign = ContentAlignment.BottomCenter;
            bdiv.UseVisualStyleBackColor = true;
            bdiv.Click += button12_Click;
            // 
            // bclear
            // 
            bclear.AutoSize = true;
            bclear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bclear.Location = new Point(202, 19);
            bclear.Margin = new Padding(3, 2, 3, 2);
            bclear.Name = "bclear";
            bclear.Size = new Size(41, 30);
            bclear.TabIndex = 5;
            bclear.Text = "C";
            bclear.TextAlign = ContentAlignment.BottomCenter;
            bclear.UseVisualStyleBackColor = true;
            bclear.Click += bclear_Click;
            // 
            // button14
            // 
            button14.AutoSize = true;
            button14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button14.Location = new Point(202, 94);
            button14.Margin = new Padding(3, 2, 3, 2);
            button14.Name = "button14";
            button14.Size = new Size(41, 30);
            button14.TabIndex = 20;
            button14.Text = "|X|";
            button14.TextAlign = ContentAlignment.BottomCenter;
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.AutoSize = true;
            button15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button15.Location = new Point(151, 57);
            button15.Margin = new Padding(3, 2, 3, 2);
            button15.Name = "button15";
            button15.Size = new Size(38, 30);
            button15.TabIndex = 21;
            button15.Text = "√";
            button15.TextAlign = ContentAlignment.BottomCenter;
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.AutoSize = true;
            button16.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button16.Location = new Point(151, 91);
            button16.Margin = new Padding(3, 2, 3, 2);
            button16.Name = "button16";
            button16.Size = new Size(38, 30);
            button16.TabIndex = 22;
            button16.Text = "xʸ";
            button16.TextAlign = ContentAlignment.BottomCenter;
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.AutoSize = true;
            button17.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button17.Location = new Point(151, 125);
            button17.Margin = new Padding(3, 2, 3, 2);
            button17.Name = "button17";
            button17.Size = new Size(38, 30);
            button17.TabIndex = 23;
            button17.Text = "x²";
            button17.TextAlign = ContentAlignment.BottomCenter;
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button9.Location = new Point(202, 60);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(41, 30);
            button9.TabIndex = 15;
            button9.Text = "CE";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button18.Location = new Point(199, 128);
            button18.Margin = new Padding(3, 2, 3, 2);
            button18.Name = "button18";
            button18.Size = new Size(41, 30);
            button18.TabIndex = 24;
            button18.Text = "N!";
            button18.TextAlign = ContentAlignment.BottomCenter;
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // bnegepos
            // 
            bnegepos.AutoSize = true;
            bnegepos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bnegepos.Location = new Point(199, 162);
            bnegepos.Margin = new Padding(3, 2, 3, 2);
            bnegepos.Name = "bnegepos";
            bnegepos.Size = new Size(41, 30);
            bnegepos.TabIndex = 25;
            bnegepos.Text = "+/-";
            bnegepos.TextAlign = ContentAlignment.BottomCenter;
            bnegepos.UseVisualStyleBackColor = true;
            bnegepos.Click += bnegepos_Click;
            // 
            // b2
            // 
            b2.AutoSize = true;
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b2.Location = new Point(43, 127);
            b2.Margin = new Padding(3, 2, 3, 2);
            b2.Name = "b2";
            b2.Size = new Size(30, 30);
            b2.TabIndex = 7;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += button1_Click;
            // 
            // b0
            // 
            b0.AutoSize = true;
            b0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b0.Location = new Point(43, 160);
            b0.Margin = new Padding(3, 2, 3, 2);
            b0.Name = "b0";
            b0.Size = new Size(30, 30);
            b0.TabIndex = 26;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += button20_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(254, 24);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { créditosToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // créditosToolStripMenuItem
            // 
            créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            créditosToolStripMenuItem.Size = new Size(118, 22);
            créditosToolStripMenuItem.Text = "Créditos";
            créditosToolStripMenuItem.Click += créditosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(254, 208);
            Controls.Add(b0);
            Controls.Add(bnegepos);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(bporcento);
            Controls.Add(bdiv);
            Controls.Add(bmult);
            Controls.Add(bsub);
            Controls.Add(button9);
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
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button9;
        private Button button18;
        private Button bnegepos;
        private Button b2;
        private Button b0;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem créditosToolStripMenuItem;
    }
}
