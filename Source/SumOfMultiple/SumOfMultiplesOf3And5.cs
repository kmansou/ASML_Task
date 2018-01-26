using System;
using SumOfMultiple.Core;
using SumOfMultiple.Core.Exceptions;

namespace SumOfMultiple
{
    public class SumOfMultiplesOf3And5 : ISumOfMultiplesOfThreeAndFive
    {
        /// <summary>
        /// Gets sum of all multiples of 3 and 5 below given limit
        /// </summary>
        /// <param name="limit">is the limit that method stops sum of all multiples below</param>
        /// <exception cref="SumOfMultiple.Core.Exceptions.LimitIsNegativeOrZeroException">Thrown when given limit is negative or zero</exception>
        /// <exception cref="SumOfMultiple.Core.Exceptions.LimitIsLessThanNumberException">Thrown when given limit is less than 3</exception>
        public decimal SumOfMultiplesOfThreeAndFive(int limit)
        {
            return SumOfMultiplesOfTwoNumbers(3, 5, limit);
        }

        /// <summary>
        /// Gets sum of all multiples of num1 and num5 below given limit
        /// </summary>
        /// <param name="num1">1st number we are going to get its multiples</param>
        /// <param name="num2">2nd number we are going to get its multiples</param>
        /// <param name="limit">is the limit that method stops sum of all multiples below</param>
        /// <exception cref="SumOfMultiple.Core.Exceptions.LimitIsNegativeOrZeroException">Thrown when given limit is negative or zero</exception>
        /// <exception cref="SumOfMultiple.Core.Exceptions.GivenNumberIsZeroOrNegativeException">Thrown when given num1 or num2 is negative or zero</exception>
        /// <exception cref="SumOfMultiple.Core.Exceptions.LimitIsLessThanNumberException">Thrown when given limit is less than 3</exception>
        public decimal SumOfMultiplesOfTwoNumbers(int num1, int num2, int limit)
        {
            if (limit < 1)
                throw new LimitIsNegativeOrZeroException();

            if (num1 < 1 || num2 < 1)
                throw new GivenNumberIsZeroOrNegativeException();

            int lowerNumber = num1 < num2 ? num1 : num2;
            if (limit <= lowerNumber)
                throw new LimitIsLessThanNumberException(lowerNumber);

            decimal sumOfMultiplesOfNum1 = 0;
            if (limit > num1)
                sumOfMultiplesOfNum1 = sumOfMultiples(num1, limit);

            decimal sumOfMultiplesOfNum2 = 0;
            if (limit > num2 && num1 != num2)
                sumOfMultiplesOfNum2 = sumOfMultiples(num2, limit);

            decimal deductlable = 0;
            if (limit > (num1 * num2))
            {
                deductlable = sumOfMultiples((num1 * num2), limit);
            }

            return sumOfMultiplesOfNum1 + sumOfMultiplesOfNum2 - deductlable;
        }

        private decimal sumOfMultiples(int num, int limit)
        {
            limit = (limit - 1) / num;
            return num * sumOfSequenceFromOne(limit);
        }

        // Sum(n) = (n/2) * (n + 1)
        private decimal sumOfSequenceFromOne(int num)
        {
            decimal numAsDecimal = Convert.ToDecimal(num);
            decimal result = numAsDecimal * (numAsDecimal + 1m);
            result = result / 2m;

            return result;
        }
    }
}
