using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Again
{
	public class GameObjects
	{
		public List<Points> Body;
		public char sign;
		public ConsoleColor color;
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
			Console.ForegroundColor = color;
			foreach(Points p in Body)
			{
				Console.SetCursorPosition(p.x, p.y);
				Console.Write(sign);
			}
		}
		public bool IsCollision(GameObjects GO)
		{
			for (int k = 0; k < GO.Body.Count; k++)
			{
				if (GO.GetType() == typeof(Snake) && this.GetType()==typeof(Snake))
				{	
					if (this.Body[0].x == GO.Body[k].x && this.Body[0].y == GO.Body[k].y)
						return true;
				}
				else
				{
					if (this.Body[0].x == GO.Body[k].x && this.Body[0].y == GO.Body[k].y)
						return true;
				}
			}
			return false;
		}
	}
}
