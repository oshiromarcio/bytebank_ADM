using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Login { get; }
        string Senha { get; }

        public bool Autenticar(string login, string senha);
    }
}
