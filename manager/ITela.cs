namespace Estats.manager
{

    public interface ITela
    {
        void OnCarregar();
        void OnDescarregar();
        UserControl GetView();
    }
}