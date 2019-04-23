using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheClosestNumber
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string FirstNumber;
		string SecondNumber;
		string Operation="";
		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
		private void NUMBERS(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			textBox1.Text += btn.Text;

		}
        private void AND(object sender,EventArgs e)
		{
			Button btn = sender as Button;
		
			FirstNumber = textBox1.Text;
			textBox1.Text = "";
		}
		private void RESULT_CLICKED(object sender, EventArgs e)
		{
			SecondNumber = textBox1.Text;
			string Checking = (double.Parse(FirstNumber) / double.Parse(SecondNumber)).ToString();
			int MultiNum = (int.Parse(FirstNumber) / int.Parse(SecondNumber));
			char NumberAfterDot=' ';
			for(int k = 0; k < Checking.Length; k++)
			{
				char Dot = Checking[k];
				if (Dot == ',')
					NumberAfterDot = Checking[k + 1];
			}
			 int CheckingNew = int.Parse(" "+NumberAfterDot);
			if (CheckingNew > 5 && MultiNum>0)
			{
				MultiNum++;
				textBox1.Text = (int.Parse(SecondNumber) * MultiNum).ToString();
			}
			else if(CheckingNew>5 && MultiNum < 0)
			{
				MultiNum--;
				textBox1.Text = (int.Parse(SecondNumber) * MultiNum).ToString();
			}
			else if(CheckingNew<=5)
			{
				textBox1.Text = (int.Parse(SecondNumber) * MultiNum).ToString(); 
			}
			
		}

		private void button13_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (textBox1.Text == "")
			{
				textBox1.Text = btn.Text;
			}
		}
	}
}
