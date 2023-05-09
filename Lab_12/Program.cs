using System.Xml.Serialization;

namespace Lab_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator<double> calculator = new Calculator<double>();

            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {calculator.Add(num1, num2)}");
            Console.WriteLine($"{num1} - {num2} = {calculator.Sub(num1, num2)}");
            Console.WriteLine($"{num1} * {num2} = {calculator.Mult(num1, num2)}");
            Console.WriteLine($"{num1} / {num2} = {calculator.Div(num1, num2)}");
        }
    }
}