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
            // Inicializa a lista de painéis
            _painelPares = new List<Panel> { Par0, Par1, Par2, Par3, Par4 };
            // Garante que apenas o primeiro painel esteja visível inicialmente
            for (int i = 0; i < _painelPares.Count; i++)
            {
                _painelPares[i].Visible = (i == 0);
                _painelPares[i].Enabled = (i == 0);
                // Limpa os campos dos painéis invisíveis
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
            // Força a atualização inicial dos botões
            AtualizarBotoes();
        }

        private void ConfigurarEventosDoPar(Panel panel)
        {
            int indice = ObterIndice(panel.Name);
            TextBox xi = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Xi{indice}");
            TextBox fi = panel.Controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == $"Fi{indice}");
            if (xi != null && fi != null)
            {
                xi.TextChanged += Par_TextChanged;
                fi.TextChanged += Par_TextChanged;
                ConfigurarValidacao(xi, false);
                ConfigurarValidacao(fi, true);
            }
            // Configura o botão de remover se existir (exceto para o primeiro painel)
            if (indice > 0)
            {
                var btn = GetRemoveButton(panel);
                if (btn != null)
                {
                    btn.Click -= BtnRmvPar_Click; // Evita duplicação
                    btn.Click += BtnRmvPar_Click;
                }
            }
        }

        private ReaLTaiizor.Controls.Button GetRemoveButton(Panel par)
        {
            int indice = ObterIndice(par.Name);
            // Para o primeiro painel, não existe botão de remover
            if (indice == 0)
                return null;
            // Procura o botão pelo nome
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
            // Garante que o botão de remover esteja oculto inicialmente
            var btn = GetRemoveButton(panel);
            if (btn != null)
            {
                btn.Visible = false;
                btn.Enabled = false;
            }
            flowLayoutPanelPares.ScrollControlIntoView(panel);
            // Força a atualização dos botões após mostrar o painel
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            // Obtém todos os painéis visíveis em ordem
            var paineisVisiveis = _painelPares
                .Where(p => p.Visible)
                .OrderBy(p => ObterIndice(p.Name))
                .ToList();
            // Se não há painéis visíveis, esconde todos os botões
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
            // Obtém o último painel visível
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
            // Atualiza botão de adição
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
            // Força a atualização dos botões após remover
            AtualizarBotoes();
        }

        private void btnAdicionarNovoPar_Click(object sender, EventArgs e)
        {
            // Procuramos o primeiro par oculto que pode ser ativado
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
            // Se chegou aqui, não há par para adicionar
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
        private void ConfigurarValidacao(TextBox tb, bool ehFi)
        {
            tb.KeyPress += (s, e) =>
            {
                char tecla = e.KeyChar;
                if (char.IsControl(tecla)) return;
                if (ehFi)
                {
                    if (!char.IsDigit(tecla))
                    {
                        e.Handled = true;
                        return;
                    }
                    string textoFinal = tb.Text.Insert(tb.SelectionStart, tecla.ToString());
                    if (textoFinal.StartsWith("0") && textoFinal.Length > 1)
                        e.Handled = true;
                }
                else
                {
                    if (char.IsDigit(tecla))
                    {
                        string textoFinal = tb.Text.Insert(tb.SelectionStart, tecla.ToString());
                        if (textoFinal.StartsWith("0") && !textoFinal.StartsWith("0,") && textoFinal.Length == 1)
                            e.Handled = true;
                        return;
                    }
                    if (tecla == ',')
                    {
                        if (tb.Text.Contains(',') || tb.SelectionStart == 0)
                            e.Handled = true;
                        return;
                    }
                    e.Handled = true;
                }
            };
            tb.KeyDown += (s, e) =>
            {
                if ((e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert))
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            };
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
            double somaFi = 0;
            if (!TglBtnListaOuFila.Checked) // Padrão: calcular pelos pares Xi/Fi
            {
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
                        for (int i = 0; i < fi; i++)
                            dados.Add(xi); // Repete Xi Fi vezes
                        somaFi += fi;
                    }
                }
            }
            else // Toggle marcado: calcular baseado na TextBox com valores separados
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
            // Verifica se há dados
            if (somaFi == 0)
            {
                return (0, 0, 0, 0, 0,
                    "Nenhum dado válido encontrado. Preencha pelo menos um valor!",
                    "", "", "");
            }
            // Cálculos
            double media = dados.Average();
            double somaQuadrados = dados.Sum(x => Math.Pow(x - media, 2));
            double variancia = somaQuadrados / somaFi;
            double desvio = Math.Sqrt(variancia);
            double cv = (media != 0)
                ? (desvio / media) * 100
                : 0;
            // Passos
            string passosMedia = $@"
📌 **Passo 1: Lista de Valores**
→ {string.Join(" ; ", dados.Select(d => d.ToString("F2")))}
📌 **Passo 2: Calcular Média**
→ x̄ = ΣXi / n
→ x̄ = {string.Join(" + ", dados.Select(d => d.ToString("F2")))} / {somaFi} = {media:F2}
".Trim();
            string passosVariancia = $@"
📌 **Passo 1: Média (x̄)**
→ x̄ = {media:F2}
📌 **Passo 2: Calcular Σ(Xi - x̄)²**
→ Para cada valor:
{string.Join("\n", dados.Select(d => $"→ ({d:F2} - {media:F2})² = {Math.Pow(d - media, 2):F2}"))}
→ Soma = {somaQuadrados:F2}
📌 **Passo 3: Variância**
→ σ² = Σ(Xi - x̄)² / n
→ σ² = {somaQuadrados:F2} / {somaFi} = {variancia:F2}
".Trim();
            string passosDesvio = $@"
