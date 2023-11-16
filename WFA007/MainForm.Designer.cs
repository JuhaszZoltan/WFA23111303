namespace WFA007
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
            tbxDarabszam = new TextBox();
            rtbDobasok = new RichTextBox();
            btnDobas = new Button();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 19);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(257, 30);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Hány kockadobást kérsz?";
            // 
            // tbxDarabszam
            // 
            tbxDarabszam.Location = new Point(275, 16);
            tbxDarabszam.Name = "tbxDarabszam";
            tbxDarabszam.Size = new Size(109, 36);
            tbxDarabszam.TabIndex = 1;
            // 
            // rtbDobasok
            // 
            rtbDobasok.Location = new Point(12, 69);
            rtbDobasok.Name = "rtbDobasok";
            rtbDobasok.Size = new Size(372, 213);
            rtbDobasok.TabIndex = 2;
            rtbDobasok.Text = "";
            // 
            // btnDobas
            // 
            btnDobas.Location = new Point(12, 298);
            btnDobas.Name = "btnDobas";
            btnDobas.Size = new Size(372, 52);
            btnDobas.TabIndex = 3;
            btnDobas.Text = "Dobás!";
            btnDobas.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 362);
            Controls.Add(btnDobas);
            Controls.Add(rtbDobasok);
            Controls.Add(tbxDarabszam);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Kockadobások";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxDarabszam;
        private RichTextBox rtbDobasok;
        private Button btnDobas;
    }
}