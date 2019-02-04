using System;
using System.Runtime.Serialization;

namespace csharpExceptions {

    [Serializable]
    public class OperacaoFinanceiraException : SaldoInsuficienteException {
        public OperacaoFinanceiraException () { }
        public OperacaoFinanceiraException (string message) : base (message) { }
        public OperacaoFinanceiraException (string message, Exception inner) : base (message, inner) { }
        protected OperacaoFinanceiraException (
            SerializationInfo info,
            StreamingContext context) : base (info, context) { }
    }
}