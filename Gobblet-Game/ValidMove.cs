using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
    public class ValidMove
    {
        public static string IsWinning(string color,Cell[,] cells)
        {
            bool white = false, black = false;
            int countW, countB;

            for(int i = 0; i < 4; i++)
            {
                countB = countW = 0;
                for(int j = 0; j < 4; j++)
                {
                    if (cells[i, j].Pieces.Count == 0)
                        continue;
                    if (cells[i, j].Pieces.Peek().Color == "white")
                        countW++;
                    else countB++;
                }
                if(countW == 4)
                {
                    white = true;
                }
                if(countB == 4)
                {
                    black = true;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                countB = countW = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (cells[j, i].Pieces.Count == 0)
                        continue;
                    if (cells[j, i].Pieces.Peek().Color == "white")
                        countW++;
                    else countB++;
                }
                if (countW == 4)
                {
                    white = true;
                }
                if (countB == 4)
                {
                    black = true;
                }
            }
            int x = 0, y = 0;
            countB = countW = 0;
            while (IsValidCoordinate(x, y))
            {
                if (cells[x, y].Pieces.Count == 0)
                {
                    x++;y++;
                    continue;
                }
                if (cells[x, y].Pieces.Peek().Color == "white")
                    countW++;
                else countB++;
                if (countW == 4)
                {
                    white = true;
                }
                if (countB == 4)
                {
                    black = true;
                }
                x++;y++;
            }
            x = 0; y = 3;
            countB = countW = 0;
            while (IsValidCoordinate(x, y))
            {
                if (cells[x, y].Pieces.Count == 0)
                {
                    x++; y--;
                    continue;
                }
                if (cells[x, y].Pieces.Peek().Color == "white")
                    countW++;
                else countB++;
                if (countW == 4)
                {
                    white = true;
                }
                if (countB == 4)
                {
                    black = true;
                }
                x++; y--;
            }

            if (white && !black) return "white";
            if (!white && black) return "black";

            if (color == "white" && white && black) return "black";
            if (color == "black" && white && black) return "white";

            return "NON";
        }
        public static bool IsInternalMoveAvailble(Cell currentCell,Cell previousCell)
        {
            //if(previousCell.Pieces.Count == 0)
             //   return false;

            if (currentCell.Pieces.Count == 0 )
                return true;

            if (previousCell.Pieces.Peek().Size > currentCell.Pieces.Peek().Size)
                return true;

            return false;
        }
        public static bool IsExternalMoveAvailble(Cell[,] Celles,Cell cell, Piece externalPiece)
        {
            if (cell.Pieces.Count == 0)
                return true;
            if (externalPiece.Size <= cell.Pieces.Peek().Size)
                return false;

             //remove comment to handle special cases
            int x = cell.Row, y = cell.Column, count = 0;
            //check row
            for (int i = 0; i < 4; i++)
            {
                if (Celles[x, i].Pieces.Count > 0 && Celles[x, i].Pieces.Peek().Color != externalPiece.Color)
                    count++;
                if (count == 3)
                    return true;
            }
            count = 0;
            //check column
            for (int i = 0; i < 4; i++)
            {
                if (Celles[i, y].Pieces.Count > 0 && Celles[i, y].Pieces.Peek().Color  != externalPiece.Color)
                    count++;
                if (count == 3)
                    return true;
            }
            //check 1 diagonall
            count = 0;
            int x1 = x - Math.Min(x, y), y1 = y - Math.Min(x, y);
            while (IsValidCoordinate(x1, y1))
            {
                if (Celles[x1, y1].Pieces.Count > 0 && Celles[x1, y1].Pieces.Peek().Color == cell.Pieces.Peek().Color && cell.Pieces.Peek().Color != externalPiece.Color)
                    count++;
                if (count == 3) return true;
                x1++; y1++;
            }
            //check 2 diagonall
            count = 0;
            int val = Math.Min(x, 3 - y);
            x1 = x - val; y1 = y + val;
            while (IsValidCoordinate(x1, y1))
            {
                if (Celles[x1, y1].Pieces.Count > 0 && Celles[x1, y1].Pieces.Peek().Color == cell.Pieces.Peek().Color && cell.Pieces.Peek().Color != externalPiece.Color)
                    count++;
                if (count == 3) return true;
                x1++; y1--;
            }
            return false;
        }

        private static bool IsValidCoordinate(int x, int y)
        {
            if (x < 0 || y < 0 || x > 3 || y > 3)
                return false;
            return true;
        }
    }
}
