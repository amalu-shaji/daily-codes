using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirement
{
    class Car
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private string _makeyear;

        public string MakeYear
        {
            get { return _makeyear; }
            set { _makeyear = value; }
        }
        private string _company;

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        private int _comfortlevel;

        public int ComfortLevel
        {
            get { return _comfortlevel; }
            set { _comfortlevel = value; }
        }
        public Car()
        {

        }
        public Car(long _id, string _name, string _model, string _makeyear, string _company, int _comfortlevel)
        {
            Id = _id;
            Name = _name;
            Model = _model;
            MakeYear = _makeyear;
            Company = _company;
            ComfortLevel = _comfortlevel;
        }
        public static Car FindCar(List<Car> carlist,long id)

        {
            if (Car.Id==id)
            {
                return Car;

            }
            return null;
        }
       }
    }

