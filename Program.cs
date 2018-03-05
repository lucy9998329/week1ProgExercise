using System;

namespace week1ProgExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();

            //Task1
            /*Console.WriteLine("Hello World!");
            Console.ReadKey();*/

            //Task2
            /*int number1 = 74;
            int number2 = 36;
            int answer = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {answer}");*/

            //Task3
            /*Console.Write("Please enter in the first number: ");
            var userInput1 = Console.ReadLine();
            int firstNumber;        
            
            if (int.TryParse(userInput1, out firstNumber))
            {
                Console.WriteLine($"The number was {firstNumber}");
            }
            else 
            {
                Console.WriteLine("Not a number. Please try again.");
            }

            Console.Write("Please enter in a second number: ");
            var userInput2 = Console.ReadLine();
            int secondNumber;

            if (int.TryParse(userInput2, out secondNumber))
            {
                Console.WriteLine($"The number was {secondNumber}");
            }
            else 
            {
                Console.WriteLine("Not a number. Please try again.");
            }
            Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber *secondNumber}");*/

            //Task4
            Console.WriteLine("Please enter in your first name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Please enter in your last name: ");
            var lastName = Console.ReadLine();
            Console.WriteLine(" Hello "+ "" + firstName + " " + lastName);
            
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            
        }
    }
}
