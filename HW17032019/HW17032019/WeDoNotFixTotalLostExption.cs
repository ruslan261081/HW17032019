using System;
using System.Runtime.Serialization;

namespace HW17032019
{
    [Serializable]
    internal class WeDoNotFixTotalLostExption : Exception
    {
        public WeDoNotFixTotalLostExption()
        {
        }

        public WeDoNotFixTotalLostExption(string message) : base(message)
        {
        }

        public WeDoNotFixTotalLostExption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeDoNotFixTotalLostExption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}