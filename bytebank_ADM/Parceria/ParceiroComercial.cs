using System;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Login { get; }
        public string Senha { get; }

        public ParceiroComercial(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }

        public bool Autenticar(string login, string senha)
        {
            return this.Login == login && this.Senha == senha;
        }
    }
}

