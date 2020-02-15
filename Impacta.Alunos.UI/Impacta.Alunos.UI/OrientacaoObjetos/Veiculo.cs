using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.UI
{
    // Será a nossa classe BASE (ou classe PAI)
    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string TipoCombustivel { get; set; }
        public int QtdeRoda { get; set; }

        // code snippet para construtor: ctor [TAB] [TAB]
        public Veiculo(string Modelo)
        {

            // sempre que usar o this, vc esta informando ao
            // .NET que vc esta referenciando algo definido
            // dentro da sua classe
            this.Modelo = Modelo;
        }


        public string LigarMotor(string ruidoAFazerAoIniciar)
        {
            return string.Format("Ligando o motor: {0}", ruidoAFazerAoIniciar);
        }

        public string PararMotor(string ruidoAFazerAoParar)
        {
            return string.Format("Desligando o Motor: {0}", ruidoAFazerAoParar);
        }

        public virtual string Drive()
        {
            return ("Implementação Padrão do metodo Drive()");
        }
    }
}
