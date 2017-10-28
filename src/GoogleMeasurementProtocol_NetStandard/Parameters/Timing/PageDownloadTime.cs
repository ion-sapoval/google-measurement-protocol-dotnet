using System;
using System.Collections.Generic;

namespace GoogleMeasurementProtocol.Parameters.Timing
{
    /// <summary>
    /// Specifies the time it took for the page to be downloaded. The value is in milliseconds.
    /// </summary>
    public class PageDownloadTime : Parameter
    {
        public PageDownloadTime(int value)
            : base(value)
        {
        }

        public override string Name => "pdt";

        public override List<string> SupportedHitTypes => new List<string> { HitTypes.Timing };

        public override Type ValueType => typeof(int);
    }
}
