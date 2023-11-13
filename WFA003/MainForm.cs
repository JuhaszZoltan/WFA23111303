namespace WFA003
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblCoral.Click += ColoredLabel_Click;
            lblGold.Click += ColoredLabel_Click;
            lblGreen.Click += ColoredLabel_Click;
            lblOrchid.Click += ColoredLabel_Click;

            btnAlaphelyzet.Click += BtnAlaphelyzet_Click;
            btnKilepes.Click += BtnKilepes_Click; ;
        }

        private void BtnKilepes_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAlaphelyzet_Click(object? sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ColoredLabel_Click(object? sender, EventArgs e)
        {
            this.BackColor = (sender as Label).BackColor;
        }
    }
}