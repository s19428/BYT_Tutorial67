using System;
using System.Collections.Generic;
using System.Text;
using BYT_Tutorial67.b_Money;
using NUnit.Framework;

namespace NUnitTestProject1.b_Money
{
	public class MoneyTest
	{
		Currency SEK, DKK, NOK, EUR;
		Money SEK100, EUR10, SEK200, EUR20, SEK0, EUR0, SEKn100;

		[SetUp]
		public void setUp()
		{
			SEK = new Currency("SEK", 0.15);
			DKK = new Currency("DKK", 0.20);
			EUR = new Currency("EUR", 1.5);
			SEK100 = new Money(10000, SEK);
			EUR10 = new Money(1000, EUR);
			SEK200 = new Money(20000, SEK);
			EUR20 = new Money(2000, EUR);
			SEK0 = new Money(0, SEK);
			EUR0 = new Money(0, EUR);
			SEKn100 = new Money(-10000, SEK);
		}

		[Test]
		public void testGetAmount()
		{
			Assert.AreEqual(10000, SEK100.GetAmount());
		}

		[Test]
		public void testGetCurrency()
		{
			Assert.AreEqual(SEK, SEK100.GetCurrency());
		}

		[Test]
		public void testToString()
		{
			Assert.AreEqual(0 + " SEK", SEK0.ToString());
		}

		[Test]
		public void testGlobalValue()
		{
			Assert.AreEqual(3000, EUR20.universalValue());
		}

		[Test]
		public void testEqualsMoney()
		{
			Assert.IsTrue(new Money(100, SEK).Equals(new Money(100, SEK)));
			Assert.IsTrue(!(new Money(101, SEK).Equals(new Money(100, SEK))));
		}

		[Test]
		public void testAdd()
		{
			Assert.AreEqual((new Money(101, SEK)).GetAmount(), new Money(100, SEK).add(new Money(1, SEK)).GetAmount());
		}

		[Test]
		public void testSub()
		{
			Assert.AreEqual((new Money(99, SEK)).GetAmount(), new Money(100, SEK).sub(new Money(1, SEK)).GetAmount());
		}

		[Test]
		public void testIsZero()
		{
			Assert.IsTrue(new Money(0, SEK).isZero());
			Assert.IsFalse(new Money(1, SEK).isZero());
		}

		[Test]
		public void testNegate()
		{
			Assert.AreEqual(new Money(100, DKK).negate(), new Money(-100, DKK));
		}

		[Test]
		public void testCompareTo()
		{
			Assert.IsTrue(new Money(100, SEK).CompareTo(new Money(55, SEK)) > 0);
			Assert.IsTrue(new Money(100, SEK).CompareTo(new Money(100, SEK)) == 0);
			Assert.IsTrue(new Money(100, SEK).CompareTo(new Money(505, SEK)) < 0);
		}
	}
}