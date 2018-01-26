using System;

namespace SequenceAnalysis.Core.Exceptions
{
    public class GivenStringIsEmpty : Exception
    {
        public GivenStringIsEmpty()
            : base("Given statement is empty")
        {

        }
    }
}
