using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestHarnesProject;

namespace TestHarnesProjectTest
{
    [TestClass]
    public class EvaluateTest
    {
        int intResult;
        double doubleResult;
        string charResult;

        [TestMethod]
        public void TestMethodGCDPositive()
        {
            intResult = TestHarnesProject.Evaluate.EvaluateGCD(15, 10);
            Assert.AreEqual(5, intResult);
            intResult = TestHarnesProject.Evaluate.EvaluateGCD(11, 33);
            Assert.AreEqual(11, intResult);
            intResult = TestHarnesProject.Evaluate.EvaluateGCD(10, 20);
            Assert.AreEqual(10, intResult);
        }

        [TestMethod]
        public void TestMethodGCDNegative()
        {
            intResult = TestHarnesProject.Evaluate.EvaluateGCD(15, 10);
            Assert.AreNotEqual(6, intResult);
            intResult = TestHarnesProject.Evaluate.EvaluateGCD(11, 33);
            Assert.AreNotEqual(10, intResult);
            intResult = TestHarnesProject.Evaluate.EvaluateGCD(10, 20);
            Assert.AreNotEqual(5, intResult);
        }

        [TestMethod]
        public void TestMethodGCDException()
        {
            try
            {
                intResult = TestHarnesProject.Evaluate.EvaluateGCD(0, 3);
            }

            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "One of the numbers equals 0!");
            }
        }

        [TestMethod]
        public void TestMethodMaxMinPositive()
        {
            intResult = TestHarnesProject.Evaluate.EvaluateMaxMin(15, 10);
            Assert.AreEqual(15, intResult);
            intResult = TestHarnesProject.Evaluate.EvaluateMaxMin(11, 33);
            Assert.AreEqual(33, intResult);
            intResult = TestHarnesProject.Evaluate.EvaluateMaxMin(10, 20);
            Assert.AreEqual(20, intResult);
        }

        [TestMethod]
        public void TestMethodMaxMinNegative()
        {
            intResult = TestHarnesProject.Evaluate.EvaluateMaxMin(15, 10);
            Assert.AreNotEqual(10, intResult);
            intResult = TestHarnesProject.Evaluate.EvaluateMaxMin(11, 33);
            Assert.AreNotEqual(11, intResult);
            intResult = TestHarnesProject.Evaluate.EvaluateMaxMin(10, 20);
            Assert.AreNotEqual(10, intResult);
        }

        [TestMethod]
        public void TestMethodMaxMinException()
        {
            try
            {
                intResult = TestHarnesProject.Evaluate.EvaluateMaxMin(3, 3);
            }

            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Not able to display MAX or MIN VALUE. The numbers are equal!");
            }
        }

        [TestMethod]
        public void TestMethodAvgPositive()
        {
            doubleResult = TestHarnesProject.Evaluate.EvaluateAvg (15, 10);
            Assert.AreEqual(12.5, doubleResult);
            doubleResult = TestHarnesProject.Evaluate.EvaluateAvg(11, 33);
            Assert.AreEqual(22, doubleResult);
            doubleResult = TestHarnesProject.Evaluate.EvaluateAvg(10, 20);
            Assert.AreEqual(15, doubleResult);
        }

        [TestMethod]
        public void TestMethodAvgNegative()
        {
            doubleResult = TestHarnesProject.Evaluate.EvaluateAvg(15, 10);
            Assert.AreNotEqual(15, doubleResult);
            doubleResult = TestHarnesProject.Evaluate.EvaluateAvg(11, 33);
            Assert.AreNotEqual(33, doubleResult);
            doubleResult = TestHarnesProject.Evaluate.EvaluateAvg(10, 20);
            Assert.AreNotEqual(20, doubleResult);
        }

        [TestMethod]
        public void TestMethodAvgException()
        {
            try
            {
                doubleResult = TestHarnesProject.Evaluate.EvaluateAvg(3, 3);
            }

            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "The average value is the same when the numbers are equal!");
            }
        }

        [TestMethod]
        public void TestMethodCharNumPositive()
        {
            charResult = TestHarnesProject.Evaluate.EvaluateCharNum (33);
            Assert.AreEqual("!", charResult);
            charResult = TestHarnesProject.Evaluate.EvaluateCharNum (255);
            Assert.AreEqual("ÿ", charResult);
            charResult = TestHarnesProject.Evaluate.EvaluateCharNum (100);
            Assert.AreEqual("d", charResult);
        }

        [TestMethod]
        public void TestMethodCharNumException()
        {
            try
            {
                charResult = TestHarnesProject.Evaluate.EvaluateCharNum(32);
            }

            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "There is no  Char value for the numbers less than 33 or more than 255!");
            }
        }

        [TestMethod]
        public void TestMethodCharNumException2()
        {
            try
            {
                charResult = TestHarnesProject.Evaluate.EvaluateCharNum(256);
            }

            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "There is no  Char value for the numbers less than 33 or more than 255!");
            }
        }
    }
}