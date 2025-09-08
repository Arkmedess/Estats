using MathNet.Numerics.Distributions;


namespace Interface_e_sistema_em_C_
{
    public partial class TelaVAC : UserControl, ITela
    {
        private GerenciadorTelas _gerenciadorTelas;
        private Panel _panelContainer;
        private int casoSelecionado = -1;

        #region Construtor
        public TelaVAC(Panel panelContainer, GerenciadorTelas gerenciadorTelas)
        {
            InitializeComponent();
            this.Load += TelaVAC_Load;
            this.Dock = DockStyle.Fill;
            _gerenciadorTelas = gerenciadorTelas;
            _panelContainer = panelContainer;
        }
        #endregion

        #region Backend
        private void DesativarMenuContexto(Control controle)
        {
            foreach (Control c in controle.Controls)
            {
                if (c is TextBox)
                    c.ContextMenuStrip = new ContextMenuStrip();

                if (c.HasChildren)
                    DesativarMenuContexto(c);
            }
        }

        #endregion

        #region Eventos de Tecla
        public void ValidacaoTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (char.IsControl(tecla))
                return;

            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            bool ValidarFi = textBox.Name.StartsWith("Tamanho");

            // ----------- CAMPO Fi: só números inteiros > 0 -----------
            if (ValidarFi)
            {
                if (!char.IsDigit(tecla))
                {
                    e.Handled = true;
                    return;
                }

                string textofinal = textBox.Text.Insert(textBox.SelectionStart, tecla.ToString());

                if (textofinal.StartsWith("0") && textofinal.Length == 1)
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            // ----------- CAMPO Xi: números com vírgula decimal -----------

            // Permite números
            if (char.IsDigit(tecla))
            {
                string textofinal = textBox.Text.Insert(textBox.SelectionStart, tecla.ToString());
                if (textofinal.StartsWith("0") && !textofinal.StartsWith("0,") && textofinal.Length == 1)
                {
                    e.Handled = true;
                }

                return;
            }

            if (tecla == ',')
            {
                if (textBox.Text.Contains(',') || textBox.SelectionStart == 0)
                {
                    e.Handled = true;
                }

                return;
            }

            e.Handled = true;
        }


