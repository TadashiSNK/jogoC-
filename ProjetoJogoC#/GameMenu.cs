//Game Menu (Extra)
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
			InitializeComponent();
		}
		
		void StartButtonClick(object sender, EventArgs e)
		{
			this.Hide();
			
		}
		void GameMenuFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
