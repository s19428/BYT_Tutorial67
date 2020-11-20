using System;
using System.Collections.Generic;
using System.Text;
using BYT_Tutorial67.b_Money;
using NUnit.Framework;

namespace NUnitTestProject1.b_Money
{
	public class BankTest
	{
		Currency SEK, DKK;
		Bank SweBank, Nordea, DanskeBank;

		[SetUp]
		public void setUp()
		{
			DKK = new Currency("DKK", 0.20);
		SEK = new Currency("SEK", 0.15);
		SweBank = new Bank("SweBank", SEK);
		Nordea = new Bank("Nordea", SEK);
		DanskeBank = new Bank("DanskeBank", DKK);
		SweBank.openAccount("Ulrika");
		SweBank.openAccount("Bob");
		Nordea.openAccount("Bob");
		DanskeBank.openAccount("Gertrud");
	}

	[Test]
	public void testGetName()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testGetCurrency()
	{
		Assert.Fail("Write test case here");
	}

	[Test]
	public void testOpenAccount() {
		Assert.Fail("Write test case here");
}

[Test]
	public void testDeposit()
{
	Assert.Fail("Write test case here");
}

[Test]
	public void testWithdraw()
{
	Assert.Fail("Write test case here");
}

[Test]
	public void testGetBalance()
{
	Assert.Fail("Write test case here");
}

[Test]
	public void testTransfer()
{
	Assert.Fail("Write test case here");
}

[Test]
	public void testTimedPayment()
{
	Assert.Fail("Write test case here");
}
}

}
