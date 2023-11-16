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
                    text: "Valamelyik sz�m form�tuma nem megfelel�!",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
            else if (felso < also)
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "Az intervallum fels� hat�ra nem lehet kisebb, mint az als�!!",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
            else
            {
                lblEredmeny.Text = also <= megadott && megadott <= felso
                    ? "a megadott sz�m az intervallumon bel�l van!"
                    : "a megadott sz�m az intervallumon k�v�l esik!";
            }
        }
    }
}