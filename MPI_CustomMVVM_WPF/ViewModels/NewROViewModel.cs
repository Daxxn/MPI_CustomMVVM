﻿using MPI_CustomMVVM_WPF.EventClasses;
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
			var newRO = MPIFactory.BuildRepairOrder();
			newRO.RONumber = NewRONumber;
			newRO.Vehicle = NewVehicleVM.FinalizeRO();
			newRO.Repairs = NewRepairVM.FinalizeRO();
			newRO.VehicleOwner = NewOwnerVM.FinalizeRO();

			// Change out later!!
			newRO.Inspection = MPIFactory.BuildInspection();


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
