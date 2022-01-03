using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your firstname.");
            string un = Console.ReadLine();
            GetUserNameData(un);
        }
        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Your firstname is {userInput.Length} symbols long.");
            Console.WriteLine($"The first letter of your firstname is {userInput[0]}.");
            for(int i = userInput.Length -1; i>=0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
