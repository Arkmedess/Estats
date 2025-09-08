#region Usings
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
#endregion

#region Namespace e Declaração de Classe
namespace Interface_e_sistema_em_C_
{
    public partial class TelaMediaPosicaoCentral : UserControl, ITela
    {
        #endregion

        #region Campos e Propriedades
        private GerenciadorTelas _gerenciadorTelas;
        private Panel _panelContainer;
        private List<Panel> _painelPares;
        private int indiceAtualGeral = 0;
        private List<string> textosSequenciais;
        private List<string> resultadosSequenciais;
        private List<string> titulosSequenciais;
        private List<PictureBox> bolinhasSequenciais;
        #endregion

        #region Inicialização e Ciclo de Vida
        public TelaMediaPosicaoCentral(Panel panelContainer, GerenciadorTelas gerenciadorTelas)
        {
            InitializeComponent();
            this.Load += TelaMediaPosicaoCentral_Load;
            this.Dock = DockStyle.Fill;
            _gerenciadorTelas = gerenciadorTelas;
            _panelContainer = panelContainer;
        }

        private void TelaMediaPosicaoCentral_Load(object sender, EventArgs e)
        {
            InicializarPares();
            DesativarMenuContexto(this);
            // Configura o botão manual
            chkParesAuto.CheckedChanged += (s, e) => AtualizarBotoes();
            AtualizarBotoes(); // Primeira atualização
            txtboxFilaExp.KeyPress += (s, e) =>
            {
                char tecla = e.KeyChar;
                if (char.IsControl(tecla))
                    return;
                if (char.IsDigit(tecla) || tecla == ',' || tecla == ';' || tecla == '-')
                    return;
                // Bloqueia tudo que não for permitido
                e.Handled = true;
            };
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

        public UserControl GetView() => this;
        #endregion

        #region Gerenciamento de Pares Xi/Fi (Adição e Remoção)
        private void InicializarPares()
        {

            _painelPares = new List<Panel> { Par0, Par1, Par2, Par3, Par4 };

            // Garante que apenas o primeiro painel esteja visível já no início.
            for (int i = 0; i < _painelPares.Count; i++)
            {
                _painelPares[i].Visible = (i == 0);
                _painelPares[i].Enabled = (i == 0);

                if (i > 0)
                {
                    var textBoxes = _painelPares[i].Controls.OfType<TextBox>();
                    foreach (var tb in textBoxes)
                    {
                        tb.Clear();
                    }
                }
                ConfigurarEventosDoPar(_painelPares[i]);
            }
            AtualizarBotoes();
        }

        private void ConfigurarEventosDoPar(Panel panel)
        {
            int indice = ObterIndice(panel.Name);
            TextBox xi = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Xi{indice}");
            TextBox fi = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Fi{indice}");

            if (xi != null)
            {
                xi.TextChanged += Xi_TextChanged;
                xi.KeyPress += ValidarEntradaXi_KeyPress;

                xi.TextChanged += Par_TextChanged;
            }

            if (fi != null)
            {
                fi.TextChanged += Fi_TextChanged;
                fi.KeyPress += ValidarEntradaFi_KeyPress;

                fi.TextChanged += Par_TextChanged;
            }

            // Configura o botão de remover (exceto para o primeiro painel)
            if (indice > 0)
            {
                var btn = GetRemoveButton(panel);
                if (btn != null)
                {
                    btn.Click -= BtnRmvPar_Click;
                    btn.Click += BtnRmvPar_Click;
                }
            }
        }

        private ReaLTaiizor.Controls.Button GetRemoveButton(Panel par)
        {
            int indice = ObterIndice(par.Name);

            if (indice == 0)
                return null;

            return par.Controls.OfType<ReaLTaiizor.Controls.Button>()
                .FirstOrDefault(b => b.Name == $"btnRmvPar{indice}");
        }

        private bool ParPreenchido(Panel panel)
        {
            string indice = ObterIndice(panel.Name).ToString();
            TextBox xi = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Xi{indice}");
            TextBox fi = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Fi{indice}");
            return !string.IsNullOrWhiteSpace(xi?.Text) &&
                   !string.IsNullOrWhiteSpace(fi?.Text);
        }

        private void MostrarPar(int indice)
        {
            if (indice < 0 || indice >= _painelPares.Count) return;
            Panel panel = _painelPares[indice];
            panel.Visible = true;
            panel.Enabled = true;

            var btn = GetRemoveButton(panel);
            if (btn != null)
            {
                btn.Visible = false;
                btn.Enabled = false;
            }
            flowLayoutPanelPares.ScrollControlIntoView(panel);

            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            // Obtém todos os painéis visíveis em ordem
            var paineisVisiveis = _painelPares
                .Where(p => p.Visible)
                .OrderBy(p => ObterIndice(p.Name))
                .ToList();

            if (!paineisVisiveis.Any())
            {
                foreach (var panel in _painelPares)
                {
                    var btn = GetRemoveButton(panel);
                    if (btn != null)
                    {
                        btn.Visible = false;
                        btn.Enabled = false;
                    }
                }
                btnAdicionarNovoPar.Visible = false;
                return;
            }

            var ultimoPar = paineisVisiveis.Last();
            int indiceUltimo = ObterIndice(ultimoPar.Name);

            // Atualiza todos os botões de remover
            foreach (var panel in _painelPares)
            {
                var btn = GetRemoveButton(panel);
                if (btn == null) continue;

                // Só mostra o botão se:
                // 1. For o último painel visível
                // 2. Houver mais de um painel visível
                // 3. O painel estiver visível
                bool deveMostrar = (panel == ultimoPar) &&
                                  (paineisVisiveis.Count > 1) &&
                                  panel.Visible;
                btn.Visible = deveMostrar;
                btn.Enabled = deveMostrar;
            }
            bool podeAdicionar = !chkParesAuto.Checked && indiceUltimo < _painelPares.Count - 1;
            btnAdicionarNovoPar.Visible = podeAdicionar;
            btnAdicionarNovoPar.Enabled = podeAdicionar;
        }

        private void Par_TextChanged(object sender, EventArgs e)
        {
            if (chkParesAuto.Checked)
            {
                for (int i = 0; i < _painelPares.Count - 1; i++)
                {
                    if (_painelPares[i].Visible &&
                        ParPreenchido(_painelPares[i]) &&
                        !_painelPares[i + 1].Visible)
                    {
                        MostrarPar(i + 1);
                        break;
                    }
                }
            }
            AtualizarBotoes();
        }

        private void RemoverUltimoPar()
        {
            Panel ultimoPar = _painelPares.LastOrDefault(p => p.Visible);
            if (ultimoPar == null) return;

            // Limpa os campos antes de esconder
            var textBoxes = ultimoPar.Controls.OfType<TextBox>();
            foreach (var tb in textBoxes)
            {
                tb.Clear();
            }
            ultimoPar.Visible = false;
            ultimoPar.Enabled = false;

            AtualizarBotoes();
        }

        private void btnAdicionarNovoPar_Click(object sender, EventArgs e)
        {
            // Procura-se o primeiro par oculto que pode ser ativado
            for (int i = 0; i < _painelPares.Count - 1; i++)
            {
                Panel parAtual = _painelPares[i];
                Panel proximoPar = _painelPares[i + 1];

                // Verifica:
                // 1. O par atual está visível
                // 2. Está preenchido (Xi e Fi não vazios)
                // 3. O próximo par ainda está oculto
                if (parAtual.Visible &&
                    ParPreenchido(parAtual) &&
                    !proximoPar.Visible)
                {
                    MostrarPar(i + 1);
                    return;
                }
            }

            MessageBox.Show(
                "Todos os pares já foram adicionados ou o par anterior não está completo.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnRmvPar_Click(object sender, EventArgs e)
        {
            RemoverUltimoPar();
        }
        #endregion

        #region Validação e Eventos de Entrada (Teclado, TextChanged)

        private void ValidarEntradaXi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            if (char.IsControl(tecla))
                return;

            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            // Permite dígitos e vírgula
            if (char.IsDigit(tecla) || tecla == ',')
            {
                if (tecla == ',')
                {
                    if (textBox.Text.Contains(',') || textBox.SelectionStart == 0)
                    {
                        e.Handled = true;
                    }
                }
                return;
            }

            e.Handled = true;
        }


        private void ValidarEntradaFi_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            if (char.IsControl(tecla))
                return;

            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            // Permite apenas dígitos
            if (!char.IsDigit(tecla))
            {
                e.Handled = true;
                return;
            }

            // Bloqueia '0' como primeiro caractere
            string textoFinal = textBox.Text.Insert(textBox.SelectionStart, tecla.ToString());
            if (textoFinal.StartsWith("0") && textoFinal.Length == 1)
            {
                e.Handled = true;
                return;
            }
        }


        private void Xi_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            string texto = textBox.Text;

            // Remove caracteres inválidos
            string textoLimpo = "";
            bool virgulaEncontrada = false;

            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    textoLimpo += c;
                }
                else if (c == ',' && !virgulaEncontrada)
                {
                    textoLimpo += c;
                    virgulaEncontrada = true;
                }
            }

