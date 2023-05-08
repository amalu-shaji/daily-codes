using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirement
{
    class Member
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _firstname;
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        private string _lastname;
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _contactNumber;
        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }
        private string _licenceNumber; 
        public string LicenceNumber
        {
            get { return _licenceNumber; }
            set { _licenceNumber = value; }
        }
        private DateTime _licenceStarDate;
        public DateTime LicenceStarDate
        {
            get { return _licenceStarDate; }
            set { _licenceStarDate = value;}
        }
        public Member() 
        {
        }
        public Member(long _id, string _firstname,  string _lastName, string _email,  string  _contactNumber, string _licenceNumber, DateTime _licenceStarDate)
        {
            Id = _id;
            
            
            FirstName = _firstname;
            
            LastName = _lastname;

            Email = _email;
            
            ContactNumber = _contactNumber;
           
            LicenceNumber = _licenceNumber;
           
            LicenceStarDate = _licenceStarDate;
            LicenceStarDate = _licenceStarDate;
        }
    }
}
