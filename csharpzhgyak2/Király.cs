using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpzhgyak2
{
	internal class Király : Figura, IComparable<Király>
	{
		string szín;
		public Király(int x, int y, string szín) : base(x, y)
		{
			if(szín=="fekete"|| szín == "fehér")
			{
				this.szín = szín;
			}
			else
			{
				this.szín = "Nem definiált";
			}
			
		}

		public override bool VéletlenLép()
		{
			Random rnd = new Random();
			int rx=rnd.Next(-1,2);
			int ry=rnd.Next(-1,2);
			if (rx == 0 && ry == 0) return false;
			if(x+rx<0 || x+rx>7 || y+ry<0 ||y+ry>7) return false;
			x = x + rx;
			y= y + ry;
			return true;
		}
		public override string ToString()
		{
			return $"Király, színe:{szín}, pozíciója: {x}, {y}";
		}

		public int CompareTo(Király? other)
		{
			return (this.x+this.y).CompareTo(other.x+other.y);
		}
	}
}
