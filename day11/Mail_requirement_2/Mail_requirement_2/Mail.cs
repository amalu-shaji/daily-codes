using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_requirement_2
{
   internal class Mail

        {

            private long _id;

            public long Id

            {

                get { return _id; }

                set { _id = value; }

            }

            private string _to;

            public string To

            {

                get { return _to; }

                set { _to = value; }

            }

            private string _from;

            public string From

            {

                get { return _from; }

                set { _from = value; }

            }

            private string _subject;

            public string Subject

            {

                get

                { return _subject; }

                set { _subject = value; }

            }

            private string _content;

            public string Content

            {

                get { return _content; }

                set { _content = value; }

            }

            private DateTime _receivedDate;

            public DateTime ReceivedDate

            {

                get { return _receivedDate; }

                set { _receivedDate = value; }

            }

            private double _size;

            public double Size

            {

                get { return _size; }

                set { _size = value; }

            }

            public Mail()

            {

            }

            public Mail(long id, string to, string from, string subject, string content, DateTime receivedDate, double size)

            {

                _id = id;

                _to = to;

                _from = from;

                _subject = subject;

                _content = content;

                _receivedDate = receivedDate;

                _size = size;

            }

            // public override string ToString()

            // {

            // return string.Format("Id:{0}\n To:{1}\n Subject:{3}\nContent:{4}\n ReceivedDate:{5]\n Size:{6}\n", Id, To, Subject, Content, ReceivedDate.ToString("dd-MM-YYY", null), Size.ToString("0.0"));

            //}

            //public override bool Equals(object obj)

            //public override bool Equals(object obj)

            //{

            // Mail m1 = obj as Mail;

            // if (m1.To == To && m1.From == From && m1.Subject == Subject)

            // return true;

            // else return false;

            //}

            //public override int GetHashCode()

            //{

            // return base.GetHashCode();

            //}

            public static Mail CreateMail(string detail)

            {

                string[] md = detail.Split(',');

                DateTime dt = DateTime.ParseExact(md[5], "dd-mm-yyy", null);

                Mail m1 = new Mail(long.Parse(md[0]), md[1], md[2], md[3], md[4], dt, double.Parse(md[6]));

                return m1;

            }

            public override string ToString()

            {

                return String.Format("{0} {1,15} {2,15} {3,15} {4,15} {5,15:dd-mm-yyy}{6,15:0.0}", Id, From, To, Subject, Content, ReceivedDate, Size);

            }

        }

    }









