namespace WFA012
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
            lblX1.Text = null;
            lblX2.Text = null;

            double a = double.Parse(tbxA.Text);
            double b = double.Parse(tbxB.Text);
            double c = double.Parse(tbxC.Text);

            if (a == 0)
            {
                lblX1.Text = $"{-c / b} (nem másodfokú)";
                lblX2.Text = null;
            }
            else
            {
                double D = Math.Pow(b, 2) - 4 * a * c;
                if (D == 0)
                {
                    lblX1.Text = $"{-b / (2 * a):0.000} (egy valós gyök)";
                    lblX2.Text = null;
                }
                else if (D < 0)
                {
                    lblX1.Text = $"nincs valós gyök!";
                    lblX2.Text = null;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    lblX1.Text = $"{x1:0.0000}";
                    lblX2.Text = $"{x2:0.0000}";
                }
            }
        }
    }
}
