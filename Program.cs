using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;


namespace desafio10_arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Azul: Alunos, Vermelho: Pessoas, Verde: Total de Pessoas-Alunos  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"*- - - - - - - - - *");
            Console.WriteLine("| Lista de Alunos |");
            Console.WriteLine(@"*- - - - - - - - - *");
           
            Console.ResetColor();

            Util util = new Util();
            Console.ForegroundColor = ConsoleColor.Blue;
            util.LeArquivo();
            Console.ResetColor();
            util.ContaNumeroAlunos();   
            Console.WriteLine(@"- - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            util.AdicionaPessoas();
            util.ApresentarPessoas();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"- - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.ForegroundColor = ConsoleColor.Green;
            util.ApresentaNumeroAlunosPessoas();
            Console.ResetColor();

        }


    }


}






