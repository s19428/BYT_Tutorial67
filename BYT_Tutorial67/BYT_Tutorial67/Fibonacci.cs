using System;
using System.Collections.Generic;
using System.Text;

namespace a_Introductory
{
	public class Fibonacci
	{
		public Fibonacci() { }

		public int fib(int n)
		{
			switch (n)
			{
				case 0: return 0;
				case 1: return 1;
				default: return (fib(n - 2) + fib(n - 1));
				//default: return (fib(n - 2) + fib(n - 1)) + 1;
			}
		}
	}
}