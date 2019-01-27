using System;

namespace csharpExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
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
            //ContaCorrente c = null;
            //Console.WriteLine(c.Saldo);

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
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}