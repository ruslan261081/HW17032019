﻿using System;
using System.Runtime.Serialization;

namespace HW17032019
{
    [Serializable]
    internal class WrongGarageException : Exception
    {
        public WrongGarageException()
        {
        }

        public WrongGarageException(string message) : base(message)
        {
        }

        public WrongGarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}