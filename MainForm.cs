using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fotos
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			PicFoto01.Image = Image.FromFile("C:/Users/uJão/Desktop/Programação/GitHub/C#/Fotos/imagens/Logo01.jpg");
		}
		
		void BtnExibirClick(object sender, EventArgs e)
		{
			PicFoto02.Image = Image.FromFile("C:/Users/uJão/Desktop/Programação/GitHub/C#/Fotos/imagens/Logo02.jpg");
		}
	}
}
