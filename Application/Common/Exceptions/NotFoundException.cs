using System;

namespace Application
{
    public class NotFoundException : Exception
    {
        public NotFoundException()
            : base()
        {
        }

        public NotFoundException(string message)
            : base(message)
        {
        }

        public NotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
        public NotFoundException(string name, params object[] key)
       : base($"Entity \"{name}\" ({string.Join(", ", key)}) was not found.")
        {
        }
    }
}
