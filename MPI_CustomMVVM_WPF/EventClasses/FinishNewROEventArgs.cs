using MPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPI_CustomMVVM_WPF.EventClasses
{
    public class FinishNewROEventArgs : EventArgs
    {
        public IRepairOrder RO { get; private set; }

        public FinishNewROEventArgs( IRepairOrder ro)
        {
            RO = ro;
        }
    }
}
