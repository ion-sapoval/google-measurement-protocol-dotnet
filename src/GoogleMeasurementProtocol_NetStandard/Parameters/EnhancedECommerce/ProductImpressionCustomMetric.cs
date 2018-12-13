using System;
using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// A product-level custom metric where index is a positive integer between 0 and 200.
    /// </summary>
    public class ProductImpressionCustomMetric : Parameter
    {
       public byte ProductIndex { get; set; }

        public byte ListIndex { get; set; }

        public byte MetricIndex { get; set; }

        public ProductImpressionCustomMetric(decimal value, byte productIndex = 1, byte listIndex = 1, byte metricIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
            ListIndex = listIndex;
            MetricIndex = metricIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);
                IndexValidator.ValidateListIndex(ListIndex);
                IndexValidator.ValidateMetricIndex(MetricIndex);

                return $"il{ListIndex}pi{ProductIndex}cm{MetricIndex}";
            }
        }

        public override Type ValueType => typeof(decimal);
    }
}
