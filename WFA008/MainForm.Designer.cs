namespace WFA008
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
            tbxSzam = new TextBox();
            lsbOsztok = new ListBox();
            btnOsztok = new Button();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(13, 15);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(69, 30);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Szám:";
            // 
            // tbxSzam
            // 
            tbxSzam.Location = new Point(88, 12);
            tbxSzam.Name = "tbxSzam";
            tbxSzam.Size = new Size(165, 36);
            tbxSzam.TabIndex = 1;
            // 
            // lsbOsztok
            // 
            lsbOsztok.FormattingEnabled = true;
            lsbOsztok.ItemHeight = 30;
            lsbOsztok.Location = new Point(13, 104);
            lsbOsztok.Name = "lsbOsztok";
            lsbOsztok.ScrollAlwaysVisible = true;
            lsbOsztok.Size = new Size(240, 334);
            lsbOsztok.TabIndex = 2;
            // 
            // btnOsztok
            // 
            btnOsztok.Location = new Point(13, 54);
            btnOsztok.Name = "btnOsztok";
            btnOsztok.Size = new Size(240, 44);
            btnOsztok.TabIndex = 3;
            btnOsztok.Text = "Osztók";
            btnOsztok.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 450);
            Controls.Add(btnOsztok);
            Controls.Add(lsbOsztok);
            Controls.Add(tbxSzam);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Osztók";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxSzam;
        private ListBox lsbOsztok;
        private Button btnOsztok;
    }
}