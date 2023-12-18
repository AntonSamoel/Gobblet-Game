using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Board
	{
		public Board(Cell[] celles)
		{
			Celles = celles;
		}

		public Cell[] Celles { get; set; }
    }
}
