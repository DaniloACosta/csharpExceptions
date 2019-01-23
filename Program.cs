using System;

namespace csharpExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente danilo = new Cliente();
            danilo.Nome = "Danilo Alves Costa";
            danilo.CPF = "123.456.789-60";
            danilo.Profissao = "Develop";

            ContaCorrente conta = new ContaCorrente(159, 12345);
            conta.Titular = danilo;
            conta.Depositar(4000);

            Cliente vitor = new Cliente();
            vitor.Nome = "Safado";
            vitor.CPF = "123.321.789-60";
            vitor.Profissao = "QA safado";

            ContaCorrente contaSafado = new ContaCorrente(159, 12345);
            contaSafado.Titular = vitor;
            contaSafado.Depositar(10);
            contaSafado.Transferir(10, conta);

            Console.WriteLine(string.Format("{0} tem {1} em dinheiro", danilo.Nome, conta.Saldo));
            Console.WriteLine(string.Format("{0} tem {1} em dinheiro", vitor.Nome, contaSafado.Saldo));
            Console.ReadLine();
        }
    }
}
