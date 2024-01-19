using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
    public class HandleAI
    {
        public static Board copyBoard(Board board)
        {
            Cell[,] cells = board.Celles;
            Cell[,] newCells = new Cell[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    newCells[i, j] = new(i, j)
                    {
                        Pieces = new Stack<Piece>()
                    };
                    Clone(cells[i, j].Pieces, newCells[i, j].Pieces);
                }
            }

            Board newCopy = new(newCells);
            return newCopy;
        }
        public static Player copyPlayer(Player player)
        {
            List<Stack<Piece>> pieces = new();
            pieces.Add(new Stack<Piece>());
            pieces.Add(new Stack<Piece>());
            pieces.Add(new Stack<Piece>());
            Clone(player.Pieces[0], pieces[0]);
            Clone(player.Pieces[1], pieces[1]);
            Clone(player.Pieces[2], pieces[2]);
            Player player1 = new(player.Name, player.IsMyTurn, player.Color, pieces);
            return player1;
        }
        public static Piece copyPiece(Piece piece)
        {
            Piece piece1 = new(piece.Id, piece.Size, piece.PlayerName, piece.Color, piece.Image);
            return piece1;
        }
        private static void Clone(Stack<Piece> from, Stack<Piece> to)
        {
            Stack<Piece> temp = new();
            while (from.Count > 0)
            {
                temp.Push(from.Pop());
            }
            while (temp.Count > 0)
            {
                from.Push(temp.Peek());
                Piece piece = temp.Pop();
                Piece piece1 = copyPiece(piece);
                to.Push(piece1);
            }
        }
    }
}
