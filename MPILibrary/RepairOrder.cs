using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary
{
    public class RepairOrder
	{
		#region - Fields & Properties
		public int RONumber { get; set; }
		public Owner VehicleOwner { get; set; }
		public Vehicle Vehicle { get; set; }
		public List<Repair> Repairs { get; set; }
		public Inspection Inspection { get; set; }
		#endregion

		#region - Constructors
		public RepairOrder( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
