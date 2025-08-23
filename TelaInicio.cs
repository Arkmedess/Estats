namespace Interface_e_sistema_em_C_
{
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.Design;

    public partial class Base : Form
    {
        #region Campos e Propriedades

        private Dictionary<string, ITela> telas = new Dictionary<string, ITela>();
        public Panel panelContainer;
        private bool _menuAberto = false;
        private GerenciadorTelas _gerenciadorTelas;
        private bool _menuAlvoAberto;  // True aberto, false fechado


        #endregion

        #region Construtor e Inicializa��o

        public Base()
        {
            InitializeComponent();
            SetupContainer();
            AjustarPosicaoBotoes();
            _gerenciadorTelas = new GerenciadorTelas(panelContainer);
            _gerenciadorTelas.MostrarTela("Inicial");
        }

        private void SetupContainer()
        {
            panelContainer = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };
            this.Controls.Add(panelContainer);
        }

        #endregion

        #region Eventos do Formul�rio

        private void Base_Load(object sender, EventArgs e)
        {
            RemoverBordasBotoes();

            string chaveAPI = ApiKeyManager.CarregarChaveAPI();

            if (string.IsNullOrEmpty(chaveAPI))
            {
                _gerenciadorTelas.MostrarTela("Configura��es");

                // Verifica novamente ap�s mostrar configura��es (caso o usu�rio j� tenha colocado)
                chaveAPI = ApiKeyManager.CarregarChaveAPI();

                if (string.IsNullOrEmpty(chaveAPI))
                {
                    var resultado = MessageBox.Show(
                        "Parece que voc� ainda n�o configurou sua chave de API do Groq.\n\n" +
                        "Com ela, voc� ter� acesso a recursos avan�ados como gera��o de texto, vis�o, �udio e muito mais.\n\n" +
                        "Voc� pode adicionar a chave agora na tela de Configura��es ou clicar em 'Obter chave gratuita' para criar uma conta no Groq.",
                        "Chave de API recomendada",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = "https://console.groq.com/",
                                UseShellExecute = true
                            });
                        }
                        catch
                        {
                            MessageBox.Show(
                                "N�o foi poss�vel abrir o navegador. Acesse: https://console.groq.com/",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    // Se o usu�rio clicar em "N�o, obrigado", o app continua normalmente (sem bloqueio)
                }
            }

            // Aqui o app continua carregando � talvez desative certos recursos se n�o houver API
            //AtualizarEstadoFuncionalidades(chaveAPI);
        }


        #endregion

        #region Barra Lateral

        private void Barra_lateral_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Botao_Tres_Barras_Click(object sender, EventArgs e)
        {
            _menuAlvoAberto = !_menuAberto;
            BarraLateralTransicao.Start();
        }

        private void AjustarPosicaoBotoes()
        {
            MenuFerramentas.PerformLayout();
            Barra_lateral_menu.SuspendLayout();

            int posicaoY = MenuFerramentas.Bottom;

            // Bot�o Configura��es
            if (pnConfig != null)
            {
                pnConfig.Visible = true;
                pnConfig.Top = posicaoY - 3;
                posicaoY = pnConfig.Bottom - 1;
            }

            // Bot�o Sobre
            if (pnSobre != null)
            {
                pnSobre.Visible = true;
                pnSobre.Top = posicaoY - 1;
                posicaoY = pnSobre.Bottom - 1;
            }

            // Bot�o Sair
            if (pnSair != null)
            {
                pnSair.Visible = true;
                pnSair.Top = posicaoY;
            }

            Barra_lateral_menu.ResumeLayout();
            Barra_lateral_menu.Refresh();
        }

        #endregion

        #region Bot�es do Menu

        private void BotaoInicio_MouseClick(object sender, MouseEventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Inicial");
        }

        private void BotaoFerramentas_Click(object sender, EventArgs e)
        {
            MenuTransicao.Start();
        }

        private void BotaoEstatParametrica_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("M�dia de Posi��o Central");
        }

        private void BotaoVAC_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Varia��o Aleat�ria Cont�nua");
        }

        private void BotaoConfiguracoes_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Configura��es");
        }

        private void BotaoSobre_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Sobre");
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        #endregion

        private void Rodape_Barra_Lateral_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(100, 79, 55, 139), 5))
            {
                e.Graphics.DrawLine(pen, 0, 0, Rodape_Barra_Lateral.Width, 0);
            }
        }

        private bool MenuExpansao = false;
        private void MenuTransicao_Tick(object sender, EventArgs e)
        {
            if (MenuExpansao == false)
            {
                MenuFerramentas.Height += 20;
                if (MenuFerramentas.Height >= 171)
                {
                    MenuTransicao.Stop();
                    MenuExpansao = true;
                }
            }
            else
            {
                MenuFerramentas.Height -= 20;
                if (MenuFerramentas.Height <= 71)
                {
                    MenuTransicao.Stop();
                    MenuExpansao = false;
                }
            }
            AjustarPosicaoBotoes();
        }

        private void BarraLateralTransicao_Tick(object sender, EventArgs e)
        {
            if (_menuAlvoAberto)
            {
                // Abrindo o menu
                Barra_lateral_menu.Width += 20;
                if (Barra_lateral_menu.Width >= 255)
                {
                    BarraLateralTransicao.Stop();
                    _menuAberto = true;

                    RestaurarBotoesOriginais();
                    btnFerramentas.Enabled = true;
                }
            }
            else
            {
                // Fechando o menu
                Barra_lateral_menu.Width -= 20;
                if (Barra_lateral_menu.Width <= 61)
                {
                    BarraLateralTransicao.Stop();
                    _menuAberto = false;

                    RemoverBordasBotoes();
                    btnFerramentas.Enabled = false;

                    // Fecha expans�o tamb�m
                    MenuExpansao = false;
                    MenuFerramentas.Height = 71;
                    MenuTransicao.Stop();
                }
            }

            AjustarPosicaoBotoes();
        }


        private void RestaurarBotoesOriginais()
        {
            foreach (Control ctrl in Barra_lateral_menu.Controls)
            {
                if (ctrl is Button botao)
                {
                    botao.FlatStyle = FlatStyle.Standard;
                    botao.FlatAppearance.BorderSize = 1;
                    botao.TabStop = true;
                }
                else if (ctrl is Panel painel)
                {
                    foreach (Control inner in painel.Controls)
                    {
                        if (inner is Button botaoInner)
                        {
                            botaoInner.FlatStyle = FlatStyle.Standard;
                            botaoInner.FlatAppearance.BorderSize = 1;
                            botaoInner.TabStop = true;
                        }
                    }
                }
            }
        }

        private void RemoverBordasBotoes()
        {
            foreach (Control ctrl in Barra_lateral_menu.Controls)
            {
                if (ctrl is Button botao)
                {
                    botao.FlatStyle = FlatStyle.Flat;
                    botao.FlatAppearance.BorderSize = 0;
                    botao.TabStop = false;
                    botao.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 15, 15);
                    botao.MouseDown += (s, e) => { /* Faz nada */ };
                }
                else if (ctrl is Panel painel)
                {
                    foreach (Control inner in painel.Controls)
                    {
                        if (inner is Button botaoInner)
                        {
                            botaoInner.FlatStyle = FlatStyle.Flat;
                            botaoInner.FlatAppearance.BorderSize = 0;
                            botaoInner.TabStop = false;
                            botaoInner.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 15, 15);
                            botaoInner.MouseDown += (s, e) => { /* Faz nada */ };
                        }
                    }
                }
            }
        }
    }
}

