namespace WFA010
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
            lblUI01 = new Label();
            lblUI02 = new Label();
            lblUI03 = new Label();
            tbxLKisebb = new TextBox();
            tbxLNagyobb = new TextBox();
            btnGeneralas = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            rtbSzamok = new RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.Location = new Point(12, 9);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(541, 69);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Milyen intervallumból generáljam a számokat?";
            lblUI01.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(111, 86);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(171, 30);
            lblUI02.TabIndex = 1;
            lblUI02.Text = "Legkisebb szám:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(88, 128);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(194, 30);
            lblUI03.TabIndex = 1;
            lblUI03.Text = "Legnagyobb szám:";
            // 
            // tbxLKisebb
            // 
            tbxLKisebb.Location = new Point(288, 83);
            tbxLKisebb.Name = "tbxLKisebb";
            tbxLKisebb.Size = new Size(174, 36);
            tbxLKisebb.TabIndex = 0;
            // 
            // tbxLNagyobb
            // 
            tbxLNagyobb.Location = new Point(288, 125);
            tbxLNagyobb.Name = "tbxLNagyobb";
            tbxLNagyobb.Size = new Size(174, 36);
            tbxLNagyobb.TabIndex = 1;
            // 
            // btnGeneralas
            // 
            btnGeneralas.Location = new Point(111, 3);
            btnGeneralas.Name = "btnGeneralas";
            btnGeneralas.Size = new Size(318, 59);
            btnGeneralas.TabIndex = 2;
            btnGeneralas.Text = "Számok generálása";
            btnGeneralas.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btnGeneralas, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 182);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(541, 65);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // rtbSzamok
            // 
            rtbSzamok.Location = new Point(12, 267);
            rtbSzamok.Name = "rtbSzamok";
            rtbSzamok.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtbSzamok.Size = new Size(541, 261);
            rtbSzamok.TabIndex = 5;
            rtbSzamok.TabStop = false;
            rtbSzamok.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 540);
            Controls.Add(rtbSzamok);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tbxLNagyobb);
            Controls.Add(tbxLKisebb);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Véletlenszámok";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private Label lblUI02;
        private Label lblUI03;
        private TextBox tbxLKisebb;
        private TextBox tbxLNagyobb;
        private Button btnGeneralas;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox rtbSzamok;
    }
}
