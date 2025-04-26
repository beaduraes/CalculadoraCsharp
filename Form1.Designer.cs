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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            bsoma = new Button();
            bsub = new Button();
            button11 = new Button();
            button13 = new Button();
            button12 = new Button();
            bclear = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button9 = new Button();
            button18 = new Button();
            button19 = new Button();
            button1 = new Button();
            button20 = new Button();
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
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(79, 127);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 8;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(7, 91);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 9;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(43, 91);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 10;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(79, 91);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 11;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(7, 57);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 12;
            button6.Text = "7";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Location = new Point(43, 57);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 13;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.Location = new Point(79, 57);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 14;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
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
            // button11
            // 
            button11.AutoSize = true;
            button11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button11.Location = new Point(115, 91);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(30, 30);
            button11.TabIndex = 17;
            button11.Text = "*";
            button11.TextAlign = ContentAlignment.BottomCenter;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button13.Location = new Point(7, 159);
            button13.Margin = new Padding(3, 2, 3, 2);
            button13.Name = "button13";
            button13.Size = new Size(30, 30);
            button13.TabIndex = 19;
            button13.Text = "%";
            button13.TextAlign = ContentAlignment.BottomCenter;
            button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.AutoSize = true;
            button12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button12.Location = new Point(79, 158);
            button12.Margin = new Padding(3, 2, 3, 2);
            button12.Name = "button12";
            button12.Size = new Size(30, 30);
            button12.TabIndex = 18;
            button12.Text = "/";
            button12.TextAlign = ContentAlignment.BottomCenter;
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
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
            button14.Location = new Point(202, 60);
            button14.Margin = new Padding(3, 2, 3, 2);
            button14.Name = "button14";
            button14.Size = new Size(41, 30);
            button14.TabIndex = 20;
            button14.Text = "|X|";
            button14.TextAlign = ContentAlignment.BottomCenter;
            button14.UseVisualStyleBackColor = true;
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
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button9.Location = new Point(199, 94);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(41, 30);
            button9.TabIndex = 15;
            button9.Text = "CE";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
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
            // 
            // button19
            // 
            button19.AutoSize = true;
            button19.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button19.Location = new Point(199, 162);
            button19.Margin = new Padding(3, 2, 3, 2);
            button19.Name = "button19";
            button19.Size = new Size(41, 30);
            button19.TabIndex = 25;
            button19.Text = "+/-";
            button19.TextAlign = ContentAlignment.BottomCenter;
            button19.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(43, 127);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 7;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button20
            // 
            button20.AutoSize = true;
            button20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button20.Location = new Point(43, 160);
            button20.Margin = new Padding(3, 2, 3, 2);
            button20.Name = "button20";
            button20.Size = new Size(30, 30);
            button20.TabIndex = 26;
            button20.Text = "0";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(254, 208);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(bsub);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(b1);
            Controls.Add(bclear);
            Controls.Add(bvirgula);
            Controls.Add(bigual);
            Controls.Add(bsoma);
            Controls.Add(display);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Calculadora Base";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
		private Button bigual;
		private Button bvirgula;
        private Button b1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button bsoma;
        private Button bsub;
        private Button button11;
        private Button button13;
        private Button button12;
        private Button bclear;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button9;
        private Button button18;
        private Button button19;
        private Button button1;
        private Button button20;
    }
}
