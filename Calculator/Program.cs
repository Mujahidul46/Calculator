using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

// DONE: build a calculator which can do 4 operations
// DONE: isolate logic for each operation by placing it inside its own method.
// DONE: Make tests for each operation
// DONE: Make multiple tests for each operation, including negative numbers.
// DONE: Handle error of user entering letter instead of number.
// DONE: Allow operations with floats
// TODO: Refactor any computational code out? Should only be input/output and main flow of program.
// TODO: Allow user to use program again at end.

namespace CalculatorApp
{
    enum Operation
    {
        Add = 1,
        Subtract,
        Multiply,
        Divide
    }

    internal class Program // Handles input and output
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            float num1, num2;
            float? result = null;

            Console.WriteLine("Hi, I'm your calculator!\n");
            Console.WriteLine("I can add, subtract, multiply or divide numbers 2 numbers for you.\n");
            Console.WriteLine("Please follow the instructions to input the calculation you want me to solve.\n");

            do
            {
                num1 = CheckNumber("Please enter your first number.");

                Console.WriteLine("Please enter the operation. Choose from 1, 2, 3 or 4.");
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");

                if (!Enum.TryParse(Console.ReadLine(), out Operation operation))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.\n1 (+), 2 (-), 3 (*) or 4 (/).");
                    continue;
                }

                // Displaying the chosen operation symbol
                string operationSymbol = GetOperationSymbol(operation);
                Console.WriteLine("{0} {1} ?", num1, operationSymbol);

                num2 = CheckNumber("Please enter your second number.");

                // Perform the calculation
                switch (operation)
                {
                    case Operation.Add:
                        result = calculator.Add(num1, num2);
                        break;
                    case Operation.Subtract:
                        result = calculator.Subtract(num1, num2);
                        break;
                    case Operation.Multiply:
                        result = calculator.Multiply(num1, num2);
                        break;
                    case Operation.Divide:
                        result = calculator.Divide(num1, num2);
                        break;
                    default:
                        result = null;
                        break;
                }



                if (result.HasValue) {
                    Console.WriteLine("Answer: {0}", result);
                }
                else {
                    Console.WriteLine("No valid result could be computed.");
                }

                Console.WriteLine("Would you like to perform another calculation? (yes/no)");
            } while (Console.ReadLine().Trim().ToLower() == "yes");

            Console.WriteLine("That's it! Thanks for using the program!");
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }

        static float CheckNumber(string prompt)
        {
            float number = 0;
            bool inputIsValid = false;

            Console.WriteLine(prompt);

            while (!inputIsValid)
            {
                inputIsValid = float.TryParse(Console.ReadLine(), out number);
                if (!inputIsValid)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            return number;
        }

        static string GetOperationSymbol(Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return "+";
                case Operation.Subtract:
                    return "-";
                case Operation.Multiply:
                    return "*";
                case Operation.Divide:
                    return "/";
                default:
                    return "?";
            }
        }




    }


}
