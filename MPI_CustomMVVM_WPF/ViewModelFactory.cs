using MPI_CustomMVVM_WPF.Interfaces;
using MPI_CustomMVVM_WPF.ViewModels;
using MPI_CustomMVVM_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF
{
    public static class ViewModelFactory
	{
		#region - Fields & Properties

		#endregion

		#region - Methods
		public static IView BuildShellView(  )
		{
			return new ShellView()
			{
				DataContext = new ShellViewModel()
			};
		}
		#endregion

		#region - Full Properties

		#endregion
	}
}
