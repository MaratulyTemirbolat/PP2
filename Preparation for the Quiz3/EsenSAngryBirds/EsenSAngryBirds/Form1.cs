using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsenSAngryBirds
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int x2, y2;
		double x1, y1;
		int x, y;
		double a = 1;//угол 1 радиан
		double t = 0;//время
		double V = 10;//скорость
		const double g = 9.8;

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillEllipse(pen.Brush, x2 + (int)(( x1 - r)), y2 + (int)((-y1 - r)), (int)(2 * r), (int)(2 * r));
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{

			x = e.Location.X;
			y = e.Location.Y;
			t = 0;
			timer1.Stop();
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			x2 = e.Location.X;
			y2 = e.Location.Y;
			int a1 = y2 - y;
			int b = x2 - x;
			double angle = Math.Atan2(a1, b);
			double Vel = Math.Sqrt((x2 - x) * (x2 - x) + (y2 - y) * (y2 - y));
			V = Vel;
			a = angle;
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			t += 0.01;
			x1 = (V * Math.Cos(a)) * t;
			y1 = (V * Math.Sin(a)) * t - g * t * t / 2;
			Refresh();
			Invalidate();
			if (V == 0)
				timer1.Stop();
			if (y + (int)((-50 * y1 - r)) > y)
			{
				timer1.Stop();

			}
		}

		double r = 10;
		Pen pen = new Pen(Color.Red, 3);
		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
