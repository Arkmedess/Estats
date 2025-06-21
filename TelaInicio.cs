namespace Interface_e_sistema_em_C_
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Base : Form
    {
        #region Campos e Propriedades

        private Dictionary<string, ITela> telas = new Dictionary<string, ITela>();
        public Panel panelContainer;
        private bool _menuAberto = false;
        private GerenciadorTelas _gerenciadorTelas;
        private bool _menuAlvoAberto;  // True aberto, false fechado


        #endregion

        #region Construtor e Inicialização

        public Base()
        {
            InitializeComponent();
            SetupContainer();
            AjustarPosicaoBotoes();
            _gerenciadorTelas = new GerenciadorTelas(panelContainer);
            _gerenciadorTelas.MostrarTela("Inicial");


            // Barra_lateral_menu.Paint += Barra_lateral_menu_Paint;
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

        #region Eventos do Formulário

        private void Base_Load(object sender, EventArgs e)
        {
            RemoverBordasBotoes();
        }

        #endregion

        #region Barra Lateral

        private void Barra_lateral_menu_Paint(object sender, PaintEventArgs e)
        {
            /*if (!_menuAberto) return;

            using (Pen pen = new Pen(Color.FromArgb(100, 79, 55, 139), 5))
            {
                e.Graphics.DrawLine(pen, Barra_lateral_menu.Width - 3, 0, Barra_lateral_menu.Width - 3, Barra_lateral_menu.Height);
            }*/
        }

        private void Botao_Tres_Barras_Click(object sender, EventArgs e)
        {
            /*_menuAberto = !_menuAberto;

            if (_menuAberto)
            {
                Barra_lateral_menu.Width = 255;
                RestaurarBotoesOriginais();


                btnFerramentas.Enabled = true;
            }
            else
            {
                Barra_lateral_menu.Width = 61;
                RemoverBordasBotoes();

                btnFerramentas.Enabled = false;

                // IMPORTANTE: Quando fecha o menu, fecha a expansão
                MenuExpansao = false;
                MenuFerramentas.Height = 71;  // Altura mínima para esconder os botões dentro do painel
                MenuTransicao.Stop();
            }

                AjustarPosicaoBotoes();
            }*/

            _menuAlvoAberto = !_menuAberto;
            BarraLateralTransicao.Start();
        }

        private void AjustarPosicaoBotoes()
        {
            // Garante que o FlowLayoutPanel esteja com altura correta e atualizada
            MenuFerramentas.PerformLayout();
            Barra_lateral_menu.SuspendLayout();

            int posicaoY = MenuFerramentas.Bottom;

            // Botão Configurações
            if (pnConfig != null)
            {
                pnConfig.Visible = true;
                pnConfig.Top = posicaoY - 3;
                posicaoY = pnConfig.Bottom - 1;
            }

            // Botão Sobre
            if (pnSobre != null)
            {
                pnSobre.Visible = true;
                pnSobre.Top = posicaoY - 1;
                posicaoY = pnSobre.Bottom - 1;
            }

            // Botão Sair
            if (pnSair != null)
            {
                pnSair.Visible = true;
                pnSair.Top = posicaoY;
            }

            Barra_lateral_menu.ResumeLayout();
            Barra_lateral_menu.Refresh();
        }

        #endregion

        #region Botões do Menu

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
            _gerenciadorTelas.MostrarTela("Média de Posição Central");
        }

        private void BotaoVAC_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Variação Aleatória Contínua");
        }

        private void BotaoConfiguracoes_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Configurações");
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

                    // Fecha expansão também
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
