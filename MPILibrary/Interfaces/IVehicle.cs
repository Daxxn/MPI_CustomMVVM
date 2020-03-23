namespace MPILibrary
{
    public interface IVehicle
    {
        string BedType { get; set; } // Body
        string BodyClass { get; set; } // General
        string Color { get; set; }
        int CurbWeightLB { get; set; } // General
        double DisplacementCI { get; set; } // Engine
        double DisplacementL { get; set; } // Engine
        int Doors { get; set; } // Body
        string DriveType { get; set; } // Engine
        string EngineConfiguration { get; set; } // Engine
        int EngineCylinders { get; set; } // Engine
        double EngineHP { get; set; } // Engine
        double EngineKW { get; set; } // Engine
        string EngineModel { get; set; } // Engine
        int[] ErrorCode { get; set; } // Main
        string FuelInjectionType { get; set; } // Engine
        string FuelTypePrimary { get; set; } // Engine
        string Make { get; set; } // Main
        int ManufacturerId { get; set; } // General
        string Model { get; set; } // Main
        int ModelYear { get; set; } // Main
        string PlantCountry { get; set; } // General
        string Series { get; set; } // Body
        string TPMS { get; set; } // Body
        int TransmissionSpeeds { get; set; } // Trans
        string TransmissionStyle { get; set; } // Trans
        string Trim { get; set; } // Body
        string ValveTrainDesign { get; set; } // Engine
        string VehicleType { get; set; } // General
        string VIN { get; set; } // Main
    }
}