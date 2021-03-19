using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class CalculatorImplementation
    {
        public static double realizarCalculo(double n1, double n2, string operador) {

            switch (operador){
                case "/":
                    if (n2.Equals(0)) {
                        throw new DivideByZeroException();
                    } else {
                        return n1 / n2;
                    }
                    break;
                case "*":
                    return n1 * n2;
                    break;
                case "-":
                    return n1 - n2;
                    break;
                case "+":
                    return n1 + n2;
                    break;
                default: 
                    throw new ArgumentException();
                        break;
            }
        }
    }
}
