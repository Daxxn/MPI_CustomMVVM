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
    /// Interaction logic for NewRORepairView.xaml
    /// </summary>
    public partial class NewRORepairView : UserControl, IView
    {
        public NewRORepairView( IViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
            SetEventBindings(vm);
        }

        public void SetEventBindings( IViewModel vm )
        {
            var vmTrue = vm as NewRORepairViewModel;
            AddRepair.Click += vmTrue.AddRepair;
            DelRepair.Click += vmTrue.RemoveRepair;
            DefaultOPCBox.SelectionChanged += vmTrue.BoxSelctionChanged;
            SaveRepair.Click += vmTrue.SaveSelectedRepairClick;
        }
    }
}
