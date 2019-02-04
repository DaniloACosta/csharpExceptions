using System;
using System.IO;

namespace csharpExceptions {
    class Program {
        static void Main (string[] args) {

            using (LeitorDeArquivo danilo = new LeitorDeArquivo ("Sem Vergonha!")) {
                danilo.LerProximaLinha ();
            }

        }

        private static void ModoClassico () {
            LeitorDeArquivo danilo = null;

            try {
                danilo = new LeitorDeArquivo ("Safado!");
                danilo.LerProximaLinha ();
            } catch (Exception) {
                Console.WriteLine ("Deu muito rum....");
            } finally {
                if (danilo != null) {
                    danilo.Dispose ();
                }
            }
        }

        private static void TestaInnerException () {
            try {
                ContaCorrente danilo = new ContaCorrente (123, 123);
                ContaCorrente SemMundial = new ContaCorrente (123, 123);
                SemMundial.Transferir (51, danilo);
            } catch (OperacaoFinanceiraException ex) {
                Console.WriteLine (ex.Message);
                Console.WriteLine (ex.StackTrace);
                Console.WriteLine ("-----------------------------------------------------------------");
                Console.WriteLine (ex.InnerException.Message);
                Console.WriteLine (ex.InnerException.StackTrace);
            }
        }

        public static int Dividir (int numero, int divisor) {
            try {
                return numero / divisor;
            } catch (DivideByZeroException) {
                Console.WriteLine (String.Format ("Exceção ao tentar dividir {0} por {1}", numero, divisor));
                throw;
            }
        }

        static void Metodo () {
            TestaDivisao (5);
        }

        static void TestaDivisao (int divisor) {
            Dividir (10, divisor);
        }
    }
}