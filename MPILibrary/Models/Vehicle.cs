using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPILibrary.Interfaces;

namespace MPILibrary
{
    public class Vehicle : IVehicle
    {
		#region - Fields & Properties
		public int[] ErrorCode { get; set; }
		public string VIN { get; set; }
		public string BodyClass { get; set; }
		public string BedType { get; set; }
		public int CurbWeightLB { get; set; }
		public double DisplacementCI { get; set; }
		public double DisplacementL { get; set; }
		public int Doors { get; set; }
		public string DriveType { get; set; }
		public string EngineConfiguration { get; set; }
		public int EngineCylinders { get; set; }
		public double EngineHP { get; set; }
		public double EngineKW { get; set; }
		public string EngineModel { get; set; }
		public string Make { get; set; }
		public int ManufacturerId { get; set; }
		public string Model { get; set; }
		public int ModelYear { get; set; }
		public string PlantCountry { get; set; }
		public string Series { get; set; }
		public string Trim { get; set; }
		public string TPMS { get; set; }
		public int TransmissionSpeeds { get; set; }
		public string TransmissionStyle { get; set; }
		public string ValveTrainDesign { get; set; }
		public string VehicleType { get; set; }
		public string FuelTypePrimary { get; set; }
		public string FuelInjectionType { get; set; }
		public string Color { get; set; }
		#endregion

		#region - Constructors
		public Vehicle( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties

		#endregion
	}
}
