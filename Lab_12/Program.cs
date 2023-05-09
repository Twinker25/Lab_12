using System;
using System.Xml.Serialization;

namespace Lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, n1, n2, n3, number;
            do
            {
                Console.Write("Enter task (1 - 5) or Calculator (6): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        Task1_2<double> max = new Task1_2<double>();
                        Console.Write("Enter number 1: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 3: ");
                        n3 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Max number: {max.Max(n1, n2, n3)}");
                        break;
                    case 2:
                        Task1_2<double> min = new Task1_2<double>();
                        Console.Write("Enter number 1: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        n2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 3: ");
                        n3 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Min number: {min.Min(n1, n2, n3)}");
                        break;
                    case 3:
                        Task3<int> taskInt = new Task3<int>();
                        Console.Write("Enter size of array: ");
                        int size = int.Parse(Console.ReadLine());
                        int[] array = new int[size];
                        Random rand = new Random();
                        for(int i = 0; i < array.Length; i++)
                        {
                            array[i] = rand.Next(-9, 10);
                            Console.Write(array[i] + " ");
                        }
                        int sum = taskInt.SumArray(array);
                        Console.WriteLine("\nSum of element array: " + sum);
                        break;
                    case 4:
                        Stack<int> stack = new Stack<int>();
                        while (true)
                        {
                            Console.Write("\n1 - Push\n2 - Pop\n3 - Peek\n4 - Count\n0 - Exit\nEnter choice: ");
                            int ch = int.Parse(Console.ReadLine());
                            switch (ch)
                            {
                                case 1:
                                    Console.Write("Enter number: ");
                                    number = int.Parse(Console.ReadLine());
                                    stack.Push(number);
                                    break;
                                case 2:
                                    stack.Pop();
                                    break;
                                case 3:
                                    int peek = stack.Peek();
                                    Console.WriteLine("Peek of stack: " + peek);
                                    break;
                                case 4:
                                    int count = stack.Count;
                                    Console.WriteLine("Count of stack: " + count);
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Error!");
                                    break;
                            }
                        }
                        break;
                    case 5:
                        Queue<int> queue = new Queue<int>();
                        while (true)
                        {
                            Console.Write("\n1 - Enqueue\n2 - Dequeue\n3 - Peek\n4 - Count\n0 - Exit\nEnter choice: ");
                            int ch = int.Parse(Console.ReadLine());
                            switch (ch)
                            {
                                case 1:
                                    Console.Write("Enter number: ");
                                    number = int.Parse(Console.ReadLine());
                                    queue.Enqueue(number);
                                    break;
                                case 2:
                                    queue.Dequeue();
                                    break;
                                case 3:
                                    int peek = queue.Peek();
                                    Console.WriteLine("Peek of stack: " + peek);
                                    break;
                                case 4:
                                    int count = queue.Count;
                                    Console.WriteLine("Count of stack: " + count);
                                    break;
                                case 0:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Error!");
                                    break;
                            }
                        }
                        break;
                    case 6:
                        Calculator<double> calculator = new Calculator<double>();
                        Console.Write("Enter number 1: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{num1} + {num2} = {calculator.Add(num1, num2)}");
                        Console.WriteLine($"{num1} - {num2} = {calculator.Sub(num1, num2)}");
                        Console.WriteLine($"{num1} * {num2} = {calculator.Mult(num1, num2)}");
                        Console.WriteLine($"{num1} / {num2} = {calculator.Div(num1, num2)}");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (choice < 1 || choice > 5);
        }
    }
}