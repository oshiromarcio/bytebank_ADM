using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionarioAutenticavel, string login, string senha)
        {
            bool usuarioAutenticado = funcionarioAutenticavel.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao nosso sistema " + login + "!");
                return true;
            }
            else
            {
                Console.WriteLine("Login ou senha incorreta");
                return false;
            }
        }
    }
}
