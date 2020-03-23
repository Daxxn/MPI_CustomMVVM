using JsonControlLib;
using MPILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VINLibrary
{
    public class VinController
    {
        #region Fields & Properties
        /// <summary>
        /// OLD | Used to build the VIN Api URL.
        /// </summary>
        public static string VinApiUrl { get; } = @"https://vpic.nhtsa.dot.gov/api/vehicles/DecodeVin/";
        /// <summary>
        /// Builds the base VIN Api URL
        /// </summary>
        public static string VinApiGetUrl { get; } = @"https://vpic.nhtsa.dot.gov/api/vehicles/decodevinvalues/";
        /// <summary>
        /// The Format specification that goes on the end of the URL, after the VIN.
        /// </summary>
        public static string VINDecodeOneFormatJson { get; } = "?format=json";
        #endregion

        #region Methods
        /// <summary>
        /// Builds the API URL and Sends a request to the NHTSA Database about the requested VIN.
        /// </summary>
        /// <param name="vin">The VIN to post from the UI.</param>
        /// <returns>Returns the deserialized json data. Needs to be parsed befor actual use.</returns>
        public static async Task<VINModel> GetVinFlatAsync( string vin )
        {
            string fullUrl;

            // Building the URL
            if (!string.IsNullOrEmpty(vin))
            {
                fullUrl = $"{VinApiGetUrl}{vin}{VINDecodeOneFormatJson}";
            }
            else
            {
                throw new Exception("Vin is null or empty.");
            }

            // The response from the APIClient
            using (HttpResponseMessage response = await ApiController.ApiClient.GetAsync(fullUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Awaits the response then deserializes the data.
                    return JsonController.ConvertStringToObject<VINModel>(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<IVehicle> GetVehicleDataAsync( string vin )
        {
            string fullUrl;

            // Building the URL
            if (!string.IsNullOrEmpty(vin))
            {
                fullUrl = $"{VinApiGetUrl}{vin}{VINDecodeOneFormatJson}";
            }
            else
            {
                throw new Exception("Vin is null or empty.");
            }

            // The response from the APIClient
            using (HttpResponseMessage response = await ApiController.ApiClient.GetAsync(fullUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    // Awaits the response then deserializes the data.
                    var responseVehicle = JsonController.ConvertStringToObject<VINModel>(await response.Content.ReadAsStringAsync());
                    return VehicleResult.ParseVINModel(responseVehicle.Results[ 0 ]);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
        #endregion
    }
}
