using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static calculator.Calculator;

namespace calculator
{
    public class Calculator
    {
        public static float Total { get; set; } = 0;

        static void Main(string[] args)
        {

            bool endApp = false;
            Console.WriteLine("Калькулятор");
            while (!endApp)

            {
                Console.WriteLine("----------------------------------");
                Queue<float> num = new Queue<float>();
                Console.WriteLine("");
                Console.WriteLine("Введите первое число:");
                num.Enqueue(Convert.ToSingle(Console.ReadLine()));


                Console.WriteLine("Введите второе число");
                num.Enqueue(Convert.ToSingle(Console.ReadLine()));

                Console.WriteLine("Выберите операцию:\n + Сложение\n - Вычитание\n * Умножение\n / Деление");
                switch (Console.ReadLine())
                {
                    case "+":
                        OperationSum.Operation(num);
                        Console.WriteLine($"Ответ: {Total}");
                        Console.WriteLine("");
                        break;

                    case "-":
                        OperationMinus.Operation(num);
                        Console.WriteLine($"Ответ: {Total}");
                        Console.WriteLine("");
                        break;

                    case "*":
                        OperationMult.Operation(num);

                        Console.WriteLine($"Ответ: {Total}");
                        Console.WriteLine("");
                        break;

                    case "/":
                        OperationDivision.Operation(num);
                        Console.WriteLine($"Ответ: {Total}");
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("Введена неверная операция, повторите попытку");
                        break;

                }
                GC.Collect(1, GCCollectionMode.Forced);

            }


        }



        public class OperationSum
        {
            public static float Operation(Queue<float> num) => Total = num.Dequeue() + num.Peek();

        }

        public class OperationMinus : OperationSum
        {
            public static new float Operation(Queue<float> num) => Total = num.Dequeue() - num.Peek();

        }

        public class OperationMult : OperationSum
        {
            public static new float Operation(Queue<float> num) => Total = num.Dequeue() * num.Peek();

        }

        public class OperationDivision : OperationSum
        {
            public static new float Operation(Queue<float> num) => Total = num.Dequeue() / num.Peek();

        }
    }



}
