namespace Interface_e_sistema_em_C_
{
    partial class TelaMediaPosicaoCentral
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMediaPosicaoCentral));
            lblTituloEstatPar = new Label();
            lblDescTela = new Label();
            lblFilaExpandida = new Label();
            Fi1 = new TextBox();
            Xi1 = new TextBox();
            AdicionarFila = new Button();
            lblResultadosEstatisticos = new Label();
            lbPassosGeral = new Label();
            lbResultadoGeral = new Label();
            BotaoProximoPassoVAC = new Button();
            pnResultadosEstatisticos = new ReaLTaiizor.Controls.Panel();
            btnAntTxt = new Button();
            btnProxTxt = new Button();
            lbTituloGeral = new Label();
            TglBtnListaOuFila = new ReaLTaiizor.Controls.HopeToggle();
            lblModoFilaExpandida = new Label();
            flowLayoutPanelPares = new FlowLayoutPanel();
            Par0 = new Panel();
            Xi0 = new TextBox();
            Fi0 = new TextBox();
            Par1 = new Panel();
            btnRmvPar1 = new ReaLTaiizor.Controls.Button();
            Par2 = new Panel();
            btnRmvPar2 = new ReaLTaiizor.Controls.Button();
            Xi2 = new TextBox();
            Fi2 = new TextBox();
            Par3 = new Panel();
            btnRmvPar3 = new ReaLTaiizor.Controls.Button();
            Xi3 = new TextBox();
            Fi3 = new TextBox();
            Par4 = new Panel();
            btnRmvPar4 = new ReaLTaiizor.Controls.Button();
            Xi4 = new TextBox();
            Fi4 = new TextBox();
            btnAdicionarNovoPar = new Button();
            chkParesAuto = new CheckBox();
            txtboxFilaExp = new ReaLTaiizor.Controls.DungeonRichTextBox();
            btnValidarFilaExp = new Button();
            txtBoxCvReverso = new TextBox();
            lblChaveAPI = new Label();
            label1 = new Label();
            txtBoxMediaReverso = new TextBox();
            lblMediaReverso = new Label();
            txtBoxDesvioReverso = new TextBox();
            lblDesvioReverso = new Label();
            txtBoxVarianciaReverso = new TextBox();
            lblVarianciaReverso = new Label();
            btnCalcReverso = new ReaLTaiizor.Controls.HopeRoundButton();
            hopeBtnMetodoReverso = new ReaLTaiizor.Controls.HopeRoundButton();
            hopeBtnMetodoPadrao = new ReaLTaiizor.Controls.HopeRoundButton();
            pnModoReverso = new ReaLTaiizor.Controls.Panel();
            pnSubModoReverso = new ReaLTaiizor.Controls.Panel();
            lblCampoObrigatorio = new Label();
            label4 = new Label();
            pnModoPadrao = new ReaLTaiizor.Controls.Panel();
            pnSubModoPadrao = new ReaLTaiizor.Controls.Panel();
            label2 = new Label();
            label3 = new Label();
            pnResultadosEstatisticos.SuspendLayout();
            flowLayoutPanelPares.SuspendLayout();
            Par0.SuspendLayout();
            Par1.SuspendLayout();
            Par2.SuspendLayout();
            Par3.SuspendLayout();
            Par4.SuspendLayout();
            pnModoReverso.SuspendLayout();
            pnSubModoReverso.SuspendLayout();
            pnModoPadrao.SuspendLayout();
            pnSubModoPadrao.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloEstatPar
            // 
            lblTituloEstatPar.Font = new Font("Berlin Sans FB Demi", 25F, FontStyle.Bold);
            lblTituloEstatPar.ForeColor = Color.White;
            lblTituloEstatPar.Location = new Point(63, 53);
            lblTituloEstatPar.Margin = new Padding(0);
            lblTituloEstatPar.Name = "lblTituloEstatPar";
            lblTituloEstatPar.Size = new Size(608, 43);
            lblTituloEstatPar.TabIndex = 6;
            lblTituloEstatPar.Text = "Cálculo da Estatística Paramétrica";
            lblTituloEstatPar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescTela
            // 
            lblDescTela.Font = new Font("Berlin Sans FB", 14F);
            lblDescTela.ForeColor = Color.White;
            lblDescTela.Location = new Point(69, 100);
            lblDescTela.Margin = new Padding(0);
            lblDescTela.Name = "lblDescTela";
            lblDescTela.Size = new Size(614, 28);
            lblDescTela.TabIndex = 7;
            lblDescTela.Text = "Insira os valores da Frequência Acumulada (Xi) e Frequência Absoluta (Fi):";
            lblDescTela.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFilaExpandida
            // 
            lblFilaExpandida.Font = new Font("Berlin Sans FB", 14F);
            lblFilaExpandida.ForeColor = Color.White;
            lblFilaExpandida.Location = new Point(192, 91);
            lblFilaExpandida.Margin = new Padding(0);
            lblFilaExpandida.Name = "lblFilaExpandida";
            lblFilaExpandida.Size = new Size(33, 28);
            lblFilaExpandida.TabIndex = 12;
            lblFilaExpandida.Text = "ou";
            lblFilaExpandida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fi1
            // 
            Fi1.Cursor = Cursors.IBeam;
            Fi1.Location = new Point(116, 7);
            Fi1.Margin = new Padding(3, 2, 3, 2);
            Fi1.Name = "Fi1";
            Fi1.PlaceholderText = "Fi";
            Fi1.Size = new Size(35, 23);
            Fi1.TabIndex = 13;
            Fi1.TextAlign = HorizontalAlignment.Center;
            // 
            // Xi1
            // 
            Xi1.Cursor = Cursors.IBeam;
            Xi1.Location = new Point(21, 7);
            Xi1.Margin = new Padding(3, 2, 3, 2);
            Xi1.Name = "Xi1";
            Xi1.PlaceholderText = "Xi";
            Xi1.Size = new Size(35, 23);
            Xi1.TabIndex = 12;
            Xi1.TextAlign = HorizontalAlignment.Center;
            // 
            // AdicionarFila
            // 
            AdicionarFila.BackColor = Color.FromArgb(79, 55, 139);
            AdicionarFila.Cursor = Cursors.Hand;
            AdicionarFila.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            AdicionarFila.FlatAppearance.BorderSize = 0;
            AdicionarFila.FlatStyle = FlatStyle.Flat;
            AdicionarFila.Font = new Font("Berlin Sans FB", 12F);
            AdicionarFila.ForeColor = Color.White;
            AdicionarFila.Location = new Point(231, 224);
            AdicionarFila.Margin = new Padding(0);
            AdicionarFila.Name = "AdicionarFila";
            AdicionarFila.Size = new Size(156, 37);
            AdicionarFila.TabIndex = 15;
            AdicionarFila.Text = "Realizar Cálculos";
            AdicionarFila.UseVisualStyleBackColor = false;
            AdicionarFila.Click += AdicionarFila_Click;
            // 
            // lblResultadosEstatisticos
            // 
            lblResultadosEstatisticos.Font = new Font("Berlin Sans FB Demi", 25F, FontStyle.Bold);
            lblResultadosEstatisticos.ForeColor = Color.White;
            lblResultadosEstatisticos.Location = new Point(812, 53);
            lblResultadosEstatisticos.Margin = new Padding(0);
            lblResultadosEstatisticos.Name = "lblResultadosEstatisticos";
            lblResultadosEstatisticos.Size = new Size(383, 43);
            lblResultadosEstatisticos.TabIndex = 17;
            lblResultadosEstatisticos.Text = "Resultados Estatísticos";
            lblResultadosEstatisticos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPassosGeral
            // 
            lbPassosGeral.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbPassosGeral.Font = new Font("Berlin Sans FB", 10F);
            lbPassosGeral.ForeColor = Color.White;
            lbPassosGeral.ImageAlign = ContentAlignment.MiddleLeft;
            lbPassosGeral.Location = new Point(46, 48);
            lbPassosGeral.Name = "lbPassosGeral";
            lbPassosGeral.Size = new Size(443, 491);
            lbPassosGeral.TabIndex = 1;
            lbPassosGeral.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbResultadoGeral
            // 
            lbResultadoGeral.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbResultadoGeral.Font = new Font("Segoe UI", 12F);
            lbResultadoGeral.ForeColor = Color.White;
            lbResultadoGeral.Location = new Point(394, 5);
            lbResultadoGeral.Name = "lbResultadoGeral";
            lbResultadoGeral.Size = new Size(125, 30);
            lbResultadoGeral.TabIndex = 23;
            lbResultadoGeral.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BotaoProximoPassoVAC
            // 
            BotaoProximoPassoVAC.BackColor = Color.FromArgb(79, 55, 139);
            BotaoProximoPassoVAC.Cursor = Cursors.Hand;
            BotaoProximoPassoVAC.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            BotaoProximoPassoVAC.FlatAppearance.BorderSize = 0;
            BotaoProximoPassoVAC.FlatStyle = FlatStyle.Flat;
            BotaoProximoPassoVAC.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BotaoProximoPassoVAC.ForeColor = Color.White;
            BotaoProximoPassoVAC.Image = (Image)resources.GetObject("BotaoProximoPassoVAC.Image");
            BotaoProximoPassoVAC.Location = new Point(1156, 716);
            BotaoProximoPassoVAC.Margin = new Padding(0);
            BotaoProximoPassoVAC.Name = "BotaoProximoPassoVAC";
            BotaoProximoPassoVAC.Size = new Size(104, 36);
            BotaoProximoPassoVAC.TabIndex = 26;
            BotaoProximoPassoVAC.UseVisualStyleBackColor = false;
            BotaoProximoPassoVAC.Visible = false;
            BotaoProximoPassoVAC.Click += BotaoProximoPassoVAC_Click;
            // 
            // pnResultadosEstatisticos
            // 
            pnResultadosEstatisticos.BackColor = Color.FromArgb(57, 45, 120);
            pnResultadosEstatisticos.Controls.Add(btnAntTxt);
            pnResultadosEstatisticos.Controls.Add(btnProxTxt);
            pnResultadosEstatisticos.Controls.Add(lbTituloGeral);
            pnResultadosEstatisticos.Controls.Add(lbResultadoGeral);
            pnResultadosEstatisticos.Controls.Add(lbPassosGeral);
            pnResultadosEstatisticos.EdgeColor = Color.FromArgb(32, 41, 50);
            pnResultadosEstatisticos.Location = new Point(739, 112);
            pnResultadosEstatisticos.Name = "pnResultadosEstatisticos";
            pnResultadosEstatisticos.Padding = new Padding(5);
            pnResultadosEstatisticos.Size = new Size(521, 574);
            pnResultadosEstatisticos.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnResultadosEstatisticos.TabIndex = 27;
            // 
            // btnAntTxt
            // 
            btnAntTxt.BackColor = Color.FromArgb(39, 51, 63);
            btnAntTxt.Cursor = Cursors.Hand;
            btnAntTxt.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            btnAntTxt.FlatAppearance.BorderSize = 0;
            btnAntTxt.FlatStyle = FlatStyle.Flat;
            btnAntTxt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnAntTxt.ForeColor = Color.White;
            btnAntTxt.Image = (Image)resources.GetObject("btnAntTxt.Image");
            btnAntTxt.Location = new Point(6, 259);
            btnAntTxt.Margin = new Padding(0);
            btnAntTxt.Name = "btnAntTxt";
            btnAntTxt.Size = new Size(25, 24);
            btnAntTxt.TabIndex = 29;
            btnAntTxt.UseVisualStyleBackColor = true;
            btnAntTxt.Click += btnAntTxt_Click;
            // 
            // btnProxTxt
            // 
            btnProxTxt.BackColor = Color.FromArgb(39, 51, 63);
            btnProxTxt.Cursor = Cursors.Hand;
            btnProxTxt.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            btnProxTxt.FlatAppearance.BorderSize = 0;
            btnProxTxt.FlatStyle = FlatStyle.Flat;
            btnProxTxt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnProxTxt.ForeColor = Color.White;
            btnProxTxt.Image = (Image)resources.GetObject("btnProxTxt.Image");
            btnProxTxt.Location = new Point(492, 259);
            btnProxTxt.Margin = new Padding(0);
            btnProxTxt.Name = "btnProxTxt";
            btnProxTxt.Size = new Size(25, 24);
            btnProxTxt.TabIndex = 28;
            btnProxTxt.UseVisualStyleBackColor = true;
            btnProxTxt.Click += btnProxTxt_Click;
            // 
            // lbTituloGeral
            // 
            lbTituloGeral.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTituloGeral.ForeColor = Color.White;
            lbTituloGeral.Location = new Point(34, 5);
            lbTituloGeral.Margin = new Padding(0);
            lbTituloGeral.Name = "lbTituloGeral";
            lbTituloGeral.Size = new Size(345, 30);
            lbTituloGeral.TabIndex = 28;
            lbTituloGeral.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TglBtnListaOuFila
            // 
            TglBtnListaOuFila.BackColor = Color.FromArgb(26, 31, 52);
            TglBtnListaOuFila.BaseColor = Color.FromArgb(26, 31, 52);
            TglBtnListaOuFila.BaseColorA = Color.FromArgb(220, 223, 230);
            TglBtnListaOuFila.BaseColorB = Color.FromArgb(100, 64, 158, 255);
            TglBtnListaOuFila.HeadColorA = Color.FromArgb(220, 223, 230);
            TglBtnListaOuFila.HeadColorB = Color.White;
            TglBtnListaOuFila.HeadColorC = Color.FromArgb(64, 158, 255);
            TglBtnListaOuFila.HeadColorD = Color.FromArgb(64, 158, 255);
            TglBtnListaOuFila.Location = new Point(216, 185);
            TglBtnListaOuFila.Name = "TglBtnListaOuFila";
            TglBtnListaOuFila.Size = new Size(48, 20);
            TglBtnListaOuFila.TabIndex = 28;
            TglBtnListaOuFila.UseVisualStyleBackColor = false;
            TglBtnListaOuFila.CheckedChanged += TglBtnListaOuFila_CheckedChanged;
            // 
            // lblModoFilaExpandida
            // 
            lblModoFilaExpandida.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblModoFilaExpandida.Font = new Font("Berlin Sans FB", 10F);
            lblModoFilaExpandida.ForeColor = Color.White;
            lblModoFilaExpandida.Location = new Point(261, 186);
            lblModoFilaExpandida.Name = "lblModoFilaExpandida";
            lblModoFilaExpandida.Size = new Size(130, 18);
            lblModoFilaExpandida.TabIndex = 1;
            lblModoFilaExpandida.Text = "Modo Fila Expandida";
            lblModoFilaExpandida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelPares
            // 
            flowLayoutPanelPares.Controls.Add(Par0);
            flowLayoutPanelPares.Controls.Add(Par1);
            flowLayoutPanelPares.Controls.Add(Par2);
            flowLayoutPanelPares.Controls.Add(Par3);
            flowLayoutPanelPares.Controls.Add(Par4);
            flowLayoutPanelPares.Controls.Add(btnAdicionarNovoPar);
            flowLayoutPanelPares.Location = new Point(10, 9);
            flowLayoutPanelPares.Name = "flowLayoutPanelPares";
            flowLayoutPanelPares.Size = new Size(174, 237);
            flowLayoutPanelPares.TabIndex = 29;
            // 
            // Par0
            // 
            Par0.BackColor = Color.FromArgb(40, 0, 0, 0);
            Par0.Controls.Add(Xi0);
            Par0.Controls.Add(Fi0);
            Par0.Location = new Point(3, 2);
            Par0.Margin = new Padding(3, 2, 3, 2);
            Par0.Name = "Par0";
            Par0.Size = new Size(169, 36);
            Par0.TabIndex = 35;
            // 
            // Xi0
            // 
            Xi0.Cursor = Cursors.IBeam;
            Xi0.Location = new Point(21, 7);
            Xi0.Margin = new Padding(3, 2, 3, 2);
            Xi0.Name = "Xi0";
            Xi0.PlaceholderText = "Xi";
            Xi0.Size = new Size(35, 23);
            Xi0.TabIndex = 10;
            Xi0.TextAlign = HorizontalAlignment.Center;
            // 
            // Fi0
            // 
            Fi0.Cursor = Cursors.IBeam;
            Fi0.Location = new Point(116, 7);
            Fi0.Margin = new Padding(3, 2, 3, 2);
            Fi0.Name = "Fi0";
            Fi0.PlaceholderText = "Fi";
            Fi0.Size = new Size(35, 23);
            Fi0.TabIndex = 11;
            Fi0.TextAlign = HorizontalAlignment.Center;
            // 
            // Par1
            // 
            Par1.BackColor = Color.FromArgb(40, 0, 0, 0);
            Par1.Controls.Add(btnRmvPar1);
            Par1.Controls.Add(Xi1);
            Par1.Controls.Add(Fi1);
            Par1.Enabled = false;
            Par1.Location = new Point(3, 42);
            Par1.Margin = new Padding(3, 2, 3, 2);
            Par1.Name = "Par1";
            Par1.Size = new Size(169, 36);
            Par1.TabIndex = 34;
            Par1.Visible = false;
            // 
            // btnRmvPar1
            // 
            btnRmvPar1.BackColor = Color.Transparent;
            btnRmvPar1.BorderColor = Color.FromArgb(32, 34, 37);
            btnRmvPar1.Enabled = false;
            btnRmvPar1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnRmvPar1.EnteredColor = Color.FromArgb(32, 34, 37);
            btnRmvPar1.Font = new Font("Microsoft Sans Serif", 12F);
            btnRmvPar1.Image = (Image)resources.GetObject("btnRmvPar1.Image");
            btnRmvPar1.ImageAlign = ContentAlignment.MiddleCenter;
            btnRmvPar1.InactiveColor = Color.FromArgb(165, 37, 37);
            btnRmvPar1.Location = new Point(72, 4);
            btnRmvPar1.Name = "btnRmvPar1";
            btnRmvPar1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnRmvPar1.PressedColor = Color.FromArgb(165, 37, 37);
            btnRmvPar1.Size = new Size(28, 28);
            btnRmvPar1.TabIndex = 32;
            btnRmvPar1.TextAlignment = StringAlignment.Center;
            btnRmvPar1.Visible = false;
            btnRmvPar1.Click += BtnRmvPar_Click;
            // 
            // Par2
            // 
            Par2.BackColor = Color.FromArgb(40, 0, 0, 0);
            Par2.Controls.Add(btnRmvPar2);
            Par2.Controls.Add(Xi2);
            Par2.Controls.Add(Fi2);
            Par2.Enabled = false;
            Par2.Location = new Point(3, 82);
            Par2.Margin = new Padding(3, 2, 3, 2);
            Par2.Name = "Par2";
            Par2.Size = new Size(169, 36);
            Par2.TabIndex = 35;
            Par2.Visible = false;
            // 
            // btnRmvPar2
            // 
            btnRmvPar2.BackColor = Color.Transparent;
            btnRmvPar2.BorderColor = Color.FromArgb(32, 34, 37);
            btnRmvPar2.Enabled = false;
            btnRmvPar2.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnRmvPar2.EnteredColor = Color.FromArgb(32, 34, 37);
            btnRmvPar2.Font = new Font("Microsoft Sans Serif", 12F);
            btnRmvPar2.Image = (Image)resources.GetObject("btnRmvPar2.Image");
            btnRmvPar2.ImageAlign = ContentAlignment.MiddleCenter;
            btnRmvPar2.InactiveColor = Color.FromArgb(165, 37, 37);
            btnRmvPar2.Location = new Point(72, 4);
            btnRmvPar2.Name = "btnRmvPar2";
            btnRmvPar2.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnRmvPar2.PressedColor = Color.FromArgb(165, 37, 37);
            btnRmvPar2.Size = new Size(28, 28);
            btnRmvPar2.TabIndex = 33;
            btnRmvPar2.TextAlignment = StringAlignment.Center;
            btnRmvPar2.Visible = false;
            btnRmvPar2.Click += BtnRmvPar_Click;
            // 
            // Xi2
            // 
            Xi2.Cursor = Cursors.IBeam;
            Xi2.Location = new Point(21, 7);
            Xi2.Margin = new Padding(3, 2, 3, 2);
            Xi2.Name = "Xi2";
            Xi2.PlaceholderText = "Xi";
            Xi2.Size = new Size(35, 23);
            Xi2.TabIndex = 14;
            Xi2.TextAlign = HorizontalAlignment.Center;
            // 
            // Fi2
            // 
            Fi2.Cursor = Cursors.IBeam;
            Fi2.Location = new Point(116, 7);
            Fi2.Margin = new Padding(3, 2, 3, 2);
            Fi2.Name = "Fi2";
            Fi2.PlaceholderText = "Fi";
            Fi2.Size = new Size(35, 23);
            Fi2.TabIndex = 15;
            Fi2.TextAlign = HorizontalAlignment.Center;
            // 
            // Par3
            // 
            Par3.BackColor = Color.FromArgb(40, 0, 0, 0);
            Par3.Controls.Add(btnRmvPar3);
            Par3.Controls.Add(Xi3);
            Par3.Controls.Add(Fi3);
            Par3.Enabled = false;
            Par3.Location = new Point(3, 122);
            Par3.Margin = new Padding(3, 2, 3, 2);
            Par3.Name = "Par3";
            Par3.Size = new Size(169, 36);
            Par3.TabIndex = 37;
            Par3.Visible = false;
            // 
            // btnRmvPar3
            // 
            btnRmvPar3.BackColor = Color.Transparent;
            btnRmvPar3.BorderColor = Color.FromArgb(32, 34, 37);
            btnRmvPar3.Enabled = false;
            btnRmvPar3.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnRmvPar3.EnteredColor = Color.FromArgb(32, 34, 37);
            btnRmvPar3.Font = new Font("Microsoft Sans Serif", 12F);
            btnRmvPar3.Image = (Image)resources.GetObject("btnRmvPar3.Image");
            btnRmvPar3.ImageAlign = ContentAlignment.MiddleCenter;
            btnRmvPar3.InactiveColor = Color.FromArgb(165, 37, 37);
            btnRmvPar3.Location = new Point(72, 4);
            btnRmvPar3.Name = "btnRmvPar3";
            btnRmvPar3.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnRmvPar3.PressedColor = Color.FromArgb(165, 37, 37);
            btnRmvPar3.Size = new Size(28, 28);
            btnRmvPar3.TabIndex = 34;
            btnRmvPar3.TextAlignment = StringAlignment.Center;
            btnRmvPar3.Visible = false;
            btnRmvPar3.Click += BtnRmvPar_Click;
            // 
            // Xi3
            // 
            Xi3.Cursor = Cursors.IBeam;
            Xi3.Location = new Point(21, 7);
            Xi3.Margin = new Padding(3, 2, 3, 2);
            Xi3.Name = "Xi3";
            Xi3.PlaceholderText = "Xi";
            Xi3.Size = new Size(35, 23);
            Xi3.TabIndex = 16;
            Xi3.TextAlign = HorizontalAlignment.Center;
            // 
            // Fi3
            // 
            Fi3.Cursor = Cursors.IBeam;
            Fi3.Location = new Point(116, 7);
            Fi3.Margin = new Padding(3, 2, 3, 2);
            Fi3.Name = "Fi3";
            Fi3.PlaceholderText = "Fi";
            Fi3.Size = new Size(35, 23);
            Fi3.TabIndex = 17;
            Fi3.TextAlign = HorizontalAlignment.Center;
            // 
            // Par4
            // 
            Par4.BackColor = Color.FromArgb(40, 0, 0, 0);
            Par4.Controls.Add(btnRmvPar4);
            Par4.Controls.Add(Xi4);
            Par4.Controls.Add(Fi4);
            Par4.Enabled = false;
            Par4.Location = new Point(3, 162);
            Par4.Margin = new Padding(3, 2, 3, 2);
            Par4.Name = "Par4";
            Par4.Size = new Size(169, 36);
            Par4.TabIndex = 36;
            Par4.Visible = false;
            // 
            // btnRmvPar4
            // 
            btnRmvPar4.BackColor = Color.Transparent;
            btnRmvPar4.BorderColor = Color.FromArgb(32, 34, 37);
            btnRmvPar4.Enabled = false;
            btnRmvPar4.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnRmvPar4.EnteredColor = Color.FromArgb(32, 34, 37);
            btnRmvPar4.Font = new Font("Microsoft Sans Serif", 12F);
            btnRmvPar4.Image = (Image)resources.GetObject("btnRmvPar4.Image");
            btnRmvPar4.ImageAlign = ContentAlignment.MiddleCenter;
            btnRmvPar4.InactiveColor = Color.FromArgb(165, 37, 37);
            btnRmvPar4.Location = new Point(72, 4);
            btnRmvPar4.Name = "btnRmvPar4";
            btnRmvPar4.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnRmvPar4.PressedColor = Color.FromArgb(165, 37, 37);
            btnRmvPar4.Size = new Size(28, 28);
            btnRmvPar4.TabIndex = 35;
            btnRmvPar4.TextAlignment = StringAlignment.Center;
            btnRmvPar4.Visible = false;
            btnRmvPar4.Click += BtnRmvPar_Click;
            // 
            // Xi4
            // 
            Xi4.Cursor = Cursors.IBeam;
            Xi4.Location = new Point(21, 7);
            Xi4.Margin = new Padding(3, 2, 3, 2);
            Xi4.Name = "Xi4";
            Xi4.PlaceholderText = "Xi";
            Xi4.Size = new Size(35, 23);
            Xi4.TabIndex = 18;
            Xi4.TextAlign = HorizontalAlignment.Center;
            // 
            // Fi4
            // 
            Fi4.Cursor = Cursors.IBeam;
            Fi4.Location = new Point(116, 7);
            Fi4.Margin = new Padding(3, 2, 3, 2);
            Fi4.Name = "Fi4";
            Fi4.PlaceholderText = "Fi";
            Fi4.Size = new Size(35, 23);
            Fi4.TabIndex = 19;
            Fi4.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAdicionarNovoPar
            // 
            btnAdicionarNovoPar.BackColor = Color.FromArgb(60, 190, 60);
            btnAdicionarNovoPar.ForeColor = Color.White;
            btnAdicionarNovoPar.Image = (Image)resources.GetObject("btnAdicionarNovoPar.Image");
            btnAdicionarNovoPar.Location = new Point(0, 200);
            btnAdicionarNovoPar.Margin = new Padding(0);
            btnAdicionarNovoPar.Name = "btnAdicionarNovoPar";
            btnAdicionarNovoPar.Size = new Size(172, 31);
            btnAdicionarNovoPar.TabIndex = 31;
            btnAdicionarNovoPar.UseVisualStyleBackColor = false;
            btnAdicionarNovoPar.Click += btnAdicionarNovoPar_Click;
            // 
            // chkParesAuto
            // 
            chkParesAuto.Checked = true;
            chkParesAuto.CheckState = CheckState.Checked;
            chkParesAuto.Font = new Font("Berlin Sans FB", 10F);
            chkParesAuto.ForeColor = Color.White;
            chkParesAuto.Location = new Point(15, 251);
            chkParesAuto.Name = "chkParesAuto";
            chkParesAuto.Size = new Size(111, 20);
            chkParesAuto.TabIndex = 31;
            chkParesAuto.Text = "Adicionar auto";
            chkParesAuto.UseVisualStyleBackColor = true;
            // 
            // txtboxFilaExp
            // 
            txtboxFilaExp.AutoWordSelection = false;
            txtboxFilaExp.BackColor = Color.Transparent;
            txtboxFilaExp.BorderColor = Color.FromArgb(180, 180, 180);
            txtboxFilaExp.EdgeColor = Color.White;
            txtboxFilaExp.Enabled = false;
            txtboxFilaExp.Font = new Font("Tahoma", 10F);
            txtboxFilaExp.ForeColor = Color.FromArgb(76, 76, 76);
            txtboxFilaExp.Location = new Point(231, 11);
            txtboxFilaExp.Name = "txtboxFilaExp";
            txtboxFilaExp.ReadOnly = false;
            txtboxFilaExp.Size = new Size(155, 131);
            txtboxFilaExp.TabIndex = 32;
            txtboxFilaExp.TextBackColor = Color.White;
            txtboxFilaExp.WordWrap = true;
            // 
            // btnValidarFilaExp
            // 
            btnValidarFilaExp.Location = new Point(231, 149);
            btnValidarFilaExp.Name = "btnValidarFilaExp";
            btnValidarFilaExp.Size = new Size(155, 27);
            btnValidarFilaExp.TabIndex = 33;
            btnValidarFilaExp.Text = "Validar Lista";
            btnValidarFilaExp.UseVisualStyleBackColor = true;
            btnValidarFilaExp.Click += btnValidarFilaExp_Click;
            // 
            // txtBoxCvReverso
            // 
            txtBoxCvReverso.Location = new Point(150, 38);
            txtBoxCvReverso.Name = "txtBoxCvReverso";
            txtBoxCvReverso.Size = new Size(32, 23);
            txtBoxCvReverso.TabIndex = 37;
            // 
            // lblChaveAPI
            // 
            lblChaveAPI.Font = new Font("Berlin Sans FB", 12F);
            lblChaveAPI.ForeColor = Color.White;
            lblChaveAPI.Location = new Point(26, 29);
            lblChaveAPI.Margin = new Padding(0);
            lblChaveAPI.Name = "lblChaveAPI";
            lblChaveAPI.Size = new Size(109, 36);
            lblChaveAPI.TabIndex = 36;
            lblChaveAPI.Text = "Coeficiente de Variação:";
            lblChaveAPI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Berlin Sans FB", 12.5F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 84);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 38;
            label1.Text = "Campos Opcionais:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxMediaReverso
            // 
            txtBoxMediaReverso.Location = new Point(150, 138);
            txtBoxMediaReverso.Name = "txtBoxMediaReverso";
            txtBoxMediaReverso.PlaceholderText = "x̄";
            txtBoxMediaReverso.Size = new Size(32, 23);
            txtBoxMediaReverso.TabIndex = 40;
            txtBoxMediaReverso.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMediaReverso
            // 
            lblMediaReverso.Font = new Font("Berlin Sans FB", 12F);
            lblMediaReverso.ForeColor = Color.White;
            lblMediaReverso.Location = new Point(26, 140);
            lblMediaReverso.Margin = new Padding(0);
            lblMediaReverso.Name = "lblMediaReverso";
            lblMediaReverso.Size = new Size(109, 18);
            lblMediaReverso.TabIndex = 39;
            lblMediaReverso.Text = "Média:";
            lblMediaReverso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxDesvioReverso
            // 
            txtBoxDesvioReverso.Location = new Point(150, 204);
            txtBoxDesvioReverso.Name = "txtBoxDesvioReverso";
            txtBoxDesvioReverso.PlaceholderText = "s";
            txtBoxDesvioReverso.Size = new Size(32, 23);
            txtBoxDesvioReverso.TabIndex = 42;
            txtBoxDesvioReverso.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDesvioReverso
            // 
            lblDesvioReverso.Font = new Font("Berlin Sans FB", 12F);
            lblDesvioReverso.ForeColor = Color.White;
            lblDesvioReverso.Location = new Point(26, 206);
            lblDesvioReverso.Margin = new Padding(0);
            lblDesvioReverso.Name = "lblDesvioReverso";
            lblDesvioReverso.Size = new Size(109, 18);
            lblDesvioReverso.TabIndex = 41;
            lblDesvioReverso.Text = "Desvio Padrão:";
            lblDesvioReverso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxVarianciaReverso
            // 
            txtBoxVarianciaReverso.Location = new Point(150, 171);
            txtBoxVarianciaReverso.Name = "txtBoxVarianciaReverso";
            txtBoxVarianciaReverso.PlaceholderText = "s²";
            txtBoxVarianciaReverso.Size = new Size(32, 23);
            txtBoxVarianciaReverso.TabIndex = 44;
            txtBoxVarianciaReverso.TextAlign = HorizontalAlignment.Center;
            // 
            // lblVarianciaReverso
            // 
            lblVarianciaReverso.Font = new Font("Berlin Sans FB", 12F);
            lblVarianciaReverso.ForeColor = Color.White;
            lblVarianciaReverso.Location = new Point(26, 173);
            lblVarianciaReverso.Margin = new Padding(0);
            lblVarianciaReverso.Name = "lblVarianciaReverso";
            lblVarianciaReverso.Size = new Size(109, 18);
            lblVarianciaReverso.TabIndex = 43;
            lblVarianciaReverso.Text = "Variância:";
            lblVarianciaReverso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCalcReverso
            // 
            btnCalcReverso.BorderColor = Color.FromArgb(220, 223, 230);
            btnCalcReverso.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnCalcReverso.DangerColor = Color.FromArgb(245, 108, 108);
            btnCalcReverso.DefaultColor = Color.FromArgb(255, 255, 255);
            btnCalcReverso.Font = new Font("Berlin Sans FB", 12F);
            btnCalcReverso.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnCalcReverso.InfoColor = Color.FromArgb(144, 147, 153);
            btnCalcReverso.Location = new Point(98, 243);
            btnCalcReverso.Margin = new Padding(10);
            btnCalcReverso.Name = "btnCalcReverso";
            btnCalcReverso.PrimaryColor = Color.FromArgb(79, 55, 139);
            btnCalcReverso.Size = new Size(108, 34);
            btnCalcReverso.SuccessColor = Color.FromArgb(103, 194, 58);
            btnCalcReverso.TabIndex = 46;
            btnCalcReverso.Text = "Realizar cálculos";
            btnCalcReverso.TextColor = Color.White;
            btnCalcReverso.WarningColor = Color.FromArgb(230, 162, 60);
            btnCalcReverso.Click += btnCalcReverso_Click;
            // 
            // hopeBtnMetodoReverso
            // 
            hopeBtnMetodoReverso.BorderColor = Color.FromArgb(220, 223, 230);
            hopeBtnMetodoReverso.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeBtnMetodoReverso.DangerColor = Color.FromArgb(245, 108, 108);
            hopeBtnMetodoReverso.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeBtnMetodoReverso.Font = new Font("Berlin Sans FB Demi", 16F, FontStyle.Bold);
            hopeBtnMetodoReverso.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeBtnMetodoReverso.InfoColor = Color.FromArgb(144, 147, 153);
            hopeBtnMetodoReverso.Location = new Point(72, 473);
            hopeBtnMetodoReverso.Margin = new Padding(10);
            hopeBtnMetodoReverso.Name = "hopeBtnMetodoReverso";
            hopeBtnMetodoReverso.PrimaryColor = Color.FromArgb(79, 55, 139);
            hopeBtnMetodoReverso.Size = new Size(207, 44);
            hopeBtnMetodoReverso.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeBtnMetodoReverso.TabIndex = 47;
            hopeBtnMetodoReverso.Text = "Método Reverso";
            hopeBtnMetodoReverso.TextColor = Color.White;
            hopeBtnMetodoReverso.WarningColor = Color.FromArgb(230, 162, 60);
            hopeBtnMetodoReverso.Click += hopeBtnMetodoReverso_Click;
            // 
            // hopeBtnMetodoPadrao
            // 
            hopeBtnMetodoPadrao.BorderColor = Color.FromArgb(220, 223, 230);
            hopeBtnMetodoPadrao.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeBtnMetodoPadrao.DangerColor = Color.FromArgb(245, 108, 108);
            hopeBtnMetodoPadrao.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeBtnMetodoPadrao.Font = new Font("Berlin Sans FB Demi", 16F, FontStyle.Bold);
            hopeBtnMetodoPadrao.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeBtnMetodoPadrao.InfoColor = Color.FromArgb(144, 147, 153);
            hopeBtnMetodoPadrao.Location = new Point(72, 146);
            hopeBtnMetodoPadrao.Margin = new Padding(10);
            hopeBtnMetodoPadrao.Name = "hopeBtnMetodoPadrao";
            hopeBtnMetodoPadrao.PrimaryColor = Color.FromArgb(79, 55, 139);
            hopeBtnMetodoPadrao.Size = new Size(207, 44);
            hopeBtnMetodoPadrao.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeBtnMetodoPadrao.TabIndex = 48;
            hopeBtnMetodoPadrao.Text = "Método Padrão";
            hopeBtnMetodoPadrao.TextColor = Color.White;
            hopeBtnMetodoPadrao.WarningColor = Color.FromArgb(230, 162, 60);
            hopeBtnMetodoPadrao.Click += hopeBtnMetodoPadrao_Click;
            // 
            // pnModoReverso
            // 
            pnModoReverso.BackColor = Color.FromArgb(57, 45, 120);
            pnModoReverso.Controls.Add(pnSubModoReverso);
            pnModoReverso.EdgeColor = Color.FromArgb(32, 41, 50);
            pnModoReverso.Location = new Point(295, 473);
            pnModoReverso.Name = "pnModoReverso";
            pnModoReverso.Padding = new Padding(5);
            pnModoReverso.Size = new Size(308, 288);
            pnModoReverso.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnModoReverso.TabIndex = 30;
            // 
            // pnSubModoReverso
            // 
            pnSubModoReverso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnSubModoReverso.BackColor = Color.FromArgb(26, 31, 52);
            pnSubModoReverso.Controls.Add(lblCampoObrigatorio);
            pnSubModoReverso.Controls.Add(label4);
            pnSubModoReverso.Controls.Add(lblChaveAPI);
            pnSubModoReverso.Controls.Add(txtBoxDesvioReverso);
            pnSubModoReverso.Controls.Add(txtBoxCvReverso);
            pnSubModoReverso.Controls.Add(lblDesvioReverso);
            pnSubModoReverso.Controls.Add(label1);
            pnSubModoReverso.Controls.Add(lblVarianciaReverso);
            pnSubModoReverso.Controls.Add(btnCalcReverso);
            pnSubModoReverso.Controls.Add(txtBoxMediaReverso);
            pnSubModoReverso.Controls.Add(lblMediaReverso);
            pnSubModoReverso.Controls.Add(txtBoxVarianciaReverso);
            pnSubModoReverso.EdgeColor = Color.FromArgb(32, 41, 50);
            pnSubModoReverso.Location = new Point(3, 3);
            pnSubModoReverso.Name = "pnSubModoReverso";
            pnSubModoReverso.Padding = new Padding(5);
            pnSubModoReverso.Size = new Size(302, 282);
            pnSubModoReverso.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnSubModoReverso.TabIndex = 47;
            // 
            // lblCampoObrigatorio
            // 
            lblCampoObrigatorio.Font = new Font("Berlin Sans FB", 12.5F);
            lblCampoObrigatorio.ForeColor = Color.White;
            lblCampoObrigatorio.Location = new Point(12, 5);
            lblCampoObrigatorio.Margin = new Padding(0);
            lblCampoObrigatorio.Name = "lblCampoObrigatorio";
            lblCampoObrigatorio.Size = new Size(159, 21);
            lblCampoObrigatorio.TabIndex = 48;
            lblCampoObrigatorio.Text = "Campo Obrigatório:";
            lblCampoObrigatorio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Berlin Sans FB", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 105);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 47;
            label4.Text = "Informe ao menos um dos parâmetros:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnModoPadrao
            // 
            pnModoPadrao.BackColor = Color.FromArgb(57, 45, 120);
            pnModoPadrao.Controls.Add(pnSubModoPadrao);
            pnModoPadrao.EdgeColor = Color.FromArgb(32, 41, 50);
            pnModoPadrao.Location = new Point(292, 146);
            pnModoPadrao.Name = "pnModoPadrao";
            pnModoPadrao.Padding = new Padding(5);
            pnModoPadrao.Size = new Size(414, 282);
            pnModoPadrao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnModoPadrao.TabIndex = 47;
            // 
            // pnSubModoPadrao
            // 
            pnSubModoPadrao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnSubModoPadrao.BackColor = Color.FromArgb(26, 31, 52);
            pnSubModoPadrao.Controls.Add(chkParesAuto);
            pnSubModoPadrao.Controls.Add(lblFilaExpandida);
            pnSubModoPadrao.Controls.Add(flowLayoutPanelPares);
            pnSubModoPadrao.Controls.Add(AdicionarFila);
            pnSubModoPadrao.Controls.Add(txtboxFilaExp);
            pnSubModoPadrao.Controls.Add(TglBtnListaOuFila);
            pnSubModoPadrao.Controls.Add(lblModoFilaExpandida);
            pnSubModoPadrao.Controls.Add(btnValidarFilaExp);
            pnSubModoPadrao.EdgeColor = Color.FromArgb(32, 41, 50);
            pnSubModoPadrao.Location = new Point(3, 3);
            pnSubModoPadrao.Name = "pnSubModoPadrao";
            pnSubModoPadrao.Padding = new Padding(5);
            pnSubModoPadrao.Size = new Size(408, 276);
            pnSubModoPadrao.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnSubModoPadrao.TabIndex = 48;
            // 
            // label2
            // 
            label2.Font = new Font("Berlin Sans FB", 9.5F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 200);
            label2.Name = "label2";
            label2.Size = new Size(205, 228);
            label2.TabIndex = 49;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.Font = new Font("Berlin Sans FB", 9.5F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 527);
            label3.Name = "label3";
            label3.Size = new Size(205, 184);
            label3.TabIndex = 50;
            label3.Text = resources.GetString("label3.Text");
            // 
            // TelaMediaPosicaoCentral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 31, 52);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnModoPadrao);
            Controls.Add(pnModoReverso);
            Controls.Add(hopeBtnMetodoPadrao);
            Controls.Add(hopeBtnMetodoReverso);
            Controls.Add(pnResultadosEstatisticos);
            Controls.Add(BotaoProximoPassoVAC);
            Controls.Add(lblResultadosEstatisticos);
            Controls.Add(lblDescTela);
            Controls.Add(lblTituloEstatPar);
            Margin = new Padding(0);
            Name = "TelaMediaPosicaoCentral";
            Size = new Size(1280, 800);
            Load += TelaMediaPosicaoCentral_Load;
            pnResultadosEstatisticos.ResumeLayout(false);
            flowLayoutPanelPares.ResumeLayout(false);
            Par0.ResumeLayout(false);
            Par0.PerformLayout();
            Par1.ResumeLayout(false);
            Par1.PerformLayout();
            Par2.ResumeLayout(false);
            Par2.PerformLayout();
            Par3.ResumeLayout(false);
            Par3.PerformLayout();
            Par4.ResumeLayout(false);
            Par4.PerformLayout();
            pnModoReverso.ResumeLayout(false);
            pnSubModoReverso.ResumeLayout(false);
            pnSubModoReverso.PerformLayout();
            pnModoPadrao.ResumeLayout(false);
            pnSubModoPadrao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblTituloEstatPar;
        private Label lblDescTela;
        private Label lblFilaExpandida;
        private TextBox Fi1;
        private TextBox Xi1;
        private Button AdicionarFila;
        private Label lblResultadosEstatisticos;
        private Label lbPassosGeral;
        private Label lbResultadoGeral;
        private Button BotaoProximoPassoVAC;
        private ReaLTaiizor.Controls.Panel pnResultadosEstatisticos;
        private Label lbTituloGeral;
        private Button btnAntTxt;
        private Button btnProxTxt;
        private ReaLTaiizor.Controls.HopeToggle TglBtnListaOuFila;
        private Label lblModoFilaExpandida;
        private FlowLayoutPanel flowLayoutPanelPares;
        private Panel Par1;
        private Panel Par0;
        private TextBox Xi0;
        private TextBox Fi0;
        private Panel Par2;
        private TextBox Xi2;
        private TextBox Fi2;
        private Panel Par3;
        private TextBox Xi3;
        private TextBox Fi3;
        private Panel Par4;
        private TextBox Xi4;
        private TextBox Fi4;
        private CheckBox chkParesAuto;
        private Button btnAdicionarNovoPar;
        private ReaLTaiizor.Controls.Button btnRmvPar1;
        private ReaLTaiizor.Controls.Button btnRmvPar2;
        private ReaLTaiizor.Controls.Button btnRmvPar3;
        private ReaLTaiizor.Controls.Button btnRmvPar4;
        private ReaLTaiizor.Controls.DungeonRichTextBox txtboxFilaExp;
        private Button btnValidarFilaExp;
        private TextBox txtBoxCvReverso;
        private Label lblChaveAPI;
        private Label label1;
        private TextBox txtBoxMediaReverso;
        private Label lblMediaReverso;
        private TextBox txtBoxDesvioReverso;
        private Label lblDesvioReverso;
        private TextBox txtBoxVarianciaReverso;
        private Label lblVarianciaReverso;
        private ReaLTaiizor.Controls.HopeRoundButton btnCalcReverso;
        private ReaLTaiizor.Controls.HopeRoundButton hopeBtnMetodoReverso;
        private ReaLTaiizor.Controls.HopeRoundButton hopeBtnMetodoPadrao;
        private ReaLTaiizor.Controls.Panel pnModoReverso;
        private ReaLTaiizor.Controls.Panel pnModoPadrao;
        private ReaLTaiizor.Controls.Panel pnSubModoReverso;
        private ReaLTaiizor.Controls.Panel pnSubModoPadrao;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCampoObrigatorio;
    }
}
