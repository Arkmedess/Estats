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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(325, 171);
            label1.Name = "label1";
            label1.Size = new Size(790, 517);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // TelaSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 33, 34);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaSobre";
            Size = new Size(1280, 800);
            Load += TelaAjuda_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}
