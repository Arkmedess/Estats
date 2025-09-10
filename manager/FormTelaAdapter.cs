namespace Estats
{
    using Estats.manager;
    public class FormTelaAdapter : ITela
    {
        private readonly Form _form;
        public FormTelaAdapter(Form form)
        {
            _form = form;
        }

        public void OnCarregar()
        {
            // Mostra todos os controles originais do form
            foreach (Control ctrl in _form.Controls)
            {
                if (ctrl.Name != "panelContainer")
                    ctrl.Visible = true;
            }
        }

        public void OnDescarregar()
        {
            foreach (Control ctrl in _form.Controls)
            {
                if (ctrl.Name != "panelContainer")
                    ctrl.Visible = false;
            }
        }

        public UserControl GetView() => null;
    }
}

