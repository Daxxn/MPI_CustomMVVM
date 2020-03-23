using MPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VINLibrary
{
    public class VehicleResult : ModelBase, IVehicle
    {
		public string BedType { get; set; }
		public string BodyClass { get; set; }
		public string Color { get; set; }
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
		public int[] ErrorCode { get; set; }
		public string FuelInjectionType { get; set; }
		public string FuelTypePrimary { get; set; }
		public string Make { get; set; }
		public int ManufacturerId { get; set; }
		public string Model { get; set; }
		public int ModelYear { get; set; }
		public string PlantCountry { get; set; }
		public string Series { get; set; }
		public string TPMS { get; set; }
		public int TransmissionSpeeds { get; set; }
		public string TransmissionStyle { get; set; }
		public string Trim { get; set; }
		public string ValveTrainDesign { get; set; }
		public string VehicleType { get; set; }
		public string VIN { get; set; }


		/// <summary>
		/// Parses the VIN Model data into a Vehicle Model
		/// </summary>
		/// <typeparam name="T">ONLY VehicleModel, just trying to get around a bug. need to fix later.</typeparam>
		/// <param name="vinData">VINResultModel from the list of results</param>
		/// <returns>Returns a complete VehicleModel with parsed numbers.</returns>
		public static IVehicle ParseVINModel( VINResultModel vinData )
		{
            //IVehicle output = new VehicleResult();
            IVehicle output = MPIFactory.BuildVehicle();

			var vehicleProps = output.GetType().GetProperties();
			var vinProps = vinData.GetType().GetProperties();

			foreach (var vinProp in vinProps)
			{
				foreach (var vehicleProp in vehicleProps)
				{
					if (vinProp.Name == vehicleProp.Name)
					{
						if (vehicleProp.PropertyType == typeof(String))
						{
							output.GetType().GetProperty(vehicleProp.Name).SetValue(output, vinProp.GetValue(vinData));
						}
						else if (vehicleProp.PropertyType == typeof(Int32))
						{
							bool success = Int32.TryParse((string)vinProp.GetValue(vinData), out int intOut);

							if (success)
							{
								vehicleProp.SetValue(output, intOut);
							}
						}
						else if (vehicleProp.PropertyType == typeof(Double))
						{
							bool success = Double.TryParse((string)vinProp.GetValue(vinData), out double doubleOut);

							if (success)
							{
								vehicleProp.SetValue(output, doubleOut);
							}
						}
						else if (vehicleProp.PropertyType == typeof(Int32[]))
						{
							vehicleProp.SetValue(output, ParseErrorCode((string)vinProp.GetValue(vinData)));
						}
						break;
					}
				}
			}

			return output;
		}

		public static int[] ParseErrorCode( string input )
		{
			if (input.Length > 1)
			{
				List<int> output = new List<int>();
				string[] splitOut = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (var num in splitOut)
				{
					bool success = Int32.TryParse(num, out int parseOut);
					output.Add(parseOut);
				}
				return output.ToArray();
			}
			else
			{
				Int32.TryParse(input[ 0 ].ToString(), out int parseOut);
				return new int[] { parseOut };
			}
		}
	}
}
