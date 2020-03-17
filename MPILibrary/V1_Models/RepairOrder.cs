using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary.V1_Models
{
	public class RepairOrder : IRepairOrder
	{
		#region - Fields & Properties
		public int RONumber { get; set; }
		public IOwner VehicleOwner { get; set; }
		public IVehicle Vehicle { get; set; }
		public List<IRepair> Repairs { get; set; }
		public IInspection Inspection { get; set; }
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
