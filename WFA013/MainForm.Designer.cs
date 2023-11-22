namespace WFA013
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
            btnJatekosKo = new Button();
            btnJatekosPapir = new Button();
            btnJatekosOllo = new Button();
            btnGepKo = new Button();
            btnGepPapir = new Button();
            btnGepOllo = new Button();
            lblJatekosPont = new Label();
            lblGepPont = new Label();
            SuspendLayout();
            // 
            // btnJatekosKo
            // 
            btnJatekosKo.BackColor = Color.White;
            btnJatekosKo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnJatekosKo.Location = new Point(12, 12);
            btnJatekosKo.Name = "btnJatekosKo";
            btnJatekosKo.Size = new Size(217, 64);
            btnJatekosKo.TabIndex = 0;
            btnJatekosKo.Text = "KŐ";
            btnJatekosKo.UseVisualStyleBackColor = false;
            // 
            // btnJatekosPapir
            // 
            btnJatekosPapir.BackColor = Color.White;
            btnJatekosPapir.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnJatekosPapir.Location = new Point(235, 12);
            btnJatekosPapir.Name = "btnJatekosPapir";
            btnJatekosPapir.Size = new Size(217, 64);
            btnJatekosPapir.TabIndex = 1;
            btnJatekosPapir.Text = "PAPÍR";
            btnJatekosPapir.UseVisualStyleBackColor = false;
            // 
            // btnJatekosOllo
            // 
            btnJatekosOllo.BackColor = Color.White;
            btnJatekosOllo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnJatekosOllo.Location = new Point(458, 12);
            btnJatekosOllo.Name = "btnJatekosOllo";
            btnJatekosOllo.Size = new Size(217, 64);
            btnJatekosOllo.TabIndex = 2;
            btnJatekosOllo.Text = "OLLÓ";
            btnJatekosOllo.UseVisualStyleBackColor = false;
            // 
            // btnGepKo
            // 
            btnGepKo.BackColor = Color.White;
            btnGepKo.Enabled = false;
            btnGepKo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnGepKo.Location = new Point(12, 91);
            btnGepKo.Name = "btnGepKo";
            btnGepKo.Size = new Size(217, 64);
            btnGepKo.TabIndex = 0;
            btnGepKo.TabStop = false;
            btnGepKo.Text = "KŐ";
            btnGepKo.UseVisualStyleBackColor = false;
            // 
            // btnGepPapir
            // 
            btnGepPapir.BackColor = Color.White;
            btnGepPapir.Enabled = false;
            btnGepPapir.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnGepPapir.Location = new Point(235, 91);
            btnGepPapir.Name = "btnGepPapir";
            btnGepPapir.Size = new Size(217, 64);
            btnGepPapir.TabIndex = 0;
            btnGepPapir.TabStop = false;
            btnGepPapir.Text = "PAPÍR";
            btnGepPapir.UseVisualStyleBackColor = false;
            // 
            // btnGepOllo
            // 
            btnGepOllo.BackColor = Color.White;
            btnGepOllo.Enabled = false;
            btnGepOllo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnGepOllo.Location = new Point(458, 91);
            btnGepOllo.Name = "btnGepOllo";
            btnGepOllo.Size = new Size(217, 64);
            btnGepOllo.TabIndex = 0;
            btnGepOllo.TabStop = false;
            btnGepOllo.Text = "OLLÓ";
            btnGepOllo.UseVisualStyleBackColor = false;
            // 
            // lblJatekosPont
            // 
            lblJatekosPont.Location = new Point(681, 12);
            lblJatekosPont.Name = "lblJatekosPont";
            lblJatekosPont.Size = new Size(125, 64);
            lblJatekosPont.TabIndex = 1;
            lblJatekosPont.Text = "pont: ###";
            lblJatekosPont.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGepPont
            // 
            lblGepPont.Location = new Point(681, 91);
            lblGepPont.Name = "lblGepPont";
            lblGepPont.Size = new Size(125, 64);
            lblGepPont.TabIndex = 1;
            lblGepPont.Text = "pont: ###";
            lblGepPont.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 167);
            Controls.Add(lblGepPont);
            Controls.Add(lblJatekosPont);
            Controls.Add(btnGepOllo);
            Controls.Add(btnJatekosOllo);
            Controls.Add(btnGepPapir);
            Controls.Add(btnJatekosPapir);
            Controls.Add(btnGepKo);
            Controls.Add(btnJatekosKo);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Kő-Papír-Olló";
            ResumeLayout(false);
        }

        #endregion

        private Button btnJatekosKo;
        private Button btnJatekosPapir;
        private Button btnJatekosOllo;
        private Button btnGepKo;
        private Button btnGepPapir;
        private Button btnGepOllo;
        private Label lblJatekosPont;
        private Label lblGepPont;
    }
}
