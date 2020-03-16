﻿using MPI_CustomMVVM_WPF.Interfaces;
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
		private ObservableCollection<Repair> _newRepairDataList = new ObservableCollection<Repair>();
		private ObservableCollection<Repair> _repairOPCodes = new ObservableCollection<Repair>();
		private Repair _selectedOpCode;
		private Repair _selectedRepair;
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

		private void AddRepairToList(  )
		{
			AddRepairToList(SelectedOPCode);
		}

		private void AddRepairToList( Repair repair )
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

		private void SaveRepairToList( Repair repair )
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
			AddRepairToList(new Repair());
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
		public Repair SelectedRepair
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