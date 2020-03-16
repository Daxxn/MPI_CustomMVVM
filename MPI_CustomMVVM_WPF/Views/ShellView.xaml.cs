using MPI_CustomMVVM_WPF.Interfaces;
using MPI_CustomMVVM_WPF.ViewModels;
using MPI_CustomMVVM_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MPI_CustomMVVM_WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class ShellView : Window, IWindowView
	{
		#region Fields & Properties
		private int CurrentTabIndex = -1;
		#endregion

		public ShellView( IViewModel vm )
		{
			InitializeComponent();
			DataContext = vm;
			SetEventBindings(vm);
		}

		public void SetEventBindings( IViewModel vm )
		{
			var viewModel = vm as ShellViewModel;
			SaveButton.Click += viewModel.SaveClick;
		}

		#region Action Event handlers
		//  These need to stay here because they activate a view.
		private void CreateRO_Click( object sender, RoutedEventArgs e )
		{
			var vm = DataContext as ShellViewModel;
			vm.NewROVM = new NewROViewModel();
			var newRO = ViewModelFactory.BuildNewROWindow(vm.NewROVM);
			vm.BuildEvents();
			newRO.Show();
		}

		/// <summary>
		/// The shell view tab controller.
		/// </summary>
		/// <param name="sender">The object firing this event</param>
		/// <param name="e">Not used for what Im doing.</param>
		private void MainTabControl_SelectionChanged( object sender, SelectionChangedEventArgs e )
		{
			if (MainTabControl.SelectedIndex != CurrentTabIndex)
			{
				if (MainTabControl.SelectedIndex == 0)
				{
					RepairOrder_Content_View.Content = ViewModelFactory.BuildRepairOrdersView(ShellViewModel.ShellInstance.RepairOrdersVM);
				}
				else if (MainTabControl.SelectedIndex == 1)
				{
					SelectedRepairOrder_Content_View.Content = ViewModelFactory.BuildSelectedRepairOrderView(ShellViewModel.ShellInstance.SelectedRepairOrderVM);
				}
				else if (MainTabControl.SelectedIndex == 2)
				{
					Inspection_Content_View.Content = ViewModelFactory.BuildInspectionView(ShellViewModel.ShellInstance.InspectionVM);
				}
				ShellViewModel.ShellInstance.SelectedTab(MainTabControl.SelectedIndex);
			}
			CurrentTabIndex = MainTabControl.SelectedIndex;
		}
		#endregion
	}
}
