using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class InspectionViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		public RepairOrder _selectedRO;
		#endregion

		#region - Constructors
		public InspectionViewModel( ) { }
		#endregion

		#region - Methods
		public void UpdateRO( RepairOrder ro )
		{
			SelectedRO = ro;
		}
		#endregion

		#region - Full Properties
		public RepairOrder SelectedRO
		{
			get { return _selectedRO; }
			set
			{
				_selectedRO = value;
				OnPropertyChanged(nameof(SelectedRO));
			}
		}
		#endregion
	}
}
