using System;

namespace Prototype.Common.Exceptions
{
    public class PrototypeException : Exception
    {
        public string Code { get; }

        public PrototypeException()
        {
        }

        public PrototypeException(string code)
        {
            Code = code;
        }

        public PrototypeException(string message, params object[] args) : this(string.Empty, message, args)
        {
        }

        public PrototypeException(string code, string message, params object[] args) : this(null, code, message, args)
        {
        }

        public PrototypeException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public PrototypeException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }        
    }
}