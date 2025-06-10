using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_e_sistema_em_C_
{
    // Esta função é responsável por configurar as telas
    public class FormTelaAdapter : ITela
    {
        // Isto faz com que a tela seja um Form
        private readonly Form _form;

        // Aqui é feita a adaptação para o Form
        public FormTelaAdapter(Form form)
        {
            _form = form;
        }

        // Esta função é responsável por carregar a tela
        public void OnCarregar()
        {
            // Mostra todos os controles o  riginais do form
            foreach (Control ctrl in _form.Controls)
            {
                if (ctrl.Name != "panelContainer") // Exclui o container
                    ctrl.Visible = true;
            }
        }

        // Esta função é responsável por descarregar a tela
        public void OnDescarregar()
        {
            // Esconde todos os controles originais
            foreach (Control ctrl in _form.Controls)
            {
                if (ctrl.Name != "panelContainer")
                    ctrl.Visible = false;
            }
        }

        // Esta função é responsável por retornar a view
        public UserControl GetView() => null; // Não aplicável para Forms
    }
}

