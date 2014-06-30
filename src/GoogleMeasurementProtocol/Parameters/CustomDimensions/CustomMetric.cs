using System;

namespace GoogleMeasurementProtocol.Parameters.CustomDimensions
{
   /// <summary>
    /// Each custom metric has an associated index.
    /// There is a maximum of 20 custom metrics (200 for Premium accounts).
    /// The name suffix must be a positive integer between 1 and 200, inclusive.
   /// </summary>
    public class CustomMetric : Parameter
    {
        public CustomMetric(int value)
            : base(value)
        {
        }

        public override string Name
        {
            get { return "cm[1-9][0-9]*"; }
        }

       public override Type ValueType
       {
           get { return typeof (int); }
       }
    }
}
