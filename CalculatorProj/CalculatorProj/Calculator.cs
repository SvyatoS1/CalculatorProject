using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProj
{
    public class Calculator
    {
        private readonly Dictionary<string, Func<double, double, double>> _operations;

        public Calculator()
        {
            _operations = new Dictionary<string, Func<double, double, double>>
           {
               {"+", (a,b) => a + b },
               {"-", (a,b) => a - b },
               {"*", (a,b) => a * b },
               {"/", (a,b) =>
                    {
                        if (b == 0) throw new DivideByZeroException("Can`t divide by zero");
                        return a / b;
                    }
               }
           };
        }

        public double Execute(string operation, double num1, double num2) {
            if (_operations.ContainsKey(operation))
            {
                return _operations[operation](num1, num2);
            }
            else 
            {
                throw new InvalidOperationException("Unknown operation");
            } 
        }
        
        protected Dictionary<string, Func<double, double, double>> GetOperation()
        {
            return _operations;
        }
    }
}
