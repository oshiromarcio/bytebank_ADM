﻿using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

#region Comentario
/*
Funcionario melissa = new Diretor("123456");
melissa.Nome = "Melissa Yuna";

Funcionario carol = new Funcionario("654321", 4000);
carol.Nome = "Caroline Miwa";

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(melissa);
gerenciador.Registrar(carol);

Console.WriteLine("Funcionário: " + melissa.Nome);
Console.WriteLine("Funcionário: " + carol.Nome);

melissa.AumentarSalario();
carol.AumentarSalario();

Console.WriteLine("Novo salário " + melissa.Nome + ": " + melissa.Salario);
Console.WriteLine("Novo salário " + carol.Nome + ": " + carol.Salario);

Console.WriteLine("Total de bonificações: " + gerenciador.totalBonificacao);
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
*/
#endregion Comentario

CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer scruton = new Designer("45632");
    scruton.Nome = "Roger Scruton";

    Diretor rand = new Diretor("3463426");
    rand.Nome = "Ayn Rand";

    Auxiliar bastiat = new Auxiliar("436723435");
    bastiat.Nome = "Frederic Bastiat";

    GerenteDeContas sowell = new GerenteDeContas("63442425");
    sowell.Nome = "Thomas Sowell";

    gerenciador.Registrar(scruton);
    gerenciador.Registrar(rand);
    gerenciador.Registrar(bastiat);
    gerenciador.Registrar(sowell);

    Console.WriteLine("Total de funcionários: " + Designer.TotalDeFuncionarios);
    Console.WriteLine("Total de bonificações: " + gerenciador.totalBonificacao);
}