namespace NT101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new playfair().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Rsa().Show();
        }

        private void btnLearnAboutRsa_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://vi.wikipedia.org/wiki/RSA_(m%C3%A3_h%C3%B3a)",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }


        private void btnLearnAboutPlayFair_Click(object sender, EventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://vi.wikipedia.org/wiki/M%C3%A3_h%C3%B3a_Playfair",
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }
    }
}
