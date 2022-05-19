using System;

namespace Console_calc
{
    public class Math
    {
        public double MathResult(double a, double b, string oper)
        {
            double result;
            switch (oper)
            {
                case "+":
                    result = a + b;
                    return result;
                case "-":
                    result = a - b;
                    return result;
                case "*":
                    result = a * b;
                    return result;
                case "/":
                    result = a / b;
                    return result;
                default:
                    Console.WriteLine("неверный оператор");
                    return 0;
            }
        }

    }
}
