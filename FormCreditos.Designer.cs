namespace CalculadoraBase
{
    partial class FormCreditos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCred = new Label();
            buttonfechar = new Button();
            SuspendLayout();
            // 
            // labelCred
            // 
            labelCred.BackColor = Color.Transparent;
            labelCred.Dock = DockStyle.Top;
            labelCred.FlatStyle = FlatStyle.System;
            labelCred.Font = new Font("Segoe UI", 12F);
            labelCred.Location = new Point(0, 0);
            labelCred.Name = "labelCred";
            labelCred.RightToLeft = RightToLeft.No;
            labelCred.Size = new Size(413, 170);
            labelCred.TabIndex = 0;
            labelCred.Text = "Desenvolvido por: \r\n\r\nDiogo Oliveira\r\nBeatriz Durães";
            labelCred.TextAlign = ContentAlignment.MiddleCenter;
            labelCred.Click += labelCred_Click;
            // 
            // buttonfechar
            // 
            buttonfechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonfechar.BackColor = Color.Gainsboro;
            buttonfechar.FlatStyle = FlatStyle.Flat;
            buttonfechar.Location = new Point(310, 191);
            buttonfechar.Name = "buttonfechar";
            buttonfechar.Size = new Size(75, 30);
            buttonfechar.TabIndex = 1;
            buttonfechar.Text = "Fechar";
            buttonfechar.UseVisualStyleBackColor = false;
            buttonfechar.Click += buttonfechar_Click;
            // 
            // FormCreditos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(413, 233);
            Controls.Add(buttonfechar);
            Controls.Add(labelCred);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCreditos";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Créditos";
            Load += FormCreditos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelCred;
        private Button buttonfechar;

    }
}