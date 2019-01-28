using System;

namespace csharpExceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException (string mensagem)
            : base(mensagem)
        {
            
        }

        public SaldoInsuficienteException ()
        {
            
        }
    }
}