        private void IconeImportarMedia_Click(object sender, EventArgs e)
        {

            var TelaMedia = _gerenciadorTelas.GetTela<TelaMediaPosicaoCentral>("Média de Posição Central");

            if (TelaMedia != null)
            {
                var (media, _, _, _, _, _, _, _, _) = TelaMedia.CalcularEstatisticas();

                if (media == 0 || double.IsNaN(media))
                {
                    MessageBox.Show("A média deve ser calculada antes de importar seu valor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MediaVAC.Text = media.ToString("F2");
            }

        }

        private void IconeImportarDesvio_Click(object sender, EventArgs e)
        {
            var TelaMedia = _gerenciadorTelas.GetTela<TelaMediaPosicaoCentral>("Média de Posição Central");

            if (TelaMedia != null)
            {
                var (_, desvio, _, _, _, _, _, _, _) = TelaMedia.CalcularEstatisticas();

                if (desvio == 0 || double.IsNaN(desvio))
                {
                    MessageBox.Show("O Desvio Padrão deve ser calculado antes de importar o seu valor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DesvioVAC.Text = desvio.ToString("F2");
            }
        }

        private void IconeImportarAmostra_Click(object sender, EventArgs e)
        {
            var TelaMedia = _gerenciadorTelas.GetTela<TelaMediaPosicaoCentral>("Média de Posição Central");

            if (TelaMedia != null)
            {
                var (_, _, _, _, somaFi, _, _, _, _) = TelaMedia.CalcularEstatisticas();

                if (somaFi == 0 || double.IsNaN(somaFi))
                {
                    MessageBox.Show("O tamanho da amostra (Soma dos valores FI) deve ser calculada antes de importar o seu valor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TamanhoDaAmostraVAC.Text = somaFi.ToString();
            }
        }

        private void CalculoVAC_Click(object sender, EventArgs e)
        {
            int casoSelecionado = this.casoSelecionado;

            if (casoSelecionado < 0 || casoSelecionado > 7)
            {
                MessageBox.Show("Por favor, selecione um caso válido antes de calcular.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Declara as variáveis de saída para os TryParse em um escopo maior
            double mediaVAC2, desvioVAC2, valorDeA2;
            double valorDeB2 = 0; // Inicializa com 0, caso não seja necessário

            // Tenta fazer o parse para os campos obrigatórios
            if (!double.TryParse(MediaVAC.Text, out mediaVAC2))
            {
                MessageBox.Show("Por favor, preencha um valor numérico válido para a Média.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(DesvioVAC.Text, out desvioVAC2))
            {
                MessageBox.Show("Por favor, preencha um valor numérico válido para o Desvio Padrão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validação do desvio padrão
            if (desvioVAC2 <= 0)
            {
                MessageBox.Show("O desvio padrão deve ser um valor positivo e diferente de zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValorDeA.Visible = false || !double.TryParse(ValorDeA.Text, out valorDeA2))
            {
                MessageBox.Show("Por favor, preencha um valor numérico válido para o Valor de A.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool precisaValorB = casoSelecionado == 3 || casoSelecionado == 6 || casoSelecionado == 7;

            if (precisaValorB)
            {
                if (ValorDeB.Visible = false || !double.TryParse(ValorDeB.Text, out valorDeB2))
                {
                    MessageBox.Show("Por favor, preencha um valor numérico válido para B.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            var distribuicaoNormal = new Normal(mediaVAC2, desvioVAC2);


            double probA = distribuicaoNormal.CumulativeDistribution(valorDeA2);
            double probB = distribuicaoNormal.CumulativeDistribution(valorDeB2);
            double probMenosA = distribuicaoNormal.CumulativeDistribution(-valorDeA2);
            double probMenosB = distribuicaoNormal.CumulativeDistribution(-valorDeB2);

            double caso0 = 0;
            double caso1 = 1 - probA;
            double caso2 = probA;
            double caso3 = probB - probA;
            double caso4 = probMenosA;
            double caso5 = 1 - probMenosA;
            double caso6 = probMenosB - probMenosA;
            double caso7 = probB - probMenosA;

            string resultado = "";

            switch (casoSelecionado)
            {
                case 0:
                    resultado =
                        $"📌 Caso 0: P(x = a)\n" +
                        $"→ Para variáveis aleatórias contínuas, a probabilidade de ocorrer exatamente um valor é sempre zero.\n" +
                        $"→ Isso ocorre porque a área sob um ponto específico em uma curva contínua é nula.\n" +
                        $"→ Resultado: P(x = {valorDeA2}) = 0";
                    break;

                case 1:
                    resultado =
                        $"📌 Caso 1: P(x ≥ a)\n" +
                        $"✔️ Etapa 1: Entenda que, em variáveis aleatórias contínuas, P(x ≥ a) = P(x > a), pois a probabilidade em um ponto exato é zero.\n" +
                        $"✔️ Etapa 2: A área sob a curva à direita de {valorDeA2} representa essa probabilidade.\n" +
                        $"✔️ Etapa 3: Usamos a função de distribuição acumulada (CDF) para calcular P(x ≤ {valorDeA2}) = {probA:F4}.\n" +
                        $"✔️ Etapa 4: Calculamos 1 - {probA:F4} para obter a área à direita.\n" +
                        $"🎯 Resultado: P(x ≥ {valorDeA2}) = 1 - {probA:F4} = {caso1:F4}";
                    break;

                case 2:
                    resultado =
                        $"📌 Caso 2: P(x ≤ a)\n" +
                        $"✔️ Etapa 1: Para variáveis contínuas, P(x ≤ a) = P(x < a).\n" +
                        $"✔️ Etapa 2: A função de distribuição acumulada fornece diretamente essa área.\n" +
                        $"✔️ Etapa 3: Basta calcular P(x ≤ {valorDeA2}) = {probA:F4}.\n" +
                        $"🎯 Resultado: P(x ≤ {valorDeA2}) = {probA:F4}";
                    break;

                case 3:
                    resultado =
                        $"📌 Caso 3: P(a ≤ x ≤ b)\n" +
                        $"✔️ Etapa 1: Aqui queremos a área sob a curva entre os valores {valorDeA2} e {valorDeB2}.\n" +
                        $"✔️ Etapa 2: Usamos a função acumulada para obter:\n" +
                        $"  • P(x ≤ {valorDeB2}) = {probB:F4}\n" +
                        $"  • P(x ≤ {valorDeA2}) = {probA:F4}\n" +
                        $"✔️ Etapa 3: Subtraímos as áreas para obter o intervalo:\n" +
                        $"  • {probB:F4} - {probA:F4} = {caso3:F4}\n" +
                        $"🎯 Resultado: P({valorDeA2} ≤ x ≤ {valorDeB2}) = {caso3:F4}";
                    break;

                case 4:
                    resultado =
                        $"📌 Caso 4: P(x ≤ -a)\n" +
                        $"✔️ Etapa 1: Estamos interessados na área à esquerda de -{valorDeA2}.\n" +
                        $"✔️ Etapa 2: A função acumulada já nos dá esse valor diretamente.\n" +
                        $"✔️ Etapa 3: Calculamos P(x ≤ {-valorDeA2}) = {probMenosA:F4}.\n" +
                        $"🎯 Resultado: P(x ≤ {-valorDeA2}) = {probMenosA:F4}";
                    break;

                case 5:
                    resultado =
                        $"📌 Caso 5: P(x ≥ -a)\n" +
                        $"✔️ Etapa 1: Essa é a área à direita de -{valorDeA2}.\n" +
                        $"✔️ Etapa 2: Calculamos P(x ≤ {-valorDeA2}) = {probMenosA:F4}.\n" +
                        $"✔️ Etapa 3: A área complementar à direita é:\n" +
                        $"  • 1 - {probMenosA:F4} = {caso5:F4}\n" +
                        $"🎯 Resultado: P(x ≥ {-valorDeA2}) = {caso5:F4}";
                    break;

                case 6:
                    resultado =
                        $"📌 Caso 6: P(-a ≤ x ≤ -b)\n" +
                        $"✔️ Etapa 1: Estamos buscando a área entre dois valores negativos: -{valorDeA2} e -{valorDeB2}.\n" +
                        $"✔️ Etapa 2: Obtemos as áreas acumuladas até esses pontos:\n" +
                        $"  • P(x ≤ {-valorDeB2}) = {probMenosB:F4}\n" +
                        $"  • P(x ≤ {-valorDeA2}) = {probMenosA:F4}\n" +
                        $"✔️ Etapa 3: Subtraímos para obter a área entre eles:\n" +
                        $"  • {probMenosB:F4} - {probMenosA:F4} = {caso6:F4}\n" +
                        $"🎯 Resultado: P({-valorDeA2} ≤ x ≤ {-valorDeB2}) = {caso6:F4}";
                    break;

                case 7:
                    resultado =
                        $"📌 Caso 7: P(-a ≤ x ≤ +b)\n" +
                        $"✔️ Etapa 1: Agora o intervalo vai de um valor negativo (-{valorDeA2}) até um positivo ({valorDeB2}).\n" +
                        $"✔️ Etapa 2: Calculamos:\n" +
                        $"  • P(x ≤ {valorDeB2}) = {probB:F4}\n" +
                        $"  • P(x ≤ {-valorDeA2}) = {probMenosA:F4}\n" +
                        $"✔️ Etapa 3: Subtraímos as áreas:\n" +
                        $"  • {probB:F4} - {probMenosA:F4} = {caso7:F4}\n" +
                        $"🎯 Resultado: P({-valorDeA2} ≤ x ≤ {valorDeB2}) = {caso7:F4}";
                    break;
            }

            ResultadoVAC.Text = resultado;
        }

        private void Caso0_Click(object sender, EventArgs e)
        {
            ValorDeA.Visible = true;
            ValorDeAText.Visible = true;

            ValorDeB.Visible = false;
            ValorDeBText.Visible = false;

            casoSelecionado = 0;
        }

        private void Caso1_Click(object sender, EventArgs e)
        {
            ValorDeA.Visible = true;
            ValorDeAText.Visible = true;

            ValorDeB.Visible = false;
            ValorDeBText.Visible = false;

            casoSelecionado = 1;
        }

        private void Caso2_Click(object sender, EventArgs e)
        {
            ValorDeA.Visible = true;
            ValorDeAText.Visible = true;

            ValorDeB.Visible = false;
            ValorDeBText.Visible = false;

            casoSelecionado = 2;
        }

        private void Caso3_Click(object sender, EventArgs e)
        {
            ValorDeA.Visible = true;
            ValorDeAText.Visible = true;

            ValorDeB.Visible = true;
            ValorDeBText.Visible = true;

            casoSelecionado = 3;
        }

        private void Caso4_Click(object sender, EventArgs e)
        {
            ValorDeA.Visible = true;
            ValorDeAText.Visible = true;

            ValorDeB.Visible = false;
            ValorDeBText.Visible = false;

            casoSelecionado = 4;
        }

        private void Caso5_Click(object sender, EventArgs e)
        {
            ValorDeA.Visible = true;
            ValorDeAText.Visible = true;

            ValorDeB.Visible = false;
            ValorDeBText.Visible = false;

            casoSelecionado = 5;

        }

        private void Caso6_Click(object sender, EventArgs e)
        {
            ValorDeA.Visible = true;
            ValorDeAText.Visible = true;

            ValorDeB.Visible = true;
            ValorDeBText.Visible = true;

            casoSelecionado = 6;
        }

        private void Caso7_Click(object sender, EventArgs e)
        {
            ValorDeA.Visible = true;
            ValorDeAText.Visible = true;

            ValorDeB.Visible = true;
            ValorDeBText.Visible = true;

            casoSelecionado = 7;
        }

        #endregion

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

        private void LimparRecursos()
        {
            // Sua lógica para liberar recursos
        }

        public UserControl GetView()
        {
            return this;
        }

        #endregion

        private void TelaVAC_Load(object sender, EventArgs e)
        {
            DesativarMenuContexto(this);
        }

    }
}