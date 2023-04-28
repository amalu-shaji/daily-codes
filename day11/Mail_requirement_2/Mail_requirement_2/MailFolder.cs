using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_requirement_2
{
    internal class MailFolder
    {
        

    private string _name;

        public string Name

        {

            get { return _name; }

            set { _name = value; }

        }

        private List<Mail> _maillist = new List<Mail>();

        public List<Mail> Maillist

        {

            get { return _maillist; }

            set { _maillist = value; }

        }

        public MailFolder()

        {

        }

        public MailFolder(string name, List<Mail> maillist)

        {

            _name = name;

            _maillist = maillist;

        }

        public void AddMailToFolder(Mail mail)

        {

            _maillist.Add(mail);

            Console.WriteLine("Mail successfully added");

        }

        public bool RemoveMailFromFolder(long id)

        {

            int count = 0;

            foreach (var item in Maillist)

            {

                if (item.Id == id)

                {

                    Maillist.Remove(item);

                    count = 1;

                    break;

                }

            }

            if (count == 1)

            {

                Console.WriteLine("Mail successfully deleted");

                return true;

            }

            else

            {

                Console.WriteLine("Mail not found in folder");

                return false;

            }

        }

        public void DisplayMails()

        {

            Console.WriteLine();

            if (_maillist.Count == 0)

            {

                Console.WriteLine("No mail to show");

            }

            else

            {

                Console.WriteLine("mails in{0}", _maillist);

            }

            Console.WriteLine("Mail in {0}\n", _maillist);

            Console.WriteLine("{0} {1,15} {2 ,15} {3,15} {6,15} ", "Id", "From", "To", "Subject", "Content", "Received Date", "size");

            foreach (Mail mail in Maillist)

            {

                Console.WriteLine(mail);

            }

        }

    }

}
   