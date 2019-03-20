using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public class GameObjects
	{
		public List<Points> Body;
		public char sign;
		public ConsoleColor color;
		public GameObjects()
		{

		}
		public GameObjects(int x,int y,char sign,ConsoleColor color)
		{
			Body = new List<Points>()
			{
				new Points(x,y)
			};
			this.sign = sign;
			this.color = color;
		}
		public void Draw()
		{
			Console.ForegroundColor  = color;
			foreach(Points p in Body)
			{
				Console.SetCursorPosition(p.x, p.y);
				Console.Write(sign);
			}
		}
	}
}
