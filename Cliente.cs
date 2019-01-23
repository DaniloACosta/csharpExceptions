namespace csharpExceptions
{
    public class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }

        public string CPF {
            get {
                return _cpf;
            }

            set {
                //validador de CPF
                _cpf = value;
            }
        }

        public string Profissao { get; set; }
    }
}