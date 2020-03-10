using MPI_CustomMVVM_WPF.Interfaces;
using MPI_CustomMVVM_WPF.ViewModels;
using MPILibrary;
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
using System.Windows.Shapes;

namespace MPI_CustomMVVM_WPF.Views
{
    /// <summary>
    /// Interaction logic for NewROWindow.xaml
    /// </summary>
    public partial class NewROWindow : Window, IWindowView
    {
        #region Fields / Properties
        private int currentTabIndex = -1;
        #endregion
        public NewROWindow( IViewModel vm )
        {
            InitializeComponent();
            DataContext = vm;

            SetEventBindings(vm);
        }

        public void SetEventBindings( IViewModel vm )
        {
            var vmTest = vm as NewROViewModel;
            FinishRO.Click += vmTest.FinishROClick;
        }

        private void TabControl_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            if (NewROTabControl.SelectedIndex != currentTabIndex)
            {
                var vm = DataContext as NewROViewModel;
                if (NewROTabControl.SelectedIndex == 0)
                {
                    NewRO_Vehicle_Content_View.Content = ViewModelFactory.BuildNewROVehicleView(vm.NewVehicleVM);
                }
                else if (NewROTabControl.SelectedIndex == 1)
                {
                    NewRo_Owner_Content_View.Content = ViewModelFactory.BuildNewROOwnerView(vm.NewOwnerVM);
                }
                else if (NewROTabControl.SelectedIndex == 2)
                {
                    NewRo_Repair_Content_View.Content = ViewModelFactory.BuildNewRORepairView(vm.NewRepairVM);
                }
            }
            currentTabIndex = NewROTabControl.SelectedIndex;
        }
    }
}
