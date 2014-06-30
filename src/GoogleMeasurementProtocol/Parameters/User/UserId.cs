using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMeasurementProtocol.Parameters.User
{
    /// <summary>
    /// This is intended to be a known identifier for a user provided by the site owner/tracking library user.
    /// It may not itself be PII. The value should never be persisted in GA cookies or other Analytics provided storage.
    /// </summary>
    public class UserId : Parameter
    {
        public UserId(string value) : base(value)
        {
        }

        public override string Name
        {
            get { return "uid"; }
        }
    }
}
