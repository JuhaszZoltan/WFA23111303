namespace WFA014
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnKiszamol.Click += BtnKiszamol_Click;
        }

        private void BtnKiszamol_Click(object? sender, EventArgs e)
        {
            double a = double.Parse(tbxBefogo01.Text);
            double b = double.Parse(tbxBefogo02.Text);

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            rtbOldalak.Text += $"a:={a,4}; b:={b,4}; c:={c,4:0.0};\n";
            tbxBefogo01.Text = null;
            tbxBefogo02.Text = null;
        }
    }
}
