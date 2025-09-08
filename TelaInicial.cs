namespace Interface_e_sistema_em_C_
{
    public partial class TelaInicial : UserControl, ITela
    {
        private ITela telaAtual;
        private GerenciadorTelas _gerenciadorTelas;
        private Panel _panelContainer;

        private const int AlturaMinimaFiltro = 0;
        private const int AlturaMaximaFiltro = 100;
        private const int PassoAnimacaoFiltro = 8;
        private bool _filtroAberto = false;
        private bool _animandoFiltro = false;

        private RssNoticiasService _rssNoticiasService = new RssNoticiasService();


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

            _ = CarregarNoticiasAsync();
        }

        public void OnDescarregar()
        {
            this.Visible = false;
            LimparRecursos();
        }

        private void LimparRecursos() { }

        public UserControl GetView() { return this; }

        private async Task CarregarNoticiasAsync()
        {
            await _rssNoticiasService.CarregarNoticiasAsync();
            AtualizarNoticiasFiltradas();
        }

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
                System.Diagnostics.Process.Start(psi2);
                linkGithub.LinkVisited = true;
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
                System.Diagnostics.Process.Start(psi3);
                linkFatec.LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível abrir o link: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcssRapido1_Click(object sender, EventArgs e) { _gerenciadorTelas.MostrarTela("Média de Posição Central"); }

        private void btnAcssRapido2_Click(object sender, EventArgs e) { _gerenciadorTelas.MostrarTela("Variação Aleatória Contínua"); }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (_filtroAberto)
            {
                RecolherFiltro();
            }
            else
            {
                ExpandirFiltro();
            }
        }

        private void ExpandirFiltro()
        {
            if (_animandoFiltro) return;

            _animandoFiltro = true;
            pnFiltrosChkLBox.Visible = true;
            pnFiltrosChkLBox.Height = 0;
            chkLBoxFiltro.Height = AlturaMaximaFiltro;
            chkLBoxFiltroTransicao.Start();
        }

        private void RecolherFiltro()
        {
            if (_animandoFiltro) return;

            _animandoFiltro = true;
            chkLBoxFiltroTransicao.Start();
        }

        private void chkLBoxFiltroTransicao_Tick(object sender, EventArgs e)
        {
            if (_filtroAberto)
            {
                // Rec
                pnFiltrosChkLBox.Height = Math.Max(pnFiltrosChkLBox.Height - PassoAnimacaoFiltro, AlturaMinimaFiltro);

                if (pnFiltrosChkLBox.Height <= AlturaMinimaFiltro)
                {
                    pnFiltrosChkLBox.Height = AlturaMinimaFiltro;
                    pnFiltrosChkLBox.Visible = false;
                    chkLBoxFiltroTransicao.Stop();
                    _animandoFiltro = false;
                    _filtroAberto = false;
                }
            }
            else
            {
                // Exp
                pnFiltrosChkLBox.Height = Math.Min(pnFiltrosChkLBox.Height + PassoAnimacaoFiltro, AlturaMaximaFiltro);

                if (pnFiltrosChkLBox.Height >= AlturaMaximaFiltro)
                {
                    pnFiltrosChkLBox.Height = AlturaMaximaFiltro;
                    chkLBoxFiltroTransicao.Stop();
                    _animandoFiltro = false;
                    _filtroAberto = true;
                }
            }
        }

        private void chkLBoxFiltro_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string valor = chkLBoxFiltro.Items[e.Index].ToString();

            if (e.NewValue == CheckState.Checked)
            {
                if (!_rssNoticiasService.FiltroPalavras.Contains(valor))
                {
                    _rssNoticiasService.FiltroPalavras.Add(valor);
                }
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                _rssNoticiasService.FiltroPalavras.Remove(valor);
            }

            AtualizarNoticiasFiltradas();
        }


        private async void AtualizarNoticiasFiltradas()
        {
            var noticiasFiltradas = _rssNoticiasService.FiltroNoticias();

            var topNoticias = noticiasFiltradas.Take(4).ToList();

            var labels = new[] { linkLblNoticia1, linkLblNoticia2, linkLblNoticia3, linkLblNoticia4 };

            for (int i = 0; i < labels.Length; i++)
            {
                if (i < topNoticias.Count)
                {
                    var noticia = topNoticias[i];
                    labels[i].Text = LimitarTitulo(noticia.Titulo, 80);
                    labels[i].Tag = noticia.Link;
                    labels[i].Visible = true;
                }
                else
                {
                    labels[i].Visible = false;
                }
            }
        }

        private string LimitarTitulo(string titulo, int limite = 80)
        {
            if (string.IsNullOrEmpty(titulo)) return "";
            return titulo.Length > limite ? titulo.Substring(0, limite) + "..." : titulo;
        }

        private void linkLblNoticia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender is LinkLabel lbl && lbl.Tag is string link && !string.IsNullOrEmpty(link))
            {
                try
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = link,
                        UseShellExecute = true
                    };
                    System.Diagnostics.Process.Start(psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Não foi possível abrir a notícia: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
