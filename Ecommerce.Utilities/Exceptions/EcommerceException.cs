using System;

namespace Ecommerce.Utilities.Exceptions
{
    public class EcommerceException : Exception
    {
        public EcommerceException()
        {
        }

        public EcommerceException(string message)
            : base(message)
        {
        }

        public EcommerceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}