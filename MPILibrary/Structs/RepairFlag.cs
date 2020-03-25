using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary
{
    public struct RepairFlag
    {
        public static List<RepairFlag> AllFlags { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }

        public RepairFlag( string name, int id )
        {
            Name = name;
            ID = id;
        }
    }
}
