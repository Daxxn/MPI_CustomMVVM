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
        public RepairOrder RO { get; private set; }

        public FinishNewROEventArgs( RepairOrder ro)
        {
            RO = ro;
        }
    }
}
