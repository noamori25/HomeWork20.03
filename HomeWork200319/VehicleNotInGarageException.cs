using System;
using System.Runtime.Serialization;

namespace HomeWork200319
{
    [Serializable]
    public class VehicleNotInGarageException : ApplicationException
    {
        public VehicleNotInGarageException()
        {
        }

        public VehicleNotInGarageException(string message) : base(message)
        {
        }

        public VehicleNotInGarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VehicleNotInGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}