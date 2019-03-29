using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeInThreads
{
	public class Menu
	{
		public string nameOfThePlayer;
		public string[] TheMainest = new string[4];
		public int cursor=0;
		public string Name = null;
		public Game game;
		public Menu()
		{
		}
		public Menu(string nameOfperson)
		{
			nameOfThePlayer = nameOfperson;
		}
		public void Color(int index,string n)
		{
			if(index == cursor)
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				Name = n;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Black;
			}
			
		}
		public void ShowMenu()
		{
			Console.Clear();
			StreamReader sr = new StreamReader("menu.txt");
			string[] Main = sr.ReadToEnd().Split('\n');
			TheMainest = new string[4];
			for(int k = 0; k < Main.Length; k++)
			{
				for(int j = 0; j < Main[k].Length;j++)
				{
					if (Main[k][j] != '.')
						TheMainest[k] += Main[k][j];
				}
			}
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write("			 THE MAIN MENU"+"\n\n");
			for(int k = 0; k < TheMainest.Length; k++)
			{
				Color(k,TheMainest[k]);
				Console.Write("\t\t\t  ");
				Console.Write ( TheMainest[k]);
				Console.Write("\n");
			}
		}
		public void Down()
		{
			cursor+=2;
			if (cursor == 4)
				cursor = 0;
		}
		public void Up()
		{
			cursor-=2;
			if (cursor < 0)
				cursor = 2;
		}
		
		public void Start()
		{
			ShowMenu();
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				if (keyInfo.Key == ConsoleKey.DownArrow)
					Down();
				else if (keyInfo.Key == ConsoleKey.UpArrow)
					Up();
				else if(keyInfo.Key == ConsoleKey.Enter)
				{
					if (Name == TheMainest[0])
					{
						Console.Clear();
						game = new Game(0,nameOfThePlayer);
						game.Start();
					}
					else if (Name == TheMainest[2])
					{
						Console.Clear();
						Game LoadGame = game.load();
						//LoadGame.snake.sign = 'O';
						LoadGame.IsAlive = true;
						LoadGame.StopGame = true;
						LoadGame.Start();
					}
				}
				ShowMenu();
			}
		}
	}
}
