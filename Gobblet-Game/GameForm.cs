using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        List<Stack<Piece>> player1Pieces;
        List<Stack<Piece>> player2Pieces;
        PictureBox? previousPictureBox = null;
        Color previousColor = Color.Aqua;
        Color selectedColor = Color.Chocolate;
        Image PreviosImage;
        public Cell[,] Celles = new Cell[4, 4];
        private Game game;

        Player player1;
        Player player2;
        bool isWinState = false;

        //AI
        bool Computer1;
        bool Computer2;

        public GameState gameState;
        private Board board;
        

        public GameForm(string player1Name, string player2Name,bool computer1, bool computer2)
        {
            Player1Name = player1Name;
            Player2Name = player2Name;
            Computer1 = computer1;
            Computer2 = computer2;
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
            player1Pieces = new List<Stack<Piece>>(3);

            Stack<Piece> stack1 = new Stack<Piece>();
            stack1.Push(new Piece(1, 1, "player1", "white", Properties.Resources.w1));
            stack1.Push(new Piece(2, 2, "player1", "white", Properties.Resources.w2));
            stack1.Push(new Piece(3, 3, "player1", "white", Properties.Resources.w3));
            stack1.Push(new Piece(4, 4, "player1", "white", Properties.Resources.w4));

            Stack<Piece> stack2 = new Stack<Piece>();
            stack2.Push(new Piece(5, 1, "player1", "white", Properties.Resources.w1));
            stack2.Push(new Piece(6, 2, "player1", "white", Properties.Resources.w2));
            stack2.Push(new Piece(7, 3, "player1", "white", Properties.Resources.w3));
            stack2.Push(new Piece(8, 4, "player1", "white", Properties.Resources.w4));

            Stack<Piece> stack3 = new Stack<Piece>();
            stack3.Push(new Piece(9, 1, "player1", "white", Properties.Resources.w1));
            stack3.Push(new Piece(10, 2, "player1", "white", Properties.Resources.w2));
            stack3.Push(new Piece(11, 3, "player1", "white", Properties.Resources.w3));
            stack3.Push(new Piece(12, 4, "player1", "white", Properties.Resources.w4));

            player1Pieces.Add(stack1);
            player1Pieces.Add(stack2);
            player1Pieces.Add(stack3);

            player2Pieces = new List<Stack<Piece>>(3);

            Stack<Piece> stack4 = new Stack<Piece>();
            stack4.Push(new Piece(13, 1, "player2", "black", Properties.Resources.b1));
            stack4.Push(new Piece(14, 2, "player2", "black", Properties.Resources.b2));
            stack4.Push(new Piece(15, 3, "player2", "black", Properties.Resources.b3));
            stack4.Push(new Piece(16, 4, "player2", "black", Properties.Resources.b4));

            Stack<Piece> stack5 = new Stack<Piece>();
            stack5.Push(new Piece(17, 1, "player2", "black", Properties.Resources.b1));
            stack5.Push(new Piece(18, 2, "player2", "black", Properties.Resources.b2));
            stack5.Push(new Piece(19, 3, "player2", "black", Properties.Resources.b3));
            stack5.Push(new Piece(20, 4, "player2", "black", Properties.Resources.b4));

            Stack<Piece> stack6 = new Stack<Piece>();
            stack6.Push(new Piece(21, 1, "player2", "black", Properties.Resources.b1));
            stack6.Push(new Piece(22, 2, "player2", "black", Properties.Resources.b2));
            stack6.Push(new Piece(23, 3, "player2", "black", Properties.Resources.b3));
            stack6.Push(new Piece(24, 4, "player2", "black", Properties.Resources.b4));

            player2Pieces.Add(stack4);
            player2Pieces.Add(stack5);
            player2Pieces.Add(stack6);


            player1 = new("player1", isMyTurn: true, "white", player1Pieces)
            {
                IsComputer = false
            };

            player2 = new("player2", isMyTurn: false, "black", player2Pieces)
            {
                IsComputer = true
            };

            p1Name.ForeColor = Color.Green;
            p2Name.ForeColor = Color.Red;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Celles[i, j] = new(i, j)
                    {
                        Pieces = new Stack<Piece>()
                    };
                }
            }
            board = new(Celles);
           // gameState = new(board,player1,player2);
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
                               if (sender2 is not PictureBox pictureBox)
                                    return;
                               if(pictureBox.BackColor != selectedColor)
                                    pictureBox.BackColor = Color.FromArgb(230, 210, 150);
                           };
                          pictureBoxes[i, j].MouseLeave += (sender2, e2) =>
                          {
                              if (sender2 is not PictureBox pictureBox)
                                  return;
                              //pictureBox.BackColor = Color.FromArgb(240, 217, 181);
                              if(pictureBox.BackColor != selectedColor)
                                 pictureBox.BackColor = Color.FromArgb(240, 217, 181);
                          };
                    }
                    else
                    {
                         pictureBoxes[i, j].MouseHover += (sender2, e2) =>
                         {
                             if (sender2 is not PictureBox pictureBox)
                                 return;
                             if (pictureBox.BackColor != selectedColor)
                                 pictureBox.BackColor = Color.FromArgb(186, 155, 105);
                         };
                         pictureBoxes[i, j].MouseLeave += (sender2, e2) =>
                         {
                             if (sender2 is not PictureBox pictureBox)
                                 return;
                             // pictureBox.BackColor = Color.FromArgb(181, 136, 99);
                             if (pictureBox.BackColor != selectedColor)
                                 pictureBox.BackColor = Color.FromArgb(181, 136, 99);
                         };

                    }

                    Celles[i, j].Color = pictureBoxes[i, j].BackColor;
                    pictureBoxes[i, j].Tag = Celles[i, j];

                    pictureBoxes[i, j].Click += PictureBox_Click; // syntax for adding some event to the picture box
                    boardPanel.Controls.Add(pictureBoxes[i, j]);
                }
                top += cellHeight;
            }
            winningText.Visible = false;
            isWinState = false;
        }

        private void endGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stack1_Click(object sender, EventArgs e)
        {
            LeftPlayer(sender, e, 0);
        }
        private void stack2_Click(object sender, EventArgs e)
        {
            LeftPlayer(sender, e, 1);
        }
        private void stack3_Click(object sender, EventArgs e)
        {
            LeftPlayer(sender, e, 2);
        }
        private void stack4_Click(object sender, EventArgs e)
        {
            RightPlayer(sender, e, 0);
        }
        private void stack5_Click_1(object sender, EventArgs e)
        {
            RightPlayer(sender, e, 1);
        }
        private void stack6_Click_1(object sender, EventArgs e)
        {
            RightPlayer(sender, e, 2);
        }
        private void LeftPlayer(object sender, EventArgs e, int num)
        {
            if (sender is PictureBox clickedPictureBox)
            {
                if (player1.Pieces[num].Count > 0)
                {
                    if (previousPictureBox != null)
                    {
                        if (previousPictureBox.Tag is not Cell)
                        {
                            previousPictureBox.BackColor = previousColor;
                            previousPictureBox = null;
                        }
                        return;
                    }

                    if (!player1.IsMyTurn || isWinState || player1.IsComputer)
                        return;
                    previousPictureBox = clickedPictureBox;
                    previousPictureBox.Tag = player1.Pieces[num];
                    previousColor = previousPictureBox.BackColor;
                    previousPictureBox.BackColor = selectedColor;
                }
            }
        }
        private void RightPlayer(object sender, EventArgs e, int num)
        {
            if (sender is PictureBox clickedPictureBox)
            {
                if (player2.Pieces[num].Count > 0)
                {     
                    if (previousPictureBox != null)
                    {
                        if (previousPictureBox.Tag is not Cell)
                        {
                              previousPictureBox.BackColor = previousColor;
                              previousPictureBox = null;
                        }
                        return;
                    }

                    if (!player2.IsMyTurn || isWinState || player2.IsComputer)
                        return;
                    previousPictureBox = clickedPictureBox;
                    previousPictureBox.Tag = player2.Pieces[num];
                    previousColor = previousPictureBox.BackColor;
                    previousPictureBox.BackColor = selectedColor;

                }
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is not PictureBox currentPictureBox) return;

            if (previousPictureBox != null)
            {
                if (currentPictureBox.Tag is not Cell currentCell) return;

                if (previousPictureBox.Tag is not Cell PreviosCell)
                {
                    HandleExternalPiece(previousPictureBox, currentPictureBox, currentCell);
                    previousPictureBox.BackColor = previousColor;
                    previousPictureBox = null;
                    ComputerPlay();
                    return;
                }

                if (PreviosCell.Pieces.Count > 0)
                {
                    if (ValidMove.IsInternalMoveAvailble(currentCell, PreviosCell))
                    {
                        currentPictureBox.Image = previousPictureBox.Image; // check for null image **
                        Piece movedPiece = PreviosCell.Pieces.Pop();
                        currentCell.Pieces.Push(movedPiece);

                        if (PreviosCell.Pieces.Count == 0)
                        {
                            previousPictureBox.BackColor = previousColor;
                            previousPictureBox.Image = null;
                        }
                        else
                        {
                            Piece piece = PreviosCell.Pieces.Peek();
                            ImageBasedOnSize(previousPictureBox, piece);
                        }
                        WhoWinned();

                        player1.previousMoves.addMove(movedPiece,PreviosCell,currentCell);

                        previousPictureBox.BackColor = previousColor;
                        previousPictureBox = null;

                        ComputerPlay();

                    }

                }
                // Reset the previous PictureBox to null
                /*previousPictureBox.BackColor = previousColor;
                previousPictureBox = null;*/

            }
            else
            {
                // Set the current PictureBox as the previous PictureBox

                if (currentPictureBox.Tag is not Cell currentCell) { return; }

                if (currentCell.Pieces.Count > 0)
                {
                    if ((player1.IsMyTurn && currentCell.Pieces.Peek().Color == "black") ||
                        (player2.IsMyTurn && currentCell.Pieces.Peek().Color == "white") || isWinState)
                        return;
                    previousPictureBox = currentPictureBox;
                    previousColor = currentCell.Color;
                    previousPictureBox.BackColor = selectedColor;
                }
            }
        }
        private void ComputerPlay()
        {
            Move m = PlayAI();

            int ind = WhichStack(player2, m.p);
            Cell? cellFrom = m.from, cellTo = m.to;

           
            int xto = cellTo.Row, yto = cellTo.Column;
            
            if (ind != -1)
            {
                PictureBox box = ChoosePicutre(ind);
                
                Piece piece = player2.Pieces[ind].Pop();
                ImageBasedOnSize(box, player2.Pieces[ind].Count > 0 ? player2.Pieces[ind].Peek() : null);
                
                //gameState.player2.Pieces[ind].Pop();

                //cellTo.Pieces.Push(piece);
                //update To 
                
                Celles[xto, yto].Pieces.Push(piece);
               // gameState.currentBoard.Celles[m.to.Row, m.to.Column].Pieces.Push(piece);
                
                pictureBoxes[cellTo.Row, cellTo.Column].Image = piece.Image;
            }
            else
            {
                //cellTo.Pieces.Push(cellFrom.Pieces.Pop());
                int xfrom = cellFrom.Row, yfrom = cellFrom.Column;
                Celles[xto, yto].Pieces.Push(Celles[xfrom, yfrom].Pieces.Pop());
                //gameState.currentBoard.Celles[m.to.Row, m.to.Column].Pieces.Push(piece);
                //gameState.currentBoard.Celles[m.from.Row, m.from.Column].Pieces.Pop();
                

                ImageBasedOnSize(pictureBoxes[xfrom, yfrom], Celles[xfrom, yfrom].Pieces.Count > 0? Celles[xfrom, yfrom].Pieces.Peek(): null);
                ImageBasedOnSize(pictureBoxes[xto, yto], Celles[xto, yto].Pieces.Peek());
            }
            WhoWinned();
        }
        private Move PlayAI()
        {
            board = new(Celles);
            gameState = new GameState(HandleAI.copyBoard(board),HandleAI.copyPlayer(player1), HandleAI.copyPlayer(player2), true);
            int x = gameState.getBestMove(gameState, 3);
            Console.WriteLine(x);
            return gameState.bestMove;
        }

        public PictureBox ChoosePicutre(int x)
        {
            if (x == 0)
                return stack4;
            else if (x == 1)
                return stack5;
            else
                return stack6;
        }
        private void SwapTurns()
        {
            player1.IsMyTurn = !player1.IsMyTurn;
            player2.IsMyTurn = !player2.IsMyTurn;

            if (player1.IsMyTurn) p1Name.ForeColor = Color.Green;
            else p1Name.ForeColor = Color.Red;
            if (player2.IsMyTurn) p2Name.ForeColor = Color.Green;
            else p2Name.ForeColor = Color.Red;
        }
        private void HandleExternalPiece(PictureBox previousPictureBox, PictureBox currentPictureBox, Cell currentCell)
        {

            if (previousPictureBox.Tag is not Stack<Piece> pieces) return;

            Piece piece = pieces.Peek();

            if (ValidMove.IsExternalMoveAvailble(Celles, currentCell, piece))
            {
                currentPictureBox.Image = previousPictureBox.Image;
                currentCell.Pieces.Push(pieces.Pop());
                player1.previousMoves.addMove(piece, null, currentCell);
                if (pieces.Count > 0)
                    piece = pieces!.Peek();
                else
                {
                    piece = null;
                }

                ImageBasedOnSize(previousPictureBox, piece);
                WhoWinned();
                
            }
        }
        private static void ImageBasedOnSize(PictureBox pictureBox, Piece? piece)
        {
            if (piece is null)
            {
                pictureBox.Image = null;
                return;
            }
            pictureBox.Image = piece.Image;
        }
        private void WhoWinned()
        {
            string state = ValidMove.IsWinning(player1.IsMyTurn ? "white" : "black", Celles);
            if (state == "white")
            {
                winningText.Text = $"{p1Name.Text} is the Winner";
                winningText.Visible = true;
                isWinState = true;
            }
            else if (state == "black")
            {
                winningText.Text = $"{p2Name.Text} is the Winner";
                winningText.Visible = true;
                isWinState = true;
            }
            SwapTurns();
        }
        private int WhichStack(Player player,Piece piece)
        {
            if (player.Pieces[0].Count > 0)
            {
                if (player.Pieces[0].Peek().Id == piece.Id)
                    return 0;
            }
            if (player.Pieces[1].Count > 0)
            {
                if (player.Pieces[1].Peek().Id == piece.Id)
                    return 1;
            }
            if (player.Pieces[2].Count > 0)
            {
                if (player.Pieces[2].Peek().Id == piece.Id)
                    return 2;
            }
            return -1;
        }
        private void BlackStack_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                previousPictureBox = pictureBox;
            }
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            string p1 = p1Name.Text, p2 = p2Name.Text;
            this.Close();
            GameForm gameForm = new (p1, p2,player1.IsComputer,player2.IsComputer);
            gameForm.Show();
        }
    }
}
