namespace GoogleMeasurementProtocol.Parameters.ContentExperiments
{
    /// <summary>
    /// This parameter specifies that this user has been exposed to a particular variation of an experiment.
    /// It should be sent in conjunction with the Experiment ID parameter.
    /// </summary>
    public class ExperimentVariant : Parameter
    {
        public ExperimentVariant(string value)
            : base(value)
        {
        }

        public override string Name => "xvar";
    }
}
