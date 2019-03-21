using System;
using System.Runtime.Serialization;

namespace HW17032019
{
    [Serializable]
    internal class CarAlredyHereException : Exception
    {
        public CarAlredyHereException()
        {
        }

        public CarAlredyHereException(string message) : base(message)
        {
        }

        public CarAlredyHereException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarAlredyHereException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}