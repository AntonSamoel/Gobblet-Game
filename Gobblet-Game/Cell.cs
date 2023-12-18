using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Cell
	{
        public Stack<Piece> Pieces { get; set; } = new Stack<Piece>();
        public int Row { get; set; }
        public int Column { get; set; }

		public Cell( int row, int column)
		{
			Row = row;
			Column = column;
		}
	}
}
