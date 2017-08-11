using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.CustomDimensions
{
   /// <summary>
    /// Each custom dimension has an associated index.
    /// There is a maximum of 20 custom dimensions (200 for Premium accounts).
    /// The name suffix must be a positive integer between 1 and 200, inclusive.
   /// </summary>
    public class CustomDimension : Parameter
    {
         public byte DimensionIndex { get; set; }

         public CustomDimension(string value, byte dimensionIndex = 1)
            : base(value)
        {
            DimensionIndex = dimensionIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateDimensionIndex(DimensionIndex);

                return $"cd{DimensionIndex}";
            }
        }
    }
}
