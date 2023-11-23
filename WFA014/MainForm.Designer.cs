namespace WFA014
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
            tbxBefogo01 = new TextBox();
            btnKiszamol = new Button();
            rtbOldalak = new RichTextBox();
            lblUI02 = new Label();
            tbxBefogo02 = new TextBox();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(25, 15);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(146, 30);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Egyik befogó:";
            // 
            // tbxBefogo01
            // 
            tbxBefogo01.Location = new Point(177, 12);
            tbxBefogo01.Name = "tbxBefogo01";
            tbxBefogo01.Size = new Size(124, 36);
            tbxBefogo01.TabIndex = 0;
            // 
            // btnKiszamol
            // 
            btnKiszamol.Location = new Point(307, 12);
            btnKiszamol.Name = "btnKiszamol";
            btnKiszamol.Size = new Size(148, 78);
            btnKiszamol.TabIndex = 2;
            btnKiszamol.Text = "Kiszámol";
            btnKiszamol.UseVisualStyleBackColor = true;
            // 
            // rtbOldalak
            // 
            rtbOldalak.Font = new Font("Consolas", 16F, FontStyle.Regular, GraphicsUnit.Point);
            rtbOldalak.Location = new Point(12, 96);
            rtbOldalak.Name = "rtbOldalak";
            rtbOldalak.Size = new Size(443, 322);
            rtbOldalak.TabIndex = 0;
            rtbOldalak.TabStop = false;
            rtbOldalak.Text = "";
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(20, 57);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(151, 30);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Másik befogó:";
            // 
            // tbxBefogo02
            // 
            tbxBefogo02.Location = new Point(177, 54);
            tbxBefogo02.Name = "tbxBefogo02";
            tbxBefogo02.Size = new Size(124, 36);
            tbxBefogo02.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 430);
            Controls.Add(rtbOldalak);
            Controls.Add(btnKiszamol);
            Controls.Add(tbxBefogo02);
            Controls.Add(lblUI02);
            Controls.Add(tbxBefogo01);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Pitagorasz tétel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxBefogo01;
        private Button btnKiszamol;
        private RichTextBox rtbOldalak;
        private Label lblUI02;
        private TextBox tbxBefogo02;
    }
}
