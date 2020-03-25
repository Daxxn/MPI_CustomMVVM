using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPILibrary.Interfaces;

namespace MPILibrary
{
    public class Inspection : IInspection
    {
		#region - Fields & Properties
		public string Name { get; set; }
		public List<IInspectionElement> InspectionData { get; set; }
		#endregion

		#region - Constructors
		public Inspection( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
