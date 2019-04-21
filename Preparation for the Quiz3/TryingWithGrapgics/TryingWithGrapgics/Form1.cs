using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryingWithGrapgics
{
	public partial class Form1 : Form
	{
		Graphics g;
		public Form1()
		{
			InitializeComponent();
		
			Point First = new Point(10, 10);
			Point Second = new Point(50, 50);
			int Len = Math.Abs(First.X - Second.X);
			int Weig = Math.Abs(Second.Y - Second.Y);
			Pen pen = new Pen(Color.Red);
			pen.Width = 3;
			
		//	g.DrawRectangle(pen, First.X, First.Y, Len, Weig);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			g = e.Graphics;
			Pen pen = new Pen(Color.Red);
			Point First = new Point(10, 10);
			Point Second = new Point(50, 50);
			int Len = Math.Abs(First.X - Second.X);
			int Weig = Math.Abs(Second.Y - Second.Y);
			g.DrawRectangle(pen, First.X, First.Y, Len, Weig);

			g.DrawLine(pen, new Point(10, 10), new Point(40, 40));
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
