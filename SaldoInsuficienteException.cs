using System;
using System.Runtime.Serialization;

namespace csharpExceptions {
    [Serializable]
    public class SaldoInsuficienteException : Exception {

        public double Take { get; set; }
        public double ValueTake { get; set; }
        public SaldoInsuficienteException () { }
        public SaldoInsuficienteException (string message) : base (message) { }
        public SaldoInsuficienteException (string message, Exception inner) : base (message, inner) { }
        protected SaldoInsuficienteException (
            SerializationInfo info,
            StreamingContext context) : base (info, context) { }
        public SaldoInsuficienteException (double take, double valueTake) : this (string.Format ("Saldo insuficiente para o saque de {0}, saldo na conta {1}.", take, valueTake)) {
            Take = take;
            ValueTake = valueTake;
        }
    }
}