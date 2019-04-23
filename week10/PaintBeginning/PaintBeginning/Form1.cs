using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintBeginning
{
	public partial class Form1 : Form
	{
		Bitmap bitmap;
		Graphics graBitmap;
		Pen pen;
		public Point PrevPoint, CurPoint;
		public bool IsClicked = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			graBitmap = Graphics.FromImage(bitmap);
			pictureBox1.Image = bitmap;
			pen = new Pen(Color.Black);
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			IsClicked = false;
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (IsClicked)
			{
				CurPoint = e.Location;
				graBitmap.DrawLine(pen, PrevPoint, CurPoint);
				PrevPoint = CurPoint;
				pictureBox1.Refresh();
			}
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			IsClicked = true;
			PrevPoint = e.Location;
		}
	}
}
