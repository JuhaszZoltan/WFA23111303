namespace WFA015
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
            tbxKedvencSzo = new TextBox();
            pbxSmiley = new PictureBox();
            btnTunjEl = new Button();
            btnGyereVissza = new Button();
            pnlMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbxSmiley).BeginInit();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI01.Location = new Point(12, 9);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(159, 21);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "Mi a kedvenc szavad?";
            // 
            // tbxKedvencSzo
            // 
            tbxKedvencSzo.BackColor = Color.White;
            tbxKedvencSzo.Location = new Point(12, 33);
            tbxKedvencSzo.Name = "tbxKedvencSzo";
            tbxKedvencSzo.Size = new Size(672, 36);
            tbxKedvencSzo.TabIndex = 1;
            // 
            // pbxSmiley
            // 
            pbxSmiley.Image = Properties.Resources.smiley01;
            pbxSmiley.Location = new Point(237, 136);
            pbxSmiley.Name = "pbxSmiley";
            pbxSmiley.Size = new Size(194, 182);
            pbxSmiley.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSmiley.TabIndex = 0;
            pbxSmiley.TabStop = false;
            // 
            // btnTunjEl
            // 
            btnTunjEl.Location = new Point(12, 562);
            btnTunjEl.Name = "btnTunjEl";
            btnTunjEl.Size = new Size(207, 64);
            btnTunjEl.TabIndex = 3;
            btnTunjEl.Text = "Tűnj el!";
            btnTunjEl.UseVisualStyleBackColor = true;
            // 
            // btnGyereVissza
            // 
            btnGyereVissza.Enabled = false;
            btnGyereVissza.Location = new Point(477, 562);
            btnGyereVissza.Name = "btnGyereVissza";
            btnGyereVissza.Size = new Size(207, 64);
            btnGyereVissza.TabIndex = 3;
            btnGyereVissza.Text = "Gyere vissza!";
            btnGyereVissza.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pbxSmiley);
            pnlMain.Location = new Point(12, 75);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(672, 481);
            pnlMain.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 638);
            Controls.Add(pnlMain);
            Controls.Add(btnGyereVissza);
            Controls.Add(btnTunjEl);
            Controls.Add(tbxKedvencSzo);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Smiley";
            ((System.ComponentModel.ISupportInitialize)pbxSmiley).EndInit();
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxKedvencSzo;
        private PictureBox pbxSmiley;
        private Button btnTunjEl;
        private Button btnGyereVissza;
        private Panel pnlMain;
    }
}
