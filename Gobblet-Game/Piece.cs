using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Piece
	{
		public Piece(int size, string playerName)
		{
			Size = size;
			PlayerName = playerName;
		}

		public int Size { get; set; }
        public string PlayerName { get; set; } = "Player 1";

    }
}
