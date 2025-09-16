/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 15/09/2025
 * Hora: 22:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoJogoC_
{
	/// <summary>
	/// Description of GameMenu.
	/// </summary>
	public partial class GameMenu : Form
	{
		public GameMenu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void StartButtonClick(object sender, EventArgs e)
		{
			this.Hide();
			
		}
	}
}
