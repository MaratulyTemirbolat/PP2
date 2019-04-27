using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PairsOfTheCircles
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public string First_Number = "";
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		public void Number_Clicked(object sender,EventArgs e)
		{
			Button bnt = sender as Button;
			textBox1.Text += bnt.Text;
		}
		public void Operation_Clicked(object sender,EventArgs e)
		{
			First_Number = textBox1.Text;

		}
		public void Result_Clicked(object sender,EventArgs e)
		{

		}
		public int a;
		private void button13_Click(object sender, EventArgs e)
		{
			a = Convert.ToInt32(textBox1.Text,16);
			textBox1.Clear();
			textBox1.Text = Convert.ToString(a);
		}
	}
}
