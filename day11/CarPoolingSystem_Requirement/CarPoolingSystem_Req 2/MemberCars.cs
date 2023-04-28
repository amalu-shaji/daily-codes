using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirement
{
	class MemberCars
	{
		private long _id;

		public long Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private Member _member;

		public Member Member
		{
			get { return _member; }
			set { _member = value; }
		}
		private Car _car;

		public Car Car
		{
			get { return _car; }
			set { _car = value; }
		}
		private string _carRegistrationNumber;

		public string CarRegistrationNumber
		{
			get { return _carRegistrationNumber; }
			set { _carRegistrationNumber = value; }
		}


		private string _carColor;

		public string CarColor
		{
			get { return _carColor; }
			set { _carColor = value; }
		}
		public MemberCars()
		{
		}
		public MemberCars(long _id, Member _member, Car _car, string _carRegistrationNumber, string _carColor)
	{	
		    Id = _id;
		    Member = _member;
	        Car = _car;
			CarRegistrationNumber  = _carRegistrationNumber;
			CarColor =  _carColor;

}  


    }
}

		



	