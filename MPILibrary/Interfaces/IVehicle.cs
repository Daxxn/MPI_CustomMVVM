namespace MPILibrary
{
    public interface IVehicle
    {
        string BedType { get; set; }
        string BodyClass { get; set; }
        string Color { get; set; }
        int CurbWeightLB { get; set; }
        double DisplacementCI { get; set; }
        double DisplacementL { get; set; }
        int Doors { get; set; }
        string DriveType { get; set; }
        string EngineConfiguration { get; set; }
        int EngineCylinders { get; set; }
        double EngineHP { get; set; }
        double EngineKW { get; set; }
        string EngineModel { get; set; }
        int[] ErrorCode { get; set; }
        string FuelInjectionType { get; set; }
        string FuelTypePrimary { get; set; }
        string Make { get; set; }
        int ManufacturerId { get; set; }
        string Model { get; set; }
        int ModelYear { get; set; }
        string PlantCountry { get; set; }
        string Series { get; set; }
        string TPMS { get; set; }
        int TransmissionSpeeds { get; set; }
        string TransmissionStyle { get; set; }
        string Trim { get; set; }
        string ValveTrainDesign { get; set; }
        string VehicleType { get; set; }
        string VIN { get; set; }
    }
}