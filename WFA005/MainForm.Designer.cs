namespace WFA005
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
            tbxElsoAdat = new TextBox();
            btnOsszeadas = new Button();
            lblUI01 = new Label();
            tbxMasodikAdat = new TextBox();
            lblUI2 = new Label();
            lblMuvelet = new Label();
            btnKivonas = new Button();
            btnSzorzas = new Button();
            btnOsztas = new Button();
            btnTorles = new Button();
            lblEredmeny = new Label();
            SuspendLayout();
            // 
            // tbxElsoAdat
            // 
            tbxElsoAdat.Location = new Point(12, 50);
            tbxElsoAdat.Name = "tbxElsoAdat";
            tbxElsoAdat.Size = new Size(100, 36);
            tbxElsoAdat.TabIndex = 0;
            // 
            // btnOsszeadas
            // 
            btnOsszeadas.Location = new Point(12, 201);
            btnOsszeadas.Name = "btnOsszeadas";
            btnOsszeadas.Size = new Size(140, 46);
            btnOsszeadas.TabIndex = 1;
            btnOsszeadas.Text = "összeadás";
            btnOsszeadas.UseVisualStyleBackColor = true;
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI01.Location = new Point(12, 28);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(54, 19);
            lblUI01.TabIndex = 2;
            lblUI01.Text = "1. adat:";
            // 
            // tbxMasodikAdat
            // 
            tbxMasodikAdat.Location = new Point(198, 50);
            tbxMasodikAdat.Name = "tbxMasodikAdat";
            tbxMasodikAdat.Size = new Size(100, 36);
            tbxMasodikAdat.TabIndex = 0;
            // 
            // lblUI2
            // 
            lblUI2.AutoSize = true;
            lblUI2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUI2.Location = new Point(198, 28);
            lblUI2.Name = "lblUI2";
            lblUI2.Size = new Size(54, 19);
            lblUI2.TabIndex = 2;
            lblUI2.Text = "2. adat:";
            // 
            // lblMuvelet
            // 
            lblMuvelet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMuvelet.Location = new Point(12, 111);
            lblMuvelet.Name = "lblMuvelet";
            lblMuvelet.Size = new Size(286, 19);
            lblMuvelet.TabIndex = 2;
            lblMuvelet.Text = "###művelet###";
            lblMuvelet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKivonas
            // 
            btnKivonas.Location = new Point(158, 201);
            btnKivonas.Name = "btnKivonas";
            btnKivonas.Size = new Size(140, 46);
            btnKivonas.TabIndex = 1;
            btnKivonas.Text = "kivonás";
            btnKivonas.UseVisualStyleBackColor = true;
            // 
            // btnSzorzas
            // 
            btnSzorzas.Location = new Point(12, 253);
            btnSzorzas.Name = "btnSzorzas";
            btnSzorzas.Size = new Size(140, 46);
            btnSzorzas.TabIndex = 1;
            btnSzorzas.Text = "szorzás";
            btnSzorzas.UseVisualStyleBackColor = true;
            // 
            // btnOsztas
            // 
            btnOsztas.Location = new Point(158, 253);
            btnOsztas.Name = "btnOsztas";
            btnOsztas.Size = new Size(140, 46);
            btnOsztas.TabIndex = 1;
            btnOsztas.Text = "osztás";
            btnOsztas.UseVisualStyleBackColor = true;
            // 
            // btnTorles
            // 
            btnTorles.Location = new Point(12, 307);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(286, 46);
            btnTorles.TabIndex = 1;
            btnTorles.Text = "törlés";
            btnTorles.UseVisualStyleBackColor = true;
            // 
            // lblEredmeny
            // 
            lblEredmeny.BackColor = Color.White;
            lblEredmeny.BorderStyle = BorderStyle.FixedSingle;
            lblEredmeny.Location = new Point(12, 130);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(286, 36);
            lblEredmeny.TabIndex = 3;
            lblEredmeny.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 365);
            Controls.Add(lblEredmeny);
            Controls.Add(lblMuvelet);
            Controls.Add(lblUI2);
            Controls.Add(lblUI01);
            Controls.Add(btnOsztas);
            Controls.Add(btnKivonas);
            Controls.Add(btnTorles);
            Controls.Add(btnSzorzas);
            Controls.Add(btnOsszeadas);
            Controls.Add(tbxMasodikAdat);
            Controls.Add(tbxElsoAdat);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Alapműveletek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxElsoAdat;
        private Button btnOsszeadas;
        private Label lblUI01;
        private TextBox tbxMasodikAdat;
        private Label lblUI2;
        private Label lblMuvelet;
        private Button btnKivonas;
        private Button btnSzorzas;
        private Button btnOsztas;
        private Button btnTorles;
        private Label lblEredmeny;
    }
}