using System;

namespace GoogleMeasurementProtocol.Parameters.Session
{
   /// <summary>
    /// Used to control the session duration.
    /// A value of 'start' forces a new session to start with this hit and 'end' forces the current session to end with this hit. All other values are ignored.
   /// </summary>
    public class SessionControl : Parameter
    {
        public SessionControl(string value): base(value)
        {
            if (value != "start" && value != "end")
            {
                throw new ArgumentException("Possible values are 'start' and 'end' .","value");
            }
        }

        public override string Name => "sc";
    }
}
