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
            string name = Askstring("what is your name");
            string[] choise = new string[] { "Margherita", "Pepperoni", "Pinaple" };

            // AskDouble (asks a question and returns a double)
            // AskChar (asks a question and returns just one character)
            // AskIntBetween asks the user to type in a number between a min and max value
        }

        static void main(string[] args)
        {
            string[] choise = new string[] { "Margherita", "Pepperoni", "Pinaple" };
            string mypizza = choosefrom(choise);
            Console.WriteLine(mypizza);
        }
        static string choosefrom(string[] options)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine((1 + 1) + ") " + options[i]);
            }
            Console.Write("make a choise");
            string selection = Console.ReadLine();





        
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
        static string Askstring(string question)
        {
            while (true)
            {
                Console.Write(question + ": ");
                try
                {
                    string value = (Console.ReadLine());
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

