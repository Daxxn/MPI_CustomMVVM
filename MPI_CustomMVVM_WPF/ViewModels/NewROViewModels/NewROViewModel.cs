using MPI_CustomMVVM_WPF.EventClasses;
using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MPI_CustomMVVM_WPF.ViewModels
{
	public class NewROViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		public event EventHandler<FinishNewROEventArgs> FinishROEvent;
		#region Nested ViewModels
		public NewROVehicleViewModel NewVehicleVM { get; private set; }
		public NewROOwnerViewModel NewOwnerVM { get; private set; }
		public NewRORepairViewModel NewRepairVM { get; private set; }
		#endregion
		private int _newRONumber;
		#endregion

		#region - Constructors
		public NewROViewModel( )
		{
			NewVehicleVM = new NewROVehicleViewModel();
			NewOwnerVM = new NewROOwnerViewModel();
			NewRepairVM = new NewRORepairViewModel();
		}
		#endregion

		#region - Methods
		public void FinishROClick( object sender, RoutedEventArgs e )
		{
			#region Testing ONLY
			var newRO = new RepairOrder
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
				Repairs = new List<Repair>()
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
			#endregion
			#region Official
			//var newRO = new RepairOrder
			//{
			//	RONumber = NewRONumber,
			//	Vehicle = NewVehicleVM.FinalizeRO(),
			//	Repairs = NewRepairVM.FinalizeRO(),
			//	VehicleOwner = NewOwnerVM.FinalizeRO(),

			//	// Change out later!!
			//	Inspection = new Inspection(),

			//};
			#endregion

			FinishROEvent.Invoke(this, new FinishNewROEventArgs(newRO));
		}
		#endregion

		#region - Full Properties
		public int NewRONumber
		{
			get { return _newRONumber; }
			set
			{
				_newRONumber = value;
				OnPropertyChanged(nameof(NewRONumber));
			}
		}
		#endregion
	}
}
