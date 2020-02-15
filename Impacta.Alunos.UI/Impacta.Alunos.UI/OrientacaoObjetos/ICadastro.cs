using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    public interface ICadastro
    {
        int BuscaIdRegistro(int nomeVeiculos);

        bool CadastrarVeiculo();
    }
}
