using MPILibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary.V1_Models
{
	public class InspectionElement : IInspectionElement
	{
		#region - Fields & Properties
		public string Title { get; set; }
		public InspectionCategory Category { get; set; }
		public InspectionResult Result { get; set; }
		public int? Measurement { get; set; }
		public string Specs { get; set; }
		#endregion

		#region - Constructors
		public InspectionElement( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
