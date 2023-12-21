﻿using System;
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
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }
		int n;
		PictureBox[,] pictureBoxes;
		int cellWidth = 200;
		int cellHeight = 200;

		private Game game;
		public GameForm(string player1Name, string player2Name)
		{
			Player1Name = player1Name;
			Player2Name = player2Name;
			InitializeComponent();
			IntalizeGame();
		}
		
		private void GameForm_Load(object sender, EventArgs e)
		{
			p1Name.Text = Player1Name;
			p2Name.Text = Player2Name;
			CreateBoard();
		}

		private void IntalizeGame()
		{
			List<Stack<Piece>> player1Pieces = new List<Stack<Piece>>(3);

			Stack<Piece> stack1 = new Stack<Piece>();
			stack1.Push(new Piece(1, 1, "player1"));
			stack1.Push(new Piece(2, 2, "player1"));
			stack1.Push(new Piece(3, 3, "player1"));
			stack1.Push(new Piece(4, 4, "player1"));

			Stack<Piece> stack2 = new Stack<Piece>();
			stack1.Push(new Piece(5, 1, "player1"));
			stack1.Push(new Piece(6, 2, "player1"));
			stack1.Push(new Piece(7, 3, "player1"));
			stack1.Push(new Piece(8, 4, "player1"));

			Stack<Piece> stack3 = new Stack<Piece>();
			stack1.Push(new Piece(9, 1, "player1"));
			stack1.Push(new Piece(10, 2, "player1"));
			stack1.Push(new Piece(11, 3, "player1"));
			stack1.Push(new Piece(12, 4, "player1"));

			player1Pieces.Add(stack1);
			player1Pieces.Add(stack2);
			player1Pieces.Add(stack3);

			List<Stack<Piece>> player2Pieces = new List<Stack<Piece>>(3);

			Stack<Piece> stack4 = new Stack<Piece>();
			stack1.Push(new Piece(13, 1, "player2"));
			stack1.Push(new Piece(14, 2, "player2"));
			stack1.Push(new Piece(15, 3, "player2"));
			stack1.Push(new Piece(16, 4, "player2"));

			Stack<Piece> stack5 = new Stack<Piece>();
			stack1.Push(new Piece(17, 1, "player2"));
			stack1.Push(new Piece(18, 2, "player2"));
			stack1.Push(new Piece(19, 3, "player2"));
			stack1.Push(new Piece(20, 4, "player2"));

			Stack<Piece> stack6 = new Stack<Piece>();
			stack1.Push(new Piece(21, 1, "player2"));
			stack1.Push(new Piece(22,2, "player2"));
			stack1.Push(new Piece(23,3, "player2"));
			stack1.Push(new Piece(24,4, "player2"));

			player2Pieces.Add(stack4);
			player2Pieces.Add(stack5);
			player2Pieces.Add(stack6);


			Player player1 = new("player1", true, player1Pieces);
			Player player2 = new("player2", true, player2Pieces);
			//game = new Game();
		}
		private void CreateBoard()
		{
			n = 4;
			pictureBoxes = new PictureBox[n, n];
			int left = boardPanel.Left - 279, top = boardPanel.Top - 71;
			Color[] colors = new Color[2];
			for (int i = 0; i < n; i++)
			{
				left = boardPanel.Left - 279;
				if (i % 2 == 0) { colors[0] = Color.FromArgb(240, 217, 181); colors[1] = Color.FromArgb(181, 136, 99); }
				else { colors[0] = Color.FromArgb(181, 136, 99); colors[1] = Color.FromArgb(240, 217, 181); }

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
					pictureBoxes[i, j].SizeMode = PictureBoxSizeMode.Zoom;

					if (pictureBoxes[i, j].BackColor == Color.FromArgb(240, 217, 181))
					{
						pictureBoxes[i, j].MouseHover += (sender2, e2) =>
						{
							PictureBox pictureBox = sender2 as PictureBox;
							pictureBox.BackColor = Color.FromArgb(230, 210, 150);
						};
						pictureBoxes[i, j].MouseLeave += (sender2, e2) =>
						{
							PictureBox pictureBox = sender2 as PictureBox;
							pictureBox.BackColor = Color.FromArgb(240, 217, 181);
						};
					}
					else
					{
						pictureBoxes[i, j].MouseHover += (sender2, e2) =>
						{
							PictureBox pictureBox = sender2 as PictureBox;
							pictureBox.BackColor = Color.FromArgb(186, 155, 105);
						};
						pictureBoxes[i, j].MouseLeave += (sender2, e2) =>
						{
							PictureBox pictureBox = sender2 as PictureBox;
							pictureBox.BackColor = Color.FromArgb(181, 136, 99);
						};

					}


					boardPanel.Controls.Add(pictureBoxes[i, j]);
				}
				top += cellHeight;
			}
		}

		private void endGame_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}