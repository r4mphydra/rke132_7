using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first nubmer");
            int un1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second nubmer");
            int un2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an action, enter +, -, * or /");
            char uo = Convert.ToChar(Console.ReadLine());
            switch (uo)
            {
                case '+':
                    AddTwoNumbers(un1, un2);
                    break;
                case '/':
                    DivideTwoNumbers(un1, un2);
                    break;
                case '*':
                    MultyplyTwoNumbers(un1, un2);
                    break;
                case '-':
                    SubstractTwoNumbers(un1, un2);
                    break;
                default:
                    Console.WriteLine("Have a good day!");
                    break;
            }
        }
        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }
        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }
        public static void MultyplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }
        public static void SubstractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
    }
}
