using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CursoCSharp.Api;

namespace CursoCSharp.MetodosEFuncoes
{
    public class Recursividade
    {
        public static void ExcluirDiretorio(string path)
        {
            if (!Directory.Exists(path))
                return;

            var info = new DirectoryInfo(path);

            //files: Arquivos (NÃO PASTAS, SOMENTE ARQUIVOS) do meu diretório
            var files = info.GetFiles();

            //Exclui arquivo-a-arquivo do meu diretório.
            foreach (var file in files)
                file.Delete();

            //directories: As pastas (NÃO ARQUVIOS, SOMENTE PASTAS) do meu diretório.
            var directories = info.GetDirectories();

            foreach (var directory in directories)
                ExcluirDiretorio(directory.FullName);

            info.Delete();
        }

        public static void Executar()
        {
           string path = @"C:\Arquivoxml - Copia";

            if (Directory.Exists(path))
            {
                ExcluirDiretorio(path);
            }
        }
    }
}
