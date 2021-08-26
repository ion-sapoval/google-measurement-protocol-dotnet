using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using GoogleMeasurementProtocol.Parameters;

namespace GoogleMeasurementProtocol.Extensions
{
    public static class ListExtensions
    {
        public static async Task<string> GenerateQueryStringAsync(this List<Parameter> list)
        {
            if (list == null)
            {
                return string.Empty;
            }

            var paramsDictionary = new Dictionary<string, string>();

            foreach (var param in list)
            {
                
                switch (param.ValueType.Name)
                {
                    case "Boolean":

                        paramsDictionary[param.Name] = param.Value == null ? string.Empty : (bool)param.Value ? "1" : "0";
                        break;

                    case "Decimal":
                        paramsDictionary[param.Name] = param.Value == null ? string.Empty : Convert.ToString(param.Value, CultureInfo.InvariantCulture);
                        break;

                    default:
                        paramsDictionary[param.Name] = param.Value == null ? string.Empty : param.Value.ToString();
                        break;
                }
            }

            using (var formUrlEncodedContent = new FormUrlEncodedContent(paramsDictionary))
            {
                return await formUrlEncodedContent.ReadAsStringAsync();
            }
        }

        public static async Task<StringContent> GenerateStringContentAsync(this List<Parameter> list)
        {
            return new StringContent(await list.GenerateQueryStringAsync());
        }
    }
}
