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
	}
}
