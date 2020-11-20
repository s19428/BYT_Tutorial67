using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BYT_Tutorial67.b_Money
{

	public class Account
	{
		private Money content;
		//private Hashtable<string, TimedPayment> timedpayments = new Hashtable<string, TimedPayment>();
		private Hashtable timedpayments = new Hashtable();

		public Account(string name, Currency currency)
		{
			this.content = new Money(0, currency);
		}

		/**
		 * Add a timed payment
		 * @param id Id of timed payment
		 * @param interval Number of ticks between payments
		 * @param next Number of ticks till first payment
		 * @param amount Amount of Money to transfer each payment
		 * @param tobank Bank where receiving account resides
		 * @param toaccount Id of receiving account
		 */
		public void addTimedPayment(string id, Int32 interval, Int32 next, Money amount, Bank tobank, string toaccount)
		{
			TimedPayment tp = new TimedPayment(interval, next, amount, this, tobank, toaccount);
			timedpayments.Add(id, tp);
		}

		/**
		 * Remove a timed payment
		 * @param id Id of timed payment to Remove
		 */
		public void RemoveTimedPayment(string id)
		{
			timedpayments.Remove(id);
		}

		/**
		 * Check if a timed payment exists
		 * @param id Id of timed payment to check for
		 */
		public bool timedPaymentExists(string id)
		{
			return timedpayments.ContainsKey(id);
		}

		/**
		 * A time unit passes in the system
		 */
		public void tick()
		{
			foreach (TimedPayment tp in timedpayments.Values)
			{
				tp.tick(); tp.tick();
			}
		}

		/**
		 * Deposit money to the account
		 * @param money Money to deposit.
		 */
		public void deposit(Money money)
		{
			content = content.add(money);
		}

		/**
		 * Withdraw money from the account
		 * @param money Money to withdraw.
		 */
		public void withdraw(Money money)
		{
			content = content.sub(money);
		}

		/**
		 * Get balance of account
		 * @return Amount of Money currently on account
		 */
		public Money GetBalance()
		{
			return content;
		}

		/* Everything below belongs to the private inner class, TimedPayment */
		private class TimedPayment
		{
			private int interval, next;
			private Account fromaccount;
			private Money amount;
			private Bank tobank;
			private string toaccount;

			public TimedPayment(Int32 interval, Int32 next, Money amount, Account fromaccount, Bank tobank, string toaccount)
			{
				this.interval = interval;
				this.next = next;
				this.amount = amount;
				this.fromaccount = fromaccount;
				this.tobank = tobank;
				this.toaccount = toaccount;
			}

			/* Return value indicates whether or not a transfer was initiated */
			public bool tick()
			{
				if (next == 0)
				{
					next = interval;

					fromaccount.withdraw(amount);
					try
					{
						tobank.deposit(toaccount, amount);
					}
					catch (AccountDoesNotExistException e)
					{
						/* Revert transfer.
						 * In reality, this should probably cause a notification somewhere. */
						fromaccount.deposit(amount);
					}
					return true;
				}
				else
				{
					next--;
					return false;
				}
			}
		}
	}
}