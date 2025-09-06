namespace Interface_e_sistema_em_C_
{
    public partial class TelaInicial : UserControl, ITela
    {
        private ITela telaAtual;
        private GerenciadorTelas _gerenciadorTelas;
        private Panel _panelContainer;

        public TelaInicial(Panel panelContainer, GerenciadorTelas gerenciadorTelas)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _gerenciadorTelas = gerenciadorTelas;
            _panelContainer = panelContainer;
        }

        #region Ciclo de Vida da Tela
        public void OnCarregar()
        {
            this.Visible = true;
            this.BringToFront();
        }

        public void OnDescarregar()
        {
            this.Visible = false;
            LimparRecursos();
        }

        private void LimparRecursos() { }

        public UserControl GetView() { return this; }

        #endregion

        private void linkYoutube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlYTB = "https://www.youtube.com/@joaocsantos6964/featured";

            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = urlYTB,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
                linkYoutube.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkUSP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlUSP = "https://www.ime.usp.br/~belitsky/wiki/lib/exe/fetch.php?media=teaching:vas_continuas_normal.pdf";

            try
            {
                var psi1 = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = urlUSP,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi1);
                linkYoutube.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnTelaInicial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlGit = "https://github.com/Arkmedess/Estats";

            try
            {
                var psi2 = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = urlGit,
                    UseShellExecute = true
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkFatec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlFatec = "https://fatecjd.edu.br/site";

            try
            {
                var psi3 = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = urlFatec,
                    UseShellExecute = true
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TituloBoasVindas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Estatística Paramétrica");
        }
    }
}
