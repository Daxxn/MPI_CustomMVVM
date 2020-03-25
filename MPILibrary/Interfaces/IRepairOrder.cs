using System.Collections.Generic;

namespace MPILibrary.Interfaces
{
    public interface IRepairOrder
    {
        IInspection Inspection { get; set; }
        List<IRepair> Repairs { get; set; }
        System.Int32 RONumber { get; set; }
        IVehicle Vehicle { get; set; }
        IOwner VehicleOwner { get; set; }

        void GenerateRONumber();
    }
}