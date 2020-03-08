using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class RepairOrdersViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private ObservableCollection<RepairOrder> _repairOrderDataList;
		private RepairOrder _selectedRepairOrder;
		#endregion

		#region - Constructors
		public RepairOrdersViewModel( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		public ObservableCollection<RepairOrder> RepairOrderDataList
		{
			get { return _repairOrderDataList; }
			set
			{
				_repairOrderDataList = value;
				OnPropertyChanged(nameof(RepairOrderDataList));
			}
		}
		public RepairOrder SelectedRepairOrder
		{
			get { return _selectedRepairOrder; }
			set
			{
				_selectedRepairOrder = value;
				OnPropertyChanged(nameof(SelectedRepairOrder));
			}
		}
		#endregion
	}
}
