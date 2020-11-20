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
			Assert.AreEqual("SEK", SEK.GetName());
	}

	[Test]
	public void testGetRate()
	{
			Assert.AreEqual(0.20, DKK.GetRate());
	}

	[Test]
	public void testSetRate()
	{
			DKK.setRate(0.19);
			Assert.AreEqual(0.19, DKK.GetRate());
	}

	[Test]
	public void testGlobalValue()
	{
			Assert.AreEqual(100 * .15, SEK.universalValue(100));
	}

	[Test]
	public void testValueInThisCurrency()
	{
			Assert.AreEqual(133, SEK.valueInThisCurrency(100, DKK));
	}

}

}
