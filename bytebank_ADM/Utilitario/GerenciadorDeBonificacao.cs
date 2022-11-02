using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double totalBonificacao { get; private set; }

        public GerenciadorDeBonificacao()
        {
            totalBonificacao = 0;
        }

        public void Registrar(Funcionario funcionario)
        {
            totalBonificacao += funcionario.GetBonificacao();
        }
    }
}
