namespace Interface_e_sistema_em_C_
{
    public partial class TelaConfig : UserControl, ITela
    {
        private Form _TelaInicio;
        public TelaConfig()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill; // Preenche o espaço disponível
        }

        // Este método é chamado quando a tela é carregada para exibição
        public void OnCarregar()
        {
            this.Visible = true;
            this.BringToFront();
            // Adicione aqui a lógica de inicialização específica
            CarregarDadosConfig();
        }

        // Este método é chamado quando a tela é descarregada para ocultação
        public void OnDescarregar()
        {
            this.Visible = false;

            // Adicione aqui a lógica de limpeza
            LimparRecursos();
        }

        // Implementação explícita de GetView
        public UserControl GetView()
        {
            return this;
        }

        private void CarregarDadosConfig()
        {
            // Sua lógica para carregar dados
        }

        private void LimparRecursos()
        {
            // Sua lógica para liberar recursos
        }

        private void TelaConfig_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}