using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Tabuada_Interativa_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Digite um número (ou 0 para sair): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero))
                {
                    if (numero != 0)
                    {
                        ExibirTabuada(numero);
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                }

            } while (numero != 0);

            Console.WriteLine("Obrigado por usar o programa. Ate a proxima !");
        }

        static void ExibirTabuada(int numero)
        {
            Console.WriteLine($"\nTabuada do {numero}:");

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
                i++;
            }

            Console.WriteLine();
        }
    }
}
        
