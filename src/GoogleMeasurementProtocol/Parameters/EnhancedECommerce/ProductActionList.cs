namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
   /// <summary>
    /// The list or collection from which a product action occurred. This is an additional parameter that can be sent when Product Action is set to 'detail' or 'click'.
    /// For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
   /// </summary>
    public class ProductActionList : Parameter
    {
        public ProductActionList(string value)
            : base(value)
        {
        }

        public override string Name => @"pal";
    }
}
