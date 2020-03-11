using MPI_CustomMVVM_WPF.ButtonCommands;
using MPI_CustomMVVM_WPF.EventClasses;
using MPI_CustomMVVM_WPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MPI_CustomMVVM_WPF.ViewModels
{
	public class ShellViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private static ShellViewModel _shellInstance;
		#region Nested View Models
		public NewROViewModel NewROVM { get; set; }
		public RepairOrdersViewModel RepairOrdersVM { get; private set; }
		public SelectedRepairOrderViewModel SelectedRepairOrderVM { get; private set; }
		#endregion

		#region Events

		#endregion
		#endregion

		#region - Constructors
		public ShellViewModel( )
		{
			RepairOrdersVM = new RepairOrdersViewModel();
			SelectedRepairOrderVM = new SelectedRepairOrderViewModel();

			
		}
		#endregion

		private void NewROVM_FinishROEvent( object sender, FinishNewROEventArgs e )
		{
			RepairOrdersVM.GetNewRepairOrder(e.RO);
		}

		public void BuildEvents(  )
		{
			NewROVM.FinishROEvent += NewROVM_FinishROEvent;
		}

		#region - Methods
		public void SaveClick( object sender, RoutedEventArgs e )
		{

		}
		#endregion

		#region - Full Properties
		public static ShellViewModel ShellInstance
		{
			get
			{
				if (_shellInstance is null)
				{
					_shellInstance = new ShellViewModel();
				}
				return _shellInstance;
			}
		}
		#endregion
	}
}
