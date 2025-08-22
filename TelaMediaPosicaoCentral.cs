#region Usings

using System.Globalization;
#endregion

namespace Interface_e_sistema_em_C_

{

    public partial class TelaMediaPosicaoCentral : UserControl, ITela
    {
        #region Campos
        private int proximoXiFiY = 40;
        private int XiX, FiX;
        private List<TextBox> listaXi = new List<TextBox>();
        private List<TextBox> listaFi = new List<TextBox>();
        private List<(TextBox Xi, TextBox Fi, Button BotaoRemover)> listaXiFi = new List<(TextBox, TextBox, Button)>();
        private GerenciadorTelas _gerenciadorTelas;
        private bool DeveAdicionarNovoPar = false;
        private bool podeAdicionar = true;
        private Panel _panelContainer;
        private List<string> listaPassos;
        private int indiceAtualGeral = 0;
        private List<string> textosSequenciais;
        private List<string> resultadosSequenciais;
        private List<string> titulosSequenciais;
        #endregion

        #region Construtor
        public TelaMediaPosicaoCentral(Panel panelContainer, GerenciadorTelas gerenciadorTelas)
        {
            InitializeComponent();
            this.Load += TelaMediaPosicaoCentral_Load;
            this.Dock = DockStyle.Fill;
            _gerenciadorTelas = gerenciadorTelas;
            _panelContainer = panelContainer;

            XiX = Xi1.Location.X;
            FiX = Fi1.Location.X;

            listaXi.Add(Xi1);
            listaFi.Add(Fi1);

            proximoXiFiY = 40;
        }
        #endregion

        #region Adição e Remoção de Pares Xi/Fi
        private void AdicionarNovoPar()
        {
            if (listaXiFi.Count > 1)
            {
                var ultimoPar = listaXiFi.Last();
                if (ultimoPar.Xi.Text == "" || ultimoPar.Fi.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos antes de adicionar um novo par.");
                    return;
                }
            }

            TextBox novoXi = CopiarConfiguracao(Xi1);
            novoXi.Location = new Point(XiX, proximoXiFiY);
            novoXi.TextChanged += VerificacaoNovoPar;
            novoXi.KeyPress += XiFi_KeyPress;
            novoXi.KeyDown += NovoXi_KeyDown;

            TextBox novoFi = CopiarConfiguracao(Fi1);
            novoFi.Location = new Point(FiX, proximoXiFiY);
            novoFi.TextChanged += VerificacaoNovoPar;
            novoFi.KeyPress += XiFi_KeyPress;
            novoFi.KeyDown += XiFi_KeyDown;

            foreach (Control control in PanelListaXiFi.Controls)
            {
                if (control is Button btn)
                {
                    btn.Visible = false;
                }
            }

            Button botaoRemover = new Button();

            botaoRemover.Font = new Font("Arial", 10, FontStyle.Bold);
            botaoRemover.ForeColor = Color.White;
            botaoRemover.Size = new Size(30, 30);
            botaoRemover.Location = new Point((PanelListaXiFi.Width - botaoRemover.Width) / 2, proximoXiFiY);
            botaoRemover.BackColor = Color.Red;
            botaoRemover.Image = Properties.Resources.Lixeira;

            botaoRemover.Click += (sender, e) => RemoverPar(novoXi, novoFi, botaoRemover);
            botaoRemover.Visible = true;

            if (listaXiFi.Count < 5)
            {

                PanelListaXiFi.Controls.Add(novoXi);
                PanelListaXiFi.Controls.Add(novoFi);
                PanelListaXiFi.Controls.Add(botaoRemover);

                listaXi.Add(novoXi);
                listaFi.Add(novoFi);
                listaXiFi.Add((novoXi, novoFi, botaoRemover));

                proximoXiFiY += 30;
                PanelListaXiFi.ScrollControlIntoView(novoXi);
            }
            else
            {
                MessageBox.Show("Limite de pares Xi-Fi atingido.");
            }
        }

        private void RemoverPar(TextBox xi, TextBox fi, Button botao)
        {
            if (!PanelListaXiFi.Controls.Contains(botao))
            {
                MessageBox.Show("O botão não foi encontrado no painel.");
                return;
            }

            PanelListaXiFi.Controls.Remove(xi);
            PanelListaXiFi.Controls.Remove(fi);
            PanelListaXiFi.Controls.Remove(botao);

            listaXi.Remove(xi);
            listaFi.Remove(fi);
            listaXiFi.RemoveAll(par => par.Xi == xi && par.Fi == fi && par.BotaoRemover == botao);

            if (listaXiFi.Count > 0)
            {
                var parAnterior = listaXiFi.Last();
                parAnterior.BotaoRemover.Visible = true;
            }

            proximoXiFiY -= 30;
        }

