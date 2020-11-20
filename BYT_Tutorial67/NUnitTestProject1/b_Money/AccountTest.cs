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

			DKK = new Currency("DKK", 0.17);
			Nordea = new Bank("Nordead bank", DKK);
			Nordea.openAccount("Montag");
		}

		[Test]
		public void testAddRemoveTimedPayment()
		{
			SweBank.addTimedPayment("Alice", "Alice", 1, 0, new Money(100, SEK), Nordea, "Montag");
			int initialAmount = SweBank.GetBalance("Alice");
			SweBank.tick();
			int amountAfter = SweBank.GetBalance("Alice");
			Assert.IsTrue(initialAmount - 100 == amountAfter);
			SweBank.RemoveTimedPayment("Alice", "Alice");
			SweBank.tick();
			int amountAfterAfter = SweBank.GetBalance("Alice");
			Assert.IsTrue(amountAfter == amountAfterAfter);
		}

		[Test]
		public void testTimedPayment()
		{
			SweBank.addTimedPayment("Alice", "Alice", 1, 0, new Money(100, SEK), Nordea, "Montag");
			int initialAmount = SweBank.GetBalance("Alice");
			SweBank.tick();
			int amountAfter = SweBank.GetBalance("Alice");
			Assert.IsTrue(initialAmount - 100 == amountAfter);
		}

		[Test]
		public void testAddWithdraw()
		{
			int initialAmount = SweBank.GetBalance("Alice");
			SweBank.deposit("Alice", new Money(100, SEK));
			int amountAfter = SweBank.GetBalance("Alice");
			Assert.IsTrue(initialAmount + 100 == amountAfter);

			Console.WriteLine("amount after = " + amountAfter);

			SweBank.withdraw("Alice", new Money(100, SEK));
			int finalAmount = SweBank.GetBalance("Alice");
			Assert.AreEqual(amountAfter - 100, finalAmount);
		}

		[Test]
		public void testGetBalance()
		{
			Assert.AreEqual(1000000, SweBank.GetBalance("Alice"));
		}
	}
}