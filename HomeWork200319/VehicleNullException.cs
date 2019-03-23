using System;
using System.Runtime.Serialization;

namespace HomeWork200319
{
    [Serializable]
    public class VehicleNullException : ApplicationException
    {
        public VehicleNullException()
        {
        }

        public VehicleNullException(string message) : base(message)
        {
        }

        public VehicleNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VehicleNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}