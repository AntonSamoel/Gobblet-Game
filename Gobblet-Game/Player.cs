using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Player
	{
		public Player(string name, bool isMyTurn, List<Stack<Piece>> pieces)
		{
			Name = name;
			IsMyTurn = isMyTurn;
			Pieces = pieces;
		}

		public string Name { get; set; }
        public bool IsMyTurn { get; set; }
		public List<Stack<Piece>> Pieces { get; set; }
    }
}

