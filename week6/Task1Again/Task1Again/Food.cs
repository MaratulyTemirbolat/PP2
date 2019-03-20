using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Again
{
	public class Food:GameObjects
	{ 
		public Food(int x,int y,char sign,ConsoleColor color) : base(x, y, sign, color)
		{
		}
		public void Generate()
		{
			Random random = new Random();
			int x = random.Next(1, 66);
			int y = random.Next(1, 21);
			Body[0].x = x;
			Body[0].y = y;
		}
	}
}
