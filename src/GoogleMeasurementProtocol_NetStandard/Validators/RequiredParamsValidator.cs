using System;
using System.Collections.Generic;
using GoogleMeasurementProtocol.Parameters;
using GoogleMeasurementProtocol.Parameters.General;
using GoogleMeasurementProtocol.Parameters.Hit;
using GoogleMeasurementProtocol.Parameters.User;

namespace GoogleMeasurementProtocol.Validators
{
    public static class RequiredParamsValidator
    {
        public static void Validate(List<Parameter> parameters)
        {
            if (!parameters.Exists(p => p is ProtocolVersion))
            {
                throw new ApplicationException("ProtocolVersion parameter is missing.");
            }

            if (!parameters.Exists(p => p is TrackingId))
            {
                throw new ApplicationException("TrackingId parameter is missing.");
            }

            if (!parameters.Exists(p => p is ClientId) && !parameters.Exists(p => p is UserId))
            {
                throw new ApplicationException("ClientId or UserId parameter should be present in the request.");
            }

            if (!parameters.Exists(p => p is HitType))
            {
                throw new ApplicationException("HitType parameter is missing.");
            }
        }
    }
}
