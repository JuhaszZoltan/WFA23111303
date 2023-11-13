namespace WFA001
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblHello.Click += LblHello_Click;
        }

        private void LblHello_Click(object? sender, EventArgs e)
        {
            _ = MessageBox.Show("Hello, World!");
        }
    }
}