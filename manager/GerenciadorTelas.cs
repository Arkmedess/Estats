namespace Estats
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Estats.manager;

    public class GerenciadorTelas
    {
        private readonly Dictionary<string, ITela> _telas = new Dictionary<string, ITela>();
        private ITela _telaAtual;
        private readonly Panel _container;


        public GerenciadorTelas(Panel container)
        {
            _container = container;
            RegistrarTelas();

        }

        private void RegistrarTelas()
        {
            _telas.Add("Início", new FormTelaAdapter(new Form()));
            _telas.Add("Inicial", new TelaInicial(_container, this));
            _telas.Add("Estatística Paramétrica", new TelaEstatisticaParametrica(this));
            _telas.Add("Média de Posição Central", new TelaMediaPosicaoCentral(_container, this));
            _telas.Add("Variação Aleatória Contínua", new TelaVAC(_container, this));
            //_telas.Add("Regressão Linear", new TelaRegressaoLinear(this));
            _telas.Add("Configurações", new TelaConfig());
            _telas.Add("Sobre", new TelaSobre());

        }

        public void MostrarTela(string chave)
        {
            if (_telas.TryGetValue(chave, out ITela novaTela))
            {
                _telaAtual?.OnDescarregar();
                _telaAtual = novaTela;
                novaTela.OnCarregar();
                _container.Controls.Clear();
                _container.Controls.Add(novaTela.GetView());

            }
        }

        public T GetTela<T>(string chave) where T : class, ITela
        {
            if (_telas.TryGetValue(chave, out ITela tela))
                return tela as T;
            return null;
        }

    }
}
