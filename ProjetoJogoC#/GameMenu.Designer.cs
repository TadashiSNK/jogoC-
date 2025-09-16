/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 15/09/2025
 * Hora: 22:11
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace ProjetoJogoC_
{
	partial class GameMenu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.startButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(138, 73);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(300, 78);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Começar!";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// GameMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 468);
			this.Controls.Add(this.startButton);
			this.Name = "GameMenu";
			this.Text = "GameMenu";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button startButton;
	}
}
