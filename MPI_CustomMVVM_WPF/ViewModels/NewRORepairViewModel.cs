using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class NewRORepairViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private ObservableCollection<Repair> _newRepairDataList = new ObservableCollection<Repair>();
		private ObservableCollection<Repair> _repairOPCodes = new ObservableCollection<Repair>();
		private Repair _selectedOpCode;
		#endregion

		#region - Constructors
		//public NewRORepairViewModel( ) { }
		public NewRORepairViewModel( )
		{
			RepairOPCodes = new ObservableCollection<Repair>(new List<Repair>()
			{
				new Repair()
				{
					OPCode = 10,
					Name = "Test Repair 1",
					Description = "This is a test of the OP code selection system."
				},
				new Repair()
				{
					OPCode = 20,
					Name = "Test Repair 2",
					Description = "Need to implement a json file with all the OP codes stored in it. Maybe with a setting file for the paths??"
				}
			});
		}
		#endregion

		#region - Methods
		public List<Repair> FinalizeRO(  )
		{
			return NewRepairDataList.ToList();
		}

		#region Event Handlers
		public void NewRepair( object sender, RoutedEventArgs e )
		{

		}

		public void AddRepair( object sender, RoutedEventArgs e )
		{
			if (SelectedOPCode != null && !NewRepairDataList.Contains(SelectedOPCode))
			{
				NewRepairDataList.Add(SelectedOPCode);
			}
		}

		public void RemoveRepair( object sender, RoutedEventArgs e )
		{

		}
		#endregion
		#endregion

		#region - Full Properties
		public ObservableCollection<Repair> NewRepairDataList
		{
			get { return _newRepairDataList; }
			set
			{
				_newRepairDataList = value;
				OnPropertyChanged(nameof(NewRepairDataList));
			}
		}

		public ObservableCollection<Repair> RepairOPCodes
		{
			get { return _repairOPCodes; }
			set
			{
				_repairOPCodes = value;
				OnPropertyChanged(nameof(RepairOPCodes));
			}
		}

		public Repair SelectedOPCode
		{
			get { return _selectedOpCode; }
			set
			{
				_selectedOpCode = value;
				OnPropertyChanged(nameof(SelectedOPCode));
			}
		}
		#endregion
	}
}
