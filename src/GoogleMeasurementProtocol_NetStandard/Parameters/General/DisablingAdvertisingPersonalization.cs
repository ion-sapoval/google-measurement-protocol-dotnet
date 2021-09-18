using System;

namespace GoogleMeasurementProtocol.Parameters.General
{
    public class DisablingAdvertisingPersonalization : Parameter
    {
        /// <summary>
        /// Use this parameter to mark an event as disabled for advertising personalization,
        /// including for events from a property with a setting that otherwise permits ads personalization.
        /// For example, if a transaction is marked to disable advertising personalization,
        /// it won't be used when populating a remarketing audience for "past purchasers".
        /// </summary>
        public DisablingAdvertisingPersonalization(bool value) : base(value)
        {
        }

        public override string Name => "npa";

        public override Type ValueType => typeof(bool);
    }
}
    