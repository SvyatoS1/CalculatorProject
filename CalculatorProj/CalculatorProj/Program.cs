using System.Text;

namespace CalculatorProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            InputValidator validator = new InputValidator();

            Instruction();
            while (true) 
            {
                try
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine("Write the operation (+, -, *, /):");
                    string operatorInput = Console.ReadLine();

                    if (operatorInput.ToLower() == "exit") break;
                    validator.isValidOperator(operatorInput);

                    Console.WriteLine("Enter the first number:");
                    string firstNumber = Console.ReadLine();
                    validator.isValidNumber(firstNumber);

                    Console.WriteLine("Enter the second number:");
                    string secondNumber = Console.ReadLine();
                    validator.isValidNumber(secondNumber);

                    double num1 = double.Parse(firstNumber);
                    double num2 = double.Parse(secondNumber);
                    double res = calculator.Execute(operatorInput, num1, num2);

                    Console.WriteLine($"Result: {res}");
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public static void Instruction()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Console calculator");
            sb.AppendLine("=======================================");
            sb.AppendLine("First choose which operation you want to execute: +, -, *, /");
            sb.AppendLine("'+' - Addition");
            sb.AppendLine("'-' - Substraction");
            sb.AppendLine("'*' - Multiplication");
            sb.AppendLine("'/' - Division");
            sb.AppendLine("Than write first number, than second number and you`ll see result in console");
            sb.AppendLine("To exit the applcation type 'exit' to the console");
            sb.AppendLine("=======================================");
            Console.WriteLine(sb.ToString());
        }
    }
}
