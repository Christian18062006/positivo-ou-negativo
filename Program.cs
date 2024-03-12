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
            bool resultado = positivoNegativo(numero);
            if (resultado)
            {
                Console.WriteLine($"O número {numero} é positivo.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é negativo.");
            }
        }
    }
}
