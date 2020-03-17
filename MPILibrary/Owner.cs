using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary
{
    public class Owner
	{
		#region - Fields & Properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public PhoneNumber Phone { get; set; }
		public string _phoneNumberString;
		public Address Address { get; set; }
		public string EmailAddress { get; set; }
		#endregion

		#region - Constructors
		public Owner( ) { }
		#endregion

		#region - Methods
		public PhoneNumber ParsePhoneNumber( string input )
		{
			throw new NotImplementedException("Phone parsing not implemented yet.");
		}

		public void ParseStreetAddress( string input )
		{
			throw new NotImplementedException("address parsing not implemented yet.");
		}
		#endregion

		#region - Full Properties
		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

		public string PhoneNumberString
		{
			get { return _phoneNumberString; }
			set
			{
				_phoneNumberString = value;
				LastName = value;
			}
		}
		#endregion
	}
}
