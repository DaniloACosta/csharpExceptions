using System;

namespace csharpExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(123, 123);
                contaCorrente.Sacar(500000);

            } catch (ArgumentException e)
            {
                if(e.ParamName == "conta")
                {
                    Console.WriteLine(e.Message);
                }
                if(e.ParamName == "agencia")
                {
                    Console.WriteLine(e.Message);
                }
            } catch(SaldoInsuficienteException e){
                Console.WriteLine(e.Message);
            }

            try
            {
                Metodo();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possivél dividir por 0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(String.Format("Exceção ao tentar dividir {0} por {1}", numero, divisor));
                throw;
            }
        }

        static void Metodo()
        {
            TestaDivisao(5);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}