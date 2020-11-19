using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace a_Introductory
{
	public class LineTest
	{
		Tutorial_Point p1, p2;
		Tutorial_Point p3, p4;
		Line l1;
		Line l2;

		[SetUp]
		public void setUp()
		{
			p1 = new Tutorial_Point(2, -3);
			p2 = new Tutorial_Point(3, 7);
			l1 = new Line(p1, p2);

			p3 = new Tutorial_Point(7, 2);
			p4 = new Tutorial_Point(8, 12);
			l2 = new Line(p3, p4);
		}

		[Test]
		public void testLength()
		{
			Assert.AreEqual(10.0498756, l1.getLength(), 0.0001);
			Assert.AreEqual(10.0498756, l2.getLength(), 0.0001);
			Assert.IsTrue(l1.isSameLengthAs(l2), "l1 should have same length as l2");
		}
	}
}
