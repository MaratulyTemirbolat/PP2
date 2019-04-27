using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string CurNumber = "";
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		public void Nimber_Clicked(object sender,EventArgs e)
		{
			Button btn = sender as Button;
			if (textBox1.Text != "0")
				textBox1.Text += btn.Text;
		}
		public void Bin_Clicked(object sender,EventArgs e)
		{

			Bin_Trans(int.Parse(textBox1.Text));
		}
		public void Bin_Trans(int Num)
		{
			while (Num > 0)
			{
				CurNumber += (Num % 2).ToString();
				Num /= 2;
			}
			textBox1.Text = "";
			for(int k = CurNumber.Length-1; k >=0; k--)
			{
				textBox1.Text += CurNumber[k];
			}
		}
	}
}
