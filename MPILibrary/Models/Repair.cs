using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPILibrary.Interfaces;

namespace MPILibrary
{
    public class Repair : IRepair
    {
		#region - Fields & Properties
		public static Repair[] _allRepairs;
		public int OPCode { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		#endregion

		#region - Constructors
		public Repair( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public static Repair[] AllRepairs
		{
			get { return _allRepairs; }
			set
			{
				_allRepairs = value;
			}
		}
		#endregion
	}
}
