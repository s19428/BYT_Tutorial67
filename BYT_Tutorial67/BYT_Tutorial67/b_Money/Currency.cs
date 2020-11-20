using System;
using System.Collections.Generic;
using System.Text;

namespace BYT_Tutorial67.b_Money
{
	public class Currency
	{
		private string name;
		private double rate;

		/**
		 * New Currency
		 * The rate argument of each currency indicates that Currency's "universal" exchange rate.
		 * Imagine that we define the rate of each currency in relation to some universal currency.
		 * This means that the rate of each currency defines its value compared to this universal currency.
		 *
		 * @param name The name of this Currency
		 * @param rate The exchange rate of this Currency
		 */
		public Currency(string name, double rate)
		{
			this.name = name;
			this.rate = rate;
		}

		/** Convert an amount of this Currency to its value in the general "universal currency"
		 * (As mentioned in the documentation of the Currency constructor)
		 * 
		 * @param amount An amount of cash of this currency.
		 * @return The value of amount in the "universal currency"
		 */
		public Int32 universalValue(Int32 amount)
		{
			return 0;
		}

		/** Get the name of this Currency.
		 * @return name of Currency
		 */
		public string GetName()
		{
			return name;
		}

		/** Get the rate of this Currency.
		 * 
		 * @return rate of this Currency
		 */
		public double GetRate()
		{
			return rate;
		}

		/** Set the rate of this currency.
		 * 
		 * @param rate New rate for this Currency
		 */
		public void setRate(double rate)
		{
			this.rate = rate;
		}

		/** Convert an amount from another Currency to an amount in this Currency
		 * 
		 * @param amount Amount of the other Currency
		 * @param othercurrency The other Currency
		*/
		public Int32 valueInThisCurrency(Int32 amount, Currency othercurrency)
		{
			return 0;
		}
	}

}