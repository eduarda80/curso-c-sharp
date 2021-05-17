using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CursoCSharp.Api;

namespace CursoCSharp.MetodosEFuncoes
{
    public sealed class Recursividade
    {    
        public static void Executar()
        {
            var dirPasta = @"C:\Nome da pasta".ParseHome();

            var dirInfo = new DirectoryInfo(dirPasta);

        public void ExcluirDiretorio(string path)
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

        /*
         Musicas
            -Musica 0
            -Rock    
                -Musica 1
                -Musica 2
                -Musica 3
                -Metal
                    -Musica 4
                    -Musica 5
                    -Musica 6
                -Romantico
                   - Musica 7
                    -Musica 8
            Pop
                MusicaX
                ...

                MIchael
                    ...
                Maddona
                    ...
                Adele
                    ...
            Jazz
                     
         */



    }
}
