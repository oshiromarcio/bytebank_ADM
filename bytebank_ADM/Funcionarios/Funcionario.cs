using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Utilitario;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario : ICalcularBonificacao
    {
        public string? Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

        // Garbage Collector: É como o construtor, mas iniciando com ~
        ~Funcionario()
        {
            Console.WriteLine("Liberando recurso do PC...");
        }
    }
}