            // Valida formato "0," vs "0X"
            if (textoLimpo.StartsWith("0") && textoLimpo.Length > 1 && textoLimpo[1] != ',')
            {
                textoLimpo = "0," + textoLimpo.Substring(1);
            }

            // Atualiza o texto se necessário
            if (texto != textoLimpo)
            {
                int posicao = textBox.SelectionStart;
                textBox.Text = textoLimpo;
                textBox.SelectionStart = Math.Min(posicao, textoLimpo.Length);
            }
        }


        private void Fi_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            // Remove não dígitos
            string textoLimpo = new string(textBox.Text.Where(char.IsDigit).ToArray());

            // Bloqueia "0" sozinho
            if (textoLimpo == "0")
            {
                textoLimpo = "";
            }

            if (textBox.Text != textoLimpo)
            {
                int posicao = textBox.SelectionStart;
                textBox.Text = textoLimpo;
                textBox.SelectionStart = Math.Min(posicao, textoLimpo.Length);
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

        #region Cálculos Estatísticos
        public (double media, double variancia, double desvio, double cv, double somaFi, string passosMedia, string passosVariancia, string passosDesvio, string passosCv) CalcularEstatisticas()
        {
            var dados = new List<double>(); // Lista de valores considerando Fi ou lista em TextBox
            var listaFi = new List<int>();
            double somaFi = 0;
            if (!TglBtnListaOuFila.Checked)
            {
                foreach (Panel panel in _painelPares)
                {
                    if (!panel.Visible) continue;
                    string indice = ObterIndice(panel.Name).ToString();
                    TextBox xiTxt = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Xi{indice}");
                    TextBox fiTxt = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Fi{indice}");
                    if (xiTxt == null || fiTxt == null) continue;
                    if (string.IsNullOrWhiteSpace(xiTxt.Text) || string.IsNullOrWhiteSpace(fiTxt.Text)) continue;
                    if (double.TryParse(xiTxt.Text, NumberStyles.Any, new CultureInfo("pt-BR"), out double xi) && int.TryParse(fiTxt.Text, out int fi) && fi > 0)
                    {
                        for (int i = 0; i < fi; i++)
                            dados.Add(xi); // Repete Xi Fi vezes
                        listaFi.Add(fi);
                        somaFi += fi;
                    }
                }
            }
            else // Toggle marcado (Fila Expandida)
            {
                string texto = txtboxFilaExp.Text.Trim();
                if (string.IsNullOrEmpty(texto))
                    return (0, 0, 0, 0, 0, "Nenhum dado válido encontrado. Preencha pelo menos um par!", "", "", "");
                // Substitui tabs e espaços por ';'
                texto = texto.Replace("\t", ";").Replace(" ", ";");
                // Permite tanto ';' quanto '-' como separadores
                string[] tokens = texto.Split(new[] { ';', '-' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string t in tokens)
                {
                    if (double.TryParse(t.Trim(), NumberStyles.Any, new CultureInfo("pt-BR"), out double valor))
                    {
                        dados.Add(valor);
                    }
                }
                somaFi = dados.Count;
            }

            if (somaFi == 0)
            {
                return (0, 0, 0, 0, 0,
                    "Nenhum dado válido encontrado. Preencha pelo menos um valor!",
                    "", "", "");
            }

            double media = dados.Average();
            double somaQuadrados = dados.Sum(x => Math.Pow(x - media, 2));
            double variancia = somaQuadrados / (somaFi - 1);
            double desvio = Math.Sqrt(variancia);
            double cv = (media != 0)
                ? (desvio / media) * 100
                : 0;

            string passosMedia = GerarPassosMedia(dados, listaFi, media, somaFi);
            string passosVariancia = GerarPassosVariancia(dados, media, somaQuadrados, somaFi, variancia);
            string passosDesvio = GerarPassosDesvio(variancia, desvio);
            string passosCv = GerarPassosCV(desvio, media, cv);
            return (media, variancia, desvio, cv, somaFi, passosMedia, passosVariancia, passosDesvio, passosCv);
        }

        private string GerarPassosMedia(List<double> dados, List<int> listaFi, double media, double somaFi)
        {
            var valoresComFrequencia = dados.GroupBy(d => d)
                .Select(g => new
                {
                    Valor = g.Key,
                    Frequencia = g.Count(),
                    Produto = g.Key * g.Count()
                })
                .ToList();

            var passosMultiplicacao = valoresComFrequencia.Select(v => $"{v.Valor:F2} × {v.Frequencia} = {(v.Valor * v.Frequencia):F2}");

            double somaProdutos = valoresComFrequencia.Sum(v => v.Valor * v.Frequencia);

            var somaProdutosStr = string.Join(" + ", valoresComFrequencia.Select(v => v.Produto.ToString("F2")));

            string somaFiStr = string.Join(" + ", listaFi.Select(f => f.ToString()));

            return $@"
→  Passo 1: Realizar a multiplicação Xi × Fi
{string.Join("\n", passosMultiplicacao)}


→ Passo 2: Somar o produto dos cálculos para obter o resultado de ΣXiFi
ΣXiFi = {somaProdutosStr} = {somaProdutos:F2}


→ Passo 3: Realizar a soma dos valores de Fi para obter o resultado de ΣFi (ou N)
ΣFi = {somaFiStr} = {somaFi:F0}


→ Passo 4: Substituir os valores na fórmula e calcular a Média: x̄ = Σ(XiFi) / ΣFi
x̄ = {somaProdutos:F2} / {somaFi:F0} = {media:F2}
".Trim();
        }

        private string GerarPassosVariancia(List<double> dados, double media, double somaQuadrados, double somaFi, double variancia)
        {
            var grupos = dados.GroupBy(d => d)
                             .Select(g => new
                             {
                                 Valor = g.Key,
                                 Frequencia = g.Count(),
                                 DesvioQuadrado = Math.Pow(g.Key - media, 2)
                             })
                             .OrderBy(g => g.Valor);

            var desviosFormatados = new StringBuilder();
            foreach (var grupo in grupos)
            {
                desviosFormatados.AppendLine($"(Xi - x̄)² × Fi = ({grupo.Valor:F2} - {media:F2})² = {grupo.DesvioQuadrado:F2} x {grupo.Frequencia} = {(grupo.DesvioQuadrado * grupo.Frequencia):F4}");
            }

            return $@"
→ Passo 1: Tenha em mãos o valor da Média (x̄) e do Tamanho da Amostra (N)
Média dos valores: x̄ = {media:F2}
N = {somaFi}

→ Passo 2: Calcular cada (Xi - x̄)² × Fi para obter o valor de Σ(Xi - x̄)²
{desviosFormatados.ToString().Trim()}
Σ(Xi - x̄)² = {somaQuadrados:F2}

→ Passo 3: Substituir os valores da fórmula e calcular a Variância: s² = Σ(Xi - x̄)² / N - 1
s² = {somaQuadrados:F2} / {somaFi} - 1 = {variancia:F2}
".Trim();
        }

        private string GerarPassosDesvio(double variancia, double desvio)
        {
            return $@"
→ Passo 1: Tenha em mãos o valor da Variância (s²)
s² = {variancia:F2}

→ Passo 2: Substitua os valores da fórmula e calcular o Desvio Padrão: s = √s²
s = √{variancia:F2} = {desvio:F2}
".Trim();
        }

        private string GerarPassosCV(double desvio, double media, double cv)
        {
            if (media == 0)
            {
                return @"
📌 Coeficiente de Variação (CV)
→ CV = (s / x̄) × 100%
→ Como a média é zero, o CV não pode ser calculado.
→ O CV é indefinido quando a média é zero.
".Trim();
            }

            string interpretacao = cv switch
            {
                < 15 => "Baixa dispersão (CV < 15%): Os dados são homogêneos.",
                < 30 => "Média dispersão (15% ≤ CV < 30%): Dispersão moderada.",
                < 50 => "Alta dispersão (30% ≤ CV < 50%): Os dados são heterogêneos.",
                _ => "Muito alta dispersão (CV ≥ 50%): Grande variabilidade nos dados."
            };

            return $@"
→ Passo 1: Tenha em mãos o valor do Desvio Padrão (s) e da Média (x̄)
s = {desvio:F2}
x̄ = {media:F2}

→ Passo 2: Substitua os valores da fórmula e calcular o Coeficiente de Variação (CV)
CV = (s / x̄) × 100%
CV = ({desvio:F2} / {media:F2}) × 100%
CV = {cv:F2}%

📌 Interpretação do CV:
→ {interpretacao}
".Trim();
        }
        #endregion


        #region Exibição de Resultados e Navegação
        private void hopeBtnCalcPadrao_Click(object sender, EventArgs e)
        {
            var resultados = CalcularEstatisticas();
            if (double.IsNaN(resultados.media) || double.IsNaN(resultados.variancia) || double.IsNaN(resultados.desvio) || double.IsNaN(resultados.cv))
            {
                MessageBox.Show("Não é possível calcular as estatísticas sem os dados fornecidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InicializarSequenciaGeral(
                resultados.passosMedia,
                resultados.passosVariancia,
                resultados.passosDesvio,
                resultados.passosCv,
                resultados.media.ToString("F2"),
                resultados.variancia.ToString("F2"),
                resultados.desvio.ToString("F2"),
                resultados.cv.ToString("F2"),
                picPaginaMedia,
                picPaginaVariancia,
                picPaginaDesvio,
                picPaginaCV
            );
            try
            {
                string fila;
                if (TglBtnListaOuFila.Checked)
                {
                    // Já usa o que o usuário digitou no txtboxFilaExp
                    fila = txtboxFilaExp.Text;
                }
                else
                {
                    // Constrói a lista expandida a partir de Xi/Fi
                    List<(double Xi, int Fi)> valores = ObterValoresXiFi();
                    fila = FilaExpandida(valores);
                    txtboxFilaExp.Text = fila; // mantém sincronizado
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            hopeBtnIrTelaVAC.Visible = true;
        }

        private List<(double Xi, int Fi)> ObterValoresXiFi()
        {
            var valores = new List<(double Xi, int Fi)>();
            foreach (Panel panel in _painelPares)
            {
                if (!panel.Visible) continue;
                string indice = ObterIndice(panel.Name).ToString();
                TextBox xiTxt = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Xi{indice}");
                TextBox fiTxt = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Fi{indice}");
                if (xiTxt == null || fiTxt == null) continue;
                if (string.IsNullOrWhiteSpace(xiTxt.Text) || string.IsNullOrWhiteSpace(fiTxt.Text)) continue;
                if (double.TryParse(xiTxt.Text, NumberStyles.Any, new CultureInfo("pt-BR"), out double xi) &&
                    int.TryParse(fiTxt.Text, out int fi) && fi > 0)
                {
                    valores.Add((xi, fi));
                }
                else
                {
                    throw new FormatException("Os valores de Xi e Fi devem ser números válidos!");
                }
            }
            return valores;
        }

        private void InicializarSequenciaGeral(string passosMedia, string passosVariancia, string passosDesvio, string passosCv, string resultadoMedia, string resultadoVariancia, string resultadoDesvio, string resultadoCv,
            PictureBox picPaginaMedia, PictureBox picPaginaVariancia, PictureBox picPaginaDesvio, PictureBox picPaginaCV)
        {
            textosSequenciais = new List<string> { passosMedia, passosVariancia, passosDesvio, passosCv };
            resultadosSequenciais = new List<string> { resultadoMedia, resultadoVariancia, resultadoDesvio, resultadoCv };
            titulosSequenciais = new List<string>
            {
                "Média: x̄ = (ΣXi·Fi) / ΣFi",
                "Variância: s² = (Xi - x̄)² / ΣFi",
                "Desvio Padrão: s = √s²",
                "Coeficiente de Variação: CV = (s / x̄) × 100%"
            };

            bolinhasSequenciais = new List<PictureBox> { picPaginaMedia, picPaginaVariancia, picPaginaDesvio, picPaginaCV };

            indiceAtualGeral = 0;
            AtualizarExibicaoResultado();
        }

        private void AtualizarExibicaoResultado()
        {
            if (textosSequenciais == null || titulosSequenciais == null || resultadosSequenciais == null)
                return;

            lbPassosGeral.Text = textosSequenciais[indiceAtualGeral];
            lbTituloGeral.Text = titulosSequenciais[indiceAtualGeral];
            lbResultadoGeral.Text = resultadosSequenciais[indiceAtualGeral];

            for (int i = 0; i < bolinhasSequenciais.Count; i++)
            {
                bolinhasSequenciais[i].Image = (i == indiceAtualGeral)
                ? Properties.Resources.Pagina_Atual
                : Properties.Resources.Outra_Pagina___Copia;
            }

        }

        private void NavegarGeral(bool proximo)
        {
            if (textosSequenciais == null || titulosSequenciais == null) return;
            int total = Math.Min(textosSequenciais.Count, titulosSequenciais.Count);
            indiceAtualGeral = proximo
                ? (indiceAtualGeral + 1) % total
                : (indiceAtualGeral - 1 + total) % total;
            AtualizarExibicaoResultado();
        }

        private void btnProxTxt_Click(object sender, EventArgs e) => NavegarGeral(true);
        private void btnAntTxt_Click(object sender, EventArgs e) => NavegarGeral(false);
        #endregion

        #region Manipulação de Dados (Fila Expandida)
        private string FilaExpandida(List<(double Xi, int Fi)> pares)
        {
            var resultado = new List<string>();
            foreach (var par in pares)
                resultado.AddRange(Enumerable.Repeat(par.Xi.ToString(), par.Fi));
            return string.Join(" - ", resultado);
        }
        #endregion


        #region Navegação entre Telas
        private void BotaoProximoPassoVAC_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Variação Aleatória Contínua");
        }
        #endregion

        #region Eventos de Interface (Não Funcionais / Em Teste)
        private void TglBtnListaOuFila_CheckedChanged(object sender, EventArgs e)
        {
            if (TglBtnListaOuFila.Checked)
            {
                flowLayoutPanelPares.Enabled = false;
                txtboxFilaExp.Enabled = true;
                btnValidarFilaExp.Enabled = TglBtnListaOuFila.Checked;
                LimparCamposDeTexto(flowLayoutPanelPares);
            }
            else
            {
                flowLayoutPanelPares.Enabled = true;
                txtboxFilaExp.Enabled = false;
                btnValidarFilaExp.Enabled = TglBtnListaOuFila.Checked;
                txtboxFilaExp.Text = string.Empty;
            }
        }
        #endregion

        #region Métodos Auxiliares
        private int ObterIndice(string nome)
        {
            return int.Parse(new string(nome.Where(char.IsDigit).ToArray()));
        }

        private void LimparCamposDeTexto(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                // TextBox normal ou RichTextBox
                if (c is TextBox || c is RichTextBox)
                {
                    c.Text = string.Empty;
                }
                else
                {
                    // Verifica se o controle possui a propriedade "Text" (para controles customizados)
                    var prop = c.GetType().GetProperty("Text");
                    if (prop != null && prop.CanWrite)
                    {
                        prop.SetValue(c, string.Empty);
                    }
                }
                // Se tiver controles filhos, aplica recursivamente
                if (c.HasChildren)
                {
                    LimparCamposDeTexto(c);
                }
            }
        }

        #endregion

        #region Validação de Dados

        private string ValidarItemNumero(string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                return "Item vazio ou com espaços.";

            if (item == ",")
                return "Vírgula sozinha (use um número como '0,5').";

            if (item.EndsWith(","))
                return $"Número incompleto: '{item}' (falta o decimal).";

            if (item.Count(c => c == ',') > 1)
                return $"Múltiplas vírgulas: '{item}' (use apenas uma vírgula por número).";

            if (item.Contains(" ") && item.Contains(","))
                return $"Espaço dentro do número: '{item}' (não use espaço antes ou depois da vírgula).";

            if (item.Length > 1 && item.StartsWith("0") && char.IsDigit(item[1]) && !item.StartsWith("0,"))
                return $"Zero à esquerda não permitido: '{item}' (use '1' em vez de '01').";

            if (double.TryParse(item, NumberStyles.Any, new CultureInfo("pt-BR"), out _))
                return null;

            if (double.TryParse(item, NumberStyles.Any, new CultureInfo("en-US"), out _))
                return null;

            return $"Formato inválido: '{item}'. Use vírgula (1,5) ou ponto (1.5).";
        }

        private string ValidarItemNumero(string item, out string sugestao)
        {
            sugestao = null;
            string erro = ValidarItemNumero(item);

            if (erro != null)
            {
                if (item == ",")
                    sugestao = "0,0";
                else if (item.EndsWith(","))
                    sugestao = item + "0";
                else if (item.Count(c => c == ',') > 1)
                    sugestao = Regex.Replace(item, ",", (match) => match.Index == item.IndexOf(',') ? "," : "");
                else if (item.Contains(" ") && item.Contains(","))
                    sugestao = item.Replace(" ", "");
                else if (item.Length > 1 && item.StartsWith("0") && char.IsDigit(item[1]) && !item.StartsWith("0,"))
                    sugestao = item.TrimStart('0');
                else if (item.Contains("."))
                    sugestao = item.Replace(".", ",");
                else if (double.TryParse(item, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
                    sugestao = item.Replace(".", ",");
                else
                    sugestao = "0"; // Sugestão genérica como último recurso
            }

            return erro;
        }
        #endregion

        private bool ValidarLista(string texto, out string listaFormatada, out string erros, char separador = '-', int? minItens = null, int? maxItens = null)
        {
            listaFormatada = string.Empty;
            erros = string.Empty;
            var errosList = new List<string>();
            if (string.IsNullOrWhiteSpace(texto))
            {
                errosList.Add("O campo está vazio.");
                erros = string.Join("\n→ ", errosList);
                return false;
            }
            string[] valores = texto.Split(new[] { ';', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var numeros = new List<string>();
            foreach (string v in valores)
            {
                string item = v.Trim();
                string erroItem = ValidarItemNumero(item, out string sugestao);
                if (erroItem != null)
                {
                    // Adiciona a sugestão à mensagem de erro se disponível
                    string mensagemErro = erroItem;
                    if (!string.IsNullOrEmpty(sugestao))
                        mensagemErro += $" Sugerido: '{sugestao}'";
                    errosList.Add(mensagemErro);
                }
                else
                {
                    numeros.Add(item);
                }
            }
            // Se houver erros, retorna false com todos os detalhes
            if (errosList.Count > 0)
            {
                erros = string.Join("\n→ ", errosList);
                return false;
            }
            // Se não houver números válidos
            if (numeros.Count == 0)
            {
                errosList.Add("Nenhum número válido foi encontrado.");
                erros = string.Join("\n→ ", errosList);
                return false;
            }
            // Validação de quantidade de itens
            if (minItens.HasValue && numeros.Count < minItens)
                errosList.Add($"Mínimo de {minItens} itens necessário(s). Encontrados: {numeros.Count}");
            if (maxItens.HasValue && numeros.Count > maxItens)
                errosList.Add($"Máximo de {maxItens} itens permitido(s). Encontrados: {numeros.Count}");

            if (errosList.Count > 0)
            {
                erros = string.Join("\n→ ", errosList);
                return false;
            }
            // Recria no formato padronizado: NÚMERO - NÚMERO - NÚMERO
            listaFormatada = string.Join($" {separador} ", numeros);
            erros = string.Empty;
            return true;
        }

        private void AplicarCorrecoesAutomaticas(string texto)
        {
            string[] valores = texto.Split(new[] { ';', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var corrigidos = new List<string>();
            foreach (string v in valores)
            {
                string item = v.Trim();
                ValidarItemNumero(item, out string sugestao);
                if (sugestao != null)
                {
                    corrigidos.Add(sugestao);
                }
                else
                {
                    corrigidos.Add(item);
                }
            }
            txtboxFilaExp.Text = string.Join(" - ", corrigidos);

            if (ValidarLista(txtboxFilaExp.Text, out string listaFormatada, out _))
            {
                txtboxFilaExp.Text = listaFormatada;
                MessageBox.Show("✅ Correções aplicadas com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnValidarFilaExp_Click(object sender, EventArgs e)
        {
            if (ValidarLista(txtboxFilaExp.Text, out string listaFormatada, out string erros,
                separador: '-', minItens: 2, maxItens: 10))
            {
                txtboxFilaExp.Text = listaFormatada;
                MessageBox.Show("Lista válida e padronizada!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Verifica se há sugestões para oferecer correção automática
                if (erros.Contains("Sugerido:"))
                {
                    var resultado = MessageBox.Show(
                        $"Corrija os seguintes erros:\n→ {erros}\n\nDeseja aplicar as sugestões automáticas?",
                        "Erros na lista",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        AplicarCorrecoesAutomaticas(txtboxFilaExp.Text);
                        return;
                    }
                }
                MessageBox.Show($"Corrija os seguintes erros:\n→ {erros}",
                    "Erro na lista",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void hopeBtnMetodoReverso_Click(object sender, EventArgs e)
        {
            pnModoReverso.Visible = true;
            pnModoPadrao.Visible = false;
        }

        private void hopeBtnMetodoPadrao_Click(object sender, EventArgs e)
        {
            pnModoReverso.Visible = false;
            pnModoPadrao.Visible = true;
        }

        private void btnCalcReverso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxCvReverso.Text) || string.IsNullOrWhiteSpace(txtBoxMediaReverso.Text))
            {
                MessageBox.Show("É necessário inserir valores para o Coeficiente de Variação e a Média!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double cvReverso = double.Parse(txtBoxCvReverso.Text.Replace(",", "."));

                double? mediaReversa = string.IsNullOrEmpty(txtBoxMediaReverso.Text)
                    ? null
                    : double.Parse(txtBoxMediaReverso.Text.Replace(",", "."));

                double? varianciaReversa = string.IsNullOrEmpty(txtBoxVarianciaReverso.Text)
                    ? null
                    : double.Parse(txtBoxDesvioReverso.Text.Replace(",", "."));

                double? desvioReverso = string.IsNullOrEmpty(txtBoxDesvioReverso.Text)
                    ? null
                    : double.Parse(txtBoxDesvioReverso.Text.Replace(",", "."));

                if (cvReverso <= 0)
                {
                    MessageBox.Show("O valor do Coeficiente de Variação deve ser maior que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double mediaCalculadaReversa, desvioCalculadoReverso, varianciaCalculadaReversa;

                if (mediaReversa.HasValue)
                {
                    mediaCalculadaReversa = mediaReversa.Value;
                    desvioCalculadoReverso = (cvReverso * mediaCalculadaReversa) / 100;
                    varianciaCalculadaReversa = Math.Pow(desvioCalculadoReverso, 2);
                }
                else if (desvioReverso.HasValue)
                {
                    desvioCalculadoReverso = desvioReverso.Value;
                    mediaCalculadaReversa = (desvioCalculadoReverso * 100) / cvReverso;
                    varianciaCalculadaReversa = Math.Pow(desvioCalculadoReverso, 2);
                }
                else if (varianciaReversa.HasValue)
                {
                    varianciaCalculadaReversa = varianciaReversa.Value;
                    desvioCalculadoReverso = Math.Sqrt(varianciaCalculadaReversa);
                    mediaCalculadaReversa = (desvioCalculadoReverso * 100) / cvReverso;
                }
                else
                {
                    MessageBox.Show("Você deve fornecer pelo menos mais um parâmetro além do CV (Média, Desvio ou Variância)!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string passosReverso = GerarPassosReverso(cvReverso, mediaReversa, desvioReverso, varianciaReversa, mediaCalculadaReversa, desvioCalculadoReverso, varianciaCalculadaReversa);

                lbPassosGeral.Text = $@"
Média: {mediaCalculadaReversa:F2}
Desvio Padrão: {desvioCalculadoReverso:F2}
Variância: {varianciaCalculadaReversa:F2}
CV: {cvReverso:F2}%

{passosReverso}
";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GerarPassosReverso(double cvReverso, double? mediaReversa, double? desvioReverso, double? varianciaReversa, double mediaCalculadaReversa, double desvioCalculadoReverso, double varianciaCalculadaReversa)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n📌 **Passos do Cálculo Reverso:**");

            if (mediaReversa.HasValue)
            {
                sb.AppendLine($"1. Dados conhecidos: CV = {cvReverso:F2}%, Média = {mediaReversa:F2}");
                sb.AppendLine($"2. Cálculo do Desvio Padrão:");
                sb.AppendLine($"   σ = (CV × x̄) / 100");
                sb.AppendLine($"   σ = ({cvReverso:F2} × {mediaReversa:F2}) / 100 = {desvioCalculadoReverso:F2}");
                sb.AppendLine($"3. Cálculo da Variância:");
                sb.AppendLine($"   σ² = σ² = {desvioCalculadoReverso:F2}² = {varianciaCalculadaReversa:F2}");
            }
            else if (desvioReverso.HasValue)
            {
                sb.AppendLine($"1. Dados conhecidos: CV = {cvReverso:F2}%, Desvio = {desvioReverso:F2}");
                sb.AppendLine($"2. Cálculo da Média:");
                sb.AppendLine($"   x̄ = (σ × 100) / CV");
                sb.AppendLine($"   x̄ = ({desvioReverso:F2} × 100) / {cvReverso:F2} = {mediaCalculadaReversa:F2}");
                sb.AppendLine($"3. Cálculo da Variância:");
                sb.AppendLine($"   σ² = σ² = {desvioReverso:F2}² = {varianciaCalculadaReversa:F2}");
            }
            else if (varianciaReversa.HasValue)
            {
                sb.AppendLine($"1. Dados conhecidos: CV = {cvReverso:F2}%, Variância = {varianciaReversa:F2}");
                sb.AppendLine($"2. Cálculo do Desvio Padrão:");
                sb.AppendLine($"   σ = √σ² = √{varianciaReversa:F2} = {desvioCalculadoReverso:F2}");
                sb.AppendLine($"3. Cálculo da Média:");
                sb.AppendLine($"   x̄ = (σ × 100) / CV");
                sb.AppendLine($"   x̄ = ({desvioCalculadoReverso:F2} × 100) / {cvReverso:F2} = {mediaCalculadaReversa:F2}");
            }

            sb.AppendLine("\n📌 **Fórmulas Utilizadas:**");
            sb.AppendLine("CV = (σ / x̄) × 100%");
            sb.AppendLine("σ = √σ²");
            sb.AppendLine("x̄ = (σ × 100) / CV");

            return sb.ToString();
        }

        private void hopeBtnIrTelaVAC_Click(object sender, EventArgs e)
        {
            _gerenciadorTelas.MostrarTela("Variação Aleatória Contínua");
        }
    }
}