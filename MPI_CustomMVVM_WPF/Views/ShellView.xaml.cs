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

        #region Windows
        public NewROWindow NewROWindow { get; private set; }
        #endregion

        #region Views
        //public RepairOrdersView RepairOrdersV { get; private set; }
        //public SelectedRepairOrderView SelectedRepairOrderV { get; private set; }
        #endregion

        #region ViewModels
        public ShellViewModel ShellVM { get; private set; } = new ShellViewModel();
        #endregion
        #endregion

        public ShellView( IViewModel vm )
        {
            InitializeComponent();
            DataContext = vm;
            //RepairOrdersV = new RepairOrdersView(ShellVM.RepairOrdersVM);
            //SelectedRepairOrderV = new SelectedRepairOrderView(ShellVM.SelectedRepairOrderVM);
        }

        #region Action Event handlers
        private void Save_Click( object sender, RoutedEventArgs e )
        {

        }

        private void CreateRO_Click( object sender, RoutedEventArgs e )
        {
            //NewROWindow = new NewROWindow();
            //NewROWindow.Show();
            var newRO = ViewModelFactory.BuildWindow<NewROWindow, NewROViewModel>();
            newRO.Show();
        }
        #endregion

        /// <summary>
        /// The shell view tab controller.
        /// </summary>
        /// <param name="sender">The object firing this event</param>
        /// <param name="e">Not needed.</param>
        private void MainTabControl_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            if (MainTabControl.SelectedIndex == 0)
            {
                //RepairOrder_Content_View.Content = RepairOrdersV;
                RepairOrder_Content_View.Content = ViewModelFactory.BuildRepairOrdersViewTesting();
            }
            else if (MainTabControl.SelectedIndex == 1)
            {
                SelectedRepairOrder_Content_View.Content = ViewModelFactory.BuildView<SelectedRepairOrderView, SelectedRepairOrderViewModel>();
                //ShellVM.SelectedRepairOrderVM.RepairOrder = ShellVM.RepairOrdersVM.SelectedRepairOrder;
            }
        }
    }
}
