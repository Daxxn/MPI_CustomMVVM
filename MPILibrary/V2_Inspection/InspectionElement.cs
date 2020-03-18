using MPILibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary.V2_Inspection
{
    public class InspectionElement
	{
		#region - Fields & Properties
		public string Name { get; set; }
		public Category Category { get; set; }
		public InspectionResult Result { get; set; }
		public List<Results> ResultData { get; set; }
		public Measurement Measurement { get; set; }
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
