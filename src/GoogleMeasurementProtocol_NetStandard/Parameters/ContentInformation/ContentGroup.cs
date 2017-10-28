using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.ContentInformation
{
    public class ContentGroup : Parameter
    {
        public byte GroupIndex { get; set; }

        public ContentGroup(string value, byte groupIndex = 1) : base(value)
        {
            GroupIndex = groupIndex;
            Value = FormatValue(Value as string);
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateContentGroupIndex(GroupIndex);

                return $"cg{GroupIndex}";
            }
        }

        private string FormatValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            return value.Replace("\\\\", "\\").Trim('\\');
        }
    }
}
