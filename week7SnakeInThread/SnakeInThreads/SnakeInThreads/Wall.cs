using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeInThreads
{
	public class Wall:GameObjects
	{
		enum Levels
		{
			FIRST,
			SECOND,
			THIRD
		}
		Levels level = Levels.FIRST;
		public Wall()
		{
		}
		public Wall(int x, int y, char sign, ConsoleColor color) : base(x, y, sign, color)
		{

		}
		public void LoadLevel()
		{
			body = new List<Points>();
				string place = "level1.txt";
			 if (level == Levels.SECOND)
				 place = "level2.txt";
			StreamReader sr = new StreamReader(place);
			string[] rows = sr.ReadToEnd().Split('\n');
			for(int k = 0; k < rows.Length; k++)
			{
				for (int j = 0; j < rows[k].Length; j++)
				{
					if (rows[k][j] == '#')
						body.Add(new Points(j, k));
				}
			}
			sr.Close();
		}
		public void NextLevel()
		{
			Console.Clear();
			if (level == Levels.FIRST)
				level = Levels.SECOND;
			LoadLevel();
		}
	}
}
