using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mailfolderreqirement1
{
     class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter mail 1 details");
            string[] mail1 = Console.ReadLine().Split(',');
            Mail m1 = new Mail(long.Parse(mail1[0]), mail1[1], mail1[2], mail1[3], mail1[4], Convert.ToDateTime(mail1[5]), Convert.ToDouble(mail1[6]));
            Console.WriteLine("enter mail 2 details");
            string[] mail2 = Console.ReadLine().Split(',');
            Mail m2 = new Mail(long.Parse(mail2[0]), mail2[1], mail2[2], mail2[3], mail2[4], Convert.ToDateTime(mail2[5]), Convert.ToDouble(mail2[6]));
            Console.WriteLine("mail1:\n" + m1);
            Console.WriteLine("mail2:\n" + m2);
            if (mail1[1] == mail2[1] && mail1[2] == mail2[2] && mail1[3] == mail2[3])

            {
                Console.WriteLine("mail is same");

            }
            else
            {

                Console.WriteLine("mail is different");
            }
        }
    }
}
   
    
  