        private TextBox CopiarConfiguracao(TextBox modelo)
        {
            return new TextBox
            {
                Width = modelo.Width,
                Height = modelo.Height,
                Size = modelo.Size,
                Font = modelo.Font,
                TextAlign = modelo.TextAlign
            };
        }
        #endregion

        #region Eventos de Tecla e Scroll
        private void NovoXi_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void NovoXi_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void XiFi_KeyDown(object sender, KeyEventArgs e)
        {
            // Bloqueia Ctrl+V e Shift+Insert
            if ((e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

        }

        private void XiFi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (char.IsControl(tecla))
                return;

            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            bool ValidarFi = textBox.Name.StartsWith("Fi");

            // ----------- CAMPO Fi: só números inteiros > 0 -----------
            if (ValidarFi)
            {
                if (!char.IsDigit(tecla))
                {
                    e.Handled = true;
                    return;
                }

                // Simula o texto final com a nova tecla inserida
                string textofinal = textBox.Text.Insert(textBox.SelectionStart, tecla.ToString());

                // Bloqueia '0' como primeiro caractere
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
                // Bloqueia se primeiro caractere for '0' sozinho (sem vírgula)
                string textofinal = textBox.Text.Insert(textBox.SelectionStart, tecla.ToString());
                if (textofinal.StartsWith("0") && !textofinal.StartsWith("0,") && textofinal.Length == 1)
                {
                    e.Handled = true;
                }

                return;
            }

            // Permite apenas uma vírgula e não como primeiro caractere
            if (tecla == ',')
            {
                if (textBox.Text.Contains(',') || textBox.SelectionStart == 0)
                {
                    e.Handled = true;
                }

                return;
            }

            // Qualquer outro caractere é bloqueado
            e.Handled = true;
        }

        private void BotaoProximoPassoVAC_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Variação Aleatória Contínua");
        }

        #endregion

        #region Verificações
        private void VerificacaoNovoPar(Object sender, EventArgs e)
        {
            var ultimoXi = listaXi[listaXi.Count - 1];
            var ultimoFi = listaFi[listaFi.Count - 1];

            bool podeAdicionar = false;

            var cultura = new CultureInfo("pt-BR");

            if (double.TryParse(ultimoXi.Text, NumberStyles.Any, cultura, out double valorXi) && int.TryParse(ultimoFi.Text, out int valorFi))
            {
                if (valorXi > 0 && valorFi > 0)
                {
                    podeAdicionar = true;
                }

                if (podeAdicionar && !DeveAdicionarNovoPar)
                {
                    podeAdicionar = false;

                    if (listaXiFi.Count + 1 < 5)
                    {
                        AdicionarNovoPar();
                    }

                    else
                    {
                        MessageBox.Show("Limite de inserção de pares Xi e Fi alcançados."); // Corrigir para não aparecer a cada modificação
                    }
                }
            }
        }

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

