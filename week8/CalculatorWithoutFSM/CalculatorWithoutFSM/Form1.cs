using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWithoutFSM
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Calculator calculator;
		private void Form1_Load(object sender, EventArgs e)
		{
			calculator = new Calculator(textBox1);
			int x = textBox1.Location.X;
			int y = textBox1.Location.Y + textBox1.Height + 5;
			int sz = 70;
			int dis = 2;
			int index = 0;
			int NewHeight = 3;
			for(int k = 0; k < 7; k++)
			{
				for(int j = 0; j < 4; j++)
				{
					Button btn = new Button();
					btn.Text = Btn_Text(index);
					btn.Size = new Size(sz, sz);
					if(btn.Text == "<—")
					{
						btn.Click += calculator.BackSpace_Clicked;
					}
					else if(index == 15 || index == 16)
					{
						btn.Click += calculator.Clean_Clicked;
					}
					else if (Choose_Function(index))
						btn.Click += calculator.Number_Clicked;
					else if (btn.Text == "=")
						btn.Click += calculator.Equal_Clicked;
					else if (!Choose_Function(index))
						btn.Click += calculator.Operation_Clicked;
					
					btn.Font = new Font("Microsoft Sans Serif", 20F);
					btn.Location = new Point(j * sz + x + dis,k * sz + y);
					index++;
					Controls.Add(btn);
				}
				NewHeight--;
			}
		}
		private bool Choose_Function(int index)
		{
			if (index < 10)
				return true;
			return false;

		}
		private string Btn_Text(int index)
		{

			if (index == 10)
			{
				return "+";
			}
			else if (index == 11)
			{
				return "-";
			}
			else if (index == 12)
			{
				return "*";
			}
			else if (index == 13)
			{
				return "/";
			}
			else if (index == 14)
			{
				return "=";
			}
			else if (index == 15)
			{
				return "C";
			}
			else if (index == 16)
			{
				return "CE";
			}
			else if (index == 17)
			{
				return "1/X";
			}
			else if (index == 18)
			{
				return "%";
			}
			else if (index == 19)
			{
				return "X^2";
			}
			else if(index == 20)
			{
				return "Sqr";
			}
			else if(index == 21)
			{
				return "X!";
			}
			else if(index == 22)
			{
				return "<—";
			}
			else if(index == 23)
			{
				return "X^y";
			}
			else if(index == 24)
			{
				return "X^3";
			}
			else if(index == 25)
			{
				return "CSqr";
			}
			else if(index == 26)
			{
				return "Sin(X)";
			}
			else if(index == 27)
			{
				return "Log(X)";
			}
			
			return index.ToString();
		}
	}
}
