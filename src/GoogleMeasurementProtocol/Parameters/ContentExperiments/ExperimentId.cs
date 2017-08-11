namespace GoogleMeasurementProtocol.Parameters.ContentExperiments
{
   /// <summary>
    /// This parameter specifies that this user has been exposed to an experiment with the given ID.
    /// It should be sent in conjunction with the Experiment Variant parameter.
   /// </summary>
    public class ExperimentId : Parameter
    {
        public ExperimentId(string value)
            : base(value)
        {
        }

        public override string Name => "xid";
    }
}
