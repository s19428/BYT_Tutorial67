using System;
using System.Collections.Generic;
using System.Text;

namespace BYT_Tutorial67.b_Money
{
	public class Money : IComparable
	{
		private int amount;
		private Currency currency;

		/**
		 * New Money
		 * @param amount	The amount of money
		 * @param currency	The currency of the money
		 */
		public Money(Int32 amount, Currency currency)
		{
			this.amount = amount;
			this.currency = currency;
		}

		/**
		 * Return the amount of money.
		 * @return Amount of money in double type.
		 */
		public double GetAmount()
		{
			return amount;
		}

		/**
		 * Returns the currency of this Money.
		 * @return Currency object representing the currency of this Money
		 */
		public Currency GetCurrency()
		{
			return currency;
		}

		/**
		 * Returns the amount of the money in the string form "(amount) (currencyname)", e.g. "10.5 SEK".
		 * Recall that we represent decimal numbers with Int32s. This means that the "10.5 SEK" mentioned
		 * above is actually represented as the Int32 1050
		 *  @return string representing the amount of Money.
		 */
		public string ToString()
		{
			return "" + amount + " " + currency.ToString();
		}

		/**
		 * Gets the universal value of the Money, according the rate of its Currency.
		 * @return The value of the Money in the "universal currency".
		 */
		public Int32 universalValue()
		{
			return -1;
		}

		/**
		 * Check to see if the value of this money is equal to the value of another Money of some other Currency.
		 * @param other The other Money that is being compared to this Money.
		 * @return A bool indicating if the two monies are equal.
		 */
		public bool Equals(Money other)
		{
			return amount
				 == other.amount && currency == other.currency;
		}

		/**
		 * Adds a Money to this Money, regardless of the Currency of the other Money.
		 * @param other The Money that is being added to this Money.
		 * @return A new Money with the same Currency as this Money, representing the added value of the two.
		 * (Remember to convert the other Money before adding the amounts)
		 */
		public Money add(Money other)
		{
			return null;
		}

		/**
		 * Subtracts a Money from this Money, regardless of the Currency of the other Money.
		 * @param other The money that is being subtracted from this Money.
		 * @return A new Money with the same Currency as this Money, representing the subtracted value.
		 * (Again, remember converting the value of the other Money to this Currency)
		 */
		public Money sub(Money other)
		{
			return null;
		}

		/**
		 * Check to see if the amount of this Money is zero or not
		 * @return True if the amount of this Money is equal to 0.0, False otherwise
		 */
		public bool isZero()
		{
			return amount == 0;
		}
		/**
		 * Negate the amount of money, i.e. if the amount is 10.0 SEK the negation returns -10.0 SEK
		 * @return A new instance of the money class initialized with the new negated money amount.
		 */
		public Money negate()
		{
			return new Money(-amount, currency);
		}

		/**
		 * Compare two Monies.
		 * compareTo is required because the class implements the Comparable interface.
		 * (Remember the universalValue method, and that Int32s already implement Comparable).
		 * Also, since compareTo must take an Object, you will have to explicitly downcast it to a Money.
		 * @return 0 if the Values of the monies are equal.
		 * A negative Int32 if this Money is less valuable than the other Money.
		 * A positive Int32 if this Money is more valuiable than the other Money.
		 */
		public int CompareTo(Object other)
		{
			return -1;
		}
	}
}