namespace Interface_e_sistema_em_C_
{
    partial class TelaConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConfig));
            lblTituloConfig = new Label();
            lblTituloAPI = new Label();
            lblChaveAPI = new Label();
            txtChaveAPI = new TextBox();
            btnSalvarAPI = new ReaLTaiizor.Controls.HopeRoundButton();
            chkMostrarAPI = new CheckBox();
            lblStatusChaveAPI = new Label();
            lblAjudaAPIKey = new Label();
            lblAjudaAPIKey2 = new Label();
            lblStatusChaveAPI2 = new Label();
            btnObterChaveAPI = new ReaLTaiizor.Controls.HopeRoundButton();
            pictureBox1 = new PictureBox();
            pnLinha1 = new Panel();
            pnLinha2 = new Panel();
            btnTesteConexao = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTituloConfig
            // 
            lblTituloConfig.Font = new Font("Berlin Sans FB Demi", 25F, FontStyle.Bold);
            lblTituloConfig.ForeColor = Color.White;
            lblTituloConfig.Location = new Point(436, 59);
            lblTituloConfig.Margin = new Padding(0);
            lblTituloConfig.Name = "lblTituloConfig";
            lblTituloConfig.Size = new Size(232, 45);
            lblTituloConfig.TabIndex = 7;
            lblTituloConfig.Text = "Configurações";
            lblTituloConfig.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloAPI
            // 
            lblTituloAPI.Font = new Font("Berlin Sans FB Demi", 17F, FontStyle.Bold);
            lblTituloAPI.ForeColor = Color.White;
            lblTituloAPI.Location = new Point(80, 116);
            lblTituloAPI.Margin = new Padding(0);
            lblTituloAPI.Name = "lblTituloAPI";
            lblTituloAPI.Size = new Size(55, 43);
            lblTituloAPI.TabIndex = 8;
            lblTituloAPI.Text = "IA";
            lblTituloAPI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChaveAPI
            // 
            lblChaveAPI.Font = new Font("Berlin Sans FB", 15F);
            lblChaveAPI.ForeColor = Color.White;
            lblChaveAPI.Location = new Point(80, 172);
            lblChaveAPI.Margin = new Padding(0);
            lblChaveAPI.Name = "lblChaveAPI";
            lblChaveAPI.Size = new Size(82, 25);
            lblChaveAPI.TabIndex = 9;
            lblChaveAPI.Text = "API Key:";
            lblChaveAPI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtChaveAPI
            // 
            txtChaveAPI.Location = new Point(167, 175);
            txtChaveAPI.Name = "txtChaveAPI";
            txtChaveAPI.PasswordChar = '*';
            txtChaveAPI.PlaceholderText = " Insira a chave da API aqui.";
            txtChaveAPI.Size = new Size(153, 23);
            txtChaveAPI.TabIndex = 10;
            // 
            // btnSalvarAPI
            // 
            btnSalvarAPI.BorderColor = Color.FromArgb(220, 223, 230);
            btnSalvarAPI.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnSalvarAPI.DangerColor = Color.FromArgb(245, 108, 108);
            btnSalvarAPI.DefaultColor = Color.FromArgb(255, 255, 255);
            btnSalvarAPI.Font = new Font("Berlin Sans FB", 12F);
            btnSalvarAPI.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnSalvarAPI.InfoColor = Color.FromArgb(144, 147, 153);
            btnSalvarAPI.Location = new Point(104, 382);
            btnSalvarAPI.Margin = new Padding(0);
            btnSalvarAPI.Name = "btnSalvarAPI";
            btnSalvarAPI.PrimaryColor = Color.FromArgb(79, 55, 139);
            btnSalvarAPI.Size = new Size(93, 38);
            btnSalvarAPI.SuccessColor = Color.FromArgb(103, 194, 58);
            btnSalvarAPI.TabIndex = 16;
            btnSalvarAPI.Text = "Salvar";
            btnSalvarAPI.TextColor = Color.White;
            btnSalvarAPI.WarningColor = Color.FromArgb(230, 162, 60);
            btnSalvarAPI.Click += btnSalvarAPI_Click;
            // 
            // chkMostrarAPI
            // 
            chkMostrarAPI.AutoSize = true;
            chkMostrarAPI.Font = new Font("Berlin Sans FB", 10F);
            chkMostrarAPI.ForeColor = Color.White;
            chkMostrarAPI.Location = new Point(167, 204);
            chkMostrarAPI.Name = "chkMostrarAPI";
            chkMostrarAPI.Size = new Size(96, 20);
            chkMostrarAPI.TabIndex = 17;
            chkMostrarAPI.Text = "Mostrar API";
            chkMostrarAPI.UseVisualStyleBackColor = true;
            chkMostrarAPI.CheckedChanged += chkMostrarAPI_CheckedChanged;
            // 
            // lblStatusChaveAPI
            // 
            lblStatusChaveAPI.Font = new Font("Berlin Sans FB", 15F);
            lblStatusChaveAPI.ForeColor = Color.White;
            lblStatusChaveAPI.Location = new Point(80, 242);
            lblStatusChaveAPI.Margin = new Padding(0);
            lblStatusChaveAPI.Name = "lblStatusChaveAPI";
            lblStatusChaveAPI.Size = new Size(82, 21);
            lblStatusChaveAPI.TabIndex = 18;
            lblStatusChaveAPI.Text = "Status:";
            lblStatusChaveAPI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAjudaAPIKey
            // 
            lblAjudaAPIKey.Font = new Font("Berlin Sans FB", 15F);
            lblAjudaAPIKey.ForeColor = Color.White;
            lblAjudaAPIKey.Location = new Point(80, 287);
            lblAjudaAPIKey.Margin = new Padding(0);
            lblAjudaAPIKey.Name = "lblAjudaAPIKey";
            lblAjudaAPIKey.Size = new Size(82, 26);
            lblAjudaAPIKey.TabIndex = 19;
            lblAjudaAPIKey.Text = "Ajuda:";
            lblAjudaAPIKey.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAjudaAPIKey2
            // 
            lblAjudaAPIKey2.Font = new Font("Berlin Sans FB", 10F);
            lblAjudaAPIKey2.ForeColor = Color.White;
            lblAjudaAPIKey2.Location = new Point(167, 295);
            lblAjudaAPIKey2.Margin = new Padding(0);
            lblAjudaAPIKey2.Name = "lblAjudaAPIKey2";
            lblAjudaAPIKey2.Size = new Size(189, 63);
            lblAjudaAPIKey2.TabIndex = 20;
            lblAjudaAPIKey2.Text = "1. Acesse: console.groq.com\r\n2. Faça login ou crie uma conta\r\n3. Vá em \"API Keys\" e crie uma\r\n4. Insira-a no campo da Chave\r\n";
            lblAjudaAPIKey2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusChaveAPI2
            // 
            lblStatusChaveAPI2.Font = new Font("Berlin Sans FB", 10F);
            lblStatusChaveAPI2.ForeColor = Color.White;
            lblStatusChaveAPI2.Location = new Point(167, 246);
            lblStatusChaveAPI2.Margin = new Padding(0);
            lblStatusChaveAPI2.Name = "lblStatusChaveAPI2";
            lblStatusChaveAPI2.Size = new Size(168, 21);
            lblStatusChaveAPI2.TabIndex = 22;
            lblStatusChaveAPI2.Text = "⚠️ Chave não configurada";
            lblStatusChaveAPI2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnObterChaveAPI
            // 
            btnObterChaveAPI.BorderColor = Color.FromArgb(220, 223, 230);
            btnObterChaveAPI.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnObterChaveAPI.DangerColor = Color.FromArgb(245, 108, 108);
            btnObterChaveAPI.DefaultColor = Color.FromArgb(255, 255, 255);
            btnObterChaveAPI.Font = new Font("Berlin Sans FB", 11.5F);
            btnObterChaveAPI.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnObterChaveAPI.InfoColor = Color.FromArgb(144, 147, 153);
            btnObterChaveAPI.Location = new Point(367, 170);
            btnObterChaveAPI.Margin = new Padding(0);
            btnObterChaveAPI.Name = "btnObterChaveAPI";
            btnObterChaveAPI.PrimaryColor = Color.FromArgb(79, 55, 139);
            btnObterChaveAPI.Size = new Size(153, 36);
            btnObterChaveAPI.SuccessColor = Color.FromArgb(103, 194, 58);
            btnObterChaveAPI.TabIndex = 23;
            btnObterChaveAPI.Text = "Obter chave gratuita do Groq";
            btnObterChaveAPI.TextColor = Color.White;
            btnObterChaveAPI.WarningColor = Color.FromArgb(230, 162, 60);
            btnObterChaveAPI.Click += btnObterChaveAPI_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pnLinha1
            // 
            pnLinha1.BackColor = Color.White;
            pnLinha1.Location = new Point(80, 230);
            pnLinha1.Name = "pnLinha1";
            pnLinha1.Size = new Size(275, 1);
            pnLinha1.TabIndex = 25;
            // 
            // pnLinha2
            // 
            pnLinha2.BackColor = Color.White;
            pnLinha2.Location = new Point(80, 277);
            pnLinha2.Name = "pnLinha2";
            pnLinha2.Size = new Size(275, 1);
            pnLinha2.TabIndex = 26;
            // 
            // btnTesteConexao
            // 
            btnTesteConexao.BorderColor = Color.FromArgb(220, 223, 230);
            btnTesteConexao.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnTesteConexao.DangerColor = Color.FromArgb(245, 108, 108);
            btnTesteConexao.DefaultColor = Color.FromArgb(255, 255, 255);
            btnTesteConexao.Font = new Font("Berlin Sans FB", 12F);
            btnTesteConexao.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnTesteConexao.InfoColor = Color.FromArgb(144, 147, 153);
            btnTesteConexao.Location = new Point(231, 382);
            btnTesteConexao.Margin = new Padding(0);
            btnTesteConexao.Name = "btnTesteConexao";
            btnTesteConexao.PrimaryColor = Color.FromArgb(79, 55, 139);
            btnTesteConexao.Size = new Size(100, 38);
            btnTesteConexao.SuccessColor = Color.FromArgb(103, 194, 58);
            btnTesteConexao.TabIndex = 27;
            btnTesteConexao.Text = "Testar conexão";
            btnTesteConexao.TextColor = Color.White;
            btnTesteConexao.WarningColor = Color.FromArgb(230, 162, 60);
            btnTesteConexao.Click += btnTesteConexao_Click;
            // 
            // TelaConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 31, 52);
            Controls.Add(btnTesteConexao);
            Controls.Add(pnLinha2);
            Controls.Add(pnLinha1);
            Controls.Add(pictureBox1);
            Controls.Add(btnObterChaveAPI);
            Controls.Add(lblStatusChaveAPI2);
            Controls.Add(lblAjudaAPIKey2);
            Controls.Add(lblAjudaAPIKey);
            Controls.Add(lblStatusChaveAPI);
            Controls.Add(chkMostrarAPI);
            Controls.Add(btnSalvarAPI);
            Controls.Add(txtChaveAPI);
            Controls.Add(lblChaveAPI);
            Controls.Add(lblTituloAPI);
            Controls.Add(lblTituloConfig);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaConfig";
            Size = new Size(1120, 720);
            Load += TelaConfig_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloConfig;
        private Label lblTituloAPI;
        private Label lblChaveAPI;
        private TextBox txtChaveAPI;
        private ReaLTaiizor.Controls.HopeRoundButton btnSalvarAPI;
        private CheckBox chkMostrarAPI;
        private Label lblStatusChaveAPI;
        private Label lblAjudaAPIKey;
        private Label lblAjudaAPIKey2;
        private Label lblStatusChaveAPI2;
        private ReaLTaiizor.Controls.HopeRoundButton btnObterChaveAPI;
        private PictureBox pictureBox1;
        private Panel pnLinha1;
        private Panel pnLinha2;
        private ReaLTaiizor.Controls.HopeRoundButton btnTesteConexao;
    }
}
