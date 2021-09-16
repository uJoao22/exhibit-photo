/*
 * Created by SharpDevelop.
 * User: uJão
 * Date: 01/07/2021
 * Time: 13:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Fotos
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
			this.PicFoto02 = new System.Windows.Forms.PictureBox();
			this.PicFoto01 = new System.Windows.Forms.PictureBox();
			this.BtnExibir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PicFoto02)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PicFoto01)).BeginInit();
			this.SuspendLayout();
			// 
			// PicFoto02
			// 
			this.PicFoto02.Location = new System.Drawing.Point(188, 37);
			this.PicFoto02.Name = "PicFoto02";
			this.PicFoto02.Size = new System.Drawing.Size(120, 120);
			this.PicFoto02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PicFoto02.TabIndex = 1;
			this.PicFoto02.TabStop = false;
			// 
			// PicFoto01
			// 
			this.PicFoto01.Location = new System.Drawing.Point(25, 35);
			this.PicFoto01.Name = "PicFoto01";
			this.PicFoto01.Size = new System.Drawing.Size(120, 120);
			this.PicFoto01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PicFoto01.TabIndex = 2;
			this.PicFoto01.TabStop = false;
			// 
			// BtnExibir
			// 
			this.BtnExibir.Location = new System.Drawing.Point(193, 175);
			this.BtnExibir.Name = "BtnExibir";
			this.BtnExibir.Size = new System.Drawing.Size(110, 23);
			this.BtnExibir.TabIndex = 3;
			this.BtnExibir.Text = "Exibir foto";
			this.BtnExibir.UseVisualStyleBackColor = true;
			this.BtnExibir.Click += new System.EventHandler(this.BtnExibirClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(344, 322);
			this.Controls.Add(this.BtnExibir);
			this.Controls.Add(this.PicFoto01);
			this.Controls.Add(this.PicFoto02);
			this.Name = "MainForm";
			this.Text = "Fotos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.PicFoto02)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PicFoto01)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button BtnExibir;
		private System.Windows.Forms.PictureBox PicFoto01;
		private System.Windows.Forms.PictureBox PicFoto02;
	}
}
