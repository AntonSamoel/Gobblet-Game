using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gobblet_Game
{
	public partial class GameForm : Form
	{
		public GameForm()
		{
			InitializeComponent();
		}
		int n;
		PictureBox[,] pictureBoxes;
		int cellWidth = 200;
		int cellHeight = 200;
		private void GameForm_Load(object sender, EventArgs e)
		{
			n = 4;
			pictureBoxes = new PictureBox[n, n];
			int left = boardPanel.Left-279, top = boardPanel.Top-71;
			Color[] colors = new Color[] { Color.White, Color.Black };
			for (int i = 0; i < n; i++)
			{
				left = boardPanel.Left-279;
				if (i % 2 == 0) { colors[0] = Color.FromArgb(112, 128, 144); colors[1] = Color.FromArgb(173, 216, 230); }
				else { colors[0] = Color.FromArgb(173, 216, 230); colors[1] = Color.FromArgb(112, 128, 144); }

				for (int j = 0; j < n; j++)
				{
					pictureBoxes[i, j] = new PictureBox();
					pictureBoxes[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
					pictureBoxes[i, j].Location = new Point(left, top);
					pictureBoxes[i, j].Size = new Size(cellWidth, cellHeight);
					left += cellWidth;
					pictureBoxes[i, j].Name = i + " " + j;
					//if (i < (n / 2) - 1 && P[i, j].BackColor == Color.Black) { P[i, j].Image = Properties.Resources.r; P[i, j].Name += " r"; }
					//else if (i > (n / 2) && P[i, j].BackColor == Color.Black)
					//{
					//	P[i, j].Image = Properties.Resources.g; P[i, j].Name += " g";
					//}
					pictureBoxes[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
					boardPanel.Controls.Add(pictureBoxes[i, j]);
				}
				top += cellHeight;
			}
		}

		
	}
}
