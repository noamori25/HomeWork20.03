using System;
using System.Runtime.Serialization;

namespace HomeWork200319
{
    [Serializable]
    public class VehicleAlreadyHereException : ApplicationException
    {
        public VehicleAlreadyHereException()
        {
        }

        public VehicleAlreadyHereException(string message) : base(message)
        {
        }

        public VehicleAlreadyHereException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VehicleAlreadyHereException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}