namespace WFA003
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
            lblUIinfo = new Label();
            btnAlaphelyzet = new Button();
            btnKilepes = new Button();
            lblCoral = new Label();
            lblGreen = new Label();
            lblGold = new Label();
            lblOrchid = new Label();
            SuspendLayout();
            // 
            // lblUIinfo
            // 
            lblUIinfo.Location = new Point(12, 9);
            lblUIinfo.Name = "lblUIinfo";
            lblUIinfo.Size = new Size(400, 52);
            lblUIinfo.TabIndex = 0;
            lblUIinfo.Text = "Kattints valamelyik színes téglalapra!";
            lblUIinfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAlaphelyzet
            // 
            btnAlaphelyzet.Location = new Point(12, 434);
            btnAlaphelyzet.Name = "btnAlaphelyzet";
            btnAlaphelyzet.Size = new Size(164, 47);
            btnAlaphelyzet.TabIndex = 1;
            btnAlaphelyzet.Text = "Alaphelyzet";
            btnAlaphelyzet.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            btnKilepes.Location = new Point(248, 434);
            btnKilepes.Name = "btnKilepes";
            btnKilepes.Size = new Size(164, 47);
            btnKilepes.TabIndex = 1;
            btnKilepes.Text = "Kilépés";
            btnKilepes.UseVisualStyleBackColor = true;
            // 
            // lblCoral
            // 
            lblCoral.BackColor = Color.LightCoral;
            lblCoral.Location = new Point(82, 77);
            lblCoral.Name = "lblCoral";
            lblCoral.Size = new Size(260, 52);
            lblCoral.TabIndex = 0;
            lblCoral.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            lblGreen.BackColor = Color.LawnGreen;
            lblGreen.Location = new Point(82, 168);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(260, 52);
            lblGreen.TabIndex = 0;
            lblGreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGold
            // 
            lblGold.BackColor = Color.Gold;
            lblGold.Location = new Point(82, 259);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(260, 52);
            lblGold.TabIndex = 0;
            lblGold.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrchid
            // 
            lblOrchid.BackColor = Color.MediumOrchid;
            lblOrchid.Location = new Point(82, 350);
            lblOrchid.Name = "lblOrchid";
            lblOrchid.Size = new Size(260, 52);
            lblOrchid.TabIndex = 0;
            lblOrchid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(424, 493);
            Controls.Add(btnKilepes);
            Controls.Add(btnAlaphelyzet);
            Controls.Add(lblOrchid);
            Controls.Add(lblGold);
            Controls.Add(lblGreen);
            Controls.Add(lblCoral);
            Controls.Add(lblUIinfo);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Színező";
            ResumeLayout(false);
        }

        #endregion

        private Label lblUIinfo;
        private Button btnAlaphelyzet;
        private Button btnKilepes;
        private Label lblCoral;
        private Label lblGreen;
        private Label lblGold;
        private Label lblOrchid;
    }
}