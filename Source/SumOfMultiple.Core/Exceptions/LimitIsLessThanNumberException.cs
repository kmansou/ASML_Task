using System;

namespace SumOfMultiple.Core.Exceptions
{
    public class LimitIsLessThanNumberException : Exception
    {
        public LimitIsLessThanNumberException(int num)
            : base("Given limit number is less than or equal " + num.ToString())
        {

        }
    }
}
