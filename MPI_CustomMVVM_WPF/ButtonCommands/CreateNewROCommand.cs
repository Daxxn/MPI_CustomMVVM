using MPI_CustomMVVM_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MPI_CustomMVVM_WPF.ButtonCommands
{
    /// <summary>
    /// -DEPRECIATED- Only used for example.
    /// </summary>
    public class CreateNewROCommand : ICommand
    {
        private Action<object> ExecuteMethod;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public CreateNewROCommand(Action<object> executeMethod )
        {
            ExecuteMethod = executeMethod;
        }

        public bool CanExecute( object parameter )
        {
            return true;
        }

        public void Execute( object parameter )
        {
            //var shellVm = parameter as ShellViewModel;
            //shellVm.CreateNewRepairOrder();
            ExecuteMethod(parameter);
        }
    }
}
