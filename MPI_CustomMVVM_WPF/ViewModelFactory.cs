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
				RepairOrderDataList = new System.Collections.ObjectModel.ObservableCollection<MPILibrary.IRepairOrder>()
				{
					MPILibrary.MPIFactory.BuildTest_A()
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

        #region Keep for future study.
        /// <summary>
        /// -DEPRECIATED-
        /// Doesnt work. The view doesnt connect with the view model and doesnt display properly.
        /// I think the problem is the "partial class" nature of XAML views. Dependency Injection would probably be the only way around this.
        /// </summary>
        public static IView BuildView<TView, TViewModel>(  ) where TView : IView
		{
			var ctor = typeof(TView).GetConstructor(new Type[] { typeof(TViewModel) });
			var param = typeof(TViewModel).GetConstructor(Type.EmptyTypes).Invoke(null);
			return (IView)ctor.Invoke(new object[]{ (TViewModel)param});
		}

		/// <summary>
		/// -DEPRECIATED-
		/// Kinda works. I just dont trust it enough. Same problem as the BuildView Method.
		/// </summary>
		public static IWindowView BuildWindow<TWindowView, TViewModel>( ) where TWindowView : IWindowView
		{
			var ctor = typeof(TWindowView).GetConstructor(new Type[] { typeof(TViewModel) });
			var param = typeof(TViewModel).GetConstructor(Type.EmptyTypes).Invoke(null);
			return (IWindowView)ctor.Invoke(new object[] { (TViewModel)param });
		}
        #endregion
        #endregion

        #region - Full Properties

        #endregion
    }
}
