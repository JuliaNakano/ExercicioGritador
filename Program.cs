using System;

namespace ExercicioGritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string frasedigitada;
            Console.Write("Digite uma frase: ");
            frasedigitada= Console.ReadLine(); 
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"{frasedigitada}".ToUpper());
            Console.ResetColor();


        }
    }
}
