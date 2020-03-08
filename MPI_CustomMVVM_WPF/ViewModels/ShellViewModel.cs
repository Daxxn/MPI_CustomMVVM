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

		#region Commands
		#endregion

		#endregion

		#region - Constructors
		public ShellViewModel( ) { }
		#endregion

		#region - Methods

		#endregion

		#region - Full Properties
		#endregion
	}
}
