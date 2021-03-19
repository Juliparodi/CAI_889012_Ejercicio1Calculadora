using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Validations
    {

        public Validations() { }

        public static List<String> operadores = new List<string>() {"+","-","*","/"};
        public static bool operatorIsOk(string operador)
        {
            return operadores.Any(operador.Contains);
        }
    }
}
