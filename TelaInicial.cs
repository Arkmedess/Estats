using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_e_sistema_em_C_
{
    public partial class TelaInicial : UserControl, ITela
    {
        private ITela telaAtual;
        private GerenciadorTelas _gerenciadorTelas;
        private Panel _panelContainer;

        public TelaInicial(Panel panelContainer, GerenciadorTelas gerenciadorTelas)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _gerenciadorTelas = gerenciadorTelas;
            _panelContainer = panelContainer;

        }

        #region Ciclo de Vida da Tela
        public void OnCarregar()
        {
            this.Visible = true;
            this.BringToFront();
        }

        public void OnDescarregar()
        {
            this.Visible = false;
            LimparRecursos();
        }

        private void LimparRecursos() { }

        public UserControl GetView() { return this; }

        #endregion
    }
}
