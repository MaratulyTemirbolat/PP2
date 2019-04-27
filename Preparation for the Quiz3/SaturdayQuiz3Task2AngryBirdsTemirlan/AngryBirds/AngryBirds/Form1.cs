using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngryBirds
{
	public partial class Form1 : Form
	{
		
		public Point DownedPoint = new Point(300,200);
		public Point UpedPoint;
		Graphics g;
		int R = 10;
		Pen pen;
		public bool IsClicked;
		int SpeedX, SpeedY;
		public Form1()
		{
			InitializeComponent();
			IsClicked = false;
			
			pen = new Pen(Color.Brown);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (IsClicked == false)
			{
				IsClicked = true;
			}
			else
			{
				IsClicked = false;

			}
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (IsClicked)
			{
				DownedPoint = e.Location;
				Refresh();
			}
			
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			g = e.Graphics;
			
			g.FillEllipse(pen.Brush, DownedPoint.X - R, DownedPoint.Y - R, 2 * R, 2 * R);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			IsClicked = false;
			UpedPoint = e.Location;
			SpeedX = Math.Abs(DownedPoint.X - UpedPoint.X);
			SpeedY = Math.Abs(DownedPoint.Y - UpedPoint.Y);
		}
	}
}
