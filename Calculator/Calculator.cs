using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator {
        public int Add(int num1, int num2) {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2) {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2) {
            return num1 * num2;
        }

        public int? Divide(int num1, int num2) {
            if (num2 == 0) {
                Console.WriteLine("Error: Can't divide by 0.");
                return null;
            }

            return num1 / num2;
        }
    }
}

