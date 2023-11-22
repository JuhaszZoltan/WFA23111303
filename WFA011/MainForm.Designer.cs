namespace WFA011
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
            lblUI02 = new Label();
            tbxPontszam = new TextBox();
            btnAdatbevitel = new Button();
            rtbPontszamok = new RichTextBox();
            lblUI01 = new Label();
            tbxNev = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnAtlagpontszam = new Button();
            lblAtlagpontszam = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(15, 62);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(110, 30);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Pontszám:";
            // 
            // tbxPontszam
            // 
            tbxPontszam.Location = new Point(131, 59);
            tbxPontszam.Name = "tbxPontszam";
            tbxPontszam.Size = new Size(180, 36);
            tbxPontszam.TabIndex = 1;
            // 
            // btnAdatbevitel
            // 
            btnAdatbevitel.Location = new Point(87, 143);
            btnAdatbevitel.Name = "btnAdatbevitel";
            btnAdatbevitel.Size = new Size(332, 48);
            btnAdatbevitel.TabIndex = 2;
            btnAdatbevitel.Text = "Adatbevitel";
            btnAdatbevitel.UseVisualStyleBackColor = true;
            // 
            // rtbPontszamok
            // 
            rtbPontszamok.Font = new Font("Consolas", 16F, FontStyle.Regular, GraphicsUnit.Point);
            rtbPontszamok.Location = new Point(12, 206);
            rtbPontszamok.Name = "rtbPontszamok";
            rtbPontszamok.Size = new Size(483, 315);
            rtbPontszamok.TabIndex = 0;
            rtbPontszamok.TabStop = false;
            rtbPontszamok.Text = "";
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(68, 23);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(57, 30);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Név:";
            // 
            // tbxNev
            // 
            tbxNev.Location = new Point(131, 17);
            tbxNev.Name = "tbxNev";
            tbxNev.Size = new Size(180, 36);
            tbxNev.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(483, 114);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbxPontszam);
            panel1.Controls.Add(lblUI02);
            panel1.Controls.Add(lblUI01);
            panel1.Controls.Add(tbxNev);
            panel1.Location = new Point(75, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 108);
            panel1.TabIndex = 5;
            // 
            // btnAtlagpontszam
            // 
            btnAtlagpontszam.Location = new Point(87, 553);
            btnAtlagpontszam.Name = "btnAtlagpontszam";
            btnAtlagpontszam.Size = new Size(332, 48);
            btnAtlagpontszam.TabIndex = 0;
            btnAtlagpontszam.TabStop = false;
            btnAtlagpontszam.Text = "Átlagpontszám";
            btnAtlagpontszam.UseVisualStyleBackColor = true;
            // 
            // lblAtlagpontszam
            // 
            lblAtlagpontszam.Location = new Point(12, 620);
            lblAtlagpontszam.Name = "lblAtlagpontszam";
            lblAtlagpontszam.Size = new Size(483, 75);
            lblAtlagpontszam.TabIndex = 5;
            lblAtlagpontszam.Text = "###atlagpontszam###";
            lblAtlagpontszam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 704);
            Controls.Add(lblAtlagpontszam);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(rtbPontszamok);
            Controls.Add(btnAtlagpontszam);
            Controls.Add(btnAdatbevitel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Dolgozat";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUI02;
        private TextBox tbxPontszam;
        private Button btnAdatbevitel;
        private RichTextBox rtbPontszamok;
        private Label lblUI01;
        private TextBox tbxNev;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnAtlagpontszam;
        private Label lblAtlagpontszam;
    }
}
