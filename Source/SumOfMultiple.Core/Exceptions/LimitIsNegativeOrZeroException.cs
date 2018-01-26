using System;

namespace SumOfMultiple.Core.Exceptions
{
    public class LimitIsNegativeOrZeroException : Exception
    {
        public LimitIsNegativeOrZeroException()
            : base("Give limit is a negative number or zero, it must be positive number")
        {

        }
    }
}
