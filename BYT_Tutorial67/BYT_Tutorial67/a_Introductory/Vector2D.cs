using System;
using System.Collections.Generic;
using System.Text;

namespace a_Introductory
{
	public class Vector2D
	{
		public Int32 x, y;

		public Vector2D(Int32 x, Int32 y)
		{
			this.x = x;
			this.y = y;
		}

		/* Construct Vector2D from two points */
		public Vector2D(Tutorial_Point p1, Tutorial_Point p2)
		{
			this.x = p2.x - p1.x;
			this.y = p2.y - p1.y;
		}

		public int dotProduct(Vector2D v)
		{
			return (x * v.x) + (y * v.y);
		}

		public bool isOrthogonalTo(Vector2D v)
		{
			return (dotProduct(v) == 0);
		}
	}
}