/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 15/09/2025
 * Hora: 21:49
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
	/// Description of Personagem_cs.
	/// </summary>
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
	}
}
