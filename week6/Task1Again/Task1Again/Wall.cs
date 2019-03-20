using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1Again
{
	public class Wall:GameObjects
	{
		enum GameLevel
		{
			FIRST,
			SECOND 
		}
		GameLevel Level = GameLevel.FIRST;
		public Wall(int x, int y, char sign, ConsoleColor color) : base(0,0, sign, color)
		{
			Body = new List<Points>();
		}
		public void LoadLevel()
		{
			Body = new List<Points>();
			string LelelName = "level1.txt";
			if (Level == GameLevel.SECOND)
				LelelName = "level2.txt";
			StreamReader sr = new StreamReader(LelelName);
			string[] rows = sr.ReadToEnd().Split('\n');
			for(int k = 0; k < rows.Length; k++)
			{
				for(int j = 0; j < rows[k].Length; j++)
				{
					if (rows[k][j] == '#')
						Body.Add(new Points(j, k));
				}
			}
		}
		public void NextLevel()
		{
			Console.Clear();
			if (Level == GameLevel.FIRST)
			{
				Level = GameLevel.SECOND;
			}
			LoadLevel();
		}
		
	}
}
