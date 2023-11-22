namespace WFA013
{
    public partial class MainForm : Form
    {
        private static Random rnd = new();
        private Button[] gepGombok;

        private int jatekosPont = 0;
        private int gepPont = 0;


        public MainForm()
        {
            InitializeComponent();

            gepGombok = new Button[] {
                btnGepKo,
                btnGepPapir,
                btnGepOllo,
            };

            btnJatekosKo.Click += BtnJatekos_Click;
            btnJatekosPapir.Click += BtnJatekos_Click;
            btnJatekosOllo.Click += BtnJatekos_Click;
        }

        private void BtnJatekos_Click(object? sender, EventArgs e)
        {
            SzinReset();

            Button jatGomb = sender as Button;
            jatGomb.BackColor = Color.LightGreen;

            Button gepGomb = gepGombok[rnd.Next(gepGombok.Length)];
            gepGomb.BackColor = Color.LightGreen;

            char nyertes = Kiertekel(jatGomb.Text, gepGomb.Text);

            if (nyertes == 'g') gepPont++;
            else if (nyertes == 'j') jatekosPont++;

            lblJatekosPont.Text = $"pont: {jatekosPont}";
            lblGepPont.Text = $"pont: {gepPont}";
        }

        private char Kiertekel(string jat, string gep)
        {
            if (jat == gep) return 'd';
            else if (
                (jat == "KÕ"    && gep == "OLLÓ") ||
                (jat == "PAPÍR" && gep == "KÕ"  ) ||
                (jat == "OLLÓ"  && gep == "PAPÍR")) 
                return 'j';
            else return 'g';
        }

        private void SzinReset()
        {
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Button) (ctrl as Button).BackColor = Color.White; 
            }
        }
    }
}
