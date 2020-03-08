using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class NewROVehicleViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		public Vehicle NewVehicle { get; private set; }

		private string _VINInput;
		private string _MakeInput;
		private string _Yearinput;
		private string _ModelInput;
		private string _ColorInput;
		#endregion

		#region - Constructors
		public NewROVehicleViewModel( ) { }
		#endregion

		#region - Methods
		public Vehicle BuildNewVehicle(  )
		{
			NewVehicle.VIN = VINInput;
			NewVehicle.Make = MakeInput;
			Int32.TryParse(YearInput, out int yearParse);
			NewVehicle.ModelYear = yearParse;
			NewVehicle.Model = ModelInput;
			NewVehicle.Color = ColorInput;

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
		#endregion

		#region - Full Properties
		public string VINInput
		{
			get { return _VINInput; }
			set
			{
				if (VINInput != null)
				{
					if (VINInput.Length <= 17)
					{
						_VINInput = value;
					} 
				}
				OnPropertyChanged(nameof(VINInput));
			}
		}

		public string MakeInput
		{
			get { return _MakeInput; }
			set
			{
				_MakeInput = value;
				OnPropertyChanged(nameof(MakeInput));
			}
		}

		public string YearInput
		{
			get { return _Yearinput; }
			set
			{
				_Yearinput = CleanNumberInput(value);
				OnPropertyChanged(nameof(YearInput));
			}
		}

		public string ModelInput
		{
			get { return _ModelInput; }
			set
			{
				_ModelInput = value;
				OnPropertyChanged(nameof(ModelInput));
			}
		}

		public string ColorInput
		{
			get { return _ColorInput; }
			set
			{
				_ColorInput = value;
				OnPropertyChanged(nameof(ColorInput));
			}
		}
		#endregion
	}
}
