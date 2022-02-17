using System;

namespace diamantes_letras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma letra: ");
            char letra_final = Convert.ToChar(Console.ReadLine().ToLower());
            char letra_inicial = 'a';
            int espaco = 0;

            for (letra_inicial = 'a'; letra_inicial <= letra_final; letra_inicial++)
            {
                Console.Write($"{new string(' ', letra_final - letra_inicial)}{letra_inicial}");
                if (letra_inicial != 'a')
                {
                    Console.Write($"{new string(' ', espaco++)}{letra_inicial}");
                }
                espaco++;
                Console.WriteLine();
            }

            espaco = letra_final - 'a';
            for (letra_inicial = (char)(letra_final - 1); 'a' <= letra_inicial; letra_inicial--)
            {
                espaco--;
                Console.Write($"{new string(' ', letra_final - letra_inicial)}{letra_inicial}");
                if (letra_inicial != 'a')
                {
                    Console.WriteLine($"{new string(' ', espaco * 2 - 1)}{letra_inicial}");
                }
            }
        }
    }
}
