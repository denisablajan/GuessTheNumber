using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate the random number
            Random rand = new Random();
            int randomNr = rand.Next(0, 100);

            //ask the user to guess
            Console.WriteLine("\tGuess the number! \nEnter a number: ");
            int number = int.Parse(Console.ReadLine());

            //check if the user guessed correctly
            while (randomNr != number)
            {
                if (randomNr < number)
                {
                    while (randomNr < number)
                    {
                        Console.WriteLine("The number is too big, try again: ");
                        number = int.Parse(Console.ReadLine());
                    }
                }
                else if (randomNr > number)
                {
                    while (randomNr > number)
                    {
                        Console.WriteLine("The number is too small, try again: ");
                        number = int.Parse(Console.ReadLine());
                    }
                }
            }
            if (randomNr == number)
                Console.WriteLine(" Congrats! You guessed the number! ({0})", number);
        }
    }
}
