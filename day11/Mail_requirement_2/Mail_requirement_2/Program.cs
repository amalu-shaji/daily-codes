using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_requirement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Mail> li = new List<Mail>();

            //for (int i = 0; i < 2; i++)

            //{

            // Console.WriteLine("Enter Mail{0} detail", i + 1);

            // string[] s = Console.ReadLine().Split(',');

            // Mail m = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], DateTime.ParseExact(s[5], "dd-MM-YY", null), double.Parse(s[6]));

            // li.Add(m);

            //}

            //int j = 1;

            //foreach (var item in li)

            //{

            // Console.WriteLine("mail{0}", j);

            // Console.WriteLine(item.ToString());

            // j++;

            //}

            //if (li[0].Equals(li[1]))

            //{

            // Console.WriteLine("Mail 1 is same as Mail2");

            //}

            //else

            //{

            // Console.WriteLine("Mail 1 is not same as Mail2");

            //}

            List<Mail> ls = new List<Mail>();

            Console.WriteLine("Enter the name of folder:");

            string name = Console.ReadLine();

            MailFolder mf = new MailFolder(name, ls);

            Mail m = new Mail();

            while (true)

            {

                Console.WriteLine("1.Add mail\n 2.Delete mail\n 3.Display mail\n 4.Exit");

                Console.WriteLine("Enter your choice");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)

                {

                    case 1:

                        Console.WriteLine("Enter details in CVS format:");

                        string[] s = Console.ReadLine().Split(',');

                        long _id = long.Parse(s[0]);

                        string _from = s[1];

                        string _to = s[2];

                        string _subject = s[3];

                        string _content = s[4];

                        DateTime _receivedDate = DateTime.Parse(s[5]);

                        double _size = double.Parse(s[6]);

                        Mail mail = new Mail(_id, _from, _to, _subject, _content, _receivedDate, _size);

                        mf.AddMailToFolder(mail);

                        break;

                    case 2:

                        Console.WriteLine("Enter the id of the mail to be deleted");

                        long mailId = long.Parse(Console.ReadLine());

                        mf.RemoveMailFromFolder(mailId);

                        break;

                    case 3:

                        mf.DisplayMails();

                        break;

                    case 4:

                        break;

                    default:

                        Console.WriteLine("Invalid choice");

                        break;

                }

            }

        }

    }

}




