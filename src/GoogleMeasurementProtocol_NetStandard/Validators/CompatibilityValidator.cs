using System;
using System.Collections.Generic;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Requests;

namespace GoogleMeasurementProtocol.Validators
{
    public static class CompatibilityValidator
    {
        public static void Validate(List<Parameter> parameters, RequestBase request, string hitType)
        {
            foreach (var param in parameters)
            {
                if (param.SupportedHitTypes != null && !param.SupportedHitTypes.Exists(h => h.Equals(hitType)))
                {
                    throw new ApplicationException($"Parameters of type '{param.GetType().Name}' are not supported by requests of type {request.GetType().Name}");
                }
            }
        }
    }
}
