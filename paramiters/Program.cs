using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int pizzas = AskInt("How many pizzas would you like?");
            int chips = AskInt("How many chips would you like?");
            char name = Askchar(char.Parse("what is your name"));

            // AskDouble (asks a question and returns a double)
            // AskChar (asks a question and returns just one character)
            // AskIntBetween asks the user to type in a number between a min and max value
        }

        static int AskInt(string question)
        {
            while(true)
            {
                Console.Write(question + ": ");
                try
                {
                    int value = int.Parse(Console.ReadLine());
                    return value;
                }
                catch
                {
                    Console.WriteLine("You need to enter a number");
                }
            }
        }

        // AskString (asks a question and returns a string)




        static char Askchar(char question)
        {
            while (true)
            {
                Console.Write(question + ": ");
                try
                {
                    char value = char.Parse(Console.ReadLine());
                    return value;
                }
                catch
                {
                    Console.WriteLine("You cant use a number.");
                }
            }
        }





    }
}

