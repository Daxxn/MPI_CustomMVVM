using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using VINLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class NewROVehicleViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		public IVehicle _newVehicle { get; private set; }
		#endregion

		#region - Constructors
		public NewROVehicleViewModel( )
		{
			NewVehicle = MPIFactory.BuildVehicle();
		}
		#endregion

		#region - Methods
		#region Event Handlers
		public async void SearchVINClick( object sender, RoutedEventArgs e )
		{
			// My VIN : WBABN53443JU29742
			// Dads VIN : KMHD84LF3HU153568
			// Jasons VIN : JHMGE8H52DC071704
			// Jasons BAD VIN : JHZGE8H52DC071704

			await Task.Run(() => MessageBox.Show("HOLD ON! Dont spam their API. The API isnt being called right now."));

			//string tempColor = NewVehicle.Color;

			//NewVehicle = await VinController.GetVehicleDataAsync(NewVehicle.VIN);
			//if (NewVehicle.ErrorCode[0] == 0)
			//{
			//	//UpdateAfterVINSearch();
			//	if (!String.IsNullOrWhiteSpace(tempColor))
			//	{
			//		NewVehicle.Color = tempColor;
			//	}
			//}
		}
		#endregion

        public IVehicle FinalizeRO(  )
		{
			return NewVehicle;
		}

		public string CleanNumberInput( string input )
		{
			string output = "";
			foreach (var n in input)
			{
				if (Char.IsDigit(n))
				{
					output += n;
				}
			}

			return output;
		}

		public string CleanVIN( string input )
		{
			string output = "";
			foreach (var c in input)
			{
				if (Char.IsDigit(c) || Char.IsLetter(c))
				{
					if (output.Length < 17)
					{
						output += c;
					}
					else
					{
						break;
					}
				}
			}
			return output;
		}
		#endregion

		#region - Full Properties
		public IVehicle NewVehicle
		{
			get { return _newVehicle; }
			set
			{
				_newVehicle = value;
				OnPropertyChanged(nameof(NewVehicle));
			}
		}
        #endregion
    }
}
