using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace advancedoptions
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			Random rnd = new Random();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			crptvaluestart.Value=rnd.Next(-2048,2048);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			crptvalueend.Value=rnd.Next(-2047, 2049);
		}
	}
}
