using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1GCD
{
	public partial class Form1 : Form
	{
		string FirstNumber;
		string SecondNumber;
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
		private void Number_Clicked(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if(textBox1.Text!="0" )
			{
				textBox1.Text += btn.Text;
			}
		}
		private void And_Clicked(object sender,EventArgs e)
		{
			FirstNumber = textBox1.Text;
			textBox1.Text = "";

		}
		private void GCD_Clicked(object sender,EventArgs e)
		{
			SecondNumber = textBox1.Text;
			int First = Math.Abs(int.Parse(FirstNumber)), Second = Math.Abs(int.Parse(SecondNumber));
			int MinNumb = Math.Min(First, Second);
			int MaxNumb = Math.Max(First, Second);
			string GCDNUmb = "";
			for(int k = MinNumb; k > 0; k--)
			{
				if (MaxNumb % k == 0 && MinNumb % k == 0)
				{
					GCDNUmb = k.ToString();
					break;
				}
			}
			textBox1.Text = GCDNUmb;
			
		}
	}
}
