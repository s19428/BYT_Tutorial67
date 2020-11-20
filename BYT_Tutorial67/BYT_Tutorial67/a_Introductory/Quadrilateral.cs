using System;
using System.Collections.Generic;
using System.Text;

namespace a_Introductory
{
	public class Quadrilateral
	{
		private Tutorial_Point p1, p2, p3, p4;
		private Line l1, l2, l3, l4;

		public Quadrilateral(Tutorial_Point p1, Tutorial_Point p2, Tutorial_Point p3, Tutorial_Point p4)
		{
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.l1 = new Line(p1, p2);
			this.l2 = new Line(p2, p3);
			this.l3 = new Line(p3, p4);
			this.l4 = new Line(p4, p1);
		}

		public bool isRectangle()
		{
			Vector2D v1 = l1.GetVector();
			Vector2D v2 = l2.GetVector();
			Vector2D v3 = l3.GetVector();
			Vector2D v4 = l4.GetVector();

			return (v1.isOrthogonalTo(v2) &&
					v2.isOrthogonalTo(v3) &&
					v3.isOrthogonalTo(v4) &&
					v4.isOrthogonalTo(v1));
		}

		public bool isSquare()
		{
			return (isRectangle() &&
					l1.isSameLengthAs(l2));
		}

	}
}