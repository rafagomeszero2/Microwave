using System;
using System.Collections.Generic;
using System.Text;

namespace Microwave.Exceptions
{
    public class CustomExceptions : ApplicationException
    {
        public CustomExceptions(string message) : base(message)
        {

        }
    }
}
