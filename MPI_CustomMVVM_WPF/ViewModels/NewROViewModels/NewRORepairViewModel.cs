using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class NewRORepairViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private ObservableCollection<IRepair> _newRepairDataList = new ObservableCollection<IRepair>();
		private ObservableCollection<IRepair> _repairOPCodes = new ObservableCollection<IRepair>();
		private IRepair _selectedOpCode;
		private IRepair _selectedRepair;
		#endregion

		#region - Constructors
		//public NewRORepairViewModel( ) { }
		public NewRORepairViewModel( )
		{
			RepairOPCodes = new ObservableCollection<IRepair>(new List<IRepair>()
			{
				MPIFactory.BuildRepair(
					10,
					"Test Repair 1",
					"This is a test of the OP code selection system."
				),
				MPIFactory.BuildRepair(
					20,
					"Test Repair 2",
					"Need to implement a json file with all the OP codes stored in it. Maybe with a setting file for the paths??"
				)
			});
		}
		#endregion

		#region - Methods
		public List<IRepair> FinalizeRO(  )
		{
			return NewRepairDataList.ToList();
		}

		private void AddRepairToList(  )
		{
			AddRepairToList(SelectedOPCode);
		}

		private void AddRepairToList( IRepair repair )
		{
			if (repair != null && !NewRepairDataList.Contains(repair))
			{
				NewRepairDataList.Add(repair);
				//SelectedOPCode = null;
			}
		}

		private void SaveRepairToList( )
		{
			SaveRepairToList(SelectedRepair);
		}

		private void SaveRepairToList( IRepair repair )
		{
			if (repair != null && !RepairOPCodes.Contains(repair))
			{
				RepairOPCodes.Add(repair);
				SelectedRepair = null;
			}
		}

		#region Event Handlers
		public void NewRepair( object sender, RoutedEventArgs e )
		{
			AddRepairToList(MPIFactory.BuildRepair());
		}

		public void AddRepair( object sender, RoutedEventArgs e )
		{
			AddRepairToList();
		}

		public void RemoveRepair( object sender, RoutedEventArgs e )
		{
			NewRepairDataList.Remove(SelectedRepair);
			SelectedRepair = NewRepairDataList.Count > 0 ? NewRepairDataList[ 0 ] : null;
			SelectedOPCode = null;
		}

		public void BoxSelctionChanged( object sender, SelectionChangedEventArgs e )
		{
			if (SelectedOPCode is null)
			{
				return;
			}
			AddRepairToList();
			SelectedRepair = SelectedOPCode;
		}

		public void SaveSelectedRepairClick( object sender, RoutedEventArgs e )
		{
			SaveRepairToList();
		}
		#endregion
		#endregion

		#region - Full Properties
		public ObservableCollection<IRepair> NewRepairDataList
		{
			get { return _newRepairDataList; }
			set
			{
				_newRepairDataList = value;
				OnPropertyChanged(nameof(NewRepairDataList));
			}
		}

		public ObservableCollection<IRepair> RepairOPCodes
		{
			get { return _repairOPCodes; }
			set
			{
				_repairOPCodes = value;
				OnPropertyChanged(nameof(RepairOPCodes));
			}
		}

		public IRepair SelectedOPCode
		{
			get { return _selectedOpCode; }
			set
			{
				_selectedOpCode = value;
				OnPropertyChanged(nameof(SelectedOPCode));
			}
		}
		public IRepair SelectedRepair
		{
			get { return _selectedRepair; }
			set
			{
				_selectedRepair = value;
				OnPropertyChanged(nameof(SelectedRepair));
			}
		}
		#endregion
	}
}
