﻿using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class SelectedRepairOrderViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		private IRepairOrder _selectedRepairOrder;
		#endregion

		#region - Constructors
		public SelectedRepairOrderViewModel( ) { }
		#endregion

		#region - Methods
		public void UpdateRO( IRepairOrder ro )
		{
			SelectedRepairOrder = ro;
		}
		#endregion

		#region - Full Properties
		public IRepairOrder SelectedRepairOrder
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
