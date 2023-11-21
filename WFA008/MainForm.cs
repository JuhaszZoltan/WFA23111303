namespace WFA008
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnOsztok.Click += BtnOsztok_Click;
        }

        private void BtnOsztok_Click(object? sender, EventArgs e)
        {
            lsbOsztok.Items.Clear();

            int n = int.Parse(tbxSzam.Text);
            if (n <= 0)
            {
                _ = MessageBox.Show(
                    "Az 'oszhatóság'ot csak a természetes számok halmazán értelmezzük");
            }
            else
            {
                lsbOsztok.Items.Add(1);
                if (n > 1)
                {
                    for (int i = 2; i <= n / 2; i++)
                    {
                        if (n % i == 0) lsbOsztok.Items.Add(i);
                    }
                    lsbOsztok.Items.Add(n);
                }
            }
        }
    }
}