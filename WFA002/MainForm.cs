namespace WFA002
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnGomb.Click += BtnGomb_Click;
            btnGomb.MouseEnter += BtnGomb_MouseEnter;
            btnGomb.MouseMove += BtnGomb_MouseMove;
            btnGomb.MouseLeave += BtnGomb_MouseLeave;
        }

        private void BtnGomb_MouseLeave(object? sender, EventArgs e)
        {
            this.BackColor = Color.White;
            btnGomb.Text = btnGomb.Text.ToLower();
        }

        private void BtnGomb_MouseMove(object? sender, MouseEventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            this.Text = $"kurzorpozíció: [x:={x};y:={y}]";
        }

        private void BtnGomb_MouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = Color.ForestGreen;
        }

        private void BtnGomb_Click(object? sender, EventArgs e)
        {
            btnGomb.Text = btnGomb.Text.ToUpper();
        }
    }
}