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
    public partial class TelaSobre : UserControl, ITela
    {
        private Form _telaInício;
        public TelaSobre()
        {
            InitializeComponent();
            AddControles();
        }

        public void AddControles()
        {
            // AdicionarControlesBasicos.AddBarraLateral(this, Barra_lateral_menu); CORRIGIR DEPOIS
        }

        // Este método é chamado quando a tela é carregada para exibição
        public void OnCarregar()
        {
            this.Visible = true;
            this.BringToFront();

            // Adicione aqui a lógica de inicialização específica
            CarregarDadosAjuda();
        }

        // Este método é chamado quando a tela é descarregada para ocultação
        public void OnDescarregar()
        {
            this.Visible = false;

            // Adicione aqui a lógica de limpeza
            LimparRecursos();
        }

        // Implementação explícita de GetView
        public UserControl GetView()
        {
            return this;
        }

        private void CarregarDadosAjuda()
        {
            // Sua lógica para carregar dados
        }

        private void LimparRecursos()
        {
            // Sua lógica para liberar recursos
        }

        private void TelaAjuda_Load(object sender, EventArgs e)
        {

        }

        private void TelaAjuda_Load_1(object sender, EventArgs e)
        {

        }
    }
}