using System;

namespace csharpExceptions {
    class Program {
        static void Main (string[] args) {
            try{
                Metodo ();
            }catch(DivideByZeroException e){
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadLine ();

        }

        public static int Dividir (int numero, int divisor) {
            ContaCorrente c = null;
            Console.WriteLine(c.Saldo);
            
            return numero / divisor;
        }

        static void Metodo () {
            try{
                TestaDivisao (0);
            }catch(NullReferenceException e){
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        static void TestaDivisao (int divisor) {
            Dividir (10, divisor);
        }
    }
}