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

			SweBank.openAccount("Whinston");
		}

		[Test]
		public void testGetName()
		{
			Assert.AreEqual("SweBank", SweBank.GetName());
		}

		[Test]
		public void testGetCurrency()
		{
			Assert.AreEqual(SweBank.GetCurrency(), SEK);
		}

		[Test]
		public void testOpenAccount() 
		{
			try
			{
				SweBank.deposit("Whinston", new Money(100, SEK));
			}
			catch (AccountDoesNotExistException adnee)
			{
				Assert.Fail("Account does ot exist");
			}

			Assert.Pass();
		}

		[Test]
		public void testDeposit()
		{
			int initialAmount = SweBank.GetBalance("Whinston");
			SweBank.deposit("Whinston", new Money(100, SEK));
			int finalAmount = SweBank.GetBalance("Whinston");
			Assert.AreEqual(initialAmount + 100, finalAmount);
		}

		[Test]
		public void testWithdraw()
		{
			int initialAmount = SweBank.GetBalance("Whinston");
			SweBank.withdraw("Whinston", new Money(100, SEK));
			int finalAmount = SweBank.GetBalance("Whinston");
			Assert.AreEqual(initialAmount - 100, finalAmount);
		}

		[Test]
		public void testGetBalance()
		{
			Assert.AreEqual(0, SweBank.GetBalance("Whinston"));
		}

		[Test]
		public void testTransfer()
		{
			Console.WriteLine("Initial amount in SweBank: " + SweBank.GetBalance("Whinston"));
			Console.WriteLine("Initial amount in SweBank: " + DanskeBank.GetBalance("Gertrud"));

			SweBank.transfer("Whinston", DanskeBank, "Gertrud", new Money(100, SEK));
			Assert.AreEqual(-100, SweBank.GetBalance("Whinston"));
			Assert.AreEqual(133, DanskeBank.GetBalance("Gertrud"));
		}

		[Test]
		public void testTimedPayment()
		{
			SweBank.addTimedPayment("Whinston", "Whinston", 2, 0, new Money(100, SEK), DanskeBank, "Gertrud");
			int initialMoney = SweBank.GetBalance("Whinston");
			SweBank.tick();
			SweBank.tick();
			Assert.AreEqual(initialMoney - 100, SweBank.GetBalance("Whinston"));
		}
	}
}