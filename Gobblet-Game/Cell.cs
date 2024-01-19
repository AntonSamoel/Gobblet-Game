using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Cell
	{
        public Stack<Piece> Pieces { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

		public Color Color { get; set; }
		public Cell(int row,int column )
		{
			Row = row;
			Column = column;
			Pieces = new Stack<Piece>();
		}
	}
}
