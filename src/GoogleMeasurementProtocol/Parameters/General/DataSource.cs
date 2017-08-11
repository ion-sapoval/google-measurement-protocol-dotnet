namespace GoogleMeasurementProtocol.Parameters.General
{
    /// <summary>
    /// Indicates the data source of the hit. Hits sent from analytics.js will have data source set to 'web'; 
    /// hits sent from one of the mobile SDKs will have data source set to 'app'.
    /// </summary>
    public class DataSource : Parameter
    {
        public DataSource(string value): base(value)
        {
        }

        public override string Name => "ds";
    }
}
