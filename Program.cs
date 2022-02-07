using System;

namespace Loops_exercise6
{
    public class Program

    {
        public static void Main(string[] args)

        {
            string userInput;
            bool repeatLoop = true;

            do
            {
                Console.WriteLine("Hello World!");

                Console.Write("Do you want to continue? (yes/no): ");

                userInput = Console.ReadLine().ToLower();

                if (userInput != "y" && userInput != "yes")
                {
                    repeatLoop = false;
                    Console.WriteLine("Bye-bye");
                    break;
                }
            }
            while (repeatLoop == true);
        }
    }
}