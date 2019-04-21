using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Button[] btns = new Button[4];
		bool ok = false;
		bool no = true;
		private void Form1_Load(object sender, EventArgs e)
		{
			Button btn = new Button();
			btn.Click += Yes_No;
			btn.Size = new Size(70, 70);
			btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			btn.Location = new Point(0,0);
			btn.Text = "CREATE";
			Controls.Add(btn);
			
		}
		
		
		public void Yes_No(object sender,EventArgs e)
		{
		
			if (!ok)
			{
				ok = true;
					for (int k = 0; k < 4; k++)
					{
						btns[k] = new Button();
						btns[k].Size = new Size(75, 75);
						btns[k].Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						btns[k].Location = new Point((k + 1) * 75 + 10, 1);
						btns[k].Text = k.ToString();
						Controls.Add(btns[k]);
					}
			}
			else
			{
				ok =false;
				for (int k = 0; k < 4; k++)
				{
					btns[k].Visible = false;
				}
			}
		}
		 
	}
}
