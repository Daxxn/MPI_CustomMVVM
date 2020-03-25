using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPILibrary.Interfaces;

namespace MPILibrary
{
    public static class RepairOrderFactory
    {
        public static IRepair BuildRepair()
        {
            return new Repair();
        }
    }
}
