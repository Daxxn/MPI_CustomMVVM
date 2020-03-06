using MPI_CustomMVVM_WPF.ViewModels;
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

namespace MPI_CustomMVVM_WPF.Views
{
    /// <summary>
    /// Interaction logic for NewRORepairView.xaml
    /// </summary>
    public partial class NewRORepairView : UserControl
    {
        public NewRORepairViewModel NewRORepairVM { get; private set; }
        public NewRORepairView( NewRORepairViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
            NewRORepairVM = vm;
        }

        private void AddRepair_Click( object sender, RoutedEventArgs e )
        {
            NewRORepairVM.AddRepair();
        }

        private void DelRepair_Click( object sender, RoutedEventArgs e )
        {
            NewRORepairVM.RemoveRepair();
        }
    }
}
