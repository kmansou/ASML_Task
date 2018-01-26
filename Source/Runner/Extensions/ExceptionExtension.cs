using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Runner.Extensions
{
    public static class ExceptionExtension
    {
        public static bool IsSystemException(this Exception exception)
        {
            return (exception.GetType().FullName.StartsWith("System."));
        }
    }
}
