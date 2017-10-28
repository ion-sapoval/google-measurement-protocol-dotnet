using System;
using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The quantity of a product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductQuantity : Parameter
    {
        public byte ProductIndex { get; set; }

        public ProductQuantity(int value, byte productIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);

                return $"pr{ProductIndex}qt";
            }
        }

        public override Type ValueType => typeof(int);
    }
}
