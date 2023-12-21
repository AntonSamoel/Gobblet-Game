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

		public Cell( )
		{
			Pieces = new Stack<Piece>();
		}
	}
}
