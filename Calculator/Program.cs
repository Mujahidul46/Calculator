using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DONE: build a calculator which can do 4 operations
// TODO: Make tests for each operation

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
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

            Console.WriteLine("{0} {1} ? = ", num1, operationSymbol ); // Display the calculation thus far
            Console.WriteLine("Please enter your second number.");
            num2 = Convert.ToInt32(Console.ReadLine());


            if(operation == "1") // Add
            {
                result = num1 + num2;
            }
            else if (operation == "2") // Subtract
            {
                result = num1 - num2;
            }
            else if (operation == "3") // Multiply
            {
                result = num1 * num2;
            }
            else if (operation == "4")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Can't divide by 0.");
                    result = null;
                }
                else
                {
                    result = num1 / num2;
                }
            }
            else
            {
                //fill
            }

            if (result.HasValue)
            {
                Console.WriteLine("Answer: {0}", result);
            }
            else
            {
                Console.WriteLine("No valid result could be computed.");
            }
            
            Console.WriteLine("That's it! Thanks for using the program!");
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
}
