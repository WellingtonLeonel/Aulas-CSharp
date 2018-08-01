using System;

namespace Aula3107_Console
{
    class Program
    {
        private static int conta;

        public static int Id { get; set; }
        public static int Id2 { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello User");
            
            Console.WriteLine("Digite um número");
            Id = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite um número");
            Id2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 para soma");
            Console.WriteLine("2 para multiplicação");
            Console.WriteLine("3 para divisão");
            Console.WriteLine("4 para subtração");
            conta = int.Parse(Console.ReadLine());

            if (conta == 1)
            {
                Console.WriteLine("Soma: " + (Id + Id2));
            }
            else if (conta == 2)
            {
                Console.WriteLine("Multiplicação: " + (Id * Id2));

            }
            else if (conta == 3)
            {
                Console.WriteLine("Divisão: " + (Id / Id2));

            }
            else if (conta == 4)
            {
                Console.WriteLine("Subtração: " + (Id - Id2));
            }

            Console.ReadKey();



        }
    }
}
