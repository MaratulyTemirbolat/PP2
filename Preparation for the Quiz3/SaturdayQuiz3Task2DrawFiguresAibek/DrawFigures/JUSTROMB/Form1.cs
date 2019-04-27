using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUSTROMB
{
	public partial class Form1 : Form
	{
		bool FirstTime = true;
		Bitmap bitmap;
		Graphics gBitmap;
		Point CurPoint;
		bool IsClicked;
		Random random;
		Color[] colors;
		int RandFigure, RandColor;
		int R;
		Pen pen;
		Point[] Romb;
		Point[] Star;
		public Form1()
		{
			InitializeComponent();
			
		}
		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			RandColor = random.Next(0, colors.Length);
			pen = new Pen(colors[RandColor], 4);
			
			 if (RandFigure == 1)
			{
				gBitmap.DrawEllipse(pen, CurPoint.X - R, CurPoint.Y - R, 2 * R, 2 * R);
			}
			else if (RandFigure == 2)
			{
				gBitmap.DrawRectangle(pen, CurPoint.X - R, CurPoint.Y - R, 3 * R, 2 * R);
			}
			else if (RandFigure == 3)
			{
				Romb = new Point[] { new Point(CurPoint.X, CurPoint.Y - R), new Point(CurPoint.X - R, CurPoint.Y), new Point(CurPoint.X, CurPoint.Y + R), new Point(CurPoint.X + R, CurPoint.Y), new Point(CurPoint.X, CurPoint.Y - R) };
				gBitmap.DrawPolygon(pen, Romb);
			}
			else if (RandFigure == 4)
			{
				Star = new Point[] { new Point(CurPoint.X, CurPoint.Y - (3 * R)), new Point(CurPoint.X - R, CurPoint.Y - R), new Point(CurPoint.X - (3 * R), CurPoint.Y), new Point(CurPoint.X - R, CurPoint.Y + R), new Point(CurPoint.X, CurPoint.Y + (3 * R)), new Point(CurPoint.X + R, CurPoint.Y + R), new Point(CurPoint.X + (3 * R), CurPoint.Y), new Point(CurPoint.X + R, CurPoint.Y - R), new Point(CurPoint.X, CurPoint.Y - (3 * R)) };
				gBitmap.DrawPolygon(pen, Star);
			}
			

		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (IsClicked == false)
			{

				if (FirstTime)
				{
					RandFigure = random.Next(1, 5);
					FirstTime = false;
				}
				else
				{
					RandFigure++;
					if (RandFigure == 5)
					{

						RandFigure = 1;
					}
				}
				CurPoint = e.Location;
				IsClicked = true;
				timer1.Start();
			}
			else
			{
				R = 10;
				timer1.Stop();
				IsClicked = false;
				
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			R += 10;
			pictureBox1.Refresh();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			gBitmap = Graphics.FromImage(bitmap);
			pictureBox1.Image = bitmap;
			IsClicked = false;
			
			random = new Random();
			colors = new Color[] { Color.Red, Color.Black, Color.Pink, Color.Aqua, Color.Aquamarine, Color.Green };
			Romb = new Point[] { new Point(CurPoint.X, CurPoint.Y - R), new Point(CurPoint.X - R, CurPoint.Y), new Point(CurPoint.X, CurPoint.Y + R), new Point(CurPoint.X + R, CurPoint.Y), new Point(CurPoint.X, CurPoint.Y - R)};
			Star = new Point[] { new Point(CurPoint.X, CurPoint.Y - (3 * R)), new Point(CurPoint.X - R, CurPoint.Y - R), new Point(CurPoint.X - (3 * R), CurPoint.Y), new Point(CurPoint.X - R, CurPoint.Y + R), new Point(CurPoint.X, CurPoint.Y + (3 * R)), new Point(CurPoint.X + R, CurPoint.Y + R), new Point(CurPoint.X + (3 * R), CurPoint.Y), new Point(CurPoint.X + R, CurPoint.Y - R), new Point(CurPoint.X, CurPoint.Y - (3 * R)) };
			R = 10;
		}
	}
}
