using MPI_CustomMVVM_WPF.Interfaces;
using MPILibrary;
using VINLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MPI_CustomMVVM_WPF.ViewModels
{
    public class NewROVehicleViewModel : ViewModelBase, IViewModel
	{
		#region - Fields & Properties
		public IVehicle NewVehicle { get; private set; }

        #region Main Info
        private string _VINInput = "";
		private string _MakeInput = "";
		private string _Yearinput = "";
		private string _ModelInput = "";
		private string _ColorInput = "";
		private int[] _errorCodes;
		#endregion

		#region Extra Info
		private string _bedType = "";
		private string _bodyClass = "";
		private int _curbWeightLB = 0;
		private double _displacementCI = 0;
		private double _displacementL = 0;
		private int _doors = 0;
		private string _driveType = "";
		private string _EngineConfiguration = "";
		private int _engineCylinders = 0;
		private double _engineHP = 0;
		private double _engineKW = 0;
		private string _engineModel = "";
		private string _fuelInjectionType = "";
		private string _fuelType = "";
		private int _manufacturerID = 0;
		private string _plantCountry = "";
		private string _series = "";
		private string _TPMS = "";
		private int _transmissionSpeeds = 0;
		private string _transmissionStyle = "";
		private string _trim = "";
		private string _valveTrainDesign = "";
		private string _vehicleType = "";
		#endregion
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
			// Dads VIN : KMHD84LF3HU153568
			// Jasons VIN : JHMGE8H52DC071704
			// Jasons BAD VIN : JHZGE8H52DC071704

			//MessageBox.Show("VIN Decoder API not integrated yet.");

			//VINModel output = await VinController.GetVinFlatAsync(VINInput);
			NewVehicle = await VinController.GetVehicleDataAsync(VINInput);
			if (NewVehicle.ErrorCode[0] == 0)
			{
				UpdateAfterVINSearch();
			}
		}
		#endregion

		public void UpdateAfterVINSearch(  )
		{
			#region Main
			MakeInput = NewVehicle.Make;
			ModelInput = NewVehicle.Model;
			YearInput = $"{NewVehicle.ModelYear}";
			#endregion

			#region Extra
			#region General
			BodyClassInput = NewVehicle.BodyClass;
			CurbWeightInput = NewVehicle.CurbWeightLB;
			PlantCountryInput = NewVehicle.PlantCountry;
			VehicleTypeInput = NewVehicle.VehicleType;
			ManufacturerIDInput = NewVehicle.ManufacturerId;
			#endregion

			#region Engine
			EngineModelInput = NewVehicle.EngineModel;
			DriveTypeInput = NewVehicle.DriveType;
			DisplacementCIInput = NewVehicle.DisplacementCI;
			DisplacementLInput = NewVehicle.DisplacementL;
			EngineConfigurationInput = NewVehicle.EngineConfiguration;
			EngineCylindersInput = NewVehicle.EngineCylinders;
			EngineHPInput = NewVehicle.EngineHP;
			EngineKWInput = NewVehicle.EngineKW;
			FuelInjectionTypeInput = NewVehicle.FuelInjectionType;
			FuelTypeInput = NewVehicle.FuelTypePrimary;
			ValveTrainDesignInput = NewVehicle.ValveTrainDesign;
			#endregion

			#region Body
			SeriesInput = NewVehicle.Series;
			TrimInput = NewVehicle.Trim;
			DoorsInput = NewVehicle.Doors;
			BedTypeInput = NewVehicle.BedType;
			TPMSInput = NewVehicle.TPMS;
			#endregion

			#region Trans
			TransmissionStyleInput = NewVehicle.TransmissionStyle;
			TransmissionSpeedsInput = NewVehicle.TransmissionSpeeds;
			#endregion
			#endregion
		}

        public IVehicle FinalizeRO(  )
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
        #region Main Info
        public string VINInput
		{
			get { return _VINInput; }
			set
			{
				if (VINInput != null)
				{
					if (VINInput.Length <= 17)
					{
						_VINInput = CleanVIN(value);
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

        #region Extra Info
        public string BedTypeInput
		{
			get { return _bedType; }
			set
			{
				_bedType = value;
				OnPropertyChanged(nameof(BedTypeInput));
			}
		}

		public string BodyClassInput
		{
			get { return _bodyClass; }
			set
			{
				_bodyClass = value;
				OnPropertyChanged(nameof(BodyClassInput));
			}
		}

		public int CurbWeightInput
		{
			get { return _curbWeightLB; }
			set
			{
				_curbWeightLB = value;
				OnPropertyChanged(nameof(CurbWeightInput));
			}
		}

		public double DisplacementCIInput
		{
			get { return _displacementCI; }
			set
			{
				_displacementCI = value;
				OnPropertyChanged(nameof(DisplacementCIInput));
			}
		}

		public double DisplacementLInput
		{
			get { return _displacementL; }
			set
			{
				_displacementL = value;
				OnPropertyChanged(nameof(DisplacementLInput));
			}
		}

		public int DoorsInput
		{
			get { return _doors; }
			set
			{
				_doors = value;
				OnPropertyChanged(nameof(DoorsInput));
			}
		}

		public string DriveTypeInput
		{
			get { return _driveType; }
			set
			{
				_driveType = value;
				OnPropertyChanged(nameof(DriveTypeInput));
			}
		}

		public string EngineConfigurationInput
		{
			get { return _EngineConfiguration; }
			set
			{
				_EngineConfiguration = value;
				OnPropertyChanged(nameof(EngineConfigurationInput));
			}
		}

		public int EngineCylindersInput
		{
			get { return _engineCylinders; }
			set
			{
				_engineCylinders = value;
				OnPropertyChanged(nameof(EngineCylindersInput));
			}
		}

		public double EngineHPInput
		{
			get { return _engineHP; }
			set
			{
				_engineHP = value;
				OnPropertyChanged(nameof(EngineHPInput));
			}
		}

		public double EngineKWInput
		{
			get { return _engineKW; }
			set
			{
				_engineKW = value;
				OnPropertyChanged(nameof(EngineKWInput));
			}
		}

		public string EngineModelInput
		{
			get { return _engineModel; }
			set
			{
				_engineModel = value;
				OnPropertyChanged(nameof(EngineModelInput));
			}
		}

		public string FuelInjectionTypeInput
		{
			get { return _fuelInjectionType; }
			set
			{
				_fuelInjectionType = value;
				OnPropertyChanged(nameof(FuelInjectionTypeInput));
			}
		}

		public string FuelTypeInput
		{
			get { return _fuelType; }
			set
			{
				_fuelType = value;
				OnPropertyChanged(nameof(FuelTypeInput));
			}
		}

		public int ManufacturerIDInput
		{
			get { return _manufacturerID; }
			set
			{
				_manufacturerID = value;
				OnPropertyChanged(nameof(ManufacturerIDInput));
			}
		}

		public string PlantCountryInput
		{
			get { return _plantCountry; }
			set
			{
				_plantCountry = value;
				OnPropertyChanged(nameof(PlantCountryInput));
			}
		}

		public string SeriesInput
		{
			get { return _series; }
			set
			{
				_series = value;
				OnPropertyChanged(nameof(SeriesInput));
			}
		}

		public string TPMSInput
		{
			get { return _TPMS; }
			set
			{
				_TPMS = value;
				OnPropertyChanged(nameof(TPMSInput));
			}
		}

		public int TransmissionSpeedsInput
		{
			get { return _transmissionSpeeds; }
			set
			{
				_transmissionSpeeds = value;
				OnPropertyChanged(nameof(TransmissionSpeedsInput));
			}
		}

		public string TransmissionStyleInput
		{
			get { return _transmissionStyle; }
			set
			{
				_transmissionStyle = value;
				OnPropertyChanged(nameof(TransmissionStyleInput));
			}
		}

		public string TrimInput
		{
			get { return _trim; }
			set
			{
				_trim = value;
				OnPropertyChanged(nameof(TrimInput));
			}
		}

		public string ValveTrainDesignInput
		{
			get { return _valveTrainDesign; }
			set
			{
				_valveTrainDesign = value;
				OnPropertyChanged(nameof(ValveTrainDesignInput));
			}
		}

		public string VehicleTypeInput
		{
			get { return _vehicleType; }
			set
			{
				_vehicleType = value;
				OnPropertyChanged(nameof(VehicleTypeInput));
			}
		}
        #endregion
        #endregion
    }
}
