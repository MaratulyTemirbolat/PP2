using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeInThreads
{
	public class Snake:GameObjects
	{
		public int EndX,EndY;
		enum Direction
		{
			NONE ,
			RIGHT ,
			LEFT ,
			UP ,
			DOWN
		}
		Direction direction = Direction.NONE;
	public Snake()
		{

		}
		public Snake(int x,int y,char sing,ConsoleColor color) : base(x, y, sing, color)
		{
		}
		public void Move()
		{
			EndX = body[body.Count - 1].x;
			EndY = body[body.Count - 1].y;
			
			if (direction == Direction.NONE)
				return;
			for(int k = body.Count-1; k > 0; k--)
			{
				body[k].x = body[k - 1].x;
				body[k].y = body[k - 1].y;
			}
			if (direction == Direction.LEFT)
			{
				if (body[0].x == 0)
					body[0].x = Console.WindowWidth-1;
				else 
				body[0].x--;
			}
			if (direction == Direction.RIGHT)
			{
				if (body[0].x == Console.WindowWidth-1)
					body[0].x = 0;
				else
				body[0].x++;
			}
			if (direction == Direction.UP)
			{
				if (body[0].y == 0)
					body[0].y = Console.WindowHeight-1;
				else
				body[0].y--;
			}
			if (direction == Direction.DOWN)
			{
				if (body[0].y == Console.WindowHeight-1)
					body[0].y = 0;
				else
				body[0].y++;
			}
		}
		public void ChangeDirection(ConsoleKeyInfo keyInfo)
		{
			if (keyInfo.Key == ConsoleKey.RightArrow && direction != Direction.LEFT)
				direction = Direction.RIGHT;
			if (keyInfo.Key == ConsoleKey.DownArrow && direction != Direction.UP)
				direction = Direction.DOWN;
			if (keyInfo.Key == ConsoleKey.UpArrow && direction != Direction.DOWN)
				direction = Direction.UP;
			if (keyInfo.Key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
				direction = Direction.LEFT;
		}
		
	}
}
