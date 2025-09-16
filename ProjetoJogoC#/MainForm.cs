/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 15/09/2025
 * Hora: 21:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoJogoC_
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
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
		Personagem heroi =  new Personagem();

		


		
		void MainFormResizeBegin(object sender, EventArgs e)
		{
			
		}
		
		void MainFormClientSizeChanged(object sender, EventArgs e)
		{
			cenario.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
//			this.Hide();
			heroi.Parent = cenario;
			heroi.Left = 0;
			heroi.Top = 0;
			heroi.SizeMode = PictureBoxSizeMode.StretchImage;
			heroi.Image = Image.FromFile("Gargoyle.gif");
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
//			this.Hide();
		}
		
		
		//Manuseando controles
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down){
				heroi.Top += 10;
			}
			if (e.KeyCode == Keys.Up){
				heroi.Top += -10;
			}
			if (e.KeyCode == Keys.Right){
				heroi.Left += 10;
			}
			if (e.KeyCode == Keys.Left){
				heroi.Left += -10;
			}
		}
	}
}
