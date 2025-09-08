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
            TituloEstatPar = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            PanelFilaExpandida = new Panel();
            FilaExpandidaLabel = new Label();
            PanelListaXiFi = new Panel();
            Fi1 = new TextBox();
            Xi1 = new TextBox();
            AdicionarFila = new Button();
            ResultadosEstatisticos = new Label();
            lbPassosGeral = new Label();
            lbResultadoGeral = new Label();
            BotaoProximoPassoVAC = new Button();
            pnResultadosEstatisticos = new ReaLTaiizor.Controls.Panel();
            btnAntTxt = new Button();
            btnProxTxt = new Button();
            lbTituloGeral = new Label();
            btnListaOuFila = new ReaLTaiizor.Controls.HopeToggle();
            PanelFilaExpandida.SuspendLayout();
            PanelListaXiFi.SuspendLayout();
            pnResultadosEstatisticos.SuspendLayout();
            SuspendLayout();
            // 
            // TituloEstatPar
            // 
            TituloEstatPar.Font = new Font("Berlin Sans FB Demi", 25F, FontStyle.Bold);
            TituloEstatPar.ForeColor = Color.White;
            TituloEstatPar.Location = new Point(63, 53);
            TituloEstatPar.Margin = new Padding(0);
            TituloEstatPar.Name = "TituloEstatPar";
            TituloEstatPar.Size = new Size(608, 43);
            TituloEstatPar.TabIndex = 6;
            TituloEstatPar.Text = "Cálculo da Estatística Paramétrica";
            TituloEstatPar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Berlin Sans FB", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 100);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(614, 28);
            label1.TabIndex = 7;
            label1.Text = "Insira os valores da Frequência Acumulada (Xi) e Frequência Absoluta (Fi):";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Berlin Sans FB", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(91, 138);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(37, 28);
            label2.TabIndex = 8;
            label2.Text = "Xi";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Berlin Sans FB", 14F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(191, 138);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(29, 28);
            label3.TabIndex = 9;
            label3.Text = "Fi";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Berlin Sans FB", 14F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(302, 138);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 12;
            label4.Text = "Fila Expandida:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelFilaExpandida
            // 
            PanelFilaExpandida.BackColor = Color.FromArgb(40, 0, 0, 0);
            PanelFilaExpandida.Controls.Add(FilaExpandidaLabel);
            PanelFilaExpandida.Location = new Point(307, 168);
            PanelFilaExpandida.Margin = new Padding(3, 2, 3, 2);
            PanelFilaExpandida.Name = "PanelFilaExpandida";
            PanelFilaExpandida.Size = new Size(308, 172);
            PanelFilaExpandida.TabIndex = 13;
            // 
            // FilaExpandidaLabel
            // 
            FilaExpandidaLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FilaExpandidaLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            FilaExpandidaLabel.Font = new Font("Berlin Sans FB", 14F);
            FilaExpandidaLabel.ForeColor = Color.White;
            FilaExpandidaLabel.Location = new Point(11, 9);
            FilaExpandidaLabel.Name = "FilaExpandidaLabel";
            FilaExpandidaLabel.Size = new Size(282, 21);
            FilaExpandidaLabel.TabIndex = 0;
            FilaExpandidaLabel.Text = "Valores aqui";
            FilaExpandidaLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PanelListaXiFi
            // 
            PanelListaXiFi.BackColor = Color.FromArgb(40, 0, 0, 0);
            PanelListaXiFi.Controls.Add(Fi1);
            PanelListaXiFi.Controls.Add(Xi1);
            PanelListaXiFi.Location = new Point(73, 168);
            PanelListaXiFi.Margin = new Padding(3, 2, 3, 2);
            PanelListaXiFi.Name = "PanelListaXiFi";
            PanelListaXiFi.Size = new Size(169, 172);
            PanelListaXiFi.TabIndex = 14;
            // 
            // Fi1
            // 
            Fi1.Cursor = Cursors.IBeam;
            Fi1.Location = new Point(108, 7);
            Fi1.Margin = new Padding(3, 2, 3, 2);
            Fi1.Name = "Fi1";
            Fi1.Size = new Size(49, 23);
            Fi1.TabIndex = 13;
            Fi1.TextChanged += VerificacaoNovoPar;
            Fi1.KeyDown += XiFi_KeyDown;
            Fi1.KeyPress += XiFi_KeyPress;
            // 
            // Xi1
            // 
            Xi1.Cursor = Cursors.IBeam;
            Xi1.Location = new Point(12, 7);
            Xi1.Margin = new Padding(3, 2, 3, 2);
            Xi1.Name = "Xi1";
            Xi1.Size = new Size(49, 23);
            Xi1.TabIndex = 12;
            Xi1.TextChanged += VerificacaoNovoPar;
            Xi1.KeyDown += XiFi_KeyDown;
            Xi1.KeyPress += XiFi_KeyPress;
            // 
            // AdicionarFila
            // 
            AdicionarFila.BackColor = Color.FromArgb(79, 55, 139);
            AdicionarFila.Cursor = Cursors.Hand;
            AdicionarFila.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            AdicionarFila.FlatAppearance.BorderSize = 0;
            AdicionarFila.FlatStyle = FlatStyle.Flat;
            AdicionarFila.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            AdicionarFila.ForeColor = Color.White;
            AdicionarFila.Location = new Point(260, 227);
            AdicionarFila.Margin = new Padding(0);
            AdicionarFila.Name = "AdicionarFila";
            AdicionarFila.Size = new Size(26, 52);
            AdicionarFila.TabIndex = 15;
            AdicionarFila.Text = ">";
            AdicionarFila.UseVisualStyleBackColor = false;
            AdicionarFila.Click += AdicionarFila_Click;
            // 
            // ResultadosEstatisticos
            // 
            ResultadosEstatisticos.Font = new Font("Berlin Sans FB Demi", 25F, FontStyle.Bold);
            ResultadosEstatisticos.ForeColor = Color.White;
            ResultadosEstatisticos.Location = new Point(812, 53);
            ResultadosEstatisticos.Margin = new Padding(0);
            ResultadosEstatisticos.Name = "ResultadosEstatisticos";
            ResultadosEstatisticos.Size = new Size(383, 43);
            ResultadosEstatisticos.TabIndex = 17;
            ResultadosEstatisticos.Text = "Resultados Estatísticos";
            ResultadosEstatisticos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPassosGeral
            // 
            lbPassosGeral.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbPassosGeral.Font = new Font("Segoe UI", 12F);
            lbPassosGeral.ForeColor = Color.White;
            lbPassosGeral.Location = new Point(34, 24);
            lbPassosGeral.Name = "lbPassosGeral";
            lbPassosGeral.Size = new Size(469, 525);
            lbPassosGeral.TabIndex = 1;
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
            pnResultadosEstatisticos.Controls.Add(lbTituloGeral);
            pnResultadosEstatisticos.Controls.Add(lbResultadoGeral);
            pnResultadosEstatisticos.Controls.Add(lbPassosGeral);
            pnResultadosEstatisticos.EdgeColor = Color.FromArgb(32, 41, 50);
            pnResultadosEstatisticos.Location = new Point(724, 112);
            pnResultadosEstatisticos.Name = "pnResultadosEstatisticos";
            pnResultadosEstatisticos.Padding = new Padding(5);
            pnResultadosEstatisticos.Size = new Size(536, 574);
            pnResultadosEstatisticos.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnResultadosEstatisticos.TabIndex = 27;
            pnResultadosEstatisticos.Text = "panel1";
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
            btnAntTxt.Location = new Point(626, 443);
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
            btnProxTxt.Location = new Point(661, 443);
            btnProxTxt.Margin = new Padding(0);
            btnProxTxt.Name = "btnProxTxt";
            btnProxTxt.Size = new Size(25, 24);
            btnProxTxt.TabIndex = 28;
            btnProxTxt.UseVisualStyleBackColor = true;
            btnProxTxt.Click += btnProxTxt_Click;
            // 
            // lbTituloGeral
            // 
            lbTituloGeral.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lbTituloGeral.ForeColor = Color.White;
            lbTituloGeral.Location = new Point(111, 5);
            lbTituloGeral.Margin = new Padding(0);
            lbTituloGeral.Name = "lbTituloGeral";
            lbTituloGeral.Size = new Size(268, 30);
            lbTituloGeral.TabIndex = 28;
            lbTituloGeral.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnListaOuFila
            // 
            btnListaOuFila.AutoSize = true;
            btnListaOuFila.BackColor = Color.FromArgb(30, 33, 34);
            btnListaOuFila.BaseColor = Color.FromArgb(30, 33, 34);
            btnListaOuFila.BaseColorA = Color.FromArgb(220, 223, 230);
            btnListaOuFila.BaseColorB = Color.FromArgb(100, 64, 158, 255);
            btnListaOuFila.HeadColorA = Color.FromArgb(220, 223, 230);
            btnListaOuFila.HeadColorB = Color.White;
            btnListaOuFila.HeadColorC = Color.FromArgb(64, 158, 255);
            btnListaOuFila.HeadColorD = Color.FromArgb(64, 158, 255);
            btnListaOuFila.Location = new Point(253, 146);
            btnListaOuFila.Name = "btnListaOuFila";
            btnListaOuFila.Size = new Size(48, 20);
            btnListaOuFila.TabIndex = 28;
            btnListaOuFila.Text = "hopeToggle1";
            btnListaOuFila.UseVisualStyleBackColor = false;
            btnListaOuFila.CheckedChanged += btnListaOuFila_CheckedChanged;
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
            Controls.Add(btnProxTxt);
            Controls.Add(btnAntTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TituloEstatPar);
            Controls.Add(PanelListaXiFi);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaMediaPosicaoCentral";
            Size = new Size(1280, 800);
            Load += TelaMediaPosicaoCentral_Load;
            PanelFilaExpandida.ResumeLayout(false);
            PanelListaXiFi.ResumeLayout(false);
            PanelListaXiFi.PerformLayout();
            pnResultadosEstatisticos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TituloEstatPar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel PanelFilaExpandida;
        private Label FilaExpandidaLabel;
        private Panel PanelListaXiFi;
        private TextBox Fi1;
        private TextBox Xi1;
        private Button AdicionarFila;
        private Label ResultadosEstatisticos;
        private Label lbPassosGeral;
        private Label lbResultadoGeral;
        private Button BotaoProximoPassoVAC;
        private ReaLTaiizor.Controls.Panel pnResultadosEstatisticos;
        private Label lbTituloGeral;
        private Button btnAntTxt;
        private Button btnProxTxt;
        private ReaLTaiizor.Controls.HopeToggle btnListaOuFila;
    }
}
