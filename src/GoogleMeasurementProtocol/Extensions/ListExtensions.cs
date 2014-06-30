using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using GoogleMeasurementProtocol.Parameters;

namespace GoogleMeasurementProtocol.Extensions
{
    public static class ListExtensions
    {
        public static NameValueCollection GenerateNameValueCollection(this List<Parameter> list)
        {
            var nameValueCollection = new NameValueCollection();

            if (list == null)
            {
                return nameValueCollection;
            }

            foreach (var param in list)
            {
                switch (param.ValueType.Name)
                {
                    case "Boolean":

                        nameValueCollection[param.Name] = param.Value == null ? string.Empty : (bool)param.Value ? "1" : "0";
                        break;

                    case "Decimal":
                        nameValueCollection[param.Name] = param.Value == null ? string.Empty : Convert.ToString(param.Value, CultureInfo.InvariantCulture);
                        break;

                    default:
                        nameValueCollection[param.Name] = param.Value == null ? string.Empty : param.Value.ToString();
                        break;
                }
            }

            return nameValueCollection;
        }
    }
}
