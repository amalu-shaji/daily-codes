using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace telephone

{

    internal class Program

    {

        static void Main(string[] args)

        {

            ElectronicPhone myPhone = new ElectronicPhone();

            myPhone.Ring();

        }

        public class Telephone

        {

            protected string phonetype;

            public string Phonetype

            {

                get { return phonetype; }

                set

                {

                    if (phonetype != null)

                        phonetype = value;

                }

            }

            public Telephone()

            {

            }

            public Telephone(string Phonetype)

            {

                phonetype = Phonetype;

            }

            public void Ring()

            {

                Console.WriteLine("Ringing the {0}", phonetype);

                Console.ReadKey();

            }

        }

        public class ElectronicPhone : Telephone

        {

            public ElectronicPhone()

            {

                phonetype = "Digital";

            }

        }

    }

}







