namespace Estats
{
    partial class TelaEstatisticaParametrica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstatisticaParametrica));
            TituloEstatPar = new Label();
            label2 = new Label();
            BlocoEstatPar = new Panel();
            DescBlocoEstatPar = new Label();
            ImagemBlocoEstat = new PictureBox();
            panel5 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            LinhaXi = new Panel();
            LinhaFi = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            Fi = new Label();
            Xi = new Label();
            ResultadoXi = new Label();
            ResultadoFi = new Label();
            Fi2 = new Label();
            Xi2 = new Label();
            SubTextoEstatPar = new Label();
            LinhaHorizontEstatPar = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel22 = new Panel();
            BotaoMediaPosCentral = new Button();
            BotaoMediaDispersao = new Button();
            BlocoEstatPar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagemBlocoEstat).BeginInit();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel13.SuspendLayout();
            LinhaXi.SuspendLayout();
            LinhaFi.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
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
            TituloEstatPar.Size = new Size(412, 43);
            TituloEstatPar.TabIndex = 0;
            TituloEstatPar.Text = "Estatística Paramétrica";
            TituloEstatPar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(95, 130);
            label2.Name = "label2";
            label2.Size = new Size(592, 98);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BlocoEstatPar
            // 
            BlocoEstatPar.BackColor = Color.FromArgb(40, 0, 0, 0);
            BlocoEstatPar.Controls.Add(DescBlocoEstatPar);
            BlocoEstatPar.Controls.Add(ImagemBlocoEstat);
            BlocoEstatPar.Controls.Add(panel5);
            BlocoEstatPar.Controls.Add(LinhaXi);
            BlocoEstatPar.Controls.Add(Fi);
            BlocoEstatPar.Controls.Add(Xi);
            BlocoEstatPar.Controls.Add(ResultadoXi);
            BlocoEstatPar.Controls.Add(ResultadoFi);
            BlocoEstatPar.Controls.Add(Fi2);
            BlocoEstatPar.Controls.Add(Xi2);
            BlocoEstatPar.Location = new Point(97, 245);
            BlocoEstatPar.Margin = new Padding(3, 2, 3, 2);
            BlocoEstatPar.Name = "BlocoEstatPar";
            BlocoEstatPar.Size = new Size(573, 293);
            BlocoEstatPar.TabIndex = 2;
            BlocoEstatPar.Paint += BlocoEstatPar_Paint;
            // 
            // DescBlocoEstatPar
            // 
            DescBlocoEstatPar.BackColor = Color.FromArgb(0, 0, 0, 0);
            DescBlocoEstatPar.Font = new Font("Segoe UI", 13F);
            DescBlocoEstatPar.ForeColor = Color.White;
            DescBlocoEstatPar.Location = new Point(38, 184);
            DescBlocoEstatPar.Name = "DescBlocoEstatPar";
            DescBlocoEstatPar.Size = new Size(498, 94);
            DescBlocoEstatPar.TabIndex = 12;
            DescBlocoEstatPar.Text = "Agrupamento discreto é uma técnica de análise de dados que agrupa pontos de dados semelhantes em grupos distintos, facilitando a identificação de padrões e estruturas ocultas.";
            DescBlocoEstatPar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ImagemBlocoEstat
            // 
            ImagemBlocoEstat.Image = (Image)resources.GetObject("ImagemBlocoEstat.Image");
            ImagemBlocoEstat.Location = new Point(252, 32);
            ImagemBlocoEstat.Margin = new Padding(3, 2, 3, 2);
            ImagemBlocoEstat.Name = "ImagemBlocoEstat";
            ImagemBlocoEstat.Size = new Size(252, 135);
            ImagemBlocoEstat.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagemBlocoEstat.TabIndex = 11;
            ImagemBlocoEstat.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel13);
            panel5.Controls.Add(panel15);
            panel5.Location = new Point(164, 132);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(18, 1);
            panel5.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel12);
            panel9.Location = new Point(19, 2);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(18, 2);
            panel9.TabIndex = 9;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(24, 0);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(18, 2);
            panel10.TabIndex = 8;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Location = new Point(102, 0);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(18, 2);
            panel11.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Location = new Point(102, 0);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(18, 2);
            panel12.TabIndex = 7;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(24, 0);
            panel13.Margin = new Padding(3, 2, 3, 2);
            panel13.Name = "panel13";
            panel13.Size = new Size(18, 2);
            panel13.TabIndex = 8;
            // 
            // panel14
            // 
            panel14.BackColor = Color.White;
            panel14.Location = new Point(102, 0);
            panel14.Margin = new Padding(3, 2, 3, 2);
            panel14.Name = "panel14";
            panel14.Size = new Size(18, 2);
            panel14.TabIndex = 7;
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.Location = new Point(102, 0);
            panel15.Margin = new Padding(3, 2, 3, 2);
            panel15.Name = "panel15";
            panel15.Size = new Size(18, 2);
            panel15.TabIndex = 7;
            // 
            // LinhaXi
            // 
            LinhaXi.BackColor = Color.White;
            LinhaXi.Controls.Add(LinhaFi);
            LinhaXi.Controls.Add(panel3);
            LinhaXi.Controls.Add(panel2);
            LinhaXi.Location = new Point(62, 132);
            LinhaXi.Margin = new Padding(3, 2, 3, 2);
            LinhaXi.Name = "LinhaXi";
            LinhaXi.Size = new Size(18, 1);
            LinhaXi.TabIndex = 6;
            // 
            // LinhaFi
            // 
            LinhaFi.BackColor = Color.White;
            LinhaFi.Controls.Add(panel6);
            LinhaFi.Controls.Add(panel8);
            LinhaFi.Location = new Point(19, 2);
            LinhaFi.Margin = new Padding(3, 2, 3, 2);
            LinhaFi.Name = "LinhaFi";
            LinhaFi.Size = new Size(18, 2);
            LinhaFi.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(24, 0);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(18, 2);
            panel6.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(102, 0);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(18, 2);
            panel7.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(102, 0);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(18, 2);
            panel8.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(24, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(18, 2);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(102, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 2);
            panel4.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(102, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 2);
            panel2.TabIndex = 7;
            // 
            // Fi
            // 
            Fi.AutoSize = true;
            Fi.BackColor = Color.FromArgb(0, 0, 0, 0);
            Fi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Fi.ForeColor = Color.White;
            Fi.Location = new Point(164, 40);
            Fi.Name = "Fi";
            Fi.Size = new Size(16, 15);
            Fi.TabIndex = 5;
            Fi.Text = "Fi";
            // 
            // Xi
            // 
            Xi.AutoSize = true;
            Xi.BackColor = Color.FromArgb(0, 0, 0, 0);
            Xi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Xi.ForeColor = Color.White;
            Xi.Location = new Point(62, 40);
            Xi.Name = "Xi";
            Xi.Size = new Size(18, 15);
            Xi.TabIndex = 4;
            Xi.Text = "Xi";
            // 
            // ResultadoXi
            // 
            ResultadoXi.BackColor = Color.FromArgb(0, 0, 0, 0);
            ResultadoXi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ResultadoXi.ForeColor = Color.White;
            ResultadoXi.Location = new Point(63, 136);
            ResultadoXi.Name = "ResultadoXi";
            ResultadoXi.Size = new Size(22, 15);
            ResultadoXi.TabIndex = 3;
            ResultadoXi.Text = "Σ";
            // 
            // ResultadoFi
            // 
            ResultadoFi.BackColor = Color.FromArgb(0, 0, 0, 0);
            ResultadoFi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ResultadoFi.ForeColor = Color.White;
            ResultadoFi.Location = new Point(162, 136);
            ResultadoFi.Name = "ResultadoFi";
            ResultadoFi.Size = new Size(25, 15);
            ResultadoFi.TabIndex = 2;
            ResultadoFi.Text = "28";
            // 
            // Fi2
            // 
            Fi2.AutoSize = true;
            Fi2.BackColor = Color.FromArgb(0, 0, 0, 0);
            Fi2.ForeColor = Color.White;
            Fi2.Location = new Point(163, 55);
            Fi2.Name = "Fi2";
            Fi2.Size = new Size(19, 75);
            Fi2.TabIndex = 1;
            Fi2.Text = "4\n5\n11\n5\n3\n";
            Fi2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Xi2
            // 
            Xi2.AutoSize = true;
            Xi2.BackColor = Color.FromArgb(0, 0, 0, 0);
            Xi2.ForeColor = Color.White;
            Xi2.Location = new Point(60, 54);
            Xi2.Name = "Xi2";
            Xi2.Size = new Size(19, 75);
            Xi2.TabIndex = 0;
            Xi2.Text = "15\r\n17\r\n20\r\n22\r\n23\r";
            // 
            // SubTextoEstatPar
            // 
            SubTextoEstatPar.Font = new Font("Segoe UI Light", 9F);
            SubTextoEstatPar.ForeColor = Color.White;
            SubTextoEstatPar.Location = new Point(97, 560);
            SubTextoEstatPar.Name = "SubTextoEstatPar";
            SubTextoEstatPar.Size = new Size(350, 35);
            SubTextoEstatPar.TabIndex = 3;
            SubTextoEstatPar.Text = "OBS: Todos os cálculos são realizados em duas casas decimais, respeitando as técnicas de arredondamento.";
            // 
            // LinhaHorizontEstatPar
            // 
            LinhaHorizontEstatPar.BackColor = Color.White;
            LinhaHorizontEstatPar.Controls.Add(panel16);
            LinhaHorizontEstatPar.Controls.Add(panel20);
            LinhaHorizontEstatPar.Controls.Add(panel22);
            LinhaHorizontEstatPar.Location = new Point(738, 118);
            LinhaHorizontEstatPar.Margin = new Padding(3, 2, 3, 2);
            LinhaHorizontEstatPar.Name = "LinhaHorizontEstatPar";
            LinhaHorizontEstatPar.Size = new Size(1, 488);
            LinhaHorizontEstatPar.TabIndex = 10;
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
            // BotaoMediaPosCentral
            // 
            BotaoMediaPosCentral.BackColor = Color.FromArgb(79, 55, 139);
            BotaoMediaPosCentral.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            BotaoMediaPosCentral.FlatAppearance.BorderSize = 0;
            BotaoMediaPosCentral.FlatStyle = FlatStyle.Flat;
            BotaoMediaPosCentral.ForeColor = Color.White;
            BotaoMediaPosCentral.Location = new Point(816, 136);
            BotaoMediaPosCentral.Margin = new Padding(0);
            BotaoMediaPosCentral.Name = "BotaoMediaPosCentral";
            BotaoMediaPosCentral.Size = new Size(228, 55);
            BotaoMediaPosCentral.TabIndex = 11;
            BotaoMediaPosCentral.Text = "Calcule a Medida de Posição Central - [Média (X̄), Mediana (Md) e Moda (Mo)]";
            BotaoMediaPosCentral.UseVisualStyleBackColor = false;
            BotaoMediaPosCentral.Click += BotaoMediaPosCentral_Click;
            // 
            // BotaoMediaDispersao
            // 
            BotaoMediaDispersao.BackColor = Color.FromArgb(79, 55, 139);
            BotaoMediaDispersao.FlatAppearance.BorderColor = Color.FromArgb(79, 55, 139);
            BotaoMediaDispersao.FlatAppearance.BorderSize = 0;
            BotaoMediaDispersao.FlatStyle = FlatStyle.Flat;
            BotaoMediaDispersao.ForeColor = Color.White;
            BotaoMediaDispersao.Location = new Point(816, 429);
            BotaoMediaDispersao.Margin = new Padding(0);
            BotaoMediaDispersao.Name = "BotaoMediaDispersao";
            BotaoMediaDispersao.Size = new Size(228, 55);
            BotaoMediaDispersao.TabIndex = 12;
            BotaoMediaDispersao.Text = "Calcule a Medida de Dispersão - [Variância (S²), Desvio Padrão (S) e Coeficiente de Variação (CV)]";
            BotaoMediaDispersao.UseVisualStyleBackColor = false;
            BotaoMediaDispersao.Click += BotaoMediaDispersao_Click;
            // 
            // TelaEstatisticaParametrica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 33, 34);
            Controls.Add(BotaoMediaDispersao);
            Controls.Add(BotaoMediaPosCentral);
            Controls.Add(LinhaHorizontEstatPar);
            Controls.Add(SubTextoEstatPar);
            Controls.Add(BlocoEstatPar);
            Controls.Add(label2);
            Controls.Add(TituloEstatPar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaEstatisticaParametrica";
            Size = new Size(1120, 720);
            Load += TelaEstatisticaParametrica_Load;
            BlocoEstatPar.ResumeLayout(false);
            BlocoEstatPar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagemBlocoEstat).EndInit();
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel13.ResumeLayout(false);
            LinhaXi.ResumeLayout(false);
            LinhaFi.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            LinhaHorizontEstatPar.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel20.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label TituloEstatPar;
        private Label label2;
        private Panel BlocoEstatPar;
        private Label Xi2;
        private Label Fi2;
        private Label Fi;
        private Label Xi;
        private Label ResultadoXi;
        private Label ResultadoFi;
        private Panel LinhaXi;
        private Panel panel2;
        private Panel panel5;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel LinhaFi;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel3;
        private Panel panel4;
        private PictureBox ImagemBlocoEstat;
        private Label DescBlocoEstatPar;
        private Label SubTextoEstatPar;
        private Panel LinhaHorizontEstatPar;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Button BotaoMediaPosCentral;
        private Button BotaoMediaDispersao;
    }
}
