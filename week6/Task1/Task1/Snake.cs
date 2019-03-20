using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public class Snake:GameObjects
	{
		public Snake(int x,int y,char sign,ConsoleColor color) : base(x, y, sign, color)
		{
		}
		public void Move(ConsoleKeyInfo keyInfo)
		{			
				for(int k = Body.Count; k > 0; k--)
			{
				Body[k].x = Body[k-1].x;
				Body[k].y = Body[k-1].y;
			}
				if (keyInfo.Key == ConsoleKey.RightArrow)
					Body[0].x++;
				if (keyInfo.Key == ConsoleKey.LeftArrow)
					Body[0].x--;
				if (keyInfo.Key == ConsoleKey.DownArrow)
					Body[0].y++;
				if (keyInfo.Key == ConsoleKey.UpArrow)
					Body[0].y--;
			
		}
	}
}
