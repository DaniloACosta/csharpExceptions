using System;

namespace csharpExceptions
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; set; }
        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                ArgumentException e = new ArgumentException("Agencia n?o pode ser menor ou igual ? zero.", nameof(agencia));
                throw e;
            }

            if (numero <= 0)
            {
                ArgumentException e = new ArgumentException("numero n?o pode ser menor ou igual ? zero.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo Insuficiente!");
            }

            _saldo -= valor;
            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestinho)
        {
            if (_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            contaDestinho.Depositar(valor);
            return true;
        }
    }
}