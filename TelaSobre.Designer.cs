namespace Interface_e_sistema_em_C_
{
    partial class TelaSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSobre));
            label1 = new Label();
            lblTituloConfig = new Label();
            linkLblLinkedIn = new LinkLabel();
            linkLblGitHub = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Berlin Sans FB", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 122);
            label1.Name = "label1";
            label1.Size = new Size(813, 378);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // lblTituloConfig
            // 
            lblTituloConfig.Font = new Font("Berlin Sans FB Demi", 25F, FontStyle.Bold);
            lblTituloConfig.ForeColor = Color.White;
            lblTituloConfig.Location = new Point(80, 53);
            lblTituloConfig.Margin = new Padding(0);
            lblTituloConfig.Name = "lblTituloConfig";
            lblTituloConfig.Size = new Size(232, 45);
            lblTituloConfig.TabIndex = 8;
            lblTituloConfig.Text = "Sobre";
            lblTituloConfig.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linkLblLinkedIn
            // 
            linkLblLinkedIn.AutoSize = true;
            linkLblLinkedIn.Font = new Font("Berlin Sans FB", 12F);
            linkLblLinkedIn.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLblLinkedIn.LinkColor = Color.White;
            linkLblLinkedIn.Location = new Point(692, 392);
            linkLblLinkedIn.Name = "linkLblLinkedIn";
            linkLblLinkedIn.Size = new Size(201, 18);
            linkLblLinkedIn.TabIndex = 9;
            linkLblLinkedIn.TabStop = true;
            linkLblLinkedIn.Text = "linkedin.com/in/arthur-victor-/";
            linkLblLinkedIn.LinkClicked += linkLblLinkedIn_LinkClicked;
            // 
            // linkLblGitHub
            // 
            linkLblGitHub.Font = new Font("Berlin Sans FB", 12F);
            linkLblGitHub.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLblGitHub.LinkColor = Color.White;
            linkLblGitHub.Location = new Point(376, 392);
            linkLblGitHub.Name = "linkLblGitHub";
            linkLblGitHub.Size = new Size(246, 18);
            linkLblGitHub.TabIndex = 10;
            linkLblGitHub.TabStop = true;
            linkLblGitHub.Text = "https://github.com/Arkmedess/Estats ";
            linkLblGitHub.LinkClicked += linkLblGitHub_LinkClicked;
            // 
            // TelaSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 31, 52);
            Controls.Add(linkLblGitHub);
            Controls.Add(linkLblLinkedIn);
            Controls.Add(lblTituloConfig);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaSobre";
            Size = new Size(1280, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTituloConfig;
        private LinkLabel linkLblLinkedIn;
        private LinkLabel linkLblGitHub;
    }
}
