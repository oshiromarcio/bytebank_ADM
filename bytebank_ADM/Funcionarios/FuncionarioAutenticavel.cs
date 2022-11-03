using System;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Login { get; }
        public string Senha { get; }

        public FuncionarioAutenticavel(string cpf, double salario, string login, string senha) : base(cpf, salario)
        {
            this.Login = login;
            this.Senha = senha;
        }

        public bool Autenticar(string login, string senha)
        {
            return this.Login == login && this.Senha == senha;
        }

        public override double GetBonificacao()
        {
            throw new NotImplementedException();
        }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }
    }
}

