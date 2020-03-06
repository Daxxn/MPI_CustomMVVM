using MPI_CustomMVVM_WPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class ShellViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties

		#region Nested View Models
		public RepairOrdersViewModel RepairOrdersVM { get; private set; } = new RepairOrdersViewModel();
		public SelectedRepairOrderViewModel SelectedRepairOrderVM { get; private set; } = new SelectedRepairOrderViewModel();
		#endregion

		#endregion

		#region - Constructors
		public ShellViewModel( )
		{
			#region Display Testing ONLY
			RepairOrdersVM.RepairOrderDataList = new System.Collections.ObjectModel.ObservableCollection<MPILibrary.RepairOrder>()
			{
				new MPILibrary.RepairOrder
				{
					RONumber = 123456,
					VehicleOwner = new MPILibrary.Owner
					{
						FirstName = "Cody",
						LastName = "Lantz",
						Address = new MPILibrary.Address(29940, "Brown RD.", "305", "Wilsonville", "Oregon", "US"),
						Phone = new MPILibrary.PhoneNumber(971,772,4975)
					},
					Vehicle = new MPILibrary.Vehicle
					{
						VIN = "JHMGE8H52DC071704"
					},
					Inspection = new MPILibrary.Inspection
					{
						Name = "Default",
						InspectionData = new List<MPILibrary.InspectionElement>()
						{
							new MPILibrary.InspectionElement
							{
								Title = "Inspect Headlights",
								Category = MPILibrary.Enums.InspectionCategory.Lighting,
								Measurement = null,
								Result = MPILibrary.Enums.InspectionResult.Open,
								Specs = ""
							},
							new MPILibrary.InspectionElement
							{
								Title = "Inspect Brakse",
								Category = MPILibrary.Enums.InspectionCategory.Brakes,
								Measurement = 0,
								Result = MPILibrary.Enums.InspectionResult.Open,
								Specs = "Minimum of 3mm"
							}
						}
					},
					Repairs = new List<MPILibrary.Repair>()
					{
						new MPILibrary.Repair
						{
							OPCode = 10,
							Name = "Front brake Replacement",
							Description = "Resurface Rotors, Replace Brake Pads and hardware."
						},
						new MPILibrary.Repair
						{
							OPCode = 11,
							Name = "Oil & Filter Change",
							Description = "Drain and refill engine oil, replace engine oil filter, Top off fluids."
						}
					}
				}
			}; 
			#endregion
		}
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		private ICommand _testUpdater;
		public ICommand TestCommand
		{
			get
			{
				if (_testUpdater == null)
					_testUpdater = new TestUpdater();
				return _testUpdater;
			}
			set
			{
				_testUpdater = value;
			}
		}
		#endregion
	}
}
