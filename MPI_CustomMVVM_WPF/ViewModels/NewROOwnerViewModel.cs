using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class NewROOwnerViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		public IOwner NewOwner { get; private set; }

		private string _FirstNameInput = "";
		private string _LastNameInput = "";
		private string _PhoneNumberInput = "";
		private string _StreetInput = "";
		private string _CityInput = "";
		private string _StateInput = "";
		private int? _ZIPInput;
		private string _CountryInput = "";
		#endregion

		#region - Constructors
		public NewROOwnerViewModel( )
		{
			NewOwner = MPIFactory.BuildOwner();
			Init();
		}
		#endregion

		#region - Methods
		public IOwner FinalizeRO(  )
		{
			return NewOwner;
		}

		public string CleanPhoneNumber( string input )
		{
			string output = "";

			foreach (var n in input)
			{
				if (Char.IsDigit(n))
				{
					output += n;
				}
				else if (n == '(' || n == ')' || n == '-' || n == ' ')
				{
					output += n;
				}
			}
			return output;
		}

		private void Init(  )
		{
			FirstNameInput = "";
			LastNameInput = "";
			PhoneNumberInput = "";
			StreetInput = "";
			CityInput = "";
			StateInput = "";
			ZIPInput = null;
			CountryInput = "";
		}
		#endregion

		#region - Full Properties
		public string FirstNameInput
		{
			get { return _FirstNameInput; }
			set
			{
				if (FirstNameInput.Length < 30)
				{
					_FirstNameInput = value;
				}
				OnPropertyChanged(nameof(FirstNameInput));
			}
		}

		public string LastNameInput
		{
			get { return _LastNameInput; }
			set
			{
				if (LastNameInput.Length < 30)
				{
					_LastNameInput = value;
				}
				OnPropertyChanged(nameof(LastNameInput));
			}
		}

		public string PhoneNumberInput
		{
			get { return _PhoneNumberInput; }
			set
			{
				_PhoneNumberInput = CleanPhoneNumber(value);
				OnPropertyChanged(nameof(PhoneNumberInput));
			}
		}

		public string StreetInput
		{
			get { return _StreetInput; }
			set
			{
				_StreetInput = value;
				OnPropertyChanged(nameof(StreetInput));
			}
		}

		public string CityInput
		{
			get { return _CityInput; }
			set
			{
				_CityInput = value;
				OnPropertyChanged(nameof(CityInput));
			}
		}

		public string StateInput
		{
			get { return _StateInput; }
			set
			{
				_StateInput = value;
				OnPropertyChanged(nameof(StateInput));
			}
		}

		public int? ZIPInput
		{
			get { return _ZIPInput; }
			set
			{
				_ZIPInput = value;
				OnPropertyChanged(nameof(ZIPInput));
			}
		}

		public string CountryInput
		{
			get { return _CountryInput; }
			set
			{
				_CountryInput = value;
				OnPropertyChanged(nameof(CountryInput));
			}
		}
		#endregion
	}
}
