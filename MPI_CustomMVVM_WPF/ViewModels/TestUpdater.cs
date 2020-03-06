using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class TestUpdater : ICommand
    {
        //public event EventHandler CanExecuteChanged;

        public bool CanExecute( object parameter )
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute( object parameter )
        {
            MessageBox.Show("Test Command");
        }
    }
}
