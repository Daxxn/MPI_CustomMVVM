using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPILibrary.Interfaces;

namespace MPILibrary
{
    public class RepairOrder : IRepairOrder
    {
        #region - Fields & Properties
        public static int ROCount { get; set; } = 0;
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
        public void GenerateRONumber()
        {
            int output = 0;
            var now = DateTime.Now;
            output = now.DayOfYear * 1000;
            ROCount++;
            output += ROCount;

            RONumber = output;
        }
		#endregion

		#region - Full Properties

		#endregion
	}
}
