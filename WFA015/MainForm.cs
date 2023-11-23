using WFA015.Properties;

namespace WFA015
{
    public partial class MainForm : Form
    {
        private static Random rnd = new();
        public MainForm()
        {
            InitializeComponent();
            tbxKedvencSzo.TextChanged += TbxKedvencSzo_TextChanged;
            btnTunjEl.Click += BtnTunjEl_Click;
            btnGyereVissza.Click += BtnGyereVissza_Click;
            pbxSmiley.MouseEnter += PbxSmiley_MouseEnter;
            pbxSmiley.MouseLeave += PbxSmiley_MouseLeave;
            pbxSmiley.Click += PbxSmiley_Click;
        }

        private void PbxSmiley_Click(object? sender, EventArgs e)
        {
            pbxSmiley.Location = new(
                x: rnd.Next(pnlMain.Width - pbxSmiley.Width),
                y: rnd.Next(pnlMain.Height - pbxSmiley.Height));
        }

        private void PbxSmiley_MouseLeave(object? sender, EventArgs e)
        {
            pbxSmiley.Image = Resources.smiley01;
        }

        private void PbxSmiley_MouseEnter(object? sender, EventArgs e)
        {
            pbxSmiley.Image = Resources.smiley02;
        }

        private void BtnGyereVissza_Click(object? sender, EventArgs e)
        {
            pbxSmiley.Show();
            btnGyereVissza.Enabled = false;
            btnTunjEl.Enabled = true;
        }

        private void BtnTunjEl_Click(object? sender, EventArgs e)
        {
            pbxSmiley.Hide();
            btnGyereVissza.Enabled = true;
            btnTunjEl.Enabled = false;
        }

        private void TbxKedvencSzo_TextChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxKedvencSzo.Text))
            {
                tbxKedvencSzo.BackColor = Color.FromArgb(
                    red: rnd.Next(256),
                    green: rnd.Next(256),
                    blue: rnd.Next(256));
            }
            else tbxKedvencSzo.BackColor = Color.White;
        }
    }
}
