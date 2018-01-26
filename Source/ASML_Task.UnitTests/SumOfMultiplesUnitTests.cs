using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfMultiple;
using ASML_Task.UnitTests.Helpers;
using SumOfMultiple.Core.Exceptions;

namespace ASML_Task.UnitTests
{
    [TestClass]
    public class SumOfMultiplesOfThreeAndFiveTests
    {
        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with limit = 0")]
        public void GetSumOfMultiplesOfThreeAndFiveWithLimitEqualsToZeroTest()
        {
            // arrange 
            int limit = 0;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();

            // act && assert
            try
            {
                sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);
            }
            catch (LimitIsNegativeOrZeroException)
            {
                return;
            }
            catch
            {
                Assert.Fail("LimitIsNegativeOrZeroException was not thrown.");
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with negative limit")]
        public void GetSumOfMultiplesOfThreeAndFiveWithNegativeLimitTest()
        {
            // arrange 
            Random random = new Random();
            int limit = random.Next(int.MinValue, -1);
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();

            // act && assert
            try
            {
                sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);
            }
            catch (LimitIsNegativeOrZeroException)
            {
                return;
            }
            catch
            {
                Assert.Fail("LimitIsNegativeOrZeroException was not thrown.");
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with limit < 3, it must throws an exception as upper bound is less than 3")]
        public void GetSumOfMultiplesOfThreeAndFiveWithLimitLessThanThreeTest()
        {
            int limit = 2;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();

            // act && assert
            try
            {
                sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);
            }
            catch (LimitIsLessThanNumberException ex)
            {
                //AssertFailedException
                StringAssert.Contains(ex.Message, "Given limit number is less than or equal 3");
                return;
            }
            catch
            {
                Assert.Fail("LimitIsLessThanNumberException was not thrown.");
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with limit = 3, it must throws an exception as upper bound is eqaul to 3")]
        public void GetSumOfMultiplesOfThreeAndFiveWithLimitEqualsToThreeTest()
        {
            int limit = 3;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();

            // act && assert
            try
            {
                sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);
            }
            catch (LimitIsLessThanNumberException ex)
            {
                //AssertFailedException
                StringAssert.Contains(ex.Message, "Given limit number is less than or equal 3");
                return;
            }
            catch
            {
                Assert.Fail("LimitIsLessThanNumberException was not thrown.");
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with limit = 4 (between 3 and five), it must return 3 as the upper bound is 4")]
        public void GetSumOfMultiplesOfThreeAndFiveWithLimitEqualsToFourTest()
        {
            // arrange 
            int limit = 4;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            decimal expected = 3m;
            // (new SumOfMultiplesHelper()).SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with limit = 5, it must return 3 as the upper bound is 5 (not included)")]
        public void GetSumOfMultiplesOfThreeAndFiveWithLimitEqualsToFiveTest()
        {
            // arrange 
            int limit = 5;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            decimal expected = 3m;
            // (new SumOfMultiplesHelper()).SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with limit = 6 (minimum number contains both 3 and 5), it must return 8 (3 + 5)")]
        public void GetSumOfMultiplesOfThreeAndFiveWithLimitEqualsMinimumNumberContainsThreeAndFiveTest()
        {
            // arrange 
            int limit = 6;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            decimal expected = 8m;
            // (new SumOfMultiplesHelper()).SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with limit minimum number contains both 3, 5 and multiple of both, e.g. 16 returns 60 (not calculating 15 twice)")]
        public void GetSumOfMultiplesOfThreeAndFiveWithLimitEqualsToSixteenTest()
        {
            // arrange 
            int limit = 16;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            decimal expected = 60m;
            // (new SumOfMultiplesHelper()).SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with small limit number, e.g. 1000 returns 233168")]
        public void GetSumOfMultiplesOfThreeAndFiveWithSmallLimitNumber()
        {
            // arrange 
            int limit = 1000;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            decimal expected = 233168m;
            // (new SumOfMultiplesHelper()).SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with medium limit number, e.g. million retruns ")]
        public void GetSumOfMultiplesOfThreeAndFiveWithMediumLimitNumber()
        {
            // arrange 
            int limit = 1000000;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            decimal expected = 233333166668m;
            // (new SumOfMultiplesHelper()).SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with large limit number, e.g. billion retruns ")]
        public void GetSumOfMultiplesOfThreeAndFiveWithLargeLimitNumber()
        {
            // arrange 
            int limit = 1000000000;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            decimal expected = 233333333166666668m;
            // (new SumOfMultiplesHelper()).SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Get sum of multiples of 3 and 5 with very large limit number, integer max number retruns 1076060070465310994")]
        public void GetSumOfMultiplesOfThreeAndFiveWithLimitEqualsToIntegerMaxNumberTest()
        {
            // arrange 
            int limit = int.MaxValue;
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            decimal expected = 1076060070465310994m;
            // (new SumOfMultiplesHelper()).SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Timing is not required here, as I'm using non-optimized calculatror to assert results, Get sum of multiples of 3 and 5 with small limit number Less than million")]
        public void GetSumOfMultiplesOfThreeAndFiveWithRandomLimitNumberLessThanMillion()
        {
            // arrange 
            Random random = new Random();
            int limit = random.Next(1000, 1000000);
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            SumOfMultiplesHelper myCalculator = new SumOfMultiplesHelper();
            decimal expected = myCalculator.SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Timing is not required here, as I'm using non-optimized calculatror to assert results, Get sum of multiples of 3 and 5 with medium limit number between million and 100 million")]
        public void GetSumOfMultiplesOfThreeAndFiveWithRandomLimitNumberLessThanHundredMillion()
        {
            // arrange 
            Random random = new Random();
            int limit = random.Next(1000000, 100000000);
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            SumOfMultiplesHelper myCalculator = new SumOfMultiplesHelper();
            decimal expected = myCalculator.SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Timing is not required here, as I'm using non-optimized calculatror to assert results, Get sum of multiples of 3 and 5 with large limit number greater than 100 million")]
        public void GetSumOfMultiplesOfThreeAndFiveWithRandomLimitNumberGreaterThan100Million()
        {
            // arrange 
            Random random = new Random();
            int limit = random.Next(100000000, int.MaxValue);
            SumOfMultiplesOf3And5 sumOfMultiples = new SumOfMultiplesOf3And5();
            SumOfMultiplesHelper myCalculator = new SumOfMultiplesHelper();
            decimal expected = myCalculator.SumOfMultiplesOfThreeAndFive(limit);

            // act
            decimal actual = sumOfMultiples.SumOfMultiplesOfThreeAndFive(limit);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
