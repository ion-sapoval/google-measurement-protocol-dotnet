using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Exceptions
{
    /// <summary>
    /// Specifies the description of an exception.
    /// </summary>
    public class ExceptionDescription : Parameter
    {
        public ExceptionDescription(string value)
            : base(value)
        {
        }

        public override string Name => "exd";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Exception };
    }
}
