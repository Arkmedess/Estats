namespace Interface_e_sistema_em_C_
{
    public partial class TelaSobre : UserControl, ITela
    {
        private Form _telaInício;
        public TelaSobre()
        {
            InitializeComponent();
            AddControles();
        }

        public void AddControles() { }


        public void OnCarregar()
        {
            this.Visible = true;
            this.BringToFront();


            CarregarDadosAjuda();
        }


        public void OnDescarregar()
        {
            this.Visible = false;


            LimparRecursos();
        }

        public UserControl GetView()
        {
            return this;
        }

        private void CarregarDadosAjuda() { }

        private void LimparRecursos() { }

        private void linkLblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlGithub = "https://github.com/Arkmedess/Estats";
            try
            {
                var psi4 = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = urlGithub,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi4);
                linkLblGitHub.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLblLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlLinkedIn = "https://linkedin.com/in/arthur-victor-/";
            try
            {
                var psi5 = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = urlLinkedIn,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi5);
                linkLblLinkedIn.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}