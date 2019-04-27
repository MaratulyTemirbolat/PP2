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
		public Point DownPoint;
		public Point UpPoint;
		public double X1, Y1;
		public double t = 0;
		public double Vx, Vy;
		public double angle;
		public double Speed;
		public double g = 9.8;
		public double R = 10;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillEllipse(new Pen(Color.Aqua).Brush, UpPoint.X + (int)(50*X1-R), UpPoint.Y+(int)(-50*Y1-R),(int)(2*R),(int)(2*R));
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			DownPoint = e.Location;
			t = 0;
			timer1.Stop();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			t += 0.1;
			X1 = (Math.Cos(angle) * Speed) * t;
			Y1 = (Math.Sin(angle) * Speed) * t - (g * t * t) / 2;
			Refresh();
			if (Speed == 0)
				timer1.Stop();
			else if (Vy - Y1 - R>Vy)
				timer1.Stop();
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			UpPoint = e.Location;
			Vx = UpPoint.X - DownPoint.X;
			Vy = UpPoint.Y - UpPoint.Y;
			angle = Math.Atan2(Vy, Vx);
			Speed = Math.Sqrt((Vy * Vy) + (Vx * Vx));
			timer1.Start();
		}
	}
}
