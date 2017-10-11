using System;
using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The product's position in a list or collection.
    /// </summary>
    public class ProductImpressionPosition : Parameter
    {
       public byte ProductIndex { get; set; }

        public byte ListIndex { get; set; }

        public ProductImpressionPosition(int value, byte productIndex = 1, byte listIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
            ListIndex = listIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);
                IndexValidator.ValidateListIndex(ListIndex);

                return $"il{ListIndex}pi{ProductIndex}ps";
            }
        }

        public override Type ValueType => typeof(int);
    }
}
