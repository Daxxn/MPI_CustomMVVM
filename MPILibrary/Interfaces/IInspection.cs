using System.Collections.Generic;

namespace MPILibrary.Interfaces
{
    public interface IInspection
    {
        List<IInspectionElement> InspectionData { get; set; }
        System.String Name { get; set; }
    }
}