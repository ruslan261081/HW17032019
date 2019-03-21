using System;
using System.Runtime.Serialization;

namespace HW17032019
{
    [Serializable]
    internal class CarNotReadyExcption : Exception
    {
        public CarNotReadyExcption()
        {
        }

        public CarNotReadyExcption(string message) : base(message)
        {
        }

        public CarNotReadyExcption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNotReadyExcption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}