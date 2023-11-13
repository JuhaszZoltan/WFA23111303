namespace WFA001
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
            lblHello = new Label();
            SuspendLayout();
            // 
            // lblHello
            // 
            lblHello.BackColor = Color.LightCoral;
            lblHello.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblHello.Location = new Point(14, 9);
            lblHello.Margin = new Padding(5, 0, 5, 0);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(419, 126);
            lblHello.TabIndex = 0;
            lblHello.Text = "Hello, World!";
            lblHello.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 144);
            Controls.Add(lblHello);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Hello, World!";
            ResumeLayout(false);
        }

        #endregion

        private Label lblHello;
    }
}