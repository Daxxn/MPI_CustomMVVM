﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary.V1_Models
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
