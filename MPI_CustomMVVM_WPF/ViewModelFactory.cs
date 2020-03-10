using MPI_CustomMVVM_WPF.Interfaces;
using MPI_CustomMVVM_WPF.ViewModels;
using MPI_CustomMVVM_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF
{
    public static class ViewModelFactory
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static IWindowView BuildShellWindow(  )
		{
			return new ShellView(new ShellViewModel());
		}

		public static IWindowView BuildShellWindow( IViewModel vm )
		{
			return new ShellView(vm);
		}

		public static IWindowView BuildNewROWindow( )
		{
			return new NewROWindow(new NewROViewModel());
		}

		public static IWindowView BuildNewROWindow( IViewModel vm )
		{
			return new NewROWindow(vm);
		}

		public static IView BuildRepairOrdersView(  )
		{
			return new RepairOrdersView(new RepairOrdersViewModel());
		}

		public static IView BuildRepairOrdersView( IViewModel vm )
		{
			return new RepairOrdersView(vm);
		}

		public static IView BuildRepairOrdersViewTesting(  )
		{
			return new RepairOrdersView(new RepairOrdersViewModel()
			{
				RepairOrderDataList = new System.Collections.ObjectModel.ObservableCollection<MPILibrary.RepairOrder>()
				{
					new MPILibrary.RepairOrder
					{
						RONumber = 123456,
						VehicleOwner = new MPILibrary.Owner
						{
							FirstName = "Cody",
							LastName = "Lantz",
							Address = new MPILibrary.Address(29940, "Brown RD.", "305", "Wilsonville", "Oregon", "US"),
							Phone = new MPILibrary.PhoneNumber(971,772,4975)
						},
						Vehicle = new MPILibrary.Vehicle
						{
							VIN = "JHMGE8H52DC071704"
						},
						Inspection = new MPILibrary.Inspection
						{
							Name = "Default",
							InspectionData = new List<MPILibrary.InspectionElement>()
							{
								new MPILibrary.InspectionElement
								{
									Title = "Inspect Headlights",
									Category = MPILibrary.Enums.InspectionCategory.Lighting,
									Measurement = null,
									Result = MPILibrary.Enums.InspectionResult.Open,
									Specs = ""
								},
								new MPILibrary.InspectionElement
								{
									Title = "Inspect Brakse",
									Category = MPILibrary.Enums.InspectionCategory.Brakes,
									Measurement = 0,
									Result = MPILibrary.Enums.InspectionResult.Open,
									Specs = "Minimum of 3mm"
								}
							}
						},
						Repairs = new List<MPILibrary.Repair>()
						{
							new MPILibrary.Repair
							{
								OPCode = 10,
								Name = "Front brake Replacement",
								Description = "Resurface Rotors, Replace Brake Pads and hardware."
							},
							new MPILibrary.Repair
							{
								OPCode = 11,
								Name = "Oil & Filter Change",
								Description = "Drain and refill engine oil, replace engine oil filter, Top off fluids."
							}
						}
					}
				}
			});
		}

		public static IView BuildSelectedRepairOrderView(  )
		{
			return new SelectedRepairOrderView(new SelectedRepairOrderViewModel());
		}

		public static IView BuildSelectedRepairOrderView( IViewModel vm )
		{
			return new SelectedRepairOrderView(vm);
		}

		public static IView BuildNewROOwnerView( )
		{
			return new NewROOwnerView(new NewROOwnerViewModel());
		}

		public static IView BuildNewROOwnerView( IViewModel vm )
		{
			return new NewROOwnerView(vm);
		}

		public static IView BuildNewROVehicleView( )
		{
			return new NewROVehicleView(new NewROVehicleViewModel());
		}

		public static IView BuildNewROVehicleView( IViewModel vm )
		{
			return new NewROVehicleView(vm);
		}

		public static IView BuildNewRORepairView( )
		{
			return new NewRORepairView(new NewRORepairViewModel());
		}

		public static IView BuildNewRORepairView( IViewModel vm)
		{
			return new NewRORepairView(vm);
		}

		/// <summary>
		/// -DEPRECIATED-
		/// Doesnt work. The view doesnt connect with the view model and doesnt display properly.
		/// </summary>
		/// <typeparam name="TView"></typeparam>
		/// <typeparam name="TViewModel"></typeparam>
		/// <returns></returns>
		public static IView BuildView<TView, TViewModel>(  ) where TView : IView
		{
			var ctor = typeof(TView).GetConstructor(new Type[] { typeof(TViewModel) });
			var param = typeof(TViewModel).GetConstructor(Type.EmptyTypes).Invoke(null);
			return (IView)ctor.Invoke(new object[]{ (TViewModel)param});
		}

		/// <summary>
		/// -DEPRECIATED-
		/// Kinda works. I just dont trust it enough.
		/// </summary>
		/// <typeparam name="TWindowView"></typeparam>
		/// <typeparam name="TViewModel"></typeparam>
		/// <returns></returns>
		public static IWindowView BuildWindow<TWindowView, TViewModel>( ) where TWindowView : IWindowView
		{
			var ctor = typeof(TWindowView).GetConstructor(new Type[] { typeof(TViewModel) });
			var param = typeof(TViewModel).GetConstructor(Type.EmptyTypes).Invoke(null);
			return (IWindowView)ctor.Invoke(new object[] { (TViewModel)param });
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
