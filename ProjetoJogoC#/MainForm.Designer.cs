/*
 * Criado por SharpDevelop.
 * Usuário: Alunos
 * Data: 15/09/2025
 * Hora: 21:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace ProjetoJogoC_
{
	partial class MainForm
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
			this.cenario = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.cenario)).BeginInit();
			this.SuspendLayout();
			// 
			// cenario
			// 
			this.cenario.Location = new System.Drawing.Point(93, 65);
			this.cenario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cenario.Name = "cenario";
			this.cenario.Size = new System.Drawing.Size(456, 313);
			this.cenario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.cenario.TabIndex = 0;
			this.cenario.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 534);
			this.Controls.Add(this.cenario);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "ProjetoJogoC#";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.ResizeBegin += new System.EventHandler(this.MainFormResizeBegin);
			this.ClientSizeChanged += new System.EventHandler(this.MainFormClientSizeChanged);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.cenario)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox cenario;
	}
}
