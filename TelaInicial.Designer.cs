namespace Interface_e_sistema_em_C_
{
    partial class TelaInicial
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
            label1 = new Label();
            TituloVAC = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(283, 177);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "teteeeee";
            // 
            // TituloVAC
            // 
            TituloVAC.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            TituloVAC.ForeColor = Color.White;
            TituloVAC.Location = new Point(110, 72);
            TituloVAC.Margin = new Padding(0);
            TituloVAC.Name = "TituloVAC";
            TituloVAC.Size = new Size(632, 43);
            TituloVAC.TabIndex = 8;
            TituloVAC.Text = "Cálculo da Variável Aleatória Contínua";
            TituloVAC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 33, 34);
            Controls.Add(TituloVAC);
            Controls.Add(label1);
            Name = "TelaInicial";
            Size = new Size(1280, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label TituloVAC;
    }
}
