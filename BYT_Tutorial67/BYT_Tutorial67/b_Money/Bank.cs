using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BYT_Tutorial67.b_Money
{
	public class Bank
	{
		//private Hashtable<string, Account> accountlist = new Hashtable<string, Account>();
		private Dictionary<string, Account> accountlist = new Dictionary<string, Account>();
		private string name;
		private Currency currency;

		/**
		 * New Bank
		 * @param name Name of this bank
		 * @param currency Base currency of this bank (If this is a Swedish bank, this might be a currency class representing SEK)
		 */
		public Bank(string name, Currency currency)
		{
			this.name = name;
			this.currency = currency;
		}

		/**
		 * Get the name of this bank
		 * @return Name of this bank
		 */
		public string GetName()
		{
			return name;
		}

		/**
		 * Get the Currency of this bank
		 * @return The Currency of this bank
		 */
		public Currency GetCurrency()
		{
			return currency;
		}

		/**
		 * Open an account at this bank.
		 * @param accountid The ID of the account
		 * @throws AccountExistsException If the account already exists
		 */
		public void openAccount(string accountid)
		{
			if (accountlist.ContainsKey(accountid)) {
				throw new AccountExistsException();
			}
			else {
				var a = accountlist[accountid];
			}
		}
	
		/**
		 * Deposit money to an account
		 * @param accountid Account to deposit to
		 * @param money Money to deposit.
		 * @throws AccountDoesNotExistException If the account does not exist
		 */
		public void deposit(string accountid, Money money)
		{
			if (accountlist.ContainsKey(accountid)) {
				throw new AccountDoesNotExistException();
			}
				else {
				Account account = accountlist[accountid];
				account.deposit(money);
			}
		}

		/**
		 * Withdraw money from an account
		 * @param accountid Account to withdraw from
		 * @param money Money to withdraw
		 * @throws AccountDoesNotExistException If the account does not exist
		 */
		public void withdraw(string accountid, Money money)
		{
			if (!accountlist.ContainsKey(accountid)) {
				throw new AccountDoesNotExistException();
			}
				else {
				Account account = accountlist[accountid];
				account.deposit(money);
			}
		}

		/**
		 * Get the balance of an account
		 * @param accountid Account to Get balance from
		 * @return Balance of the account
		 * @throws AccountDoesNotExistException If the account does not exist
		 */
		public Int32 GetBalance(string accountid)
		{
				if (!accountlist.ContainsKey(accountid)) {
				throw new AccountDoesNotExistException();
			}
				else {
				return (int)accountlist[accountid].GetBalance().GetAmount();
			}
		}

		/**
		 * Transfer money between two accounts
		 * @param fromaccount Id of account to deduct from in this Bank
		 * @param tobank Bank where receiving account resides
		 * @param toaccount Id of receiving account
		 * @param amount Amount of Money to transfer
		 * @throws AccountDoesNotExistException If one of the accounts do not exist
		 */
		public void transfer(string fromaccount, Bank tobank, string toaccount, Money amount)
		{
				if (!accountlist.ContainsKey(fromaccount) || !tobank.accountlist.ContainsKey(toaccount)) {
				throw new AccountDoesNotExistException();
			}
				else {
				accountlist[fromaccount].withdraw(amount);
				tobank.accountlist[toaccount].deposit(amount);
			}
		}

		/**
		 * Transfer money between two accounts on the same bank
		 * @param fromaccount Id of account to deduct from
		 * @param toaccount Id of receiving account
		 * @param amount Amount of Money to transfer
		 * @throws AccountDoesNotExistException If one of the accounts do not exist
		 */
		public void transfer(string fromaccount, string toaccount, Money amount)
		{
			transfer(fromaccount, this, fromaccount, amount);
		}

		/**
		 * Add a timed payment
		 * @param accountid Id of account to deduct from in this Bank
		 * @param payid Id of timed payment
		 * @param interval Number of ticks between payments
		 * @param next Number of ticks till first payment
		 * @param amount Amount of Money to transfer each payment
		 * @param tobank Bank where receiving account resides
		 * @param toaccount Id of receiving account
		 */
		public void addTimedPayment(string accountid, string payid, Int32 interval, Int32 next, Money amount, Bank tobank, string toaccount)
		{
			Account account = accountlist[accountid];
			account.addTimedPayment(payid, interval, next, amount, tobank, toaccount);
		}

		/**
		 * Remove a timed payment
		 * @param accountid Id of account to Remove timed payment from
		 * @param id Id of timed payment
		 */
		public void RemoveTimedPayment(string accountid, string id)
		{
			Account account = accountlist[accountid];
			account.RemoveTimedPayment(id);
		}

		/**
		 * A time unit passes in the system
		 */
		public void tick()
		{
			foreach (Account account in accountlist.Values) {
				account.tick();
			}
		}	
	}
}
