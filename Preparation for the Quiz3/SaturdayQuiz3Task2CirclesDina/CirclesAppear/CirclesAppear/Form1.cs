using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirclesAppear
{
	public partial class Form1 : Form
	{
		Bitmap bitmap;
		bool IsClicked;
		Graphics gBitmap;
		Point CurPoint;
		int Dir;
		Color[] colors;
		Random randomForColors,randomForDirections;
		int forColors;
		int R = 15;
		
		public Form1()
		{
			InitializeComponent();
			
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			IsClicked = true;
			CurPoint = e.Location;
			Dir = randomForDirections.Next(1, 5);
			forColors = randomForColors.Next(0, colors.Length);
			timer1.Start();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			IsClicked = false;
			gBitmap = Graphics.FromImage(bitmap);
			pictureBox1.Image = bitmap;
			randomForColors = new Random();
			randomForDirections = new Random();
			colors = new Color[] { Color.Red, Color.Blue, Color.Pink, Color.Yellow, Color.Green, Color.Gold, Color.Black,Color.Aqua };
			
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			if (IsClicked)
			{
				gBitmap.FillEllipse(new Pen(colors[forColors]).Brush, CurPoint.X - R, CurPoint.Y - R, 2 * R, 2 * R);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			pictureBox1.Refresh();
			if (Dir == 1)
			{
				CurPoint.X -= (R+15);
			}
			else if(Dir == 2)
			{
				CurPoint.X += (R+15);
			}
			else if(Dir == 3)
			{
				CurPoint.Y -= (R+15);
			}
			else if(Dir == 4)
			{
				CurPoint.Y += (R+15);
			}
		}
	}
}
