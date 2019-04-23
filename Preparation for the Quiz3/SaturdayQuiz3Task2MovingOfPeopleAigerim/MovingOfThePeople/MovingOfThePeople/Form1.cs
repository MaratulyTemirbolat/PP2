using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingOfThePeople
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Bitmap bitmap;
		Pen pen;
		Point Person1;
		Point Person2;
		bool IsClicked = false;
		int R = 15;
		Graphics gBitmap;
		Point[] points;
		private void Form1_Load(object sender, EventArgs e)
		{
			points = new Point[] {new Point(190,120),new Point(170,140),new Point(190,160),new Point(210,140),new Point(190,120)};
			Person1 = new Point(80, 220);
			Person2 = new Point(140, 220);
			
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			gBitmap = Graphics.FromImage(bitmap);
			pen = new Pen(Color.Blue);
			pictureBox1.Image = bitmap;
			gBitmap.FillRectangle(pen.Brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
			pen.Color = Color.Green;
			gBitmap.FillRectangle(pen.Brush,0,(pictureBox1.Height/2)+60,pictureBox1.Width,pictureBox1.Height);
			pen.Color = Color.Yellow;
			gBitmap.FillEllipse(pen.Brush, 15, 30, 110, 110);
			pen.Color = Color.Blue;
			gBitmap.FillEllipse(pen.Brush, 45, 35, 80, 80);
			pen.Color = Color.White;
			gBitmap.FillPolygon(pen.Brush,points);
			points = new Point[] { new Point(350,5), new Point(330,25), new Point(350,45), new Point(370,25), new Point(350,5) };
			gBitmap.FillPolygon(pen.Brush,points);
			points = new Point[] { new Point(390,120), new Point(370,140), new Point(390,160), new Point(410,140), new Point(390,120)};
			gBitmap.FillPolygon(pen.Brush,points);
			points = new Point[] { new Point(520,60), new Point(500,80), new Point(520,100), new Point(540,80), new Point(520,60) };
			gBitmap.FillPolygon(pen.Brush,points);
			points = new Point[] { new Point(700,160), new Point(680,180), new Point(700,200), new Point(720,180), new Point(700,160) };
			gBitmap.FillPolygon(pen.Brush,points);
			
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillEllipse(new Pen(Color.Red).Brush, Person1.X, Person1.Y, 2 * R, 2 * R);
			e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + (2 * R),Person1.X +R,Person1.Y+(5*R));
			e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + (2 * R), Person1.X + (2 * R), Person1.Y + (3 * R));
			e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + (2 * R), Person1.X - (R), Person1.Y + (3 * R));
			e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + (5 * R), Person1.X + (2 * R), Person1.Y + (7 * R));
			e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + (5 * R), Person1.X - (1 * R), Person1.Y + (7 * R));
			e.Graphics.FillEllipse(new Pen(Color.Red).Brush, Person2.X, Person2.Y, 2 * R, 2 * R);
			e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + (2 * R), Person2.X + R, Person2.Y + (5 * R));
			e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + (2 * R), Person2.X + (2 * R), Person2.Y + (3 * R));
			e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + (2 * R), Person2.X - (R), Person2.Y + (3 * R));
			e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + (5 * R), Person2.X + (2 * R), Person2.Y + (7 * R));
			e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + (5 * R), Person2.X - (1 * R), Person2.Y + (7 * R));
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (IsClicked)
			{
				Person1.X -= R;
				Person2.X += R;
				pictureBox1.Refresh();
			}
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (IsClicked == false)
			{
				timer1.Start();
				IsClicked = true;
			}
			else
			{
				timer1.Stop();
				IsClicked = false;
			}
		}
	}
}
