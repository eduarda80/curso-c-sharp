using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    public sealed class Recursividade
    {
        public static void Executar()
        {
            void ExcluirPasta(int numeroArquivo)
            {
                string arquivos = @"C:\Arquivos\arq1" + numeroArquivo + ".txt";
                bool result = File.Exists(arquivos);

                if (result == true)
                {
                    using (StreamReader arquivo = File.OpenText(arquivos))
                    {
                        string linha;
                        while ((linha = arquivo.ReadLine()) != null)
                        {
                            Console.WriteLine("Arquivo encontrado");
                            File.Delete(arquivos);
                            Console.WriteLine("Arquivo excluído com sucesso");
                        }
                    }
                }

                string arquivo2 = @"C:\Arquivos\Arq2" + numeroArquivo + ".txt";
                if (File.Exists(arquivo2))
                {
                    ExcluirPasta(numeroArquivo + 1);
                }

                string arquivo3 = @"C:\Arquivos\Arq3" + numeroArquivo + ".txt";
                if (File.Exists(arquivo3))
                {
                    ExcluirPasta(numeroArquivo + 1);
                }
            }
        }
    }
}
