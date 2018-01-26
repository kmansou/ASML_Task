using SumOfMultiple.Core;

namespace ASML_Task.UnitTests.Helpers
{
    internal class SumOfMultiplesHelper : ISumOfMultiplesOfThreeAndFive
    {
        public decimal SumOfMultiplesOfThreeAndFive(int limit)
        {
            return sumOfMultiplesOfTwoNumbersNormalWay(3, 5, limit);
        }

        private static decimal sumOfMultiplesOfTwoNumbersNormalWay(int num1, int num2, int limit)
        {
            if (num1 < 1 || num2 < 1)
                return 0;

            decimal result = 0;
            for (int i = 1; i < limit; i++)
            {
                if ((i % num1 == 0) || (i % num2 == 0))
                {
                    result = result + i;
                }
            }
            return result;
        }
    }
}
