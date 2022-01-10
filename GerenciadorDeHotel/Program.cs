using System;

namespace GerenciadorDeHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente[] Quartos = new Cliente[10];

            Console.Write("Quantos quartos serão alugados? ");
            int QtdQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < QtdQuartos; i++)
            {
                Console.WriteLine("\nAluguel #" + (i + 1) + ": ");
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();

                Console.Write("Email: ");
                string Email = Console.ReadLine();

                Console.Write("Quarto: ");
                int Quarto = int.Parse(Console.ReadLine());

                Quartos[Quarto] = new Cliente(Nome, Email);
            }
            Console.WriteLine("\nQuartos ocupados:");

            for (int j = 0; j < 10; j++)
            {
                if (Quartos[j] != null)
                {
                    Console.WriteLine(j + ": " + Quartos[j]);
                }
            }
        }
    }
}
