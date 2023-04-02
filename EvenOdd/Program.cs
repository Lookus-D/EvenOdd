using System;

namespace EvenOdd
{
    class Program
    { 
    static void Main(string[] args)
        {
            Console.WriteLine("Let's check the number you choose is even or odd!");
            Console.WriteLine("Choose your number, please.");
            
            string number = Console.ReadLine();
            
            int chosenNumber;
            
            Int32.TryParse(number, out chosenNumber);

            if(chosenNumber %2 == 0) 
            {
                Console.WriteLine($"Your number \"{number}\" is even");
            }
            else
            {
                Console.WriteLine($"Your number \"{number}\" is odd");
            }
        }
    }
}
