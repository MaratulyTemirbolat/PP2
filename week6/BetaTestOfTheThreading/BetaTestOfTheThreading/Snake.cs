using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace BetaTestOfTheThreading
{
	public class Snake
	{
		public int x;
		public int y;
		public enum Direction
		{
			NONE,
			UP,
			DOWN,
			LEFT,
			RIGHT
		}
		public Direction direction = Direction.NONE;
		public Snake(int x,int y)
		{
			this.x = x;
			this.y = y;
			
		}
		public void Move()
		{
			while (true)
			{
				if (direction == Direction.UP)
					y--;
				else if (direction == Direction.DOWN)
					y++;
				else if (direction == Direction.LEFT)
					x--;
				else if (direction == Direction.RIGHT)
					x++;
				Thread.Sleep(200);
				Console.Clear();
				Console.CursorVisible = false;
				Console.SetCursorPosition(x, y);
				Console.Write((char)2);
			}
		}
		public void ChangeOfTheDir()
		{
			while (true) {
				ConsoleKeyInfo KeyInfo = Console.ReadKey();
				if (KeyInfo.Key == ConsoleKey.RightArrow && direction != Direction.LEFT)
					direction = Direction.RIGHT;
				else if (KeyInfo.Key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
					direction = Direction.LEFT;
				else if (KeyInfo.Key == ConsoleKey.DownArrow && direction != Direction.UP)
					direction = Direction.DOWN;
				else if (KeyInfo.Key == ConsoleKey.UpArrow && direction != Direction.DOWN)
					direction = Direction.UP;
			}
		}
		
	}
}
