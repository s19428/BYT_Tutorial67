using System;
using System.Collections.Generic;
using System.Text;

namespace a_Introductory
{
	public class Tutorial_Point
	{
		public Int32 x, y;

		public Tutorial_Point(Int32 x, Int32 y)
		{
			this.x = x;
			this.y = y;
		}

		public Tutorial_Point add(Tutorial_Point p)
		{
			return new Tutorial_Point(x + p.x, y + p.y);
		}

		public Tutorial_Point sub(Tutorial_Point p)
		{
			return new Tutorial_Point(x - p.x, y - p.y);
		}
	}
}