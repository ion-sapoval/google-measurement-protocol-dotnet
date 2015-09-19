using System;
using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The product's position in a list or collection. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductPosition : Parameter
    {
        public byte ProductIndex { get; set; }

        public ProductPosition(string value, byte productIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);

                return string.Format("pr{0}ps", ProductIndex);
            }
        }

        public override Type ValueType
        {
            get { return typeof(int); }
        }
    }
}
