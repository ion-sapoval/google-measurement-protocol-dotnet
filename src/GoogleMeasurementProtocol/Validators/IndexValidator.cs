using System;

namespace GoogleMeasurementProtocol.Validators
{
    internal static class IndexValidator
    {
        public static void ValidateProductIndex(byte index)
        {
            if (index < 1 || index > 200)
            {
                throw new ApplicationException("Product index must be a positive integer between 1 and 200, inclusive.");
            }
        }

        public static void ValidateDimensionIndex(byte index)
        {
            if (index < 1 || index > 200)
            {
                throw new ApplicationException("Dimension index must be a positive integer between 1 and 200, inclusive.");
            }
        }

        public static void ValidateMetricIndex(byte index)
        {
            if (index < 1 || index > 200)
            {
                throw new ApplicationException("Metric index must be a positive integer between 1 and 200, inclusive.");
            }
        }

        public static void ValidateListIndex(byte index)
        {
            if (index < 1 || index > 200)
            {
                throw new ApplicationException("List index must be a positive integer between 1 and 200, inclusive.");
            }
        }

        public static void ValidatePromotionIndex(byte index)
        {
            if (index < 1 || index > 200)
            {
                throw new ApplicationException("Promotion index must be a positive integer between 1 and 200, inclusive.");
            }
        }

        public static void ValidateContentGroupIndex(byte index)
        {
            if (index < 1 || index > 5)
            {
                throw new ApplicationException("Group index must be a positive integer between 1 and 5, inclusive.");
            }
        }
    }
}
