using System;
using System.Runtime.Serialization;

namespace HomeWork200319
{
    [Serializable]
    public class CarNotReadyException : ApplicationException
    {
        public CarNotReadyException()
        {
        }

        public CarNotReadyException(string message) : base(message)
        {
        }

        public CarNotReadyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CarNotReadyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}