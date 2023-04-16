using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure fig = null;
            Console.WriteLine("Enter 'C' for circle or 'S' for square");
            string ch=Console.ReadLine();
            if (ch == "C")
            {
                fig = new Circle();
            }
            else if(ch =="S")
            { 
                fig= new Square();
            }
            fig.Dimension = 10;
            Console.WriteLine("Area:" +fig.Area());
            Console.WriteLine("Perimeter"+fig.Perimeter());
        }
    }
    interface IFigure
    {
        int Dimension { get; set; }
        double Area();
        double Perimeter();

    }
    class Circle : IFigure
    {
        
        private int _Radius;

        public int Dimension
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
        public double Area() 
        {
            return Math.PI * _Radius;
        }
        public double Perimeter() 
        {
            return 2* Math.PI * _Radius;
        }

    }
    class Square: IFigure
    {
        private int _Side;

        public int Dimension
        {
            get { return _Side; }
            set { _Side = value; }
        }
        public double Area()
        {
            return _Side * _Side;
        }
        public double Perimeter()
        {
            return 4  * _Side;
        }
    }
}