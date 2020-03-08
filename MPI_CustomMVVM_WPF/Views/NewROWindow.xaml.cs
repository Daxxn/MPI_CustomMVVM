using MPI_CustomMVVM_WPF.EventClasses;
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
        public event EventHandler<NewRepairOrderEventArgs> CreatingRepairOrder;
        #region Views
        public NewROVehicleView NewVehicleV { get; private set; }
        public NewROOwnerView NewOwnerV { get; private set; }
        public NewRORepairView NewRepairV { get; private set; }
        #endregion
        #region ViewModels
        public NewROViewModel NewROVM { get; private set; } = new NewROViewModel();
        #endregion
        public NewROWindow( IViewModel vm )
        {
            InitializeComponent();
            DataContext = vm;
            //DataContext = NewROVM;
            //NewVehicleV = new NewROVehicleView(NewROVM.NewVehicleVM);
            //NewOwnerV = new NewROOwnerView(NewROVM.NewOwnerVM);
            //NewRepairV = new NewRORepairView(NewROVM.NewRepairVM);
        }

        private void FinishRO_Click( object sender, RoutedEventArgs e )
        {
            // Migrating to NewROVM
            CreatingRepairOrder.Invoke(this, new NewRepairOrderEventArgs(new RepairOrder()
            {
                Vehicle = NewROVM.NewVehicleVM.BuildNewVehicle(),
                VehicleOwner = NewROVM.NewOwnerVM.BuildNewOwner(),
                Repairs = NewROVM.NewRepairVM.BuildNewRepair()
            }
            ));
        }

        private void TabControl_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            if (NewROTabControl.SelectedIndex == 0)
            {
                NewRO_Vehicle_Content_View.Content = NewVehicleV;
            }
            else if (NewROTabControl.SelectedIndex == 1)
            {
                NewRo_Owner_Content_View.Content = NewOwnerV;
            }
            else if (NewROTabControl.SelectedIndex == 2)
            {
                NewRo_Repair_Content_View.Content = NewRepairV;
            }
        }
    }
}
