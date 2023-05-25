using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace sample

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter the student type:");

            string Studenttype = Console.ReadLine();

            Console.WriteLine("Enter the tution fee:");

            float TutionFee = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the bus fee:");

            float BusFee = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hostel fee:");

            float HostelFee = float.Parse(Console.ReadLine());

            if (Studenttype == "MSDS")

            {

                double Fee1 = TutionFee + BusFee;

                Console.WriteLine("The fees to be paid by the student is " +string.Format("{0:0.00}", Fee1));

            }

            else if (Studenttype == "MSH")

            {

                double Fee2 = TutionFee + HostelFee;

                Console.WriteLine("The fees to be paid by the student is " + string.Format("{0:0.00}", Fee2));

            }

            else if (Studenttype == "MGSDS")

            {

                double Fee3 = 1.5 * TutionFee + BusFee;

                Console.WriteLine("The fees to be paid by the student is " + string.Format("{0:0.00}", Fee3));

            }

            else if (Studenttype == "MGSH")

            {

                double Fee4 = 1.5 * TutionFee + HostelFee;

                Console.WriteLine("The fees to be paid by the student is " + string.Format("{0:0.00}", Fee4));

            }

        }

    }

}