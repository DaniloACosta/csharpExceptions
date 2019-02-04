using System;
using System.IO;

namespace csharpExceptions {
    public class LeitorDeArquivo : IDisposable {
        public string Arquivo { get; }

        public LeitorDeArquivo (string arquivo) {
            Arquivo = arquivo;
            Console.WriteLine ("Abrindo arquivo: " + arquivo);
            throw new FileNotFoundException("Não encontrei o " + arquivo);
        }

        public string LerProximaLinha () {
            Console.WriteLine ("Lendo linha...");
            return "Linha do arquivo";
            throw new IOException("Erro ao encontrar a próxima linha");
        }

        public void Dispose()
        {
            Console.WriteLine ("Fechando arquivo.");
        }
    }
}