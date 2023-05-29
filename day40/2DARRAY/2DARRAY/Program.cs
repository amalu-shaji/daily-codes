using System;

using System.Collections.Generic;

using System.Diagnostics.CodeAnalysis;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Challenge5

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int[][] a = new int[6][];

            for (int i = 0; i < 6; i++)

            {

                a[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            }

            int max_sum = 0;

            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    int sum = (a[i][j] + a[i][j + 1] + a[i][j + 2]) +

                      (a[i + 1][j + 1]) +

                      (a[i + 2][j] + a[i + 2][j + 1] + a[i + 2][j + 2]);

                    if (sum > max_sum)

                    {

                        max_sum = sum;

                    }

                }

            }



            Console.WriteLine(max_sum);





        }

    }

}
