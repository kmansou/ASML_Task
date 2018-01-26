using System;

namespace SumOfMultiple.Core.Exceptions
{
    public class GivenNumberIsZeroOrNegativeException : Exception
    {
        public GivenNumberIsZeroOrNegativeException()
            : base("Give number is a negative number or zero, it must be positive number")
        {

        }
    }
}
