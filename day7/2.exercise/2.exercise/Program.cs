using System;

namespace _2.exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            string result;
            Console.WriteLine("input a number");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int reminder = num % 2;
                result = Convert.ToString(reminder) + result;
                num /= 2;
            }
                    result = Convert.ToString(num) +result;
                    Console.WriteLine("Binary: {0}", result);
                    Console.ReadLine();
                
            
        }
    }
}
        

