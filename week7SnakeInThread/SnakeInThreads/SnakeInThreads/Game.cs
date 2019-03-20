using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeInThreads
{
	public class Game
	{
		public string name;
		public Snake snake;
		public Wall wall;
		public Food food;
		public List<GameObjects> ListOfObjects;
		public bool IsAlive;
		public int Result;
		public int Speed;
		public Game()
		{

		}
		public Game(int Just,string name)
		{
			ListOfObjects = new List<GameObjects>();
			snake = new Snake(10, 10, 'O', ConsoleColor.Red);
			food = new Food(0, 0, '*', ConsoleColor.Black);
			wall = new Wall(0, 0, '#', ConsoleColor.Green);
			Result = 0;
			this.name = name;
			Speed = 200;
			while (food.IsCollision(snake) || food.IsCollision(wall))
			{
				food.Generate();
			}
			wall.LoadLevel();
			IsAlive = true;
			ListOfObjects.Add(snake);
			ListOfObjects.Add(food);
			ListOfObjects.Add(wall);
		}
		public void Start()
		{
			Thread thread = new Thread(MoveSnake);
			thread.Start();
			while (IsAlive)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				snake.ChangeDirection(keyInfo);
			}
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition(20, 20);
			Console.Write("GAME OVER!!!");
			Console.ReadKey();
			

		}
		public void MoveSnake()
		{
			while (IsAlive)
			{
				snake.Move();
				if (snake.IsCollision(food))
				{
					snake.body.Add(new Points(0,0));
					food.Generate();
					Result++;
					if (Result % 3 == 0)
					{
						wall.NextLevel();
						Speed -= 200;
						Speed = Math.Max(100, Speed);
					}
				}
				if (food.IsCollision(wall))
				{
					food.Generate();
				}
				if (snake.IsCollision(snake) || snake.IsCollision(wall))
					IsAlive = false;

				Show();
				Thread.Sleep(Speed);
			}
		}
		public void Show()
		{
			//Console.Clear();
			Console.SetCursorPosition(snake.EndX, snake.EndY);
			Console.Write(' ');
			foreach(GameObjects g in ListOfObjects)
			{
				g.Draw();
				if (g.GetType() == typeof(Snake))
				{
					Console.SetCursorPosition(snake.body[0].x, snake.body[0].y);
					Console.Write((char)2);
				}
				Console.ForegroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(0, 28);
				Console.Write("Your score is: " + Result);
			}
		}
	}
}
