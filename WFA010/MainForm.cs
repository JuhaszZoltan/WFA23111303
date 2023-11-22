namespace WFA010
{
    public partial class MainForm : Form
    {
        private static Random rnd = new();

        public MainForm()
        {
            InitializeComponent();
            btnGeneralas.Click += BtnGeneralas_Click;
        }

        private void BtnGeneralas_Click(object? sender, EventArgs e)
        {
            rtbSzamok.Clear();
            int lk = int.Parse(tbxLKisebb.Text);
            int ln = int.Parse(tbxLNagyobb.Text) + 1;
            for (int i = 0; i < 100; i++) rtbSzamok.Text += $"{rnd.Next(lk, ln)} ";
        }
    }
}
