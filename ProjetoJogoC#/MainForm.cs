// Classe Mainform
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoJogoC_
{
	public partial class MainForm : Form
	{
		
		
		public MainForm()
		{
			InitializeComponent();
//			this.Size = new Size(1920, 1080);
			

			
			//MENU PRINCIPAL
			GameMenu menu_Principal = new GameMenu();
			menu_Principal.ShowDialog();
			
			//CENARIO
			cenario.Visible = true;
			cenario.Parent = this;
			cenario.Left = 0;
			cenario.Top = 0;
			cenario.SizeMode = PictureBoxSizeMode.StretchImage;
			cenario.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
			cenario.Image = Image.FromFile("cenario0.gif");
			

		}
		
		//PERSONAGEM PRINCIPAL
		Heroi player =  new Heroi();

		


		
		void MainFormResizeBegin(object sender, EventArgs e)
		{
			
		}
		
		void MainFormClientSizeChanged(object sender, EventArgs e)
		{
			cenario.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			player.Parent = cenario;
			player.Left = 0;
			player.Top = 0;
			player.SizeMode = PictureBoxSizeMode.StretchImage;
			player.Image = Image.FromFile("Gargoyle.gif");
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
//			this.Hide();
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.A){
				player.Esquerda(player);
			}
			if (e.KeyCode == Keys.D){
				player.Direita(player);
			}
			if (e.KeyCode == Keys.S){
				player.Baixo(player);
			}
			if (e.KeyCode == Keys.W){
				player.Cima(player);
			}
		}
	}
}
