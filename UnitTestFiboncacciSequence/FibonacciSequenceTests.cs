using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciSequence;
using System.Collections.Generic;

namespace UnitTestFiboncacciSequence
{
    [TestClass]
    public class FibonacciSequenceTests
    {
        [TestMethod]
        public void Test_CalculateFibonacciSequence()
        {
            FibonacciSequence.FibonacciSequence fibonacciSequence = new FibonacciSequence.FibonacciSequence();
            var sequence = new int [] { 2, 4, 6, 8 };
            var limit = 12;
            var expected = new int[] { 2, 4, 6, 8, 20, 38, 72, 138, 268, 516, 994, 1916 };
            var actual = fibonacciSequence.CalculateFibonacciSequence(sequence, limit);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
