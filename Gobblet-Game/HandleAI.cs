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

    }
}