        #region Backend: Estatísticas, Fila, Cálculo
        private void AdicionarFila_Click(object sender, EventArgs e)
        {
            var resultados = CalcularEstatisticas();


            if (double.IsNaN(resultados.media) || double.IsNaN(resultados.variancia) || double.IsNaN(resultados.desvio))
            {
                MessageBox.Show("Não é possível calcular as estatísticas sem os dados fornecidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InicializarSequenciaGeral(resultados.passosMedia, resultados.passosVariancia, resultados.passosDesvio, resultados.media.ToString("F2"), resultados.variancia.ToString("F2"), resultados.desvio.ToString("F2"));

            try
            {
                List<(double Xi, int Fi)> valores = ObterValoresXiFi();
                string fila = FilaExpandida(valores);
                FilaExpandidaLabel.Text = fila;
                RedimensaoFilaExpandida();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BotaoProximoPassoVAC.Visible = true;
        }

        public (double media, double variancia, double desvio, double somaFi, string passosMedia, string passosVariancia, string passosDesvio) CalcularEstatisticas()
        {
            List<double> xi = new List<double>();
            List<int> fi = new List<int>();

            double somaFi = 0;
            double MultiplicacaoXiFi = 0;

            for (int i = 0; i < listaXi.Count; i++) // este if tem a função 
            {
                if (double.TryParse(listaXi[i].Text, out double valorXi) && int.TryParse(listaFi[i].Text, out int valorFi)) // este if serve 
                {
                    xi.Add(valorXi);
                    fi.Add(valorFi);
                    somaFi += valorFi;
                    MultiplicacaoXiFi += valorXi * valorFi;
                }
            }

            double media = MultiplicacaoXiFi / somaFi;

            double somaQuadrados = 0;

            for (int i = 0; i < xi.Count; i++)
            {
                somaQuadrados += fi[i] * Math.Pow(xi[i] - media, 2);
            }

            double variancia = somaQuadrados / somaFi;
            double desvio = Math.Sqrt(variancia);

            string passosMedia =
              $"📌 Passo 1: Calcular a soma de Xi · Fi\n" +
              $"→ Para cada linha, multiplique o valor de Xi pela sua frequência Fi.\n" +
              $"→ Depois, some esses produtos. Isso é a soma de todos os valores.\n" +
              $"→ Soma (Xi · Fi) = {MultiplicacaoXiFi}\n\n" +

              $"📌 Passo 2: Calcular a soma das frequências Fi\n" +
              $"→ Some todas as frequências (Fi) da sua tabela. Isso representa o número total de elementos (ou observações) no seu conjunto de dados (N).\n" +
              $"→ Soma Fi = {somaFi}\n\n" +

              $"📌 Passo 3: Aplicar a fórmula da média ponderada\n" +
              $"→ A média (x̄) é obtida dividindo-se a soma dos produtos (Xi · Fi) pelo número total de frequências (ΣFi).\n" +
              $"→ Exemplo: x̄ = {MultiplicacaoXiFi} / {somaFi} = {media:F2}";

            string passosVar =
                $"📌 Passo 1: Calcular a média\n" +
                $"→ Primeiro, você precisa da média (x̄) do seu conjunto de dados. Ela serve como o ponto de referência para medir a dispersão.\n" +
                $"→ Média (x̄) = {media:F2}\n\n" +

                $"📌 Passo 2: Calcular a soma de Fi · (Xi - x̄)²\n" +
                $"→ Para cada linha da sua tabela:\n" +
                $"  a. Subtraia a média (x̄) de cada valor (Xi): (Xi - x̄).\n" +
                $"  b. Eleve esse resultado ao quadrado para eliminar valores negativos e dar maior peso a desvios maiores: (Xi - x̄)².\n" +
                $"  c. Multiplique esse quadrado pela frequência correspondente (Fi): Fi · (Xi - x̄)².\n" +
                $"→ Por fim, some todos esses resultados. Essa soma é a soma dos desvios quadrados ponderados pela frequência.\n" +
                $"→ Soma = {somaQuadrados:F2}\n\n" +

                $"📌 Passo 3: Aplicar a fórmula da variância\n" +
                $"→ A variância é calculada dividindo a soma obtida no Passo 2 pelo número total de frequências (N = ΣFi).\n" +
                $"→ Fórmula: Variância = (ΣFi · (Xi - x̄)²) / (ΣFi)\n" +
                $"→ Exemplo: Variância = {somaQuadrados:F2} / {somaFi} = {variancia:F2}";

            string passosDesvio =
                $"📌 Passo 1: Calcular a variância\n" +
                $"→ O desvio padrão é diretamente derivado da variância, então você precisa ter a variância (σ²) calculada primeiro.\n" +
                $"→ Variância = {variancia:F2}\n\n" +

                $"📌 Passo 2: Aplicar a fórmula do desvio padrão\n" +
                $"→ Calcule a raiz quadrada da variância.\n" +
                $"→ Fórmula: Desvio Padrão = √Variância\n" +
                $"→ Exemplo: Desvio Padrão = √{variancia:F2} = {Math.Sqrt(variancia):F2}";

            return (media, variancia, desvio, somaFi, passosMedia, passosVar, passosDesvio);
        }

        private void NavegarGeral(bool proximo)
        {
            if (textosSequenciais == null || titulosSequenciais == null) return;

            int total = Math.Min(textosSequenciais.Count, titulosSequenciais.Count);

            if (proximo)
                indiceAtualGeral = (indiceAtualGeral + 1) % total;
            else
                indiceAtualGeral = (indiceAtualGeral - 1 + total) % total;

            lbPassosGeral.Text = textosSequenciais[indiceAtualGeral];
            lbTituloGeral.Text = titulosSequenciais[indiceAtualGeral];
            lbResultadoGeral.Text = resultadosSequenciais[indiceAtualGeral];
        }

        private void InicializarSequenciaGeral(string passosMedia, string passosVariancia, string passosDesvio, string resultadoMedia, string resultadoVariancia, string resultadoDesvio)
        {
            textosSequenciais = new List<string> { passosMedia, passosVariancia, passosDesvio };

            resultadosSequenciais = new List<string> { resultadoMedia, resultadoVariancia, resultadoDesvio };

            titulosSequenciais = new List<string>
            {
                "Média: x̄ = (ΣXi·Fi) / ΣFi",
                "Variância: σ² = ΣFi·(Xi - x̄)² / ΣFi",
                "Desvio Padrão: σ = √σ²"
            };

            indiceAtualGeral = 0;

            lbPassosGeral.Text = textosSequenciais[indiceAtualGeral];
            lbTituloGeral.Text = titulosSequenciais[indiceAtualGeral];
            lbResultadoGeral.Text = resultadosSequenciais[indiceAtualGeral];  // Só se você quiser exibir isso
        }



        private List<(double Xi, int Fi)> ObterValoresXiFi()
        {
            var valores = new List<(double Xi, int Fi)>();

            foreach (var (Xi, Fi, _) in listaXiFi.Prepend((Xi1, Fi1, null)))
            {
                bool XiVazio = string.IsNullOrWhiteSpace(Xi.Text);
                bool FiVazio = string.IsNullOrWhiteSpace(Fi.Text);

                if (XiVazio && FiVazio)
                    break;

                if (XiVazio || FiVazio)
                    continue;

                if (double.TryParse(Xi.Text, out double valorXi) && int.TryParse(Fi.Text, out int valorFi))
                {
                    valores.Add((valorXi, valorFi));
                }
                else
                {
                    throw new FormatException("Os valores de Xi e Fi devem ser preenchidos com números válidos!");
                }
            }
            return valores;
        }

        private void RedimensaoFilaExpandida()
        {
            FilaExpandidaLabel.Width = PanelFilaExpandida.ClientSize.Width - 20;
            FilaExpandidaLabel.Height = FilaExpandidaLabel.PreferredHeight + 10;
            FilaExpandidaLabel.Padding = new Padding(5);
            FilaExpandidaLabel.MaximumSize = new Size(PanelFilaExpandida.ClientSize.Width - 20, 0);

            if (FilaExpandidaLabel.Height > PanelFilaExpandida.ClientSize.Height)
            {
                PanelFilaExpandida.AutoScroll = true;
            }

            else
            {
                PanelFilaExpandida.AutoScroll = false;
            }

            FilaExpandidaLabel.TextAlign = ContentAlignment.TopLeft;
        }

        private string FilaExpandida(List<(double Xi, int Fi)> pares)
        {
            List<string> Resultado = new List<string>();

            foreach (var par in pares)
            {
                for (int i = 0; i < par.Fi; i++)
                {
                    Resultado.Add(par.Xi.ToString());
                }
            }
            return string.Join(" - ", Resultado);
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

        private void LimparRecursos() { }

        public UserControl GetView() { return this; }

        private void TelaMediaPosicaoCentral_Load(object sender, EventArgs e)
        {
            RedimensaoFilaExpandida();
            DesativarMenuContexto(this);
        }

        #endregion

        private void btnProxTxt_Click(object sender, EventArgs e)
        {
            NavegarGeral(true);
        }

        private void btnAntTxt_Click(object sender, EventArgs e)
        {
            NavegarGeral(false);
        }

        private void btnListaOuFila_CheckedChanged(object sender, EventArgs e) // não funciona, veriricar o por que isso ocore
        {
            if (btnListaOuFila.Checked)
            {
                Panel pnlBlock = new Panel();
                pnlBlock.Location = new Point(73, 168);
                pnlBlock.Size = new Size(169, 172);
                pnlBlock.BackColor = Color.FromArgb(60, 128, 128, 128);

                this.Controls.Add(pnlBlock);
            }
            else
            {
                RichTextBox txtFilaExpandida = new RichTextBox();
                txtFilaExpandida.Location = new Point(307, 168);
                txtFilaExpandida.Size = new Size(300, 160);

                this.Controls.Add(txtFilaExpandida);
            }
        }
    }
}

