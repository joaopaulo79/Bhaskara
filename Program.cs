using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;
            string txtA, txtB, txtC;
            bool realA, realB, realC;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- Bhaskara ---\n");
            Console.ResetColor();

            Console.WriteLine("Programa que calcula as raízes de\numa equação de segundo grau,");
            Console.WriteLine("utilizando o método de Bhaskara.\n");

            Console.Write("(A): ");
            txtA = Console.ReadLine();

            realA = Double.TryParse(txtA, out a);


            Console.Write("(B): ");
            txtB = Console.ReadLine();

            realB = Double.TryParse(txtB, out b);


            Console.Write("(C): ");
            txtC = Console.ReadLine();

            realC = Double.TryParse(txtC, out c);

            if (realA && realB && realC)
            {
                delta = Math.Pow(b, 2) - 4 * a * c;

                if (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nNão é uma equação do segundo grau!\n");
                    Console.ResetColor();
                }
                if (delta < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nComo delta = {delta:N2}, a equação não possui raízes reais!\n");
                    Console.ResetColor();
                }
                if (a != 0 && delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nx1 = {x1:N2} e x2 = {x2:N2}\n");
                    Console.ResetColor();
                }
            }
            else
            {
                if (realA && realB && !realC 
                || realA && !realB && realC 
                || !realA && realB && realC)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nUm dos valores inseridos, não é um número!!\n");
                    Console.ResetColor();
                }
                if (realA && !realB && !realC 
                || !realA && realB && !realC 
                || !realA && !realB && realC)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nDois dos valores inseridos, não são números!!\n");
                    Console.ResetColor();
                }
                if (!realA && !realB && !realC)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nDigite os números corretamente!!\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
