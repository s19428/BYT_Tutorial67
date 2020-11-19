using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace a_Introductory
{
	public class PointTest
	{
		Tutorial_Point p1, p2, p3;

		[SetUp]
		public void setUp()
		{
			p1 = new Tutorial_Point(7, 9);
			p2 = new Tutorial_Point(-3, -30);
			p3 = new Tutorial_Point(-10, 3);
		}

		public void testAdd()
		{
			Tutorial_Point res1 = p1.add(p2);
			Tutorial_Point res2 = p1.add(p3);

			Assert.AreEqual(4, res1.x);
			Assert.AreEqual(-21, res1.y);
			Assert.AreEqual(-3, res2.x);
			Assert.AreEqual(12, res2.x);
		}

		public void testSub()
		{
			Tutorial_Point res1 = p1.sub(p2);
			Tutorial_Point res2 = p1.sub(p3);

			Assert.AreEqual(4, res1.x);
			Assert.AreEqual(-21, res1.y);
			Assert.AreEqual(-3, res2.x);
			Assert.AreEqual(12, res2.x);
		}
	}
}