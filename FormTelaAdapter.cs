namespace Interface_e_sistema_em_C_
{

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

        public void OnDescarregar()
        {
            // Esconde todos os controles originais
            foreach (Control ctrl in _form.Controls)
            {
                if (ctrl.Name != "panelContainer")
                    ctrl.Visible = false;
            }
        }

        public UserControl GetView() => null; // Não aplicável para Forms
    }
}

