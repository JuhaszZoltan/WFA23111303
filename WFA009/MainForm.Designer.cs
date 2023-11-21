namespace WFA009
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
            tbxUjElem = new TextBox();
            lsbElemek = new ListBox();
            btnHozzaadas = new Button();
            lblUI01 = new Label();
            btnOsszesTorlese = new Button();
            btnKijeloltTorlese = new Button();
            SuspendLayout();
            // 
            // tbxUjElem
            // 
            tbxUjElem.Location = new Point(12, 31);
            tbxUjElem.Name = "tbxUjElem";
            tbxUjElem.Size = new Size(213, 36);
            tbxUjElem.TabIndex = 0;
            // 
            // lsbElemek
            // 
            lsbElemek.FormattingEnabled = true;
            lsbElemek.ItemHeight = 30;
            lsbElemek.Items.AddRange(new object[] { "alma", "banán", "körte" });
            lsbElemek.Location = new Point(12, 73);
            lsbElemek.Name = "lsbElemek";
            lsbElemek.Size = new Size(213, 364);
            lsbElemek.TabIndex = 1;
            // 
            // btnHozzaadas
            // 
            btnHozzaadas.ForeColor = Color.ForestGreen;
            btnHozzaadas.Location = new Point(237, 31);
            btnHozzaadas.Name = "btnHozzaadas";
            btnHozzaadas.Size = new Size(180, 62);
            btnHozzaadas.TabIndex = 2;
            btnHozzaadas.Text = "Hozzáadás";
            btnHozzaadas.UseVisualStyleBackColor = true;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI01.Location = new Point(12, 9);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(56, 19);
            lblUI01.TabIndex = 3;
            lblUI01.Text = "új elem:";
            // 
            // btnOsszesTorlese
            // 
            btnOsszesTorlese.ForeColor = Color.Brown;
            btnOsszesTorlese.Location = new Point(237, 167);
            btnOsszesTorlese.Name = "btnOsszesTorlese";
            btnOsszesTorlese.Size = new Size(180, 62);
            btnOsszesTorlese.TabIndex = 2;
            btnOsszesTorlese.Text = "Összes törlése";
            btnOsszesTorlese.UseVisualStyleBackColor = true;
            // 
            // btnKijeloltTorlese
            // 
            btnKijeloltTorlese.ForeColor = Color.Red;
            btnKijeloltTorlese.Location = new Point(237, 99);
            btnKijeloltTorlese.Name = "btnKijeloltTorlese";
            btnKijeloltTorlese.Size = new Size(180, 62);
            btnKijeloltTorlese.TabIndex = 2;
            btnKijeloltTorlese.Text = "Kijelölt törlése";
            btnKijeloltTorlese.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 454);
            Controls.Add(lblUI01);
            Controls.Add(btnKijeloltTorlese);
            Controls.Add(btnOsszesTorlese);
            Controls.Add(btnHozzaadas);
            Controls.Add(lsbElemek);
            Controls.Add(tbxUjElem);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Zöldség - Gyümölcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUjElem;
        private ListBox lsbElemek;
        private Button btnHozzaadas;
        private Label lblUI01;
        private Button btnOsszesTorlese;
        private Button btnKijeloltTorlese;
    }
}
