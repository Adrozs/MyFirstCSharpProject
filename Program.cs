/* Adrian Rozsahegyi .NET23 */


namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variable declaration.
            int number;
            string input;
            bool isNumber;
            int failCounter = 0;


            // Asks user for input, then tries to convert user input (string) to int.
            // If it can't it re-promts user for input unil valid input (an int) is given.
            Console.Write("Enter a number: ");

            do
            {   
                input = Console.ReadLine();

                isNumber = int.TryParse(input, out number);

                // Promts user with an error message if invalid input was given.
                // (with a twist. The program desends into madness if the user continues to refuse correct input).
                if (isNumber == false)
                {
                    if (failCounter < 3)
                    {
                        Console.Write("Invalid input. Please try again: ");
                    }
                    else if (failCounter < 6)
                    {
                        Console.Write("Stop resisting, enter a number: ");
                    }
                    else if (failCounter < 12)
                    {
                        Console.Write("... ");
                    }
                    else if (failCounter == 12)
                    {
                        Console.Write("[You hear the program making a strange sound... is.. is it sobbing?]");
                    }
                    else
                    {
                        Console.Write("[crying noises]");
                    }
                    failCounter++;
                }
            
            } while (isNumber == false);  


            // Checks if user input was more than 10 and sends message depending on if it was or not.
            if(number > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            // Asks what users name is, takes input from user and prints "Hello <name>!"
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hej " + name + "!");

            // Checks if i is less than or equal to input and prints out i until it is
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine((i));
            }

        }
    }
}