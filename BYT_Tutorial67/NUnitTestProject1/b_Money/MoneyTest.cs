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
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testGetCurrency()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testToString()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testGlobalValue()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testEqualsMoney()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testAdd()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testSub()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testIsZero()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testNegate()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testCompareTo()
	{
		Assert.Fail("Write test case here");
	}
}

}