using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task1Again
{
	public class Snake:GameObjects
	{
		
		public int endX, endY;
		public enum Direction
		{
			NONE,
			LEFT,
			RIGHT,
			DOWN,
			UP
		}
		public Direction direction = Direction.NONE;
		public Snake(int x, int y, char sign, ConsoleColor color) : base(x, y, sign, color)
		{
			
		}
		public void ChangeDirection()
		{
			
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				if (keyInfo.Key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
					direction = Direction.LEFT;
				else if (keyInfo.Key == ConsoleKey.RightArrow && direction != Direction.LEFT)
					direction = Direction.RIGHT;
				else if (keyInfo.Key == ConsoleKey.DownArrow && direction != Direction.UP)
					direction = Direction.DOWN;
				else if (keyInfo.Key == ConsoleKey.UpArrow && direction != Direction.DOWN)
					direction = Direction.UP;
		}
		public  void Move()
		{
			while (true)
			{
				//endx = body[body.count - 1].x;
				//endy = body[body.count - 1].y;
				for (int k = Body.Count-1; k > 0; k--)
				{
					Body[k].x = Body[k - 1].x;
					Body[k].y = Body[k - 1].y;
				}
				if (direction == Direction.UP)
					Body[0].y--;
				else if (direction == Direction.DOWN)
					Body[0].y++;
				else if (direction == Direction.LEFT)
					Body[0].x--;
				else if (direction == Direction.RIGHT)
					Body[0].x++;
				
			}
		}
		//public void Move(ConsoleKeyInfo keyInfo)
		//{
		//	endX = Body[Body.Count - 1].x;
		//	endY = Body[Body.Count - 1].y;
		//	if (keyInfo.Key == ConsoleKey.RightArrow && direction != Direction.LEFT)
		//	{
				
		//		for (int k = Body.Count - 1; k > 0; k--)
		//		{
		//			Body[k].x = Body[k - 1].x;
		//			Body[k].y = Body[k - 1].y;
		//		}
		//		direction = Direction.RIGHT;
		//		Body[0].x++;
		//	}
		//	else if (keyInfo.Key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
		//	{
		//		for (int k = Body.Count - 1; k > 0; k--)
		//		{
		//			Body[k].x = Body[k - 1].x;
		//			Body[k].y = Body[k - 1].y;
		//		}
		//		direction = Direction.LEFT;
		//		Body[0].x--;
				
		//	}

		//	else if (keyInfo.Key == ConsoleKey.DownArrow && direction != Direction.UP)
		//	{
		//		for (int k = Body.Count - 1; k > 0; k--)
		//		{
		//			Body[k].x = Body[k - 1].x;
		//			Body[k].y = Body[k - 1].y;
		//		}
		//		direction = Direction.DOWN;
		//		Body[0].y++;
				
		//	}
		//	else if (keyInfo.Key == ConsoleKey.UpArrow && direction != Direction.DOWN)
		//	{
		//		for (int k = Body.Count - 1; k > 0; k--)
		//		{
		//			Body[k].x = Body[k - 1].x;
		//			Body[k].y = Body[k - 1].y;
		//		}
		//		direction = Direction.UP;
		//		Body[0].y--;
				
		//	}
			
		//}
	}
}
