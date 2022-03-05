using System.IO;

namespace ManipulandoArquivos.helper
{
    public class FileHelper
    {
       public void ListarDiretorios(string caminho)
       {
           var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories); //pode se usar apenas (caminho)

           foreach (var retorno in retornoCaminho)
           {
               System.Console.WriteLine(retorno);
           }
       } 

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivo = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories); //"*" - todos arquivos | ".txt" só texto

            foreach (var retorno in retornoArquivo)
           {
               System.Console.WriteLine(retorno);
           }
        }

       public void CriarDiretorio(string caminho)
       {
           var retorno = Directory.CreateDirectory(caminho);
           System.Console.WriteLine(retorno.FullName); //tem outras opçoes alem de .FullName
       }

       public void ApagarDiretorio(string caminho, bool apagarArquivos)
       {
           Directory.Delete(caminho, apagarArquivos); //nao retorna nada
       }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho)) //so vai se criar se nao tiver o arquivo
            //recomenda-se de ler/escrever de maneira fracionada, para nao ter alto consumo de memoria
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            
            using (var stream = File.CreateText(caminho)) //using é responsavel por terminar a stream
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha); //a stream sera uma intermediaria, pra q nao se escreva tudo de uma vez
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo); //adicionara o conteudo
            //para o stream, basta trocar File.CreateText por File.AppendAllText
        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho); //carrega todo o conteudo na memoria, pode travar

            foreach(var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using(var stream = File.OpenText(caminho)) //faça a leitura de cada linha, até a ultima linha
            {
                while ((linha = stream.ReadLine()) != null) //maneira mais recomendada
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever); //mover o arquivo, da para mudar o nome tbm
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever); //nao permite sobrescrita, alem de que se fale
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

    }
}