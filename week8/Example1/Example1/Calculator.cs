using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
	public class Calculator
	{
		public string FirstNumber="0";
		public string SupportingNumber = "";
		public string SecondNumber = "";
		public string ResultNumber="";
		public bool Ok = false;
		public string Operation="";
		States state = States.NONE;
		Operations oper = Operations.NONE;
		TextBox textBox;
		public Calculator(TextBox textBox)
		{
			this.textBox = textBox;
		}

		enum States
		{
			NONE,
			OPERATION,
			NUMBER,
			EQUAL
		}
		enum Operations
		{
			NONE,
			PLUS,
			MINES,
			MULTIPLE,
			DEVIDE,
			EMPTY
		}
		
		public void Number_Clicked(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (state == States.NONE || state == States.NUMBER)
			{
				textBox.Text += btn.Text;
			}
			if(state == States.OPERATION)
			{
				textBox.Text = "";
				textBox.Text += btn.Text;
			}
			state = States.NUMBER;	
		}
		public void Operation_Clicked(object sender, EventArgs e)
		{
			Button btn =  (Button)sender;
			if(state == States.NONE)
			{
				Operation = btn.Text;
			}
			if(state == States.NUMBER)
			{
				FirstNumber = textBox.Text;
				if (Operation.Length > 0)
					Calculate();
				Operation = btn.Text;
			}
			if(state == States.EQUAL)
			{
				FirstNumber = textBox.Text;
			}
			state = States.OPERATION;

			//FirstNumber = textBox.Text;
			//Operation = btn.Text;
			//state = States.OPERATION;
			//if (btn.Text == "+")
			//	oper = Operations.PLUS;
			//if (btn.Text == "-")
			//	oper = Operations.MINES;
			//if (btn.Text == "*")
			//	oper = Operations.MULTIPLE;
			//if (btn.Text == "/")
			//	oper = Operations.DEVIDE;
			//if (btn.Text == "C")
			//{
			//	textBox.Text = "";
			//	FirstNumber = "";
			//}
		}
		public void Equal_Clicked(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if(state!=States.EQUAL)
			SecondNumber = textBox.Text;
			ResultNumber = textBox.Text;
			if(textBox.Text!="")
			Calculate();
			state = States.EQUAL;
		}
		public void Calculate()
		{
			if (state != States.EQUAL)
			{
				if (Operation == "+")
				{
					ResultNumber = (double.Parse(FirstNumber) + double.Parse(ResultNumber)).ToString();
				}
				if (Operation == "-")
				{
					ResultNumber = (double.Parse(FirstNumber) - double.Parse(ResultNumber)).ToString();
				}
				if (Operation == "*")
				{
					ResultNumber = (double.Parse(FirstNumber) * double.Parse(ResultNumber)).ToString();
				}
				if (Operation == "/")
				{
					ResultNumber = (double.Parse(FirstNumber) / double.Parse(ResultNumber)).ToString();
				}
				textBox.Text = ResultNumber;
			}
			else
			{
				if (Operation == "+")
				{
					ResultNumber = (double.Parse(textBox.Text) + double.Parse(SecondNumber)).ToString();
				}
				if (Operation == "-")
				{
					ResultNumber = (double.Parse(textBox.Text) - double.Parse(SecondNumber)).ToString();
				}
				if (Operation == "*")
				{
					ResultNumber = (double.Parse(textBox.Text) * double.Parse(SecondNumber)).ToString();
				}
				if (Operation == "/")
				{
					ResultNumber = (double.Parse(textBox.Text) / double.Parse(SecondNumber)).ToString();
				}
				textBox.Text = ResultNumber;
			}
		}
	}
}
