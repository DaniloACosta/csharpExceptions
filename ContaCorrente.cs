using System;

namespace csharpExceptions {
    public class ContaCorrente {
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; set; }
        public int Agencia { get; }
        public int Numero { get; }

        public int ContadorSaquesNaoPermitidos { get; set; }
        public int ContadorTransferenciasNaoPermitidas { get; set; }

        private double _saldo;
        public double Saldo {
            get {
                return _saldo;
            }
            set {
                if (value < 0) {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente (int agencia, int numero) {
            if (agencia <= 0) {
                ArgumentException e = new ArgumentException ("Agencia não pode ser menor ou igual à zero.", nameof (agencia));
                throw e;
            }

            if (numero <= 0) {
                ArgumentException e = new ArgumentException ("numero não pode ser menor ou igual à zero.", nameof (numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public void Sacar (double valor) {
            if (valor < 0) {
                throw new ArgumentException ("Valor do saque não pode ser negativo", nameof (valor));
            }

            if (_saldo < valor) {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException (_saldo, valor);
            }

            _saldo -= valor;

        }

        public void Depositar (double valor) {
            _saldo += valor;
        }

        public void Transferir (double valor, ContaCorrente contaDestinho) {
            try {
                this.Sacar (valor);
            } catch (SaldoInsuficienteException ex) {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException ("Ops, ocorreu um erro na transferencia. Nosso suporte tecnico já foi comunicado!", ex);
            }
            contaDestinho.Depositar (valor);
        }
    }
}