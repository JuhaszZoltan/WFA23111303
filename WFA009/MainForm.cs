namespace WFA009
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnHozzaadas.Click += BtnHozzaadas_Click;
            btnKijeloltTorlese.Click += BtnKijeloltTorlese_Click;
            btnOsszesTorlese.Click += BtnOsszesTorlese_Click;
        }

        private void BtnOsszesTorlese_Click(object? sender, EventArgs e)
        {
            lsbElemek.Items.Clear();
        }

        private void BtnKijeloltTorlese_Click(object? sender, EventArgs e)
        {
            lsbElemek.Items.Remove(lsbElemek.SelectedItem);
        }

        private void BtnHozzaadas_Click(object? sender, EventArgs e)
        {
            lsbElemek.Items.Add(tbxUjElem.Text);
        }
    }
}
