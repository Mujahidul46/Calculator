using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DONE: build a calculator which can do 4 operations
// DONE: isolate logic for each operation by placing it inside its own method.
// TODO: Make tests for each operation
// TODO: Make multiple tests for each operation, including negative numbers.
// TODO: Handle error of user entering letter instead of number.
// TODO: Check if it can do calculations with floats.
// TODO: Refactor any computational code out? Should only be input/output and main flow of program.

namespace CalculatorApp
{
    internal class Program // Handles input and output
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int num1, num2;
            string operation;
            string operationSymbol;
            int? result = null;

            Console.WriteLine("Hi, I'm your calculator!\n");
            Console.WriteLine("I can add, subtract, multiply or divide numbers 2 numbers for you.\n");
            Console.WriteLine("Please follow the instructions to input the calculation you want me to solve.\n");

            Console.WriteLine("Please enter your first number.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the operation. Choose from 1, 2, 3 or 4.");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            operation = Console.ReadLine();

            while (operation != "1" && operation != "2" && operation != "3" && operation != "4") // While invalid input, keep asking user for valid input
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.WriteLine("Please enter the operation. Choose from 1 (+), 2 (-), 3 (*) or 4 (/).");
                operation = Console.ReadLine();
            }

            // Convert operation input (1,2,3,4) into symbol (+,-,x,/)
            if (operation == "1") { operationSymbol = "+"; }
            else if (operation == "2") { operationSymbol = "-"; }
            else if (operation == "3") { operationSymbol = "*"; }
            else if (operation == "4") { operationSymbol = "/"; }
            else { operationSymbol = null; }

            Console.WriteLine("{0} {1} ? = ", num1, operationSymbol );
            Console.WriteLine("Please enter your second number.");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Perform the calculation
            switch(operation) {
                case "1":
                    result = calculator.Add(num1, num2);
                    break;
                case "2":
                    result = calculator.Subtract(num1, num2);
                    break;
                case "3":
                    result = calculator.Multiply(num1, num2);
                    break;
                case "4":
                    result = calculator.Divide(num1, num2);
                    break;
            }


            if (result.HasValue) {
                Console.WriteLine("Answer: {0}", result);
            }
            else {
                Console.WriteLine("No valid result could be computed.");
            }
            
            Console.WriteLine("That's it! Thanks for using the program!");
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
}
