using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaturdayQuiz3Task1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public string FirstNumber = "", SecondNumber = "";
		public bool Ok = true;
		private void Form1_Load(object sender, EventArgs e)
		{
			int sz = 75;
			int x = textBox1.Location.X;
			int y = textBox1.Location.Y+ textBox1.Height+5;
			int d = 5;
			int index = 0;
			
			for(int k = 0; k < 3; k++)
			{
				for(int j = 0; j < 4; j++)
				{
					Button btn = new Button();
					btn.Text = Op_Num(index);
					btn.Size = new Size(sz, sz);
					btn.Location = new Point(j * sz + x + 5, k * sz + y + 5);
					if (index < 10)
						btn.Click += Number_Clicked;
					else if (index == 10)
						btn.Click += And_Clicked;
					else if (index == 11)
						btn.Click += Checking_Clicked;
					Controls.Add(btn);
					index++;
				}
			}
		}
		public string Op_Num(int number)
		{
			
			if(number == 10)
			{
				return "AND";
			}
		    if(number == 11)
			{
				return "CHECK";
			}
			return number.ToString();
		}
		public void Number_Clicked(object sender,EventArgs e)
		{
			Button btn = sender as Button;
			if (Ok == false)
			{
				textBox1.Text =btn.Text;
				Ok = true;
			}
			
			textBox1.Text += btn.Text;
		}
		public void And_Clicked(object sender,EventArgs e)
		{
			FirstNumber = textBox1.Text;
			textBox1.Text = "";
		}
		public void Checking_Clicked(object sender,EventArgs e)
		{
			if (Ok)
			{
				SecondNumber = textBox1.Text;
				textBox1.Text = "";
				textBox1.Text = IsCoprime();
				Ok = false;
			}
		}
		public string IsCoprime()
		{
			for(int k = int.Parse(FirstNumber)-1; k >0;k--)
			{
				if (int.Parse(FirstNumber) % k == 0)
				{
					for(int j = int.Parse(SecondNumber) - 1; j > 0; j--)
					{
						if(int.Parse(SecondNumber) % j == 0)
						{
							if (k == j)
							{
								return k.ToString();
							}
						}
					}
				}
			}
			return "1";
		}
	}
}
