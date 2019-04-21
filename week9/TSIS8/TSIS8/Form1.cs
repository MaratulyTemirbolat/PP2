using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSIS8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			Point[] pointsForYellow = new Point[] { new Point(400,150), new Point(330,190),new Point(330,230),new Point(400,270),new Point(470,230),new Point(470,190),new Point(400,150) };
			Point[] pointsForGreenDirection = new Point[] { new Point(400,180), new Point(370,210), new Point(385,210), new Point(385,240), new Point(415,240), new Point(415,210), new Point(430,210), new Point(400,180) };
			Point[] pointsForGreenStar = new Point[] { new Point(450,70), new Point(440,100), new Point(420,110), new Point(440,120), new Point(450,140), new Point(460,120), new Point(480,110), new Point(460,100), new Point(450,70) };
			Graphics g = e.Graphics;
			Pen pen1 = new Pen(Color.Black);
			g.FillRectangle(pen1.Brush, 0, 0, this.Width, this.Height);
			pen1.Color = Color.Blue;
			g.FillRectangle(pen1.Brush, 10, 10, this.Width - 36, this.Height - 50);
			pen1.Color = Color.White;
			g.FillEllipse(pen1.Brush, 40, 40, 35, 35);
			g.FillEllipse(pen1.Brush, 50, 330, 35, 35);
			g.FillEllipse(pen1.Brush, 300, 20, 35, 35);
			g.FillEllipse(pen1.Brush, 500, 60, 35, 35);
			g.FillEllipse(pen1.Brush, 330, 350, 35, 35);
			g.FillEllipse(pen1.Brush, 660, 290, 35, 35);
			g.FillEllipse(pen1.Brush, 720, 180, 35, 35);
			pen1.Color = Color.Yellow;
			g.FillPolygon(pen1.Brush, pointsForYellow);
			pen1.Color = Color.Green;
			g.FillPolygon(pen1.Brush, pointsForGreenDirection);
			g.FillPolygon(pen1.Brush, pointsForGreenStar);
			TextBox textBox = new TextBox();
			textBox.Size = new Size(180,170);
			textBox.Location = new Point(550, 15);
			textBox.Text = "Level:1 Score: 200 Live: *** ";
			Controls.Add(textBox);
			
		}
	}
}
