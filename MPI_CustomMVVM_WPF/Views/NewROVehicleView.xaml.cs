using MPI_CustomMVVM_WPF.Interfaces;
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
    /// Interaction logic for NewROVehicleView.xaml
    /// </summary>
    public partial class NewROVehicleView : UserControl, IView
    {
        public NewROVehicleViewModel NewVehicleVM { get; private set; }
        public NewROVehicleView( IViewModel vm )
        {
            InitializeComponent();
            DataContext = vm;
            //NewVehicleVM = vm;
        }

        private void SearchVIN_Click( object sender, RoutedEventArgs e )
        {
            MessageBox.Show("VIN Decoder API not integrated yet.");
        }
    }
}
