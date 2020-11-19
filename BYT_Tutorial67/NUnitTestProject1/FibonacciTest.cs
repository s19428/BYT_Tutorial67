using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace a_Introductory
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
		public void testFib()
		{
			Fibonacci tester = new Fibonacci();
            Assert.AreEqual(0, tester.fib(0));
            Assert.AreEqual(1, tester.fib(1));
            Assert.AreEqual(1, tester.fib(2));
            Assert.AreEqual(2, tester.fib(3));
            Assert.AreEqual(3, tester.fib(4));
            Assert.AreEqual(5, tester.fib(5));
            Assert.AreEqual(8, tester.fib(6));
            Assert.AreEqual(13, tester.fib(7));
            //Assert.AreEqual("0", 0, tester.fib(0));
            //Assert.AreEqual("1", 1, tester.fib(1));
            //Assert.AreEqual("2", 1, tester.fib(2));
            //Assert.AreEqual("3", 2, tester.fib(3));
            //Assert.AreEqual("4", 3, tester.fib(4));
            //Assert.AreEqual("5", 5, tester.fib(5));
            //Assert.AreEqual("6", 8, tester.fib(6));
            //Assert.AreEqual("7", 13, tester.fib(7));
        }
	}
}
