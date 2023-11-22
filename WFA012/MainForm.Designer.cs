namespace WFA012
{
    partial class MainForm
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
            tbxA = new TextBox();
            lblUI01 = new Label();
            btnKiszamol = new Button();
            tbxB = new TextBox();
            lblUI02 = new Label();
            tbxC = new TextBox();
            lblUI03 = new Label();
            lblUI04 = new Label();
            lblUI05 = new Label();
            lblX1 = new Label();
            lblX2 = new Label();
            SuspendLayout();
            // 
            // tbxA
            // 
            tbxA.Location = new Point(12, 12);
            tbxA.Name = "tbxA";
            tbxA.Size = new Size(54, 36);
            tbxA.TabIndex = 0;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(72, 15);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(71, 30);
            lblUI01.TabIndex = 1;
            lblUI01.Text = "x^2 +";
            // 
            // btnKiszamol
            // 
            btnKiszamol.Location = new Point(12, 64);
            btnKiszamol.Name = "btnKiszamol";
            btnKiszamol.Size = new Size(353, 40);
            btnKiszamol.TabIndex = 3;
            btnKiszamol.Text = "Kiszámol";
            btnKiszamol.UseVisualStyleBackColor = true;
            // 
            // tbxB
            // 
            tbxB.Location = new Point(149, 12);
            tbxB.Name = "tbxB";
            tbxB.Size = new Size(54, 36);
            tbxB.TabIndex = 1;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(209, 15);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(44, 30);
            lblUI02.TabIndex = 1;
            lblUI02.Text = "x +";
            // 
            // tbxC
            // 
            tbxC.Location = new Point(259, 12);
            tbxC.Name = "tbxC";
            tbxC.Size = new Size(54, 36);
            tbxC.TabIndex = 2;
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(319, 15);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(46, 30);
            lblUI03.TabIndex = 1;
            lblUI03.Text = "= 0";
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Location = new Point(12, 117);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(67, 30);
            lblUI04.TabIndex = 1;
            lblUI04.Text = "x1 := ";
            // 
            // lblUI05
            // 
            lblUI05.AutoSize = true;
            lblUI05.Location = new Point(12, 159);
            lblUI05.Name = "lblUI05";
            lblUI05.Size = new Size(67, 30);
            lblUI05.TabIndex = 1;
            lblUI05.Text = "x2 := ";
            // 
            // lblX1
            // 
            lblX1.AutoSize = true;
            lblX1.Location = new Point(85, 117);
            lblX1.Name = "lblX1";
            lblX1.Size = new Size(113, 30);
            lblX1.TabIndex = 4;
            lblX1.Text = "###x1###";
            // 
            // lblX2
            // 
            lblX2.AutoSize = true;
            lblX2.Location = new Point(85, 159);
            lblX2.Name = "lblX2";
            lblX2.Size = new Size(113, 30);
            lblX2.TabIndex = 4;
            lblX2.Text = "###x2###";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 198);
            Controls.Add(lblX2);
            Controls.Add(lblX1);
            Controls.Add(btnKiszamol);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI05);
            Controls.Add(lblUI04);
            Controls.Add(lblUI01);
            Controls.Add(tbxC);
            Controls.Add(tbxB);
            Controls.Add(tbxA);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Másodfokú egyenlet megoldó";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxA;
        private Label lblUI01;
        private Button btnKiszamol;
        private TextBox tbxB;
        private Label lblUI02;
        private TextBox tbxC;
        private Label lblUI03;
        private Label lblUI04;
        private Label lblUI05;
        private Label lblX1;
        private Label lblX2;
    }
}
