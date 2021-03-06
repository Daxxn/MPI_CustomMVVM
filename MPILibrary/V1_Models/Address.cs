﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary.V1_Models
{
	public struct Address : IAddress
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
		public void ParseAddress( string input )
		{
			if (!String.IsNullOrWhiteSpace(input))
			{
				string[] streetSplit = input.Split(' ');

				if (streetSplit.Length > 2)
				{
					bool success = Int32.TryParse(streetSplit[ 0 ], out int parseOut);
					if (success)
					{
						StreetNumber = parseOut;
					}

					StreetName = streetSplit[ 1 ];
					AppartmentNumber = streetSplit[ 2 ];
				}
			}
		}
		#endregion

		#region - Full Properties
		public string FullAddress
		{
			get
			{
				return $"{StreetNumber} {StreetName} {AppartmentNumber}\n{City} {State} {Country} , {ZipCode}";
			}
		}
		#endregion
	}
}
