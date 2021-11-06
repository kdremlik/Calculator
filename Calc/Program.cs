using System;

namespace Calculator
{
    class Program
    {
        static float Math(float x, float y, string option)
        {
           

            
            
            
            
            return result;
        }


        static void Main(string[] args)
        {
            bool cont = true;
            while (cont == true)
            {
                // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C# by Dremliktoprzechuj\r");
            Console.WriteLine("------------------------\n");

            string comma = ",";
            // Read first number from user.
            Console.WriteLine($"Type first number, and press enter (use \",\" as separator)");
            float x = float.Parse(Console.ReadLine());
            // Read second number from user.
            Console.WriteLine("Type second number, and press enter (use \",\" as separator)");
            float y = float.Parse(Console.ReadLine());

            // Convert user typed numbers to float.
            //float x = float.Parse(x);
            //float y = float.Parse(y);
            
            // Ask user to chose option.
            Console.WriteLine($"Chose what do you want to do with numbers {x} and {y}");
            Console.WriteLine($"\ta - Add {x} to {y}");
            Console.WriteLine($"\ts - Subtract {y} from {x}");
            Console.WriteLine($"\tsr - Subtract Reversed {x} from {y}");
            Console.WriteLine($"\tm - Multiply {x} by {y}");
            Console.WriteLine($"\td - Divide {x} by {y}");
            Console.WriteLine($"\tdr - Divide Reversed {y} by {x}");
            Console.Write("Your option? ");

                //Do the math.
            string opt = Console.ReadLine();
            float result = Math(x, y, opt);
                switch (opt)
            {
                case "a":
                    Console.WriteLine($"Your result: {y} + {x} = {result}");
                     break;
                case "s":
                    Console.WriteLine($"Your result: {y} - {x} = {result}");
                    break;
                case "sr":
                    Console.WriteLine($"Your result: {x} - {y} = {result}");
                    break;
                case "m":
                    Console.WriteLine($"Your result: {x} * {y} = {result}");
                    break;
                case "d":
                    Console.WriteLine($"Your result: {x} / {y} = {result}");
                    break;
                case "dr":
                    Console.WriteLine($"Your result: {y} / {x} = {result}");
                    break;
            }

             

            }

            

            Console.WriteLine("Naciśnij cokolwiek");
            Console.ReadLine();
            Environment.Exit(0);

            //Console.WriteLine("Podaj liczbę którą chcesz ");
            //int pow = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Podaj liczbę którą podniosę do potęgi {pow}: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Liczba {x} podniesiona do kwadratu wynosi { Math.Pow(x, pow)}");
        }
    }
}
