using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary
{
    public struct Address
	{
		#region - Fields & Properties
		public int StreetNumber { get; set; }
		public string StreetName { get; set; }
		public string AppartmentNumber { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public int ZipCode { get; set; }
		public string Country { get; set; }
		#endregion

		#region - Constructors
		public Address( int streetNumber, string streetName, string appartmentNumber, string city, string state, string country )
		{
			StreetNumber = streetNumber;
			StreetName = streetName;
			AppartmentNumber = appartmentNumber;
			City = city;
			State = state;
			ZipCode = 0;
			Country = country;
		}

		public Address( int streetNumber, string streetName, string appartmentNumber, string city, string state, int zipCode, string country )
		{
			StreetNumber = streetNumber;
			StreetName = streetName;
			AppartmentNumber = appartmentNumber;
			City = city;
			State = state;
			ZipCode = zipCode;
			Country = country;
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
