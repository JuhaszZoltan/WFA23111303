namespace WFA007
{
    public partial class MainForm : Form
    {
        static Random rnd = new();
        public MainForm()
        {
            InitializeComponent();
            btnDobas.Click += BtnDobas_Click;
            tbxDarabszam.TextChanged += TbxDarabszam_TextChanged;
        }

        private void TbxDarabszam_TextChanged(object? sender, EventArgs e)
            => rtbDobasok.Clear();

        private void BtnDobas_Click(object? sender, EventArgs e)
        {
            try
            {
                int db = int.Parse(tbxDarabszam.Text);
                for (int i = 0; i < db; i++)
                    rtbDobasok.Text += $"{rnd.Next(1, 7)} ";
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(text: ex.Message);
            }
        }
    }
}