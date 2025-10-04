//Classe Heroi
using System;

namespace ProjetoJogoC_
{
	public class Heroi: Personagem
	{
		public Heroi()
		{
	
		}
		//Controles
		public void Esquerda (Heroi player)
		{
			player.Left += -20;
			player.direcao = -1;
			TestarDirecao(player, "esquerda");
		}
		
		public void Direita (Heroi player)
		{
			player.Left += 20;
			player.direcao = 1;
			TestarDirecao(player, "direita");
		}
		
		public void Cima (Heroi player)
		{
			player.Top += -20;
		}
		
		public void Baixo (Heroi player)
		{
			player.Top += 20;
		}
		
		public void returnToBounds (Heroi player, MainForm tela)
		{
			if (player.Top < -40) {
				player.Top = tela.ClientSize.Height - (player.Height/2);
			}
			
			if (player.Top >= tela.ClientSize.Height - 20){
				player.Top = -20;
			}
			
			if (player.Left < -30)
			{
				player.Left = tela.ClientSize.Width - (player.Width/2);
			}
			
			if(player.Left >= tela.ClientSize.Width - (player.Width/4))
			{
				player.Left = 0 - (player.Width/2);
			}
		}
	}
}
