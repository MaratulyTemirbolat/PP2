using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWithoutFSM
{
	class Calculator
	{
		enum States
		{
			NONE,
			NUMBER,
			OPERATION,
			EQUAL,
			BACKSPACE
		}
		public string FirstNumber;
		public string ResultNumber;
		public string Operation;
		public bool Ok;
		States state;
		TextBox textBox;
		public Calculator(TextBox textBox)
		{
			Ok = true;
			FirstNumber = "";
			ResultNumber = "";
			Operation = "";
			state = States.NONE;
			this.textBox = textBox;
		    textBox.Text = "0";
		}
		public void BackSpace_Clicked(object sender,EventArgs e)
		{
			Button btn = sender as Button;
			if (state != States.EQUAL && Ok)
			{
				if (textBox.Text != "" || textBox.Text =="0")
				{
					string NewNumber = "";
					for (int k = 0; k < textBox.Text.Length - 1; k++)
					{
						char LastLetter = textBox.Text[k];
						NewNumber += LastLetter;
					}
					textBox.Text = NewNumber;
				}
				else
				{
					textBox.Text = "0";
				}

				state = States.BACKSPACE;
			}
		}
		public void Clean_Clicked(object sender,EventArgs e)
		{
			Button btn = (Button)sender;
			if (btn.Text == "C")
			{
				FirstNumber = "";
				ResultNumber = "";
				textBox.Text = "0";
				Operation = "";
				state = States.NONE;
			}
			else if (btn.Text == "CE")
			{
				textBox.Text = "";
			}
		}
		public void Number_Clicked(object sender,EventArgs e)
		{
			Button btn = (Button)sender;
			if(state == States.NONE)
			{
				textBox.Text = btn.Text;
			}
			if(state == States.BACKSPACE)
			{
				textBox.Text = btn.Text;
			}
			if(state == States.NUMBER)
			{
				textBox.Text += btn.Text;
			}
			if(state == States.OPERATION)
			{
				textBox.Text = btn.Text;
			}
			if(state == States.EQUAL)
			{
				textBox.Text = btn.Text;
			}
			state = States.NUMBER;
		}
		public void Operation_Clicked(object sender,EventArgs e)
		{
			Button btn = (Button)sender;
			
					
			 if(state == States.OPERATION )
			{
				Operation = btn.Text;
				if (Immidiatly_Operations(btn.Text))
					Calculate();
			}
			else if(state == States.NUMBER)
			{
				if (Operation.Length > 0 || Immidiatly_Operations(btn.Text))
				{
					Operation = btn.Text;
					Calculate();
				}
				FirstNumber = textBox.Text;
				Operation = btn.Text;
			}
			
			else if(state == States.EQUAL)
			{
				FirstNumber = textBox.Text;
				Operation = btn.Text;
			}
			state = States.OPERATION;
		}
		public bool Immidiatly_Operations(string Operation)
		{
			if (Operation == "Sqr")
				return true;
			else if (Operation == "1/X")
				return true;
			else if (Operation == "X^2")
				return true;
			else if (Operation == "X!")
				return true;
			else if (Operation == "X^3")
				return true;
			else if (Operation == "CSqr")
				return true;
			else if (Operation == "Ln(X)")
				return true;
			else if (Operation == "Log(X)")
				return true;
			return false;
		}
		public void Equal_Clicked(object sender,EventArgs e)
		{
			Button btn = sender as Button;
			if (Operation != "")
			{
				Calculate();
			}
			state = States.EQUAL;
		}
		
		public void Calculate()
		{
			if (state != States.EQUAL)
			{
				ResultNumber = textBox.Text;
				if (Operation == "+")
				textBox.Text = (double.Parse(FirstNumber) + double.Parse(ResultNumber)).ToString();
				if (Operation == "-")
				textBox.Text = (double.Parse(FirstNumber) - double.Parse(ResultNumber)).ToString();
				if(Operation == "*")
				textBox.Text = (double.Parse(FirstNumber) * double.Parse(ResultNumber)).ToString();
				if (Operation == "/")
				textBox.Text = (double.Parse(FirstNumber) / double.Parse(ResultNumber)).ToString();
				if (Operation == "Sqr")
					textBox.Text = (Math.Sqrt(double.Parse(textBox.Text))).ToString();
				if (Operation == "1/X")
					textBox.Text = (1 / double.Parse(textBox.Text)).ToString();
				if (Operation == "X^2")
					textBox.Text = (double.Parse(textBox.Text) * double.Parse(textBox.Text)).ToString();
				if(Operation == "X!")
				{
					if (int.Parse(textBox.Text) > 0)
					{
						int a = int.Parse(textBox.Text);
						for (int k = 1; k < int.Parse(textBox.Text); k++)
						{
							a = a * k;
						}
						textBox.Text = a.ToString();
					}
				}
				if (Operation == "Log(X)")
					textBox.Text = (Math.Log10(double.Parse(textBox.Text))).ToString();
				if(Operation == "CSqr")
				{
					
					textBox.Text = (Math.Pow(double.Parse(textBox.Text),(double)1.0/3.0)).ToString();
				}
				if (Operation == "X^3")
					textBox.Text = (double.Parse(textBox.Text) * double.Parse(textBox.Text) * double.Parse(textBox.Text)).ToString();
				if(Operation == "X^y")
				{
					double f = double.Parse(FirstNumber);
					double s = double.Parse(ResultNumber);
					textBox.Text = (Math.Pow(f, s)).ToString();
				}
			}
			else
			{
				if (Operation == "+")
					textBox.Text = (double.Parse(textBox.Text) + double.Parse(ResultNumber)).ToString();
				if(Operation == "-")
					textBox.Text = (double.Parse(textBox.Text) - double.Parse(ResultNumber)).ToString();
				if(Operation == "*")
					textBox.Text = (double.Parse(textBox.Text) * double.Parse(ResultNumber)).ToString();
				if(Operation == "/")
					textBox.Text = (double.Parse(textBox.Text) / double.Parse(ResultNumber)).ToString();
				if (Operation == "Sqr")
					textBox.Text = (Math.Sqrt(double.Parse(textBox.Text))).ToString();
				if(Operation == "1/X")
					textBox.Text = (1 / double.Parse(textBox.Text)).ToString();
				if(Operation == "X^2")
					textBox.Text = (double.Parse(textBox.Text) * double.Parse(textBox.Text)).ToString();
				if (Operation == "X!")
				{
					if (int.Parse(textBox.Text) > 0)
					{
						int a = int.Parse(textBox.Text);
						for (int k = 1; k < int.Parse(textBox.Text); k++)
						{
							a = a * k;
						}
						textBox.Text = a.ToString();
					}
				}
				if (Operation == "Log(X)")
					textBox.Text = (Math.Log10(double.Parse(textBox.Text))).ToString();
				if (Operation == "CSqr")
				{	
					textBox.Text = (Math.Pow(double.Parse(textBox.Text),(double)1.0/3.0)).ToString();
				}
				if (Operation == "X^3")
					textBox.Text = (double.Parse(textBox.Text) * double.Parse(textBox.Text) * double.Parse(textBox.Text)).ToString();
				if(Operation == "X^y")
				{
					textBox.Text = (Math.Pow(double.Parse(textBox.Text), double.Parse(ResultNumber))).ToString();
				}
			}
			Ok = false;
		}

	}
}
