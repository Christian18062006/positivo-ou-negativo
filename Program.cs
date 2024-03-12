using System;

namespace PositivoNegativo
{
    class Program
    {
        public static bool positivoNegativo(int numero)
        {
            if (numero>=0)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Positivo ou negativo.");
            numero = int.Parse(Console.ReadLine());

        }
    }
}
