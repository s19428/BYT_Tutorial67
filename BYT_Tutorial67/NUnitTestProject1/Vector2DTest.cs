﻿using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace a_Introductory
{

	public class Vector2DTest
	{
		Vector2D v1, v2, v3;

		[SetUp]
		public void setUp()
		{
			/* v1 and v3 are orthogonal, v1 and v2 aren't. */
			v1 = new Vector2D(-2, 4);
			v2 = new Vector2D(1, 2);
			v3 = new Vector2D(2, 1);
		}

		[Test]
		public void testDotProduct()
		{
			Assert.AreEqual(0, v1.dotProduct(v3), "v1 and v3 are orthogonal. The dot product should be zero.");
			Assert.AreEqual(6, v1.dotProduct(v2), "The dot product of v1 and v2 should be (-2 * 1) + (4 * 2) = 6");
		}

		[Test]
		public void testOrthogonality()
		{
			Assert.IsFalse(v1.isOrthogonalTo(v2), "v1 should not be orthogonal to v2");
			Assert.IsTrue(v1.isOrthogonalTo(v3), "v1 should be orthogonal to v3");
		}
	}
}