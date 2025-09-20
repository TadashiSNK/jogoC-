//Classe Personagem
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoJogoC_
{
	public class Personagem: PictureBox
	{
		public Personagem()
		{
			Width = 90;
			Height = 90;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
		}
		
		public int hp = 200;
		public int ataque = 15;
		public int defesa = 15;
		public int velocidade = 25;
		public int direcao = 1;
		
		public void TestarDirecao (Personagem main, string direcao){
			if (direcao == "direita" && main.direcao == 1){
				main.Image = Image.FromFile("Gargoyle.gif");
			}
			if (direcao == "esquerda" && main.direcao == -1){
				main.Image = Image.FromFile("GargoyleEsq.gif");
			}
		}
	}
}
