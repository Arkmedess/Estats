using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_e_sistema_em_C_
{
    public interface ITela
    {
        void OnCarregar();
        void OnDescarregar();
        UserControl GetView();
    }
}