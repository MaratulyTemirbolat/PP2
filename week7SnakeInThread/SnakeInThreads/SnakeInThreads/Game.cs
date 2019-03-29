using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace SnakeInThreads
{
	public class Game
	{
		public bool StopGame;
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
			StopGame = true;
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
			while (IsAlive==true && StopGame == true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				if(keyInfo.Key == ConsoleKey.Escape)
				{
					Console.Clear();
					StopGame = false;
					Console.Clear();
				}
				snake.ChangeDirection(keyInfo);
			}
			IsAlive = true;
			Save();
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition(20, 20);
			Console.Write("GAME OVER!!!");
			Console.ReadKey();
		}
		public void Save()
		{
			FileStream fs = new FileStream("save1.xml", FileMode.Truncate, FileAccess.Write);
			XmlSerializer ser = new XmlSerializer(typeof(Game));
			ser.Serialize(fs, this);
			fs.Close();
		}
		public Game load()
		{
			FileStream fs = new FileStream("save1.xml", FileMode.Open, FileAccess.Read);
			XmlSerializer xs = new XmlSerializer(typeof(Game));
			Game newgame = xs.Deserialize(fs) as Game;
			fs.Close();
			return newgame;
		}
		public void MoveSnake()
		{
			while (IsAlive==true && StopGame ==true)
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
					Console.Clear();
					food.Generate();
				}
				if (snake.IsCollision(snake) || snake.IsCollision(wall) ||StopGame==false)
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
			foreach (GameObjects g in ListOfObjects)
			{
				g.Draw();
				if (g.GetType() == typeof(Snake))
				{
					Console.SetCursorPosition(snake.body[0].x, snake.body[0].y);
					Console.Write((char)2);
				}
				Console.ForegroundColor = ConsoleColor.Black;
				Console.SetCursorPosition(0, 27);
				Console.Write("Your score is: " + Result);
				Console.SetCursorPosition(0, 28);
				Console.Write("Your name is: " + name);
			}
		}
	}
}
