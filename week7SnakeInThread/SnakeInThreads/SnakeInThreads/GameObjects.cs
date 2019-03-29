using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeInThreads
{
	public class GameObjects
	{
		public List<Points> body;
		public char sign;
		public ConsoleColor color;
		public GameObjects()
		{
		}
		public GameObjects(int x,int y,char sign,ConsoleColor color)
		{
			body = new List<Points>()
			{
				new Points(x,y)
			};
			this.sign = sign;
			this.color = color;
		}
		public bool IsCollision(GameObjects GO)
		{
			for (int k = 0,j=1;k< GO.body.Count; k++)
			{
				if (GO.GetType() == typeof(Snake) && this.GetType() == typeof(Snake))
				{
					if (j == GO.body.Count)
						continue;
					if (this.body[0].x == GO.body[j].x && this.body[0].y == GO.body[j].y && GO.body.Count > 2)
						return true;
					
					j++;
				}
				else
				{
					if (this.body[0].x == GO.body[k].x && this.body[0].y == GO.body[k].y)
						return true;
				}
			}
			return false;
		}
		public void Draw()
		{
			Console.ForegroundColor = color;
			foreach(Points p in body)
			{
				Console.SetCursorPosition(p.x, p.y);
				Console.Write(sign);
			}
		}
	}
}
