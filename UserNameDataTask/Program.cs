using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your firstname.");
            string un = Console.ReadLine();
            Console.WriteLine("Choose an action, enter 1-3");
            char uo = Convert.ToChar(Console.ReadLine());
            switch (uo)
            {
                case '1':
                    Console.WriteLine($"Your firstname is {un.Length} symbols long.");
                    break;
                case '2':
                    Console.WriteLine($"The first letter of your firstname is {un[0]}.");
                    break;
                case '3':
                    for (int i = un.Length - 1; i >= 0; i--)
                    {
                        Console.Write(un[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Have a good day!");
                    break;
            }

        }
    }
}



