namespace Interface_e_sistema_em_C_
{
    public partial class TelaEstatisticaParametrica : UserControl, ITela
    {
        private GerenciadorTelas _gerenciadorTelas;
        public TelaEstatisticaParametrica(GerenciadorTelas gerenciadorTelas)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _gerenciadorTelas = gerenciadorTelas;
        }

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

        private void BlocoEstatPar_Paint(object sender, PaintEventArgs e) { }

        private void BotaoMediaDispersao_Click(object sender, EventArgs e) { }
        private void BotaoMediaPosCentral_Click(object sender, EventArgs e) { _gerenciadorTelas.MostrarTela("Média de Posição Central"); }

        private void TelaEstatisticaParametrica_Load(object sender, EventArgs e) { }
    }
}
