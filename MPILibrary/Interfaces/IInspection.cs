using System.Collections.Generic;

namespace MPILibrary
{
    public interface IInspection
    {
        List<IInspectionElement> InspectionData { get; set; }
        string Name { get; set; }
    }
}