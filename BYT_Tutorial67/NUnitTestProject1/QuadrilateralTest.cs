using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace a_Introductory
{
	public class QuadrilateralTest
	{
		Quadrilateral square1, square2, rectangle1, rectangle2, quad;

		[SetUp]
		public void setUp() 
		{
			/* Set up two squares,
			 * two rectangles that are not squares,
			 * and a quad that is neither a rectangle nor a square. */
			square1 = new Quadrilateral(new Tutorial_Point(2, 3), new Tutorial_Point(4, 7), new Tutorial_Point(8, 5), new Tutorial_Point(6, 1));
			square2 = new Quadrilateral(new Tutorial_Point(-1, -1), new Tutorial_Point(-1, 1), new Tutorial_Point(1, 1), new Tutorial_Point(1, -1));
			rectangle1 = new Quadrilateral(new Tutorial_Point(4, 2), new Tutorial_Point(3, 4), new Tutorial_Point(9, 7), new Tutorial_Point(10, 5));
			rectangle2 = new Quadrilateral(new Tutorial_Point(-2, -1), new Tutorial_Point(-2, 1), new Tutorial_Point(2, 1), new Tutorial_Point(2, -1));
			quad = new Quadrilateral(new Tutorial_Point(-2, -2), new Tutorial_Point(-1, 1), new Tutorial_Point(1, 1), new Tutorial_Point(1, -1));
		}

		[Test]
		public void testRectangle()
		{
			String msg = "Should be a rectangle";
			Assert.IsTrue(square1.isRectangle(), msg);
			Assert.IsTrue(square2.isRectangle(), msg);
			Assert.IsTrue(rectangle1.isRectangle(), msg);
			Assert.IsTrue(rectangle2.isRectangle(), msg);
			Assert.IsFalse(quad.isRectangle(), "Should not be a rectangle");
		}

		[Test]
		public void testSquare()
		{
			string tmsg = "Should be a square";
			string fmsg = "Should not be a square";
			Assert.IsTrue(square1.isSquare(), tmsg);
			Assert.IsTrue(square2.isSquare(), tmsg);
			Assert.IsFalse(rectangle1.isSquare(), fmsg);
			Assert.IsFalse(rectangle2.isSquare(), fmsg);
			Assert.IsFalse(quad.isSquare(), fmsg);
		}
	}
}
