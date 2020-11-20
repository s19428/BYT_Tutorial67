using System;
using System.Collections.Generic;
using System.Text;
using BYT_Tutorial67.b_Money;
using NUnit.Framework;

namespace NUnitTestProject1.b_Money
{
	public class CurrencyTest
	{
		Currency SEK, DKK, NOK, EUR;

		[SetUp]
		public void setUp()
		{
			/* Setup currencies with exchange rates */
			SEK = new Currency("SEK", 0.15);
		DKK = new Currency("DKK", 0.20);
		EUR = new Currency("EUR", 1.5);
	}

	[Test]
	public void testGetName()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testGetRate()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testSetRate()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testGlobalValue()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testValueInThisCurrency()
	{
		Assert.Fail("Write test case here");
	}

}

}
