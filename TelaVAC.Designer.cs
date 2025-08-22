namespace Interface_e_sistema_em_C_
{
    partial class TelaVAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVAC));
            TituloVAC = new Label();
            SubTextoVAC = new Label();
            MediaVAC = new TextBox();
            DesvioVAC = new TextBox();
            ValorMediaVACText = new Label();
            DesvioPadraoVACText = new Label();
            BotaoVoltarMedia = new Button();
            AmostraVACText = new Label();
            BotaoDesvioVAC = new Panel();
            IconeImportarDesvio = new PictureBox();
            TamanhoDaAmostraVAC = new TextBox();
            Caso0 = new Button();
            Caso1 = new Button();
            Caso2 = new Button();
            Caso3 = new Button();
            Caso4 = new Button();
            Caso5 = new Button();
            Caso6 = new Button();
            Caso7 = new Button();
            LinhaHorizontEstatPar = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            SubTextoVAC2 = new Label();
            ResultadoVAC = new Label();
            MediaLabel = new Label();
            TituloVAC2 = new Label();
            BotaoAmostraVAC = new Panel();
            IconeImportarAmostra = new PictureBox();
            BotaoMediaVAC = new Panel();
            IconeImportarMedia = new PictureBox();
            ValorDeA = new TextBox();
            ValorDeAText = new Label();
            ValorDeBText = new Label();
            ValorDeB = new TextBox();
            CalculoVAC = new Button();
            BotaoDesvioVAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconeImportarDesvio).BeginInit();
            LinhaHorizontEstatPar.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel20.SuspendLayout();
            BotaoAmostraVAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconeImportarAmostra).BeginInit();
            BotaoMediaVAC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconeImportarMedia).BeginInit();
            SuspendLayout();
            // 
            // TituloVAC
            // 
            TituloVAC.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            TituloVAC.ForeColor = Color.White;
            TituloVAC.Location = new Point(60, 83);
            TituloVAC.Margin = new Padding(0);
            TituloVAC.Name = "TituloVAC";
            TituloVAC.Size = new Size(632, 43);
            TituloVAC.TabIndex = 7;
            TituloVAC.Text = "Cálculo da Variável Aleatória Contínua";
            TituloVAC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SubTextoVAC
            // 
            SubTextoVAC.Font = new Font("Segoe UI", 12F);
            SubTextoVAC.ForeColor = Color.White;
            SubTextoVAC.Location = new Point(68, 130);
            SubTextoVAC.Margin = new Padding(0);
            SubTextoVAC.Name = "SubTextoVAC";
            SubTextoVAC.Size = new Size(557, 28);
            SubTextoVAC.TabIndex = 8;
            SubTextoVAC.Text = "Insira os valores da Média (x̄), Desvio Padrão (S) e do Tamanho da Amostra (N):";
            SubTextoVAC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MediaVAC
            // 
            MediaVAC.Cursor = Cursors.IBeam;
            MediaVAC.Location = new Point(301, 177);
            MediaVAC.Margin = new Padding(3, 2, 3, 2);
            MediaVAC.Name = "MediaVAC";
            MediaVAC.Size = new Size(35, 23);
            MediaVAC.TabIndex = 12;
            MediaVAC.TextAlign = HorizontalAlignment.Center;
            MediaVAC.KeyPress += ValidacaoTexto_KeyPress;
            // 
            // DesvioVAC
            // 
            DesvioVAC.Cursor = Cursors.IBeam;
            DesvioVAC.Location = new Point(301, 208);
            DesvioVAC.Margin = new Padding(3, 2, 3, 2);
            DesvioVAC.Multiline = true;
            DesvioVAC.Name = "DesvioVAC";
            DesvioVAC.Size = new Size(35, 23);
            DesvioVAC.TabIndex = 13;
            DesvioVAC.TextAlign = HorizontalAlignment.Center;
            DesvioVAC.KeyPress += ValidacaoTexto_KeyPress;
            // 
            // ValorMediaVACText
            // 
            ValorMediaVACText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ValorMediaVACText.ForeColor = Color.White;
            ValorMediaVACText.Location = new Point(70, 178);
            ValorMediaVACText.Margin = new Padding(0);
            ValorMediaVACText.Name = "ValorMediaVACText";
            ValorMediaVACText.Size = new Size(154, 23);
            ValorMediaVACText.TabIndex = 20;
            ValorMediaVACText.Text = "Valor da Média (x̄):";
            ValorMediaVACText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DesvioPadraoVACText
            // 
            DesvioPadraoVACText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DesvioPadraoVACText.ForeColor = Color.White;
            DesvioPadraoVACText.Location = new Point(70, 207);
            DesvioPadraoVACText.Margin = new Padding(0);
            DesvioPadraoVACText.Name = "DesvioPadraoVACText";
            DesvioPadraoVACText.Size = new Size(228, 22);
            DesvioPadraoVACText.TabIndex = 21;
            DesvioPadraoVACText.Text = "Valor do Desvio Padrão (σ²):";
            DesvioPadraoVACText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BotaoVoltarMedia
            // 
            BotaoVoltarMedia.BackColor = Color.FromArgb(79, 55, 139);
            BotaoVoltarMedia.Cursor = Cursors.Hand;
            BotaoVoltarMedia.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            BotaoVoltarMedia.FlatAppearance.BorderSize = 0;
            BotaoVoltarMedia.FlatStyle = FlatStyle.Flat;
            BotaoVoltarMedia.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            BotaoVoltarMedia.ForeColor = Color.White;
            BotaoVoltarMedia.Location = new Point(68, 676);
            BotaoVoltarMedia.Margin = new Padding(0);
            BotaoVoltarMedia.Name = "BotaoVoltarMedia";
            BotaoVoltarMedia.Size = new Size(122, 47);
            BotaoVoltarMedia.TabIndex = 16;
            BotaoVoltarMedia.Text = "<";
            BotaoVoltarMedia.UseVisualStyleBackColor = false;
            // 
            // AmostraVACText
            // 
            AmostraVACText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AmostraVACText.ForeColor = Color.White;
            AmostraVACText.Location = new Point(70, 237);
            AmostraVACText.Margin = new Padding(0);
            AmostraVACText.Name = "AmostraVACText";
            AmostraVACText.Size = new Size(209, 24);
            AmostraVACText.TabIndex = 23;
            AmostraVACText.Text = "Tamanho da Amostra (N):";
            AmostraVACText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BotaoDesvioVAC
            // 
            BotaoDesvioVAC.BackColor = Color.FromArgb(79, 55, 139);
            BotaoDesvioVAC.Controls.Add(IconeImportarDesvio);
            BotaoDesvioVAC.Location = new Point(342, 208);
            BotaoDesvioVAC.Name = "BotaoDesvioVAC";
            BotaoDesvioVAC.Size = new Size(33, 23);
            BotaoDesvioVAC.TabIndex = 23;
            // 
            // IconeImportarDesvio
            // 
            IconeImportarDesvio.Cursor = Cursors.Hand;
            IconeImportarDesvio.Image = (Image)resources.GetObject("IconeImportarDesvio.Image");
            IconeImportarDesvio.Location = new Point(0, 0);
            IconeImportarDesvio.Name = "IconeImportarDesvio";
            IconeImportarDesvio.Size = new Size(33, 24);
            IconeImportarDesvio.SizeMode = PictureBoxSizeMode.CenterImage;
            IconeImportarDesvio.TabIndex = 39;
            IconeImportarDesvio.TabStop = false;
            IconeImportarDesvio.Click += IconeImportarDesvio_Click;
            // 
            // TamanhoDaAmostraVAC
            // 
            TamanhoDaAmostraVAC.Cursor = Cursors.IBeam;
            TamanhoDaAmostraVAC.Location = new Point(301, 239);
            TamanhoDaAmostraVAC.Margin = new Padding(3, 2, 3, 2);
            TamanhoDaAmostraVAC.Multiline = true;
            TamanhoDaAmostraVAC.Name = "TamanhoDaAmostraVAC";
            TamanhoDaAmostraVAC.Size = new Size(35, 23);
            TamanhoDaAmostraVAC.TabIndex = 24;
            TamanhoDaAmostraVAC.TextAlign = HorizontalAlignment.Center;
            TamanhoDaAmostraVAC.KeyPress += ValidacaoTexto_KeyPress;
            // 
            // Caso0
            // 
            Caso0.BackColor = Color.FromArgb(79, 55, 139);
            Caso0.Cursor = Cursors.Hand;
            Caso0.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            Caso0.FlatAppearance.BorderSize = 0;
            Caso0.FlatStyle = FlatStyle.Flat;
            Caso0.ForeColor = Color.White;
            Caso0.Location = new Point(68, 345);
            Caso0.Margin = new Padding(0);
            Caso0.Name = "Caso0";
            Caso0.Size = new Size(177, 48);
            Caso0.TabIndex = 25;
            Caso0.Text = "Caso [0]: P(x=a)\n";
            Caso0.UseVisualStyleBackColor = false;
            Caso0.Click += Caso0_Click;
            // 
            // Caso1
            // 
            Caso1.BackColor = Color.FromArgb(79, 55, 139);
            Caso1.Cursor = Cursors.Hand;
            Caso1.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            Caso1.FlatAppearance.BorderSize = 0;
            Caso1.FlatStyle = FlatStyle.Flat;
            Caso1.ForeColor = Color.White;
            Caso1.Location = new Point(68, 410);
            Caso1.Margin = new Padding(0);
            Caso1.Name = "Caso1";
            Caso1.Size = new Size(177, 48);
            Caso1.TabIndex = 26;
            Caso1.Text = " Caso [1]:\r\nP(x ≥ +a)=P(x > +a)\r\n";
            Caso1.UseVisualStyleBackColor = false;
            Caso1.Click += Caso1_Click;
            // 
            // Caso2
            // 
            Caso2.BackColor = Color.FromArgb(79, 55, 139);
            Caso2.Cursor = Cursors.Hand;
            Caso2.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            Caso2.FlatAppearance.BorderSize = 0;
            Caso2.FlatStyle = FlatStyle.Flat;
            Caso2.ForeColor = Color.White;
            Caso2.Location = new Point(68, 475);
            Caso2.Margin = new Padding(0);
            Caso2.Name = "Caso2";
            Caso2.Size = new Size(177, 48);
            Caso2.TabIndex = 27;
            Caso2.Text = "  Caso [2]:\r\nP(x ≤ +a)=P(x < +a)\r\n";
            Caso2.UseVisualStyleBackColor = false;
            Caso2.Click += Caso2_Click;
            // 
            // Caso3
            // 
            Caso3.BackColor = Color.FromArgb(79, 55, 139);
            Caso3.Cursor = Cursors.Hand;
            Caso3.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            Caso3.FlatAppearance.BorderSize = 0;
            Caso3.FlatStyle = FlatStyle.Flat;
            Caso3.ForeColor = Color.White;
            Caso3.Location = new Point(68, 540);
            Caso3.Margin = new Padding(0);
            Caso3.Name = "Caso3";
            Caso3.Size = new Size(177, 48);
            Caso3.TabIndex = 28;
            Caso3.Text = " Caso [3]:\r\nP(+a ≤ x ≤ +b)=P(+a <x < +b)";
            Caso3.UseVisualStyleBackColor = false;
            Caso3.Click += Caso3_Click;
            // 
            // Caso4
            // 
            Caso4.BackColor = Color.FromArgb(79, 55, 139);
            Caso4.Cursor = Cursors.Hand;
            Caso4.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            Caso4.FlatAppearance.BorderSize = 0;
            Caso4.FlatStyle = FlatStyle.Flat;
            Caso4.ForeColor = Color.White;
            Caso4.Location = new Point(280, 345);
            Caso4.Margin = new Padding(0);
            Caso4.Name = "Caso4";
            Caso4.Size = new Size(172, 48);
            Caso4.TabIndex = 29;
            Caso4.Text = " Caso [4]:\r\nP(x ≤ -a) = P(x < -a)\r\n";
            Caso4.UseVisualStyleBackColor = false;
            Caso4.Click += Caso4_Click;
            // 
            // Caso5
            // 
            Caso5.BackColor = Color.FromArgb(79, 55, 139);
            Caso5.Cursor = Cursors.Hand;
            Caso5.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            Caso5.FlatAppearance.BorderSize = 0;
            Caso5.FlatStyle = FlatStyle.Flat;
            Caso5.ForeColor = Color.White;
            Caso5.Location = new Point(280, 410);
            Caso5.Margin = new Padding(0);
            Caso5.Name = "Caso5";
            Caso5.Size = new Size(172, 48);
            Caso5.TabIndex = 30;
            Caso5.Text = " Caso [5]:\r\nP(x ≥ -a) = P(x > -a)\r\n";
            Caso5.UseVisualStyleBackColor = false;
            Caso5.Click += Caso5_Click;
            // 
            // Caso6
            // 
            Caso6.BackColor = Color.FromArgb(79, 55, 139);
            Caso6.Cursor = Cursors.Hand;
            Caso6.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            Caso6.FlatAppearance.BorderSize = 0;
            Caso6.FlatStyle = FlatStyle.Flat;
            Caso6.ForeColor = Color.White;
            Caso6.Location = new Point(280, 475);
            Caso6.Margin = new Padding(0);
            Caso6.Name = "Caso6";
            Caso6.Size = new Size(172, 48);
            Caso6.TabIndex = 31;
            Caso6.Text = " Caso [6]:\r\nP(-a ≤ x ≤ -b)=P(-a < x < -b)\r\n";
            Caso6.UseVisualStyleBackColor = false;
            Caso6.Click += Caso6_Click;
            // 
            // Caso7
            // 
            Caso7.BackColor = Color.FromArgb(79, 55, 139);
            Caso7.Cursor = Cursors.Hand;
            Caso7.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            Caso7.FlatAppearance.BorderSize = 0;
            Caso7.FlatStyle = FlatStyle.Flat;
            Caso7.ForeColor = Color.White;
            Caso7.Location = new Point(280, 540);
            Caso7.Margin = new Padding(0);
            Caso7.Name = "Caso7";
            Caso7.Size = new Size(172, 48);
            Caso7.TabIndex = 32;
            Caso7.Text = " Caso [7]:\r\nP(-a ≤ x ≤ +b)=P(-a < x < +b)\r\n\r\n";
            Caso7.UseVisualStyleBackColor = false;
            Caso7.Click += Caso7_Click;
            // 
            // LinhaHorizontEstatPar
            // 
            LinhaHorizontEstatPar.BackColor = Color.White;
            LinhaHorizontEstatPar.Controls.Add(panel16);
            LinhaHorizontEstatPar.Controls.Add(panel20);
            LinhaHorizontEstatPar.Controls.Add(panel22);
            LinhaHorizontEstatPar.Location = new Point(725, 138);
            LinhaHorizontEstatPar.Margin = new Padding(3, 2, 3, 2);
            LinhaHorizontEstatPar.Name = "LinhaHorizontEstatPar";
            LinhaHorizontEstatPar.Size = new Size(1, 488);
            LinhaHorizontEstatPar.TabIndex = 33;
            // 
            // panel16
            // 
            panel16.BackColor = Color.White;
            panel16.Controls.Add(panel17);
            panel16.Controls.Add(panel19);
            panel16.Location = new Point(19, 2);
            panel16.Margin = new Padding(3, 2, 3, 2);
            panel16.Name = "panel16";
            panel16.Size = new Size(18, 2);
            panel16.TabIndex = 9;
            // 
            // panel17
            // 
            panel17.BackColor = Color.White;
            panel17.Controls.Add(panel18);
            panel17.Location = new Point(24, 0);
            panel17.Margin = new Padding(3, 2, 3, 2);
            panel17.Name = "panel17";
            panel17.Size = new Size(18, 2);
            panel17.TabIndex = 8;
            // 
            // panel18
            // 
            panel18.BackColor = Color.White;
            panel18.Location = new Point(102, 0);
            panel18.Margin = new Padding(3, 2, 3, 2);
            panel18.Name = "panel18";
            panel18.Size = new Size(18, 2);
            panel18.TabIndex = 7;
            // 
            // panel19
            // 
            panel19.BackColor = Color.White;
            panel19.Location = new Point(102, 0);
            panel19.Margin = new Padding(3, 2, 3, 2);
            panel19.Name = "panel19";
            panel19.Size = new Size(18, 2);
            panel19.TabIndex = 7;
            // 
            // panel20
            // 
            panel20.BackColor = Color.White;
            panel20.Controls.Add(panel21);
            panel20.Location = new Point(24, 0);
            panel20.Margin = new Padding(3, 2, 3, 2);
            panel20.Name = "panel20";
            panel20.Size = new Size(18, 2);
            panel20.TabIndex = 8;
            // 
            // panel21
            // 
            panel21.BackColor = Color.White;
            panel21.Location = new Point(102, 0);
            panel21.Margin = new Padding(3, 2, 3, 2);
            panel21.Name = "panel21";
            panel21.Size = new Size(18, 2);
            panel21.TabIndex = 7;
            // 
            // panel22
            // 
            panel22.BackColor = Color.White;
            panel22.Location = new Point(102, 0);
            panel22.Margin = new Padding(3, 2, 3, 2);
            panel22.Name = "panel22";
            panel22.Size = new Size(18, 2);
            panel22.TabIndex = 7;
            // 
            // SubTextoVAC2
            // 
            SubTextoVAC2.Font = new Font("Segoe UI", 12F);
            SubTextoVAC2.ForeColor = Color.White;
            SubTextoVAC2.Location = new Point(65, 300);
            SubTextoVAC2.Margin = new Padding(0);
            SubTextoVAC2.Name = "SubTextoVAC2";
            SubTextoVAC2.Size = new Size(180, 28);
            SubTextoVAC2.TabIndex = 34;
            SubTextoVAC2.Text = "Selecione o tipo de caso:";
            SubTextoVAC2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ResultadoVAC
            // 
            ResultadoVAC.BackColor = Color.FromArgb(0, 0, 0, 0);
            ResultadoVAC.Font = new Font("Segoe UI", 10F);
            ResultadoVAC.ForeColor = Color.White;
            ResultadoVAC.Location = new Point(758, 175);
            ResultadoVAC.Name = "ResultadoVAC";
            ResultadoVAC.Size = new Size(422, 348);
            ResultadoVAC.TabIndex = 37;
            ResultadoVAC.Text = "ResultadoVAC";
            // 
            // MediaLabel
            // 
            MediaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MediaLabel.ForeColor = Color.White;
            MediaLabel.Location = new Point(758, 130);
            MediaLabel.Margin = new Padding(0);
            MediaLabel.Name = "MediaLabel";
            MediaLabel.Size = new Size(199, 32);
            MediaLabel.TabIndex = 36;
            MediaLabel.Text = "Média:  μ = (ΣXi·Fi) / ΣFi";
            MediaLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TituloVAC2
            // 
            TituloVAC2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            TituloVAC2.ForeColor = Color.White;
            TituloVAC2.Location = new Point(752, 83);
            TituloVAC2.Margin = new Padding(0);
            TituloVAC2.Name = "TituloVAC2";
            TituloVAC2.Size = new Size(382, 43);
            TituloVAC2.TabIndex = 35;
            TituloVAC2.Text = "Resultados Estatísticos";
            TituloVAC2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BotaoAmostraVAC
            // 
            BotaoAmostraVAC.BackColor = Color.FromArgb(79, 55, 139);
            BotaoAmostraVAC.Controls.Add(IconeImportarAmostra);
            BotaoAmostraVAC.Location = new Point(342, 239);
            BotaoAmostraVAC.Name = "BotaoAmostraVAC";
            BotaoAmostraVAC.Size = new Size(33, 23);
            BotaoAmostraVAC.TabIndex = 24;
            // 
            // IconeImportarAmostra
            // 
            IconeImportarAmostra.Cursor = Cursors.Hand;
            IconeImportarAmostra.Image = (Image)resources.GetObject("IconeImportarAmostra.Image");
            IconeImportarAmostra.Location = new Point(0, 0);
            IconeImportarAmostra.Name = "IconeImportarAmostra";
            IconeImportarAmostra.Size = new Size(33, 24);
            IconeImportarAmostra.SizeMode = PictureBoxSizeMode.CenterImage;
            IconeImportarAmostra.TabIndex = 40;
            IconeImportarAmostra.TabStop = false;
            IconeImportarAmostra.Click += IconeImportarAmostra_Click;
            // 
            // BotaoMediaVAC
            // 
            BotaoMediaVAC.BackColor = Color.FromArgb(79, 55, 139);
            BotaoMediaVAC.Controls.Add(IconeImportarMedia);
            BotaoMediaVAC.Location = new Point(342, 177);
            BotaoMediaVAC.Name = "BotaoMediaVAC";
            BotaoMediaVAC.Size = new Size(33, 23);
            BotaoMediaVAC.TabIndex = 24;
            // 
            // IconeImportarMedia
            // 
            IconeImportarMedia.Cursor = Cursors.Hand;
            IconeImportarMedia.Image = (Image)resources.GetObject("IconeImportarMedia.Image");
            IconeImportarMedia.Location = new Point(0, 0);
            IconeImportarMedia.Name = "IconeImportarMedia";
            IconeImportarMedia.Size = new Size(33, 24);
            IconeImportarMedia.SizeMode = PictureBoxSizeMode.CenterImage;
            IconeImportarMedia.TabIndex = 38;
            IconeImportarMedia.TabStop = false;
            IconeImportarMedia.Click += IconeImportarMedia_Click;
            // 
            // ValorDeA
            // 
            ValorDeA.Cursor = Cursors.IBeam;
            ValorDeA.Location = new Point(559, 177);
            ValorDeA.Margin = new Padding(3, 2, 3, 2);
            ValorDeA.Name = "ValorDeA";
            ValorDeA.Size = new Size(35, 23);
            ValorDeA.TabIndex = 39;
            ValorDeA.TextAlign = HorizontalAlignment.Center;
            ValorDeA.Visible = false;
            ValorDeA.KeyPress += ValidacaoTexto_KeyPress;
            // 
            // ValorDeAText
            // 
            ValorDeAText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ValorDeAText.ForeColor = Color.White;
            ValorDeAText.Location = new Point(458, 175);
            ValorDeAText.Margin = new Padding(0);
            ValorDeAText.Name = "ValorDeAText";
            ValorDeAText.Size = new Size(95, 23);
            ValorDeAText.TabIndex = 40;
            ValorDeAText.Text = "Valor de a:";
            ValorDeAText.TextAlign = ContentAlignment.MiddleLeft;
            ValorDeAText.Visible = false;
            // 
            // ValorDeBText
            // 
            ValorDeBText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ValorDeBText.ForeColor = Color.White;
            ValorDeBText.Location = new Point(458, 208);
            ValorDeBText.Margin = new Padding(0);
            ValorDeBText.Name = "ValorDeBText";
            ValorDeBText.Size = new Size(95, 23);
            ValorDeBText.TabIndex = 42;
            ValorDeBText.Text = "Valor de b:";
            ValorDeBText.TextAlign = ContentAlignment.MiddleLeft;
            ValorDeBText.Visible = false;
            // 
            // ValorDeB
            // 
            ValorDeB.Cursor = Cursors.IBeam;
            ValorDeB.Location = new Point(559, 209);
            ValorDeB.Margin = new Padding(3, 2, 3, 2);
            ValorDeB.Name = "ValorDeB";
            ValorDeB.Size = new Size(35, 23);
            ValorDeB.TabIndex = 41;
            ValorDeB.TextAlign = HorizontalAlignment.Center;
            ValorDeB.Visible = false;
            ValorDeB.KeyPress += ValidacaoTexto_KeyPress;
            // 
            // CalculoVAC
            // 
            CalculoVAC.BackColor = Color.FromArgb(79, 55, 139);
            CalculoVAC.Cursor = Cursors.Hand;
            CalculoVAC.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            CalculoVAC.FlatAppearance.BorderSize = 0;
            CalculoVAC.FlatStyle = FlatStyle.Flat;
            CalculoVAC.ForeColor = Color.White;
            CalculoVAC.Location = new Point(475, 253);
            CalculoVAC.Margin = new Padding(0);
            CalculoVAC.Name = "CalculoVAC";
            CalculoVAC.Size = new Size(105, 48);
            CalculoVAC.TabIndex = 43;
            CalculoVAC.Text = "Realizar cálculo da distribuição:";
            CalculoVAC.UseVisualStyleBackColor = false;
            CalculoVAC.Click += CalculoVAC_Click;
            // 
            // TelaVAC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 33, 34);
            Controls.Add(CalculoVAC);
            Controls.Add(ValorDeBText);
            Controls.Add(ValorDeB);
            Controls.Add(ValorDeAText);
            Controls.Add(ValorDeA);
            Controls.Add(BotaoMediaVAC);
            Controls.Add(BotaoAmostraVAC);
            Controls.Add(ResultadoVAC);
            Controls.Add(MediaLabel);
            Controls.Add(TituloVAC2);
            Controls.Add(SubTextoVAC2);
            Controls.Add(LinhaHorizontEstatPar);
            Controls.Add(Caso7);
            Controls.Add(Caso6);
            Controls.Add(Caso5);
            Controls.Add(Caso4);
            Controls.Add(Caso3);
            Controls.Add(Caso2);
            Controls.Add(Caso1);
            Controls.Add(Caso0);
            Controls.Add(TamanhoDaAmostraVAC);
            Controls.Add(BotaoDesvioVAC);
            Controls.Add(AmostraVACText);
            Controls.Add(BotaoVoltarMedia);
            Controls.Add(DesvioPadraoVACText);
            Controls.Add(ValorMediaVACText);
            Controls.Add(DesvioVAC);
            Controls.Add(MediaVAC);
            Controls.Add(SubTextoVAC);
            Controls.Add(TituloVAC);
            Name = "TelaVAC";
            Size = new Size(1280, 800);
            Load += TelaVAC_Load;
            BotaoDesvioVAC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconeImportarDesvio).EndInit();
            LinhaHorizontEstatPar.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel20.ResumeLayout(false);
            BotaoAmostraVAC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconeImportarAmostra).EndInit();
            BotaoMediaVAC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconeImportarMedia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloVAC;
        private Label SubTextoVAC;
        private TextBox MediaVAC;
        private TextBox DesvioVAC;
        private Label ValorMediaVACText;
        private Label DesvioPadraoVACText;
        private Button BotaoVoltarMedia;
        private Label AmostraVACText;
        private Panel BotaoDesvioVAC;
        private TextBox TamanhoDaAmostraVAC;
        private Button Caso0;
        private Button Caso1;
        private Button Caso2;
        private Button Caso3;
        private Button Caso4;
        private Button Caso5;
        private Button Caso6;
        private Button Caso7;
        private Panel LinhaHorizontEstatPar;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Label SubTextoVAC2;
        private Label ResultadoVAC;
        private Label MediaLabel;
        private Label TituloVAC2;
        private Panel BotaoAmostraVAC;
        private Panel BotaoMediaVAC;
        private PictureBox IconeImportarMedia;
        private PictureBox IconeImportarDesvio;
        private PictureBox IconeImportarAmostra;
        private TextBox ValorDeA;
        private Label ValorDeAText;
        private Label ValorDeBText;
        private TextBox ValorDeB;
        private Button CalculoVAC;
    }
}
