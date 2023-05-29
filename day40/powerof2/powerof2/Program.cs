using System;
namespace powerof2
{


    class Inner
    {
        public class Private
        {
            public bool powerof2(int number)
            {
                
                if (number == 0)

                    return false;

                while (number != 1)
                {
                    if (number % 2 != 0)
                    {
                        return false;
                    }
                    number = number / 2;


                }
                return true;
            }
        }
        class Solution
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the number");
                int number = Convert.ToInt32(Console.ReadLine());

                Inner.Private innerPrivate = new Inner.Private();
                if (innerPrivate.powerof2(number))
                {
                    Console.WriteLine(number + "is power of 2");
                }
                else 
                {
                    Console.WriteLine(number+ "is not power of 2");
                }
            }
        }
    }
}
