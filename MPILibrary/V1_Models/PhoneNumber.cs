using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary.V1_Models
{
    public struct PhoneNumber : IPhoneNumber
    {
        public string PhoneNumberString { get; set; }
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
            PhoneNumberString = $"{country} - ({areaCode}) - {exchange} - {local}";
        }

        public PhoneNumber( int areaCode, int exchange, int local )
        {
            CountryCode = 1;
            AreaCode = areaCode;
            Exchange = exchange;
            LocalNumber = local;
            PhoneNumberString = $"({areaCode}) {exchange} - {local}";
        }

        public string NumberDisplay
        {
            get
            {
                string temp = CountryCode == 1 ? "" : $"{CountryCode} - ";
                return $"{temp}( {AreaCode} ) - {Exchange} - {LocalNumber}";
            }
        }
    }
}
