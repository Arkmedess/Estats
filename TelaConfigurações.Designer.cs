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
            TituloVAC = new Label();
            SuspendLayout();
            // 
            // TituloVAC
            // 
            TituloVAC.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            TituloVAC.ForeColor = Color.White;
            TituloVAC.Location = new Point(373, 294);
            TituloVAC.Margin = new Padding(0);
            TituloVAC.Name = "TituloVAC";
            TituloVAC.Size = new Size(336, 43);
            TituloVAC.TabIndex = 8;
            TituloVAC.Text = "Tela em Construção";
            TituloVAC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TelaConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 33, 34);
            Controls.Add(TituloVAC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaConfig";
            Size = new Size(1120, 720);
            Load += TelaConfig_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label TituloVAC;
    }
}
