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
            LinhaHorizontEstatPar = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            ResultadosEstatisticos = new Label();
            MediaLabel = new Label();
            VarianciaLabel = new Label();
            DesvioPadraoLabel = new Label();
            PassosMedia = new Label();
            PassosVariancia = new Label();
            PassosDesvioPadrao = new Label();
            ResultadoMedia = new Label();
            ResultadoVariancia = new Label();
            ResultadoDesvio = new Label();
            BotaoProximoPassoVAC = new Button();
            PanelFilaExpandida.SuspendLayout();
            PanelListaXiFi.SuspendLayout();
            LinhaHorizontEstatPar.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel20.SuspendLayout();
            SuspendLayout();
            // 
            // TituloEstatPar
            // 
            TituloEstatPar.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            TituloEstatPar.ForeColor = Color.White;
            TituloEstatPar.Location = new Point(88, 83);
            TituloEstatPar.Margin = new Padding(0);
            TituloEstatPar.Name = "TituloEstatPar";
            TituloEstatPar.Size = new Size(608, 43);
            TituloEstatPar.TabIndex = 6;
            TituloEstatPar.Text = "Cálculo da Estatística Paramétrica";
            TituloEstatPar.TextAlign = ContentAlignment.MiddleLeft;
            TituloEstatPar.Click += TituloEstatPar_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 126);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(541, 28);
            label1.TabIndex = 7;
            label1.Text = "Insira os valores da Frequência Acumulada (Xi) e Frequência Absoluta (Fi):";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(116, 164);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(37, 28);
            label2.TabIndex = 8;
            label2.Text = "Xi";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(216, 164);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(29, 28);
            label3.TabIndex = 9;
            label3.Text = "Fi";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(322, 164);
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
            PanelFilaExpandida.Location = new Point(327, 194);
            PanelFilaExpandida.Margin = new Padding(3, 2, 3, 2);
            PanelFilaExpandida.Name = "PanelFilaExpandida";
            PanelFilaExpandida.Size = new Size(308, 172);
            PanelFilaExpandida.TabIndex = 13;
            PanelFilaExpandida.Paint += BlocoEstatPar_Paint;
            // 
            // FilaExpandidaLabel
            // 
            FilaExpandidaLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FilaExpandidaLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            FilaExpandidaLabel.Font = new Font("Segoe UI", 10F);
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
            PanelListaXiFi.Location = new Point(98, 194);
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
            AdicionarFila.Location = new Point(285, 253);
            AdicionarFila.Margin = new Padding(0);
            AdicionarFila.Name = "AdicionarFila";
            AdicionarFila.Size = new Size(26, 52);
            AdicionarFila.TabIndex = 15;
            AdicionarFila.Text = ">";
            AdicionarFila.UseVisualStyleBackColor = false;
            AdicionarFila.Click += AdicionarFila_Click;
            // 
            // LinhaHorizontEstatPar
            // 
            LinhaHorizontEstatPar.BackColor = Color.White;
            LinhaHorizontEstatPar.Controls.Add(panel16);
            LinhaHorizontEstatPar.Controls.Add(panel20);
            LinhaHorizontEstatPar.Controls.Add(panel22);
            LinhaHorizontEstatPar.Location = new Point(676, 107);
            LinhaHorizontEstatPar.Margin = new Padding(3, 2, 3, 2);
            LinhaHorizontEstatPar.Name = "LinhaHorizontEstatPar";
            LinhaHorizontEstatPar.Size = new Size(1, 488);
            LinhaHorizontEstatPar.TabIndex = 16;
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
            // ResultadosEstatisticos
            // 
            ResultadosEstatisticos.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            ResultadosEstatisticos.ForeColor = Color.White;
            ResultadosEstatisticos.Location = new Point(714, 67);
            ResultadosEstatisticos.Margin = new Padding(0);
            ResultadosEstatisticos.Name = "ResultadosEstatisticos";
            ResultadosEstatisticos.Size = new Size(382, 40);
            ResultadosEstatisticos.TabIndex = 17;
            ResultadosEstatisticos.Text = "Resultados Estatísticos";
            ResultadosEstatisticos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MediaLabel
            // 
            MediaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MediaLabel.ForeColor = Color.White;
            MediaLabel.Location = new Point(719, 107);
            MediaLabel.Margin = new Padding(0);
            MediaLabel.Name = "MediaLabel";
            MediaLabel.Size = new Size(199, 22);
            MediaLabel.TabIndex = 18;
            MediaLabel.Text = "Média:  x̄ = (ΣXi·Fi) / ΣFi";
            MediaLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // VarianciaLabel
            // 
            VarianciaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            VarianciaLabel.ForeColor = Color.White;
            VarianciaLabel.Location = new Point(719, 337);
            VarianciaLabel.Margin = new Padding(0);
            VarianciaLabel.Name = "VarianciaLabel";
            VarianciaLabel.Size = new Size(245, 21);
            VarianciaLabel.TabIndex = 19;
            VarianciaLabel.Text = "Variância: σ² = ΣFi·(Xi - x̄)² / ΣFi";
            VarianciaLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DesvioPadraoLabel
            // 
            DesvioPadraoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DesvioPadraoLabel.ForeColor = Color.White;
            DesvioPadraoLabel.Location = new Point(719, 552);
            DesvioPadraoLabel.Margin = new Padding(0);
            DesvioPadraoLabel.Name = "DesvioPadraoLabel";
            DesvioPadraoLabel.Size = new Size(187, 23);
            DesvioPadraoLabel.TabIndex = 20;
            DesvioPadraoLabel.Text = "Desvio Padrão: σ = √σ²";
            DesvioPadraoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PassosMedia
            // 
            PassosMedia.BackColor = Color.FromArgb(0, 0, 0, 0);
            PassosMedia.Font = new Font("Segoe UI", 9F);
            PassosMedia.ForeColor = Color.White;
            PassosMedia.Location = new Point(719, 130);
            PassosMedia.Name = "PassosMedia";
            PassosMedia.Size = new Size(484, 202);
            PassosMedia.TabIndex = 1;
            PassosMedia.Text = "Média";
            // 
            // PassosVariancia
            // 
            PassosVariancia.BackColor = Color.FromArgb(0, 0, 0, 0);
            PassosVariancia.Font = new Font("Segoe UI", 9F);
            PassosVariancia.ForeColor = Color.White;
            PassosVariancia.Location = new Point(719, 359);
            PassosVariancia.Name = "PassosVariancia";
            PassosVariancia.Size = new Size(484, 188);
            PassosVariancia.TabIndex = 21;
            PassosVariancia.Text = "Variância";
            // 
            // PassosDesvioPadrao
            // 
            PassosDesvioPadrao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PassosDesvioPadrao.BackColor = Color.FromArgb(0, 0, 0, 0);
            PassosDesvioPadrao.Font = new Font("Segoe UI", 9F);
            PassosDesvioPadrao.ForeColor = Color.White;
            PassosDesvioPadrao.Location = new Point(719, 575);
            PassosDesvioPadrao.Name = "PassosDesvioPadrao";
            PassosDesvioPadrao.Size = new Size(484, 162);
            PassosDesvioPadrao.TabIndex = 22;
            PassosDesvioPadrao.Text = "Desvio Padrão";
            // 
            // ResultadoMedia
            // 
            ResultadoMedia.BackColor = Color.FromArgb(0, 0, 0, 0);
            ResultadoMedia.Font = new Font("Segoe UI", 10F);
            ResultadoMedia.ForeColor = Color.White;
            ResultadoMedia.Location = new Point(913, 109);
            ResultadoMedia.Name = "ResultadoMedia";
            ResultadoMedia.Size = new Size(183, 21);
            ResultadoMedia.TabIndex = 23;
            ResultadoMedia.Text = "ResultadoMédia";
            ResultadoMedia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ResultadoVariancia
            // 
            ResultadoVariancia.BackColor = Color.FromArgb(0, 0, 0, 0);
            ResultadoVariancia.Font = new Font("Segoe UI", 10F);
            ResultadoVariancia.ForeColor = Color.White;
            ResultadoVariancia.Location = new Point(967, 337);
            ResultadoVariancia.Name = "ResultadoVariancia";
            ResultadoVariancia.Size = new Size(126, 21);
            ResultadoVariancia.TabIndex = 24;
            ResultadoVariancia.Text = "ResultadoVariancia";
            ResultadoVariancia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ResultadoDesvio
            // 
            ResultadoDesvio.BackColor = Color.FromArgb(0, 0, 0, 0);
            ResultadoDesvio.Font = new Font("Segoe UI", 10F);
            ResultadoDesvio.ForeColor = Color.White;
            ResultadoDesvio.Location = new Point(907, 554);
            ResultadoDesvio.Name = "ResultadoDesvio";
            ResultadoDesvio.Size = new Size(183, 21);
            ResultadoDesvio.TabIndex = 25;
            ResultadoDesvio.Text = "ResultadoDesvio";
            ResultadoDesvio.TextAlign = ContentAlignment.MiddleLeft;
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
            BotaoProximoPassoVAC.Location = new Point(1099, 715);
            BotaoProximoPassoVAC.Margin = new Padding(0);
            BotaoProximoPassoVAC.Name = "BotaoProximoPassoVAC";
            BotaoProximoPassoVAC.Size = new Size(104, 36);
            BotaoProximoPassoVAC.TabIndex = 26;
            BotaoProximoPassoVAC.UseVisualStyleBackColor = false;
            BotaoProximoPassoVAC.Visible = false;
            BotaoProximoPassoVAC.Click += BotaoProximoPassoVAC_Click;
            // 
            // TelaMediaPosicaoCentral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 33, 34);
            Controls.Add(BotaoProximoPassoVAC);
            Controls.Add(ResultadoDesvio);
            Controls.Add(ResultadoVariancia);
            Controls.Add(ResultadoMedia);
            Controls.Add(PassosDesvioPadrao);
            Controls.Add(PassosVariancia);
            Controls.Add(PassosMedia);
            Controls.Add(DesvioPadraoLabel);
            Controls.Add(VarianciaLabel);
            Controls.Add(MediaLabel);
            Controls.Add(ResultadosEstatisticos);
            Controls.Add(LinhaHorizontEstatPar);
            Controls.Add(AdicionarFila);
            Controls.Add(PanelFilaExpandida);
            Controls.Add(label4);
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
            LinhaHorizontEstatPar.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel20.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel LinhaHorizontEstatPar;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Label ResultadosEstatisticos;
        private Label MediaLabel;
        private Label VarianciaLabel;
        private Label DesvioPadraoLabel;
        private Label PassosMedia;
        private Label PassosVariancia;
        private Label PassosDesvioPadrao;
        private Label ResultadoMedia;
        private Label ResultadoVariancia;
        private Label ResultadoDesvio;
        private Button BotaoProximoPassoVAC;
    }
}
