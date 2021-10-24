using System;

namespace number_gusser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");

            while (true)
            {

                //Init current number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                Console.WriteLine("\nGuess a number between 1 - 10:");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Plese type a number!");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Worng number, please try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer =="N")
                {
                    Console.WriteLine($"Good by {inputName} see you soon :)");
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Meni Avitan";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{appName}: Version {appVersion}: by {appAuthor}");

            Console.ResetColor();
        }
        
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
