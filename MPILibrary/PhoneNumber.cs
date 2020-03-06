using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary
{
    public struct PhoneNumber
    {
        public int CountryCode { get; set; }
        public int AreaCode { get; set; }
        public int Exchange { get; set; }
        public int LocalNumber { get; set; }

        public PhoneNumber( int country, int areaCode, int exchange, int local )
        {
            CountryCode = country;
            AreaCode = areaCode;
            Exchange = exchange;
            LocalNumber = local;
        }

        public PhoneNumber( int areaCode, int exchange, int local )
        {
            CountryCode = 1;
            AreaCode = areaCode;
            Exchange = exchange;
            LocalNumber = local;
        }
    }
}
