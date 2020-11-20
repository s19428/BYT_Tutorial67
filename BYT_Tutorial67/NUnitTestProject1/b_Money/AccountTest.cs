using System;
using System.Collections.Generic;
using System.Text;
using BYT_Tutorial67.b_Money;
using NUnit.Framework;

namespace NUnitTestProject1.b_Money
{

	public class AccountTest
	{
		Currency SEK, DKK;
		Bank Nordea;
		Bank DanskeBank;
		Bank SweBank;
		Account testAccount;

		[SetUp]
		public void setUp()
		{
			SEK = new Currency("SEK", 0.15);
			SweBank = new Bank("SweBank", SEK);
			SweBank.openAccount("Alice");
			testAccount = new Account("Hans", SEK);
			testAccount.deposit(new Money(10000000, SEK));

			SweBank.deposit("Alice", new Money(1000000, SEK));
		}

		[Test]
		public void testAddRemoveTimedPayment()
		{
			Assert.Fail("Write test case here");
		}

		[Test]
		public void testTimedPayment()
		{
			Assert.Fail("Write test case here");
		}

		[Test]
		public void testAddWithdraw()
		{
			Assert.Fail("Write test case here");
		}

		[Test]
		public void testGetBalance()
		{
			Assert.Fail("Write test case here");
		}
	}
}
