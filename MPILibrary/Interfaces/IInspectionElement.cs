using MPILibrary.Enums;

namespace MPILibrary
{
    public interface IInspectionElement
    {
        InspectionCategory Category { get; set; }
        int? Measurement { get; set; }
        InspectionResult Result { get; set; }
        string Specs { get; set; }
        string Title { get; set; }
    }
}