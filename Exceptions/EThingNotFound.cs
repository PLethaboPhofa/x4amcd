using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace x4amcd.Exceptions
{
    public class EThingNotFound: Exception
    {
        public EThingNotFound() : base()
        {
        }

        public EThingNotFound(string? message) : base(message)
        {
        }

        public EThingNotFound(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}