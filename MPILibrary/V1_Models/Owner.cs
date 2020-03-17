using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary.V1_Models
{
	public class Owner : IOwner
	{
		#region - Fields & Properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public IPhoneNumber Phone { get; set; }
		public IAddress Address { get; set; }
		#endregion

		#region - Constructors
		public Owner( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}
		#endregion
	}
}
