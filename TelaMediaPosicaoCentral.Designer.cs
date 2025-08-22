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
            pnResultadosEstatisticos.BackColor = Color.FromArgb(39, 51, 63);
            pnResultadosEstatisticos.Controls.Add(btnAntTxt);
            pnResultadosEstatisticos.Controls.Add(btnProxTxt);
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
            btnProxTxt.Location = new Point(505, 259);
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
            // TelaMediaPosicaoCentral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 31, 52);
            Controls.Add(btnListaOuFila);
            Controls.Add(pnResultadosEstatisticos);
            Controls.Add(BotaoProximoPassoVAC);
            Controls.Add(ResultadosEstatisticos);
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
