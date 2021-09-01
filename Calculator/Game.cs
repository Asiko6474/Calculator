using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        bool validInput = false;
        // Allows 2 numbers to be added together
        void CalculateAddition(float number1, float number2)
        {
            Console.Write("The answer is: ");
            Console.WriteLine(number1 + number2);
        }
        //Allows 2 numbers to be subtracted
        void CalculateSubtraction(float number1, float number2)
        {
            Console.Write("The answer is: ");
            Console.WriteLine(number1 - number2);
        }
        void CalculateDivision(float number1, float number2)
        {
            Console.Write("The answer is: ");
            Console.WriteLine(number1 / number2);
        }
        //Allows 2 numbers to be multiplied
        void CalculateMultiplication (float number1, float number2)
        {
            Console.Write("The answer is: ");
            Console.WriteLine(number1 * number2);
        }
        //holds the entire calculator
        void Calculator()
        {

            Console.WriteLine("Are you (1) adding, (2) subtracting, (3) dividing, or (4) multiplying?");

            while (validInput == false)
            {
                string input = Console.ReadLine();
                float value1;
                float value2;
                //Adds the numbers
                if (input == "1")
                {

                    // Reads the first number for addition
                    Console.WriteLine("Enter the first number");
                    string number1 = Console.ReadLine();
                    Single.TryParse(number1, out value1);

                    // reads the second number for addition
                    Console.WriteLine("Enter the second number");
                    string number2 = Console.ReadLine();
                    Single.TryParse(number2, out value2);

                    CalculateAddition(value1, value2);
                    Console.ReadKey();
                    Console.Clear();
                    validInput = true;
                }

                // subtracts the numbers
                else if (input == "2")
                {
                    // Reads the first number for addition
                    Console.WriteLine("Enter the first number");
                    string number1 = Console.ReadLine();
                    Single.TryParse(number1, out value1);

                    // reads the second number for addition
                    Console.WriteLine("Enter the second number");
                    string number2 = Console.ReadLine();
                    Single.TryParse(number2, out value2);

                    CalculateSubtraction(value1, value2);
                    Console.ReadKey();
                    Console.Clear();
                    validInput = true;
                }
                // divides the numbers
                else if (input == "3")
                {
                    // Reads the first number for addition
                    Console.WriteLine("Enter the first number");
                    string number1 = Console.ReadLine();
                    Single.TryParse(number1, out value1);

                    // reads the second number for addition
                    Console.WriteLine("Enter the second number");
                    string number2 = Console.ReadLine();
                    Single.TryParse(number2, out value2);

                    CalculateDivision(value1, value2);
                    Console.ReadKey();
                    Console.Clear();
                    validInput = true;
                }
                //multiplies the numbers
                else if (input == "4")
                {
                    // Reads the first number for addition
                    Console.WriteLine("Enter the first number");
                    string number1 = Console.ReadLine();
                    Single.TryParse(number1, out value1);

                    // reads the second number for addition
                    Console.WriteLine("Enter the second number");
                    string number2 = Console.ReadLine();
                    Single.TryParse(number2, out value2);

                    CalculateMultiplication(value1, value2);
                    Console.ReadKey();
                    Console.Clear();
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Error: this is not an option");
                }
            }
        }
        public void Run()
        {
            Calculator();
            Console.WriteLine("if you want to keep going, type 'yes' to continue.");
            String answer;
            answer = Console.ReadLine();
            if (answer == "yes" || answer == "Yes")
            {
                validInput = false;
                Calculator();
                Console.ReadLine();
            }
        }
    }
}
