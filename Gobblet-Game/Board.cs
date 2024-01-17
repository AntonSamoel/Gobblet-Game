using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Board
	{
		public Cell[,] Celles { get; set; }

        public Board(Cell[,] cells)
        {
			Celles = cells; 
		}
    }
}
