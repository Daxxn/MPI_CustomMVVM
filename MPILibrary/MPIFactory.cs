﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPILibrary.V1_Models;

namespace MPILibrary
{
	public static class MPIFactory
	{
		public static IAddress BuildAddress(  )
		{
			return new Address();
		}

		public static IInspection BuildInspection(  )
		{
			return new Inspection();
		}

		public static IInspectionElement BuildInspectionElement(  )
		{
			return new InspectionElement();
		}

		public static IOwner BuildOwner(  )
		{
			return new Owner();
		}

		public static IPhoneNumber BuildPhoneNumber(  )
		{
			return new PhoneNumber();
		}

		public static IRepair BuildRepair(  )
		{
			return new Repair();
		}

		public static IRepair BuildRepair( int opcode, string name, string desc )
		{
			return new Repair()
			{
				OPCode = opcode,
				Name = name,
				Description = desc
			};
		}

		public static IRepairFlag BuildRepairFlag(  )
		{
			return new RepairFlag();
		}

		public static IRepairOrder BuildRepairOrder( )
		{
			return new RepairOrder();
		}

		public static IVehicle BuildVehicle( )
		{
			return new Vehicle();
		}

		#region Testing Builds
		public static IRepairOrder BuildTest_A( )
		{
			return new RepairOrder
			{
				RONumber = 123456,
				VehicleOwner = new Owner
				{
					FirstName = "Cody",
					LastName = "Lantz",
					Address = new Address(29940, "Brown RD.", "305", "Wilsonville", "Oregon", "US"),
					Phone = new PhoneNumber(971, 772, 4975)
				},
				Vehicle = new Vehicle
				{
					VIN = "JHMGE8H52DC071704"
				},
				Inspection = new Inspection
				{
					Name = "Default",
					InspectionData = new List<IInspectionElement>()
					{
						new InspectionElement
						{
							Title = "Inspect Headlights",
							Category = MPILibrary.Enums.InspectionCategory.Lighting,
							Measurement = null,
							Result = MPILibrary.Enums.InspectionResult.Open,
							Specs = ""
						},
						new InspectionElement
						{
							Title = "Inspect Brakse",
							Category = MPILibrary.Enums.InspectionCategory.Brakes,
							Measurement = 0,
							Result = MPILibrary.Enums.InspectionResult.Open,
							Specs = "Minimum of 3mm"
						}
					}
				},
				Repairs = new List<IRepair>()
				{
					new Repair
					{
						OPCode = 10,
						Name = "Front brake Replacement",
						Description = "Resurface Rotors, Replace Brake Pads and hardware."
					},
					new Repair
					{
						OPCode = 11,
						Name = "Oil & Filter Change",
						Description = "Drain and refill engine oil, replace engine oil filter, Top off fluids."
					}
				}
			};
		}

		public static IRepairOrder BuildTest_B(  )
		{
			return new RepairOrder()
			{
				RONumber = 123456,
				Vehicle = new Vehicle()
				{
					VIN = "WBABN53443JU29742",
					Make = "BMW",
					Model = "330Ci",
					ModelYear = 2003,
					Doors = 2,
					Color = "Red",
					TransmissionSpeeds = 5,
					TransmissionStyle = "Manual"
				},
				VehicleOwner = new Owner
				{
					FirstName = "Cody",
					LastName = "Lantz",
					Phone = new PhoneNumber(971, 772, 4975),
					Address = new Address(29940, "sw Brown Rd", "#305", "Wilsonville", "Oregon", 97070, "USA"),
					EmailAddress = "nynjalantz@gmail.com"
				},
				Repairs = new List<IRepair>()
				{
					new Repair()
					{
						Name = "Replace Left Inner Tierod",
						Description = "Remove and replace Left side inner tierod and boot.",
						OPCode = 110
					},
					new Repair()
					{
						Name = "Replace Right Inner Tierod",
						Description = "Remove and replace Left side inner tierod and boot.",
						OPCode = 111
					},
					new Repair()
					{
						Name = "Perform Four Wheel Alignment",
						Description = "Perform four wheel alignment and testdrive vehicle.",
						OPCode = 10
					}
				},
				Inspection = new Inspection()
			};
		}
		#endregion
		}
}
