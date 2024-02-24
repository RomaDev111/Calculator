using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Operations
    {
        public static double Add(double num1, double num2)
        { 
            return num1 + num2;
        }

        public static double Substract(double num1, double num2) 
        {
            return num1 - num2;       
        }

        public static double Multiply (double num1, double num2)
        {
            return num1 * num2; 
        }

        public static double Divide (double num1, double num2)
        {
            if (num2 == 0) 
            {
                Console.WriteLine( "Error:Division by zero.");
                return double.NaN;
            }
            return num1 / num2; 
        }


    }
}
