using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace telephone_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone myphone = new ElectronicPhone();
            myphone.Ring();
        }
    }
  
        public class Telephone
        {
            protected string phonetype;
            public string Phonetype {
            get { return phonetype; }
            set{ if (phonetype != null) phonetype value; }

            public void Ring()
            {
                Console.WriteLine($"Ringing the{phonetype}.");
            }
        }
    public class ElectronicPhone : Telephone 
        { 
            public ElectronicPhone()
            {
                phonetype = "Digital";

            }
       }
    public class Program
        {
            public static void Main()
            {
                ElectronicPhone myPhone = new ElectronicPhone();
            }
        }
    }


