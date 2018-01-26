using ASML_Task.UnitTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceAnalysis;
using SequenceAnalysis.Core.Exceptions;
using System;
using System.IO;

namespace ASML_Task.UnitTests
{
    [TestClass]
    public class SequenceAnalysisUnitTests
    {
        readonly string resourcesPath;
        public SequenceAnalysisUnitTests()
        {
            resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
        }

        [TestMethod]
        [Description("Analize null")]
        public void UpperCaseWordsAnalyzeWithNullInputString()
        {
            // arrange
            string inputStatement = null;
            UpperCaseWordsAnalyer analyzer = new UpperCaseWordsAnalyer();

            // act && assert
            try
            {
                analyzer.Analize(inputStatement);
            }
            catch (GivenStringIsEmpty)
            {
                return;
            }
            catch
            {
                Assert.Fail("GivenStringIsEmpty was not thrown.");
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        [Description("Analize empty string")]
        public void UpperCaseWordsAnalyzeWithEmptyInputString()
        {
            // arrange
            string inputStatement = "";
            UpperCaseWordsAnalyer analyzer = new UpperCaseWordsAnalyer();

            // act && assert
            try
            {
                analyzer.Analize(inputStatement);
            }
            catch (GivenStringIsEmpty)
            {
                return;
            }
            catch
            {
                Assert.Fail("GivenStringIsEmpty was not thrown.");
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        [Description("Analize a very simple statement containing 4 words, 16 characters")]
        public void UpperCaseWordsAnalyzeWithSimpleInputString()
        {
            // arrange
            string inputStatement = "This IS a STRING";
            UpperCaseWordsAnalyer analyzer = new UpperCaseWordsAnalyer();
            string expected = "GIINRSST";

            // act
            string actual = analyzer.Analize(inputStatement);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Analize a statement with length > 2500 character, contains letter only words, digit only words, special character only words and combination between them all")]
        public void UpperCaseWordsAnalyzeWith_MoreThan2500_LengthStatement()
        {
            // arrange
            string inputStatement = File.ReadAllText(Path.Combine(resourcesPath, "IntroductionToKarimMansour.txt"));
            UpperCaseWordsAnalyer analyzer = new UpperCaseWordsAnalyer();
            UpperCaseWordsAnalyzerHelper helper = new UpperCaseWordsAnalyzerHelper();
            string expected = helper.Analize(inputStatement);

            // act
            string actual = analyzer.Analize(inputStatement);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Analize a statement with length > 32K character, contains letter only words, digit only words, special character only words and combination between them all")]
        public void UpperCaseWordsAnalyzeWith_MoreThan32K_LengthStatement()
        {
            // arrange
            string inputStatement = File.ReadAllText(Path.Combine(resourcesPath, "Wikipedia_SoftwareEngineering.txt"));
            UpperCaseWordsAnalyer analyzer = new UpperCaseWordsAnalyer();
            UpperCaseWordsAnalyzerHelper helper = new UpperCaseWordsAnalyzerHelper();
            string expected = helper.Analize(inputStatement);

            // act
            string actual = analyzer.Analize(inputStatement);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [Description("Analize a statement with length > 200K character, contains letter only words, digit only words, special character only words and combination between them all")]
        public void UpperCaseWordsAnalyzeWith_MoreThan200K_LengthStatement()
        {
            // arrange
            string inputStatement = File.ReadAllText(Path.Combine(resourcesPath, "Wikipedia_NetherlandsAndEindhoven.txt"));
            UpperCaseWordsAnalyer analyzer = new UpperCaseWordsAnalyer();
            UpperCaseWordsAnalyzerHelper helper = new UpperCaseWordsAnalyzerHelper();
            string expected = helper.Analize(inputStatement);

            // act
            string actual = analyzer.Analize(inputStatement);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
