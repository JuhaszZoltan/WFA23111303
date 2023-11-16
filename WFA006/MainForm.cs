namespace WFA006
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnMegallapit.Click += BtnMegallapit_Click;
        }

        private void BtnMegallapit_Click(object? sender, EventArgs e)
        {
            bool alsoSiker = int.TryParse(tbxAlso.Text, out int also);
            bool felsoSiker = int.TryParse(tbxFelso.Text, out int felso);
            bool megadottSiker = int.TryParse(tbxMegadott.Text, out int megadott);

            if (!alsoSiker || !felsoSiker || !megadottSiker)
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "Valamelyik szám formátuma nem megfelelõ!",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
            else if (felso < also)
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "Az intervallum felsõ határa nem lehet kisebb, mint az alsó!!",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
            else
            {
                lblEredmeny.Text = also <= megadott && megadott <= felso
                    ? "a megadott szám az intervallumon belül van!"
                    : "a megadott szám az intervallumon kívül esik!";
            }
        }
    }
}