using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace a_Introductory
{
	public class Line
	{
		private Tutorial_Point p1, p2;

		public Line(Tutorial_Point p1, Tutorial_Point p2)
		{
			this.p1 = p1;
			this.p2 = p2;
		}

		public Vector2D getVector()
		{
			return new Vector2D(p1, p2);
		}

		public double getLength()
		{
			return Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
		}

		public bool isSameLengthAs(Line l)
		{
			return (Math.Abs(getLength() - l.getLength()) < 0.00001);
		}
	}
}