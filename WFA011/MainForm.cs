namespace WFA011
{
    
    public partial class MainForm : Form
    {
        private List<Dolgozat> dolgozatok = new();
        public MainForm()
        {
            InitializeComponent();
            btnAdatbevitel.Click += BtnAdatbevitel_Click;
            btnAtlagpontszam.Click += BtnAtlagpontszam_Click;
        }

        private void BtnAtlagpontszam_Click(object? sender, EventArgs e)
        {
            lblAtlagpontszam.Text = $"{dolgozatok.Average(d => d.Pontszam):0.00}";
        }

        private void BtnAdatbevitel_Click(object? sender, EventArgs e)
        {
            lblAtlagpontszam.Text = null;

            string nev = tbxNev.Text;
            int pontszam = int.Parse(tbxPontszam.Text);

            rtbPontszamok.Text += $"{nev,-20} {pontszam,3}\n";
            dolgozatok.Add(new(nev, pontszam));

            tbxNev.Text = null;
            tbxPontszam.Text = null;
        }
    }
}
