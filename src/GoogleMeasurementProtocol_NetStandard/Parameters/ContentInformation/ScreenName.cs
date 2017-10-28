namespace GoogleMeasurementProtocol.Parameters.ContentInformation
{
    /// <summary>
    /// If not specified, this will default to the unique URL of the page by either using the &dl parameter as-is
    /// or assembling it from &dh and &dp. App tracking makes use of this for the 'Screen Name' of the screenview hit.
    /// </summary>
    public class ScreenName : Parameter
    {
        public ScreenName(string value) : base(value)
        {
        }

        public override string Name => "cd";
    }
}
