using MPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF.EventClasses
{
    public class NewRepairOrderEventArgs : EventArgs
	{
		#region - Fields & Properties
		public RepairOrder RO { get; set; }
		#endregion

		#region - Constructors
		public NewRepairOrderEventArgs( RepairOrder ro )
		{
			RO = ro;
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
