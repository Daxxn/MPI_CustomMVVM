using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class NewROViewModel : ViewModelBase
	{
		#region - Fields & Properties
		#region Nested ViewModels
		public NewROVehicleViewModel NewVehicleVM { get; private set; } = new NewROVehicleViewModel();
		public NewRO_OwnerViewModel NewOwnerVM { get; private set; } = new NewRO_OwnerViewModel();
		public NewRORepairViewModel NewRepairVM { get; private set; } = new NewRORepairViewModel();
		#endregion
		private int _newRONumber;
		#endregion

		#region - Constructors
		public NewROViewModel( ) { }
		#endregion

		#region - Methods

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
