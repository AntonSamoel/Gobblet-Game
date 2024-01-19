using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Game
	{
		public Game(Board board, Player[] players)
		{
			Board = board;
			Players = players;
		}

		public Board Board { get; set; }
        public Player[] Players { get; set; }
    }
}
