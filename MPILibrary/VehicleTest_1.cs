using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary
{
    public class VehicleTest_1 : ModelBase, IVehicle
    {
        private string _bedType;
        public string BedType
        {
            get { return _bedType; }
            set
            {
                _bedType = value;
                OnPropertyChanged(nameof(BedType));
            }
        }
        public string _bodyClass;
        public string BodyClass
        {
            get { return _bodyClass; }
            set
            {
                _bodyClass = value;
                OnPropertyChanged(nameof(BodyClass));
            }
        }
        public string _Color;
        public string Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                OnPropertyChanged(nameof(Color));
            }
        }
        public int _CurbWeightLB;
        public int CurbWeightLB
        {
            get { return _CurbWeightLB; }
            set
            {
                _CurbWeightLB = value;
                OnPropertyChanged(nameof(CurbWeightLB));
            }
        }
        public double _DisplacementCI;
        public double DisplacementCI
        {
            get { return _DisplacementCI; }
            set
            {
                _DisplacementCI = value;
                OnPropertyChanged(nameof(DisplacementCI));
            }
        }
        public double _DisplacementL;
        public double DisplacementL
        {
            get { return _DisplacementL; }
            set
            {
                _DisplacementL = value;
                OnPropertyChanged(nameof(DisplacementL));
            }
        }
        public int _Doors;
        public int Doors
        {
            get { return _Doors; }
            set
            {
                _Doors = value;
                OnPropertyChanged(nameof(Doors));
            }
        }
        public string _DriveType;
        public string DriveType
        {
            get { return _DriveType; }
            set
            {
                _DriveType = value;
                OnPropertyChanged(nameof(DriveType));
            }
        }
        public string _EngineConfiguration;
        public string EngineConfiguration
        {
            get { return _EngineConfiguration; }
            set
            {
                _EngineConfiguration = value;
                OnPropertyChanged(nameof(EngineConfiguration));
            }
        }
        public int _EngineCylinders;
        public int EngineCylinders
        {
            get { return _EngineCylinders; }
            set
            {
                _EngineCylinders = value;
                OnPropertyChanged(nameof(EngineCylinders));
            }
        }
        public double _EngineHP;
        public double EngineHP
        {
            get { return _EngineHP; }
            set
            {
                _EngineHP = value;
                OnPropertyChanged(nameof(EngineHP));
            }
        }
        public double _EngineKW;
        public double EngineKW
        {
            get { return _EngineKW; }
            set
            {
                _EngineKW = value;
                OnPropertyChanged(nameof(EngineKW));
            }
        }
        public string _EngineModel;
        public string EngineModel
        {
            get { return _EngineModel; }
            set
            {
                _EngineModel = value;
                OnPropertyChanged(nameof(EngineModel));
            }
        }
        public int[] _ErrorCode;
        public int[] ErrorCode
        {
            get { return _ErrorCode; }
            set
            {
                _ErrorCode = value;
                OnPropertyChanged(nameof(ErrorCode));
            }
        }
        public string _FuelInjectionType;
        public string FuelInjectionType
        {
            get { return _FuelInjectionType; }
            set
            {
                _FuelInjectionType = value;
                OnPropertyChanged(nameof(FuelInjectionType));
            }
        }
        public string _FuelTypePrimary;
        public string FuelTypePrimary
        {
            get { return _FuelTypePrimary; }
            set
            {
                _FuelTypePrimary = value;
                OnPropertyChanged(nameof(FuelTypePrimary));
            }
        }
        public string _Make;
        public string Make
        {
            get { return _Make; }
            set
            {
                _Make = value;
                OnPropertyChanged(nameof(Make));
            }
        }
        public int _ManufacturerId;
        public int ManufacturerId
        {
            get { return _ManufacturerId; }
            set
            {
                _ManufacturerId = value;
                OnPropertyChanged(nameof(ManufacturerId));
            }
        }
        public string _Model;
        public string Model
        {
            get { return _Model; }
            set
            {
                _Model = value;
                OnPropertyChanged(nameof(Model));
            }
        }
        public int _ModelYear;
        public int ModelYear
        {
            get { return _ModelYear; }
            set
            {
                _ModelYear = value;
                OnPropertyChanged(nameof(ModelYear));
            }
        }
        public string _PlantCountry;
        public string PlantCountry
        {
            get { return _PlantCountry; }
            set
            {
                _PlantCountry = value;
                OnPropertyChanged(nameof(PlantCountry));
            }
        }
        public string _Series;
        public string Series
        {
            get { return _Series; }
            set
            {
                _Series = value;
                OnPropertyChanged(nameof(Series));
            }
        }
        public string _TPMS;
        public string TPMS
        {
            get { return _TPMS; }
            set
            {
                _TPMS = value;
                OnPropertyChanged(nameof(TPMS));
            }
        }
        public int _TransmissionSpeeds;
        public int TransmissionSpeeds
        {
            get { return _TransmissionSpeeds; }
            set
            {
                _TransmissionSpeeds = value;
                OnPropertyChanged(nameof(TransmissionSpeeds));
            }
        }
        public string _TransmissionStyle;
        public string TransmissionStyle
        {
            get { return _TransmissionStyle; }
            set
            {
                _TransmissionStyle = value;
                OnPropertyChanged(nameof(TransmissionStyle));
            }
        }
        public string _Trim;
        public string Trim
        {
            get { return _Trim; }
            set
            {
                _Trim = value;
                OnPropertyChanged(nameof(Trim));
            }
        }
        public string _ValveTrainDesign;
        public string ValveTrainDesign
        {
            get { return _ValveTrainDesign; }
            set
            {
                _ValveTrainDesign = value;
                OnPropertyChanged(nameof(ValveTrainDesign));
            }
        }
        public string _VehicleType;
        public string VehicleType
        {
            get { return _VehicleType; }
            set
            {
                _VehicleType = value;
                OnPropertyChanged(nameof(VehicleType));
            }
        }
        public string _VIN;
        public string VIN
        {
            get { return _VIN; }
            set
            {
                _VIN = value;
                OnPropertyChanged(nameof(VIN));
            }
        }

        public void Update( )
        {
            this.OnPropertyChanged(nameof(BodyClass));
        }
    }
}
