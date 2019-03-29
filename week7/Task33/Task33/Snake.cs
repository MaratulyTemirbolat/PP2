using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task33
{
	class Snake
	{
		public int k = 0;
		public List<Points> body;
		public char sign;
		public ConsoleColor color;
		public Snake()
		{

		}
		enum Direction
		{
			NONE,
			LEFT,
			RIGHT,
			UP,
			DOWN
		}
		Direction direction;
		public Snake(int x, int y, char sign, ConsoleColor color)
		{
			body = new List<Points>()
			{
				new Points(x,y)
			};
			this.sign = sign;
			this.color = color;
			direction = Direction.NONE;
		}
		public void Move()
		{
			
			for(int k = body.Count-1; k>0; k--)
			{
				//body[k] = body[k - 1];
				body[k].x = body[k - 1].x;
				body[k].y = body[k - 1].y;
			}
				if (direction == Direction.NONE)
					return;
				else if (direction == Direction.RIGHT)
					body[0].x++;
				else if (direction == Direction.LEFT)
					body[0].x--;
				else if (direction == Direction.DOWN)
					body[0].y++;
				else if (direction == Direction.UP)
					body[0].y--;
			k++;
			if (k == 7)
			{
				body.Add(new Points(0, 0));
				k = 0;
			}
				Show();
			Thread.Sleep(200);
			
		}
		public void Show()
		{
			Console.Clear();
				Console.ForegroundColor = color;
				foreach (Points p in body)
				{
					Console.SetCursorPosition(p.x, p.y);
					Console.Write(sign);
				}
			
		}
		public void ChangeDirection()
		{
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				if (keyInfo.Key == ConsoleKey.DownArrow && direction != Direction.UP)
					direction = Direction.DOWN;
				else if (keyInfo.Key == ConsoleKey.UpArrow && direction != Direction.DOWN)
					direction = Direction.UP;
				else if (keyInfo.Key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
					direction = Direction.LEFT;
				else if (keyInfo.Key == ConsoleKey.RightArrow && direction != Direction.LEFT)
					direction = Direction.RIGHT;
			}
		}
	}
}
