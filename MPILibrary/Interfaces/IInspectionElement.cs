using MPILibrary.Enums;

namespace MPILibrary.Interfaces
{
    public interface IInspectionElement
    {
        InspectionCategory Category { get; set; }
        System.Int32? Measurement { get; set; }
        InspectionResult Result { get; set; }
        System.String Specs { get; set; }
        System.String Title { get; set; }
    }
}