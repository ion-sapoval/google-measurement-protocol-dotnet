using System;

namespace GoogleMeasurementProtocol.Parameters.General
{
    /// <summary>
    /// Used to collect offline / latent hits. The value represents the time delta (in milliseconds) between when the hit
    /// being reported occurred and the time the hit was sent. The value must be greater than or equal to 0. Values greater
    ///  than four hours may lead to hits not being processed.
    /// </summary>
    public class QueueTime:Parameter
    {
        public QueueTime(int value) : base(value)
        {
        }

        public override string Name => "qt";

        public override Type ValueType => typeof(int);
    }
}
