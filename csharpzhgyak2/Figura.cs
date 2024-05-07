using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpzhgyak2
{
	internal abstract class Figura
	{
		protected int x;
		protected int y;

		protected Figura(int x, int y)
		{
			if(x>=0 && x <= 7)
			{
				this.x = x;
			}
			else
			{
				this.x = 4;
			}
			if (y >= 0 && y <= 7)
			{
				this.y = y;
			}
			else
			{
				this.y = 4;
			}
		}
		public int getX()
		{
			return x;
		}
		public int getY()
		{
			return y;
		}

		public void setX(int x)
		{
			this.x = x;
		}
		public void setY(int y)
		{
			this.y = y;
		}

		public abstract bool VéletlenLép();
	}
}
