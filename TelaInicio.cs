    namespace Interface_e_sistema_em_C_
    {
    using System.Diagnostics.Eventing.Reader;
    using System.Drawing;
        using System.Drawing.Drawing2D;
        using System.Drawing.Text;
        using System.Reflection.Emit;
        using System.Windows.Forms;

    public partial class Base : Form
    {
        #region Campos e Propriedades

        private Dictionary<string, ITela> telas = new Dictionary<string, ITela>();
        private ITela telaAtual;
        public Panel panelContainer;
        private double _Largura_Barra_lateral;
        private bool _menuAberto = true;
        private bool _BotaoFerrAberto = false;
        private GerenciadorTelas _gerenciadorTelas;

        #endregion

        #region Construtor e Inicialização

        public Base()
        {
            InitializeComponent();
            SetupContainer();
            AjustarPosicaoBotoes();
            _gerenciadorTelas = new GerenciadorTelas(panelContainer);
            _gerenciadorTelas.MostrarTela("Início");

            _Largura_Barra_lateral = 260;
            Barra_lateral_menu.Width = (int)_Largura_Barra_lateral;
            Barra_lateral_menu.BringToFront();

            Barra_lateral_menu.Paint += Barra_lateral_menu_Paint;
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

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void Base_Load(object sender, EventArgs e)
        {
        }

        #endregion

        #region Barra Lateral

        private void Barra_lateral_menu_Paint(object sender, PaintEventArgs e)
        {
            if (!_menuAberto) return;

            using (Pen pen = new Pen(Color.FromArgb(100, 79, 55, 139), 5))
            {
                e.Graphics.DrawLine(pen, Barra_lateral_menu.Width - 3, 0, Barra_lateral_menu.Width - 3, Barra_lateral_menu.Height);
            }
        }

        private void Botao_Tres_Barras_Click(object sender, EventArgs e)
        {
            _menuAberto = !_menuAberto;

            Barra_lateral_menu.Width = _menuAberto
                ? (int)_Largura_Barra_lateral
                : (int)(_Largura_Barra_lateral / 3.15);

            foreach (Control controle in Barra_lateral_menu.Controls)
            {
                if (controle == SubFerramentas)
                {
                    controle.Visible = _menuAberto && _BotaoFerrAberto;
                }
                else if (controle is Panel)
                {
                    controle.Visible = _menuAberto;
                }
            }
        }

        private void AjustarPosicaoBotoes()
        {
            int posicaoY = BotaoFerramentas.Bottom + 10;

            if (SubFerramentas.Visible)
            {
                SubFerramentas.Location = new Point(BotaoFerramentas.Location.X, BotaoFerramentas.Bottom);
                posicaoY = SubFerramentas.Bottom + 10;
            }
            else
            {
                SubFerramentas.Visible = false;
            }

            if (BotaoConfiguracoes != null)
            {
                BotaoConfiguracoes.Visible = true;
                BotaoConfiguracoes.Top = posicaoY;
                posicaoY = BotaoConfiguracoes.Bottom + 10;
            }

            if (BotaoSobre != null)
            {
                BotaoSobre.Visible = true;
                BotaoSobre.Top = posicaoY;
                posicaoY = BotaoSobre.Bottom + 10;
            }

            if (BotaoSair != null)
            {
                BotaoSair.Visible = true;
                BotaoSair.Top = posicaoY;
            }

            Barra_lateral_menu.Refresh();
        }

        #endregion

        #region Barra Superior

        private void Barra_superior_roxa_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion

        #region Botões do Menu

        private void BotaoInicio_MouseClick(object sender, MouseEventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Início");
        }

        private void BotaoFerramentas_Click(object sender, EventArgs e)
        {
            _BotaoFerrAberto = !_BotaoFerrAberto;
            SubFerramentas.Visible = _BotaoFerrAberto;
            AjustarPosicaoBotoes();
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

        private void BotaoPesquisar_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion

        #region Rodapé

        private void Rodape_Barra_Lateral_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(100, 79, 55, 139), 5))
            {
                e.Graphics.DrawLine(pen, 0, 0, Rodape_Barra_Lateral.Width, 0);
            }
        }

        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVAC_Click(object sender, EventArgs e)
        {

        }
    }
}