📌 **Passo 1: Variância (σ²)**
→ σ² = {variancia:F2}
📌 **Passo 2: Desvio Padrão**
→ σ = √σ²
→ σ = √{variancia:F2} = {desvio:F2}
".Trim();
            string passosCv = GerarPassosCV(desvio, media, cv);
            return (media, variancia, desvio, cv, somaFi, passosMedia, passosVariancia, passosDesvio, passosCv);
        }

        private string GerarPassosCV(double desvio, double media, double cv)
        {
            if (media == 0)
            {
                return @"
📌 **Coeficiente de Variação (CV)**
→ CV = (σ / x̄) × 100%
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
📌 **Passo 1: Desvio Padrão (σ)**
→ σ = {desvio:F2}
📌 **Passo 2: Média (x̄)**
→ x̄ = {media:F2}
📌 **Passo 3: Coeficiente de Variação (CV)**
→ CV = (σ / x̄) × 100%
→ CV = ({desvio:F2} / {media:F2}) × 100%
→ CV = {cv:F2}%
📌 **Interpretação do CV:**
→ {interpretacao}
".Trim();
        }







        #endregion

        #region Exibição de Resultados e Navegação
        private void AdicionarFila_Click(object sender, EventArgs e)
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
                resultados.cv.ToString("F2")
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

            BotaoProximoPassoVAC.Visible = true;
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

        private void InicializarSequenciaGeral(string passosMedia, string passosVariancia, string passosDesvio, string passosCv, string resultadoMedia, string resultadoVariancia, string resultadoDesvio, string resultadoCv)
        {
            textosSequenciais = new List<string> { passosMedia, passosVariancia, passosDesvio, passosCv };
            resultadosSequenciais = new List<string> { resultadoMedia, resultadoVariancia, resultadoDesvio, resultadoCv };
            titulosSequenciais = new List<string>
            {
                "Média: x̄ = (ΣXi·Fi) / ΣFi",
                "Variância: s² = ΣFi·(Xi - x̄)² / ΣFi",
                "Desvio Padrão: s = √s²",
                "Coeficiente de Variação: CV = (σ / x̄) × 100%"
            };
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
            // TODO: Implementar alternância entre visualização de lista e fila
            // Atualmente não está funcionando corretamente
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
            if (!double.TryParse(item, NumberStyles.AllowDecimalPoint, new CultureInfo("pt-BR"), out _))
                return $"Não é um número válido: '{item}' (use formato brasileiro: 2,5).";
            if (double.TryParse(item, NumberStyles.Any, new CultureInfo("pt-BR"), out _))
                return null;
            // Tenta converter com ponto (en-US)
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
                // Gera sugestão baseada no erro
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
                else
                    sugestao = "0";
            }
            return erro;
        }

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
            // Se houver erros de quantidade, retorna false
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
            // Revalida após correções
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
                txtboxFilaExp.Text = listaFormatada; // força padronização
                MessageBox.Show("✅ Lista válida e padronizada!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        #endregion

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
                double cvReverso = double.Parse(txtBoxCvReverso.Text.Replace(",","."));

                double? mediaReversa = string.IsNullOrEmpty(txtBoxMediaReverso.Text)
                    ? null
                    : double.Parse(txtBoxMediaReverso.Text.Replace(",", "."));

                double? varianciaReversa = string.IsNullOrEmpty(txtBoxDesvioReverso.Text)
                    ? null
                    : double.Parse(txtBoxDesvioReverso.Text.Replace(",", "."));

                double? desvioReverso = string.IsNullOrEmpty(txtBoxDesvioReverso.Text)
                    ? null
                    : double.Parse(txtBoxDesvioReverso.Text.Replace(",", "."));

                if (cvReverso <= 0 || (mediaReversa.HasValue && mediaReversa.Value <= 0))
                {
                    MessageBox.Show("O valor do Coeficiente de Variação e Média devem ser maior que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                double mediaCalculadaReversa, desvioCalculadoReverso, varianciaCalculadaReversa;

                if (mediaReversa.HasValue)
                {
                    mediaCalculadaReversa = mediaReversa.Value;
                    desvioCalculadoReverso = (cvReverso * mediaCalculadaReversa) / 100;
                    varianciaCalculadaReversa = Math.Pow(desvioCalculadoReverso, 2);
                }
                else if (varianciaReversa.HasValue)
                {
                    varianciaCalculadaReversa = varianciaReversa.Value;
                    desvioCalculadoReverso = Math.Sqrt(varianciaCalculadaReversa);
                    mediaCalculadaReversa = (desvioCalculadoReverso * 100) / cvReverso;
                }
                else if (desvioReverso.HasValue)
                {
                    desvioCalculadoReverso = desvioReverso.Value;
                    mediaCalculadaReversa = (desvioCalculadoReverso * 100) / cvReverso;
                    varianciaCalculadaReversa = Math.Pow(desvioCalculadoReverso, 2);
                }
                else
                {
                    MessageBox.Show("Você deve fornecer pelo menos mais um parâmetro além do CV e Média", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string passosReverso = GerarPassosReverso(cvReverso, mediaReversa, desvioReverso, varianciaReversa, mediaCalculadaReversa, desvioCalculadoReverso, varianciaCalculadaReversa);

                // Exibir resultados
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

        private string GerarPassosReverso(double cvReverso, double? mediaReversa, double? desvioReverso, double? varianciaReversa,
                                         double mediaCalculadaReversa, double desvioCalculadoReverso, double varianciaCalculadaReversa)
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
    }
}