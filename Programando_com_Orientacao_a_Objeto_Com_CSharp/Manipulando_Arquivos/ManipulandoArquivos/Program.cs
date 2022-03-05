using System;
using System.IO;
using ManipulandoArquivos.helper;

namespace ManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta");
            var listaString = new List<string>{"Linha 1", "Linha 2", "Linha 3"};
            var caminhoArquivo = Path.Combine(caminho, "arquivo.txt");
            var caminhoArquivoNovo = Path.Combine(caminho, "Pasta", "arquivo-movido.txt");
            FileHelper helper = new FileHelper();

            helper.ListarDiretorios(caminho); //Irá mostrar os diretórios do local
            
            helper.ListarArquivosDiretorios(caminho); //irá mostrar os arquivos

            System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            helper.CriarDiretorio(caminhoPathCombine);
            //Path.Combine - organiza de maneira q nao precisa se preocupar com as barras

            helper.ApagarDiretorio(caminhoPathCombine, true); //precisa indicar se for um diretorio vazio ou com arquivos
            //arquivo é deletado totalmente, nao vai pra lixeira

            helper.CriarArquivoTexto(caminho, "Olá Mundo!"); //criar arquivo com texto "Olá mundo"

            helper.CriarArquivoTextoStream(caminho, listaString); //criar arquivo texto com a lista de strings

            helper.AdicionarTexto(caminho, "Eae brother!"); //adicionara ao texto 

            helper.LerArquivo(caminho);
            helper.LerArquivoStream(caminho);

            helper.MoverArquivo(caminhoArquivo, caminhoArquivoNovo, false); //alem de mover, vai mudar o nome

            helper.CopiarArquivo(caminhoArquivo, caminhoArquivoNovo, false);

            helper.DeletarArquivo(caminho);
        }
    }
}