using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
	public partial class Form1 : Form
	{
		enum Directions
		{
			NONE,
			LEFT,
			RIGHT,
			DOWN,
			UP
		}
		Point RecT = new Point(300, 300);
		Directions dir = Directions.NONE;
		Random random = new Random();
		int Width = 50, Height = 50;
		int R = 10;
		Pen pen = new Pen(Color.Black);
		Point Shar = new Point(400, 100);
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		public void Up(object sender,EventArgs e)
		{
			dir = Directions.UP;
			timer1.Start();
		}
		public void Down(object sender,EventArgs e)
		{
			dir = Directions.DOWN;
			timer1.Start();
		}
		public void Left(object sender,EventArgs e)
		{
			dir = Directions.LEFT;
			timer1.Start();
		}
		public void Right(object sender,EventArgs e)
		{
			dir = Directions.RIGHT;
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (IsCollision())
			{
				Shar.X = random.Next(2,600);
				Shar.Y = random.Next(2, 600);
			}
			if(dir == Directions.RIGHT)
			{
				RecT.X += 5;
			}
			if(dir == Directions.DOWN)
			{
				RecT.Y += 5;
			}
			if(dir == Directions.LEFT)
			{
				RecT.X -= 5;
			}
			if(dir == Directions.UP)
			{
				RecT.Y -= 5;
			}
			
			Refresh();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			g.FillRectangle(pen.Brush, RecT.X, RecT.Y, Width, Height);
			g.FillEllipse(pen.Brush, Shar.X-R, Shar.Y-R, 2 * R, 2 * R);
			
		}
		public bool IsCollision()
		{
			if ((Shar.X < RecT.X + Width && Shar.X > RecT.X) && (Shar.Y > RecT.Y && Shar.Y < RecT.Y + Height))
				return true;
			return false;
		}
	}
}
