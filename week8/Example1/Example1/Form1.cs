using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Example1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int index = 0;
			int y = textBox1.Location.Y + textBox1.Height + 20;
			Calculator calc = new Calculator(textBox1);
			for(int k = 0; k < 3; k++)
			{
				for(int j = 0; j < 3; j++)
				{
					index++;
					Button btn = new Button();
					btn.Click += calc.Number_Clicked;
					btn.Size = new Size(70, 70);
					btn.Text = index.ToString();
					btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					btn.Location = new Point(j * 70 + 20, k * 70 + y);
					Controls.Add(btn);
				}
			}
			int NewCoordY = 3;
			for(int k = 0; k < 2; k++)
			{
				for(int j = 0; j < 3; j++)
				{
					index++;
					Button btnOp = new Button();
					if (Charg(index) == "=")
						btnOp.Click += calc.Equal_Clicked;
					else
					btnOp.Click += calc.Operation_Clicked;
					btnOp.Size = new Size(70, 70);
					btnOp.Text = Charg(index);
					btnOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					btnOp.Location = new Point(j * 70 + 20, NewCoordY * 70 + y);
					
					Controls.Add(btnOp);
				}
				NewCoordY++;
			}
			//Button btnEq = new Button();
			//btnEq.Click += calc.Equal_Clicked;
			//btnEq.Size = new Size(70, 70);
			//btnEq.Text = "=";
			//btnEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//btnEq.Location = new Point(90, NewCoordY * 70 + y);
			//Controls.Add(btnEq);
		}
		public string  Charg(int ind)
		{
			if (ind == 10)
				return "+";
			if (ind == 11)
				return "-";
			if (ind == 12)
				return "*";
			if (ind == 13)
				return "/";
			if (ind == 14)
				return "=";
			if (ind == 15)
				return "C";
			return ind.ToString();
		}
	}
}
