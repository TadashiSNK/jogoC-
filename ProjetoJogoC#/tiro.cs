using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoJogoC_
{
	

	public class Tiro : PictureBox
	{
		public Timer clock;
		
		
		public Tiro()
		{
			Width = 30;
			Height = 30;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			this.Image = Image.FromFile("fireball2.gif");
		}
		
		public void tick(object sender, EventArgs e)
		{
			this.Left += 10;
		}
		
		clock.
		
		clock.interval = 1000;
		
		
		
		
		
		
		
		
		
		
		
	}
}
