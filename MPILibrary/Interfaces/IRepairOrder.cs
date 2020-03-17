using System.Collections.Generic;

namespace MPILibrary
{
    public interface IRepairOrder
    {
        IInspection Inspection { get; set; }
        List<IRepair> Repairs { get; set; }
        int RONumber { get; set; }
        IVehicle Vehicle { get; set; }
        IOwner VehicleOwner { get; set; }
    }
}