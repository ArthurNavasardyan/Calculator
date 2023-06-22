using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MathCalculation1
{
     class Calculator
    {
        
        public double MathAction()
        {
            double rezult = 0;

            try
            {
                Console.WriteLine("Write the first number");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" select the action + , - , * , / ");
                string c = Console.ReadLine();
                Console.WriteLine("Write the second number");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b == 0)
                {
                    Console.WriteLine(" A number is not divisible by zero ");
                    return 0;
                }
                switch (c)
                {
                    case "+":
                        rezult = a + b;
                        break;
                    case "-":
                        rezult = a - b;
                        break;
                    case "*":
                        rezult = a * b;
                        break;
                    case "/":
                        rezult = a / b;
                        break;
                    default:
                        Console.WriteLine("There is no such action");
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine(" type could not be changed ");
            }
                                             
            return rezult;
        }
                   
     }
}
