using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01.PNG
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string NOME;                                                      /* string atribui um nome */                              

            Console.Write("Entre seu nome: ");
            NOME = Console.ReadLine();
            Console.WriteLine("Ola, " + NOME);                                /* o nome recebe ola */

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
