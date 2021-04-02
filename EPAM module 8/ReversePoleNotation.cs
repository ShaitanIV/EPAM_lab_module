using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_module_8
{
    static class ReversePoleNotation
    {
        public static double Count (string expression)
        {
            string[] expressionAsArray = expression.Split(" ");
            Stack<double> stack = new Stack<double>();

            if (expression == "")
                return 0;
            try
            {
                foreach (var item in expressionAsArray)
                {
                    double temp;
                    if (Double.TryParse(item, out temp))
                        stack.Enqueue(temp);
                    else if (item == "+")
                    {
                        var operand1 = stack.Dequeue();
                        var operand2 = stack.Dequeue();
                        stack.Enqueue(operand1 + operand2);
                    }
                    else if (item == "-")
                    {
                        var operand1 = stack.Dequeue();
                        var operand2 = stack.Dequeue();
                        stack.Enqueue(operand2 - operand1);
                    }
                    else if (item == "/")
                    {
                        var operand1 = stack.Dequeue();
                        var operand2 = stack.Dequeue();
                        stack.Enqueue(operand2 / operand1);
                    }
                    else if (item == "*")
                    {
                        var operand1 = stack.Dequeue();
                        var operand2 = stack.Dequeue();
                        stack.Enqueue(operand1 * operand2);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Expression is not in right format");
                return 0;
            }
            return stack.Dequeue();
        }
    }
}
