using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task1Again
{
	public class Game
	{
		public bool HeadOfTheSnake = true;
		public Snake snake;
		public Wall wall;
		public int Score;
		List<GameObjects> games;
		public Food food;
		public Game()
		{
		}
		public Game(int Just)
		{
			wall = new Wall(0,0,'#', ConsoleColor.Cyan);
			games = new List<GameObjects>();
			food = new Food(5,2, '$', ConsoleColor.Black);
			snake = new Snake(9, 10, (char)2, ConsoleColor.Red);
			Score = 0;
			wall.LoadLevel();
			while (food.IsCollision(wall) || food.IsCollision(snake))
			{
				food.Generate();
			}
			games.Add(food);
			games.Add(snake);
			games.Add(wall);
		
		}
		public void StartTheGame()
		{
			Thread thread = new Thread(snake.ChangeDirection);
			thread.Start();
			while (true)
			{
				//Show();
				if (snake.IsCollision(food))
				{
					Score++;
					if (Score % 3 == 0)
					{
						wall.NextLevel();
					}
					snake.Body.Add(new Points(0, 0));
					food.Generate();
				}
				if (food.IsCollision(wall))
					food.Generate();
				if (snake.IsCollision(wall))
				{
					Console.Clear();
					Console.SetCursorPosition(20, 10);
					Console.WriteLine("GAME OVER!!!");
					Console.ReadKey();
					return;
				}
				snake.Move();
			}
		}
		public void Show()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(1, 26);
			Console.Write("Your Score is : "+Score);
			foreach (GameObjects g in games)
			{

				//if (g.GetType() == typeof(Snake))
				//{
				//	Console.SetCursorPosition(snake.endX, snake.endY);
				//	Console.Write(' ');
				//}
					g.Draw();
				Thread.Sleep(200);
			}
		}
	}
}
