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
    /// Interaction logic for NewROOwnerView.xaml
    /// </summary>
    public partial class NewROOwnerView : UserControl, IView
    {
        public NewRO_OwnerViewModel NewOwnerVM { get; set; }
        public NewROOwnerView( IViewModel vm )
        {
            InitializeComponent();
            DataContext = vm;
            //NewOwnerVM = vm;
        }
    }
}
