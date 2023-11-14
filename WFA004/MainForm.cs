namespace WFA004
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnKekBetu.Click += BtnKekBetu_Click;
            btnFeherHatter.Click += BtnFeherHatter_Click;
            btnTorol.Click += BtnTorol_Click;
            btnBalKozep.Click += BtnBalKozep_Click;
            btnKozepKozep.Click += BtnKozepKozep_Click;
            btnJobbKozep.Click += BtnJobbKozep_Click;
            btnNagybetus.Click += BtnNagybetus_Click;
            btnNagyit.Click += BtnNagyit_Click;
            btnKicsinyit.Click += BtnKicsinyit_Click;
            btnKilepes.Click += BtnKilepes_Click;
            btnAlaphelyzet.Click += BtnAlaphelyzet_Click;
        }

        private void BtnAlaphelyzet_Click(object? sender, EventArgs e)
        {
            Application.Restart();
        }

        private void BtnKilepes_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnKicsinyit_Click(object? sender, EventArgs e)
        {
            float size = lblText.Font.Size;
            size--;
            if (size > 0)
            {
                lblText.Font = new Font(
                    familyName: "Segoe UI",
                    emSize: size);
            }
        }

        private void BtnNagyit_Click(object? sender, EventArgs e)
        {
            float size = lblText.Font.Size;
            size++;
            lblText.Font = new Font(
                familyName: "Segoe UI",
                emSize: size);
        }

        private void BtnNagybetus_Click(object? sender, EventArgs e)
        {
            lblText.Text = lblText.Text.ToUpper();
        }

        private void BtnJobbKozep_Click(object? sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleRight;
        }

        private void BtnKozepKozep_Click(object? sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void BtnBalKozep_Click(object? sender, EventArgs e)
        {
            lblText.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void BtnTorol_Click(object? sender, EventArgs e)
        {
            lblText.Text = null;
        }

        private void BtnFeherHatter_Click(object? sender, EventArgs e)
        {
            lblText.BackColor = Color.White;
        }

        private void BtnKekBetu_Click(object? sender, EventArgs e)
        {
            lblText.ForeColor = Color.Blue;
        }
    }
}