﻿using System;
using System.Runtime.Serialization;

namespace HW17032019
{
    [Serializable]
    internal class CarNullException : Exception
    {
        public CarNullException()
        {
        }

        public CarNullException(string message) : base(message)
        {
        }

        public CarNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}