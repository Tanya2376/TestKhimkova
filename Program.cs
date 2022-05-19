using System;

namespace Console_calc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double a;
            double b;
            string input2 = "";

            Console.WriteLine("Calculator");
            while (true)
            {
                
                Console.WriteLine("Введите первое число (может быть целым, либо дробным с разделителем ','), затем Enter");
                var input1 = Console.ReadLine();

                if (!Double.TryParse(input1, out a))
                {
                    Console.WriteLine("Неверное число, попробуйте снова");
                    continue;
                }

                Console.WriteLine("Введите математический оператор( + - * / ), затем Enter");
                input2 = Console.ReadLine();
                switch (input2)
                {
                    case "+":
                        break;
                    case "-":
                        break;
                    case "*":
                        break;
                    case "/":
                        break;
                    default:
                        Console.WriteLine("Неверный оператор");
                        continue;
                }

                Console.WriteLine("Calculator");
                Console.WriteLine("Введите второе число (может быть целым, либо дробным с разделителем ','), затем Enter");
                var input3 = Console.ReadLine();

                if (!Double.TryParse(input3, out b))
                {
                    Console.WriteLine("Неверное число, попробуйте снова");
                    continue;
                }
                else
                {
                    break;
                }
            }
            

            Math math = new Math();
            
            Console.WriteLine( a + " " + input2 + " " + b + " = " + math.MathResult(a, b, input2));
            Console.ReadLine();
        }
    }
}
