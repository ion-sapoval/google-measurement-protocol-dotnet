using System;
using GoogleMeasurementProtocol.Requests;

namespace GoogleMeasurementProtocol.Validators
{
    public static class CompatibilityValidator
    {
        public static void Validate(RequestBase request)
        {
            foreach (var param in request.Parameters)
            {
                if (param.SupportedHitTypes != null && !param.SupportedHitTypes.Exists(h => h.Equals(request.HitType)))
                {
                    throw new ApplicationException($"Parameters of type '{param.GetType().Name}' are not supported by requests of type {request.GetType().Name}");
                }
            }
        }
    }
}
