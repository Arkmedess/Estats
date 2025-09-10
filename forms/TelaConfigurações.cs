using Estats.apis;
using Estats.manager;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Estats
{
    public partial class TelaConfig : UserControl, ITela
    {
        private Form _TelaInicio;
        private class _ApiKeyManager;
        public TelaConfig()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public void OnCarregar()
        {
            this.Visible = true;
            this.BringToFront();
            CarregarDadosConfig();
        }

        public void OnDescarregar()
        {
            this.Visible = false;

            LimparRecursos();
        }

        public UserControl GetView() { return this; }

        private void CarregarDadosConfig() { }

        private void LimparRecursos() { }

        private void TelaConfig_Load(object sender, EventArgs e) { }

        private void btnSalvarAPI_Click(object sender, EventArgs e)
        {
            string ChaveAPI = txtChaveAPI.Text.Trim();

            if (string.IsNullOrEmpty(ChaveAPI))
            {
                MessageBox.Show("Por favor, insira a chave API do Groq.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ApiKeyManager.SalvarChaveAPI(ChaveAPI);

            MessageBox.Show("Chave API registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkGroqAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://console.groq.com/",
                UseShellExecute = true
            });
        }

        private void btnObterChaveAPI_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://console.groq.com/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inicializar o navegador. Por favor acesse: https://console.groq.com/ para obter a chave.", "Acesso ao site", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkMostrarAPI_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarAPI.Checked)
            {
                txtChaveAPI.PasswordChar = '\0';
            }
            else
            {
                txtChaveAPI.PasswordChar = '*';
            }

        }

        private async void btnTesteConexao_Click(object sender, EventArgs e)
        {
            string ChaveAPI = txtChaveAPI.Text.Trim();

            if (string.IsNullOrEmpty(ChaveAPI))
            {
                MessageBox.Show("Por favor, insira uma chave de API.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTesteConexao.Enabled = false;
            btnTesteConexao.Text = "Testando...";

            try
            {
                var GroqService = new GroqService(ChaveAPI);
                bool ConexaoOK = await GroqService.TestarConexaoAsync();

                if (ConexaoOK)
                {
                    MessageBox.Show("Conexão com a API Groq realizada com sucesso!", "Sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ApiKeyManager.SalvarChaveAPI(ChaveAPI);
                }
                else
                {
                    MessageBox.Show("Falha na conexão com a API Groq. Verifique sua conexão com a internet e a chave inserida e tente novamente.", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}"  , "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnTesteConexao.Enabled = true;
                btnTesteConexao.Text = "Testar conexão";
            }
        }
    }
}