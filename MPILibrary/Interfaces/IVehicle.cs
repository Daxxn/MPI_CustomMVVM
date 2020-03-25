namespace MPILibrary.Interfaces
{
    public interface IVehicle
    {
        System.String BedType { get; set; }
        System.String BodyClass { get; set; }
        System.String Color { get; set; }
        System.Int32 CurbWeightLB { get; set; }
        System.Double DisplacementCI { get; set; }
        System.Double DisplacementL { get; set; }
        System.Int32 Doors { get; set; }
        System.String DriveType { get; set; }
        System.String EngineConfiguration { get; set; }
        System.Int32 EngineCylinders { get; set; }
        System.Double EngineHP { get; set; }
        System.Double EngineKW { get; set; }
        System.String EngineModel { get; set; }
        System.Int32[] ErrorCode { get; set; }
        System.String FuelInjectionType { get; set; }
        System.String FuelTypePrimary { get; set; }
        System.String Make { get; set; }
        System.Int32 ManufacturerId { get; set; }
        System.String Model { get; set; }
        System.Int32 ModelYear { get; set; }
        System.String PlantCountry { get; set; }
        System.String Series { get; set; }
        System.String TPMS { get; set; }
        System.Int32 TransmissionSpeeds { get; set; }
        System.String TransmissionStyle { get; set; }
        System.String Trim { get; set; }
        System.String ValveTrainDesign { get; set; }
        System.String VehicleType { get; set; }
        System.String VIN { get; set; }
    }
}