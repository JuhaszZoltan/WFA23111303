namespace WFA006
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
            tbxAlso = new TextBox();
            lblUI02 = new Label();
            tbxFelso = new TextBox();
            lblUI03 = new Label();
            tbxMegadott = new TextBox();
            btnMegallapit = new Button();
            lblEredmeny = new Label();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI01.Location = new Point(12, 22);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(83, 21);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Alsó határ:";
            // 
            // tbxAlso
            // 
            tbxAlso.Location = new Point(12, 46);
            tbxAlso.Name = "tbxAlso";
            tbxAlso.Size = new Size(100, 36);
            tbxAlso.TabIndex = 0;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI02.Location = new Point(221, 22);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(89, 21);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Felső határ:";
            // 
            // tbxFelso
            // 
            tbxFelso.Location = new Point(221, 46);
            tbxFelso.Name = "tbxFelso";
            tbxFelso.Size = new Size(100, 36);
            tbxFelso.TabIndex = 1;
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI03.Location = new Point(12, 97);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(134, 21);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "A megadott szám:";
            // 
            // tbxMegadott
            // 
            tbxMegadott.Location = new Point(12, 121);
            tbxMegadott.Name = "tbxMegadott";
            tbxMegadott.Size = new Size(153, 36);
            tbxMegadott.TabIndex = 2;
            // 
            // btnMegallapit
            // 
            btnMegallapit.Location = new Point(171, 97);
            btnMegallapit.Name = "btnMegallapit";
            btnMegallapit.Size = new Size(150, 60);
            btnMegallapit.TabIndex = 3;
            btnMegallapit.Text = "Megállapít";
            btnMegallapit.UseVisualStyleBackColor = true;
            // 
            // lblEredmeny
            // 
            lblEredmeny.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblEredmeny.Location = new Point(12, 176);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(309, 53);
            lblEredmeny.TabIndex = 3;
            lblEredmeny.Text = "######";
            lblEredmeny.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 238);
            Controls.Add(lblEredmeny);
            Controls.Add(btnMegallapit);
            Controls.Add(tbxMegadott);
            Controls.Add(lblUI03);
            Controls.Add(tbxFelso);
            Controls.Add(lblUI02);
            Controls.Add(tbxAlso);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Intervallum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxAlso;
        private Label lblUI02;
        private TextBox tbxFelso;
        private Label lblUI03;
        private TextBox tbxMegadott;
        private Button btnMegallapit;
        private Label lblEredmeny;
    }
}