using System;
using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.CustomDimensions
{
   /// <summary>
    /// Each custom metric has an associated index.
    /// There is a maximum of 20 custom metrics (200 for Premium accounts).
    /// The name suffix must be a positive integer between 1 and 200, inclusive.
   /// </summary>
    public class CustomMetric : Parameter
    {
        public byte MetricIndex { get; set; }

        public CustomMetric(int value, byte metricIndex = 1)
            : base(value)
        {
            MetricIndex = metricIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateMetricIndex(MetricIndex);

                return string.Format("cm{0}", MetricIndex);
            }
        }

       public override Type ValueType
       {
           get { return typeof (int); }
       }
    }
}
