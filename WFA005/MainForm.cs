namespace WFA005
{
    public partial class MainForm : Form
    {
        float elsoAdat;
        float masodikAdat;

        public MainForm()
        {
            InitializeComponent();
            btnOsszeadas.Click += BtnOsszeadas_Click;
            btnKivonas.Click += BtnKivonas_Click;
            btnSzorzas.Click += BtnSzorzas_Click;
            btnOsztas.Click += BtnOsztas_Click;
            tbxElsoAdat.TextChanged += TbxAdat_TextChanged;
            tbxMasodikAdat.TextChanged += TbxAdat_TextChanged;
            btnTorles.Click += BtnTorles_Click;
        }

        private void BtnTorles_Click(object? sender, EventArgs e)
        {
            tbxElsoAdat.Text = null;
            tbxMasodikAdat.Text = null;
            lblEredmeny.Text = null;
        }

        private void TbxAdat_TextChanged(object? sender, EventArgs e)
        {
            lblMuvelet.Text = "###m�velet###";
            lblEredmeny.Text = null;
        }

        private void BtnOsztas_Click(object? sender, EventArgs e)
        {
            if (AdatokAtalakitasa())
            {
                if (masodikAdat == 0)
                {
                    _ = MessageBox.Show(
                        caption: "HIBA",
                        text: "Null�val nem lehet osztani!!",
                        icon: MessageBoxIcon.Error,
                        buttons: MessageBoxButtons.OK);
                }
                else
                {
                    lblMuvelet.Text = "oszt�s";
                    lblEredmeny.Text = $"{elsoAdat / masodikAdat}";
                }
            }
        }

        private void BtnSzorzas_Click(object? sender, EventArgs e)
        {
            if (AdatokAtalakitasa())
            {
                lblMuvelet.Text = "szorz�s";
                lblEredmeny.Text = $"{elsoAdat * masodikAdat}";
            }
        }

        private bool AdatokAtalakitasa()
        {
            bool elsoSiker = float.TryParse(tbxElsoAdat.Text, out elsoAdat);
            bool masodikSiker = float.TryParse(tbxMasodikAdat.Text, out masodikAdat);

            if (!elsoSiker || !masodikSiker)
            {
                _ = MessageBox.Show(
                    caption: "HIBA",
                    text: "Az adatok �talak�t�sa nem siker�lt!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            return elsoSiker && masodikSiker;
        }

        private void BtnKivonas_Click(object? sender, EventArgs e)
        {
            if (AdatokAtalakitasa())
            {
                lblMuvelet.Text = "kivon�s";
                lblEredmeny.Text = $"{elsoAdat - masodikAdat}";
            }
        }

        private void BtnOsszeadas_Click(object? sender, EventArgs e)
        {
            if (AdatokAtalakitasa())
            {
                lblMuvelet.Text = "�sszead�s";
                lblEredmeny.Text = $"{elsoAdat + masodikAdat}";
            }
        }
    }
}