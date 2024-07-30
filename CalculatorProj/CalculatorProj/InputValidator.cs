using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProj
{
    public class InputValidator : Calculator
    {
        public bool isValidOperator(string input)
        {
            var operation = GetOperation();
            input = input.Trim();
            if (operation.ContainsKey(input)) 
            {
                return true;
            }
            else
            {
                throw new InvalidOperationException("Unknown operator");
            }
        }

        public bool isValidNumber(string input) 
        {
            if (double.TryParse(input, out _))
            {
                return true;
            }
            else
            { 
                throw new InvalidDataException("Its not a number"); 
            }
          
        }
    }
}
