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
            // Adicione aqui a lógica de inicialização específica
        }

        // Este método é chamado quando a tela é descarregada para ocultação
        public void OnDescarregar()
        {
            this.Visible = false;
            LimparRecursos();
        }

        private void LimparRecursos()
        {
            // Sua lógica para liberar recursos
        }

        // Implementação explícita de GetView
        public UserControl GetView()
        {
            return this;
        }

        private void BlocoEstatPar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotaoMediaDispersao_Click(object sender, EventArgs e)
        {

        }
        private void BotaoMediaPosCentral_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Média de Posição Central");
        }

        private void TelaEstatisticaParametrica_Load(object sender, EventArgs e)
        {

        }
    }
}
