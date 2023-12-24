using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Piece
	{
        public int Id { get; set; }
        public Color Color { get; set; }
        public bool IsOut { get; set; }
        public Piece(int id,int size, string playerName)
		{
			Id = id;
			Size = size;
			PlayerName = playerName;
		}

		public int Size { get; set; }
        public string PlayerName { get; set; } = "Player 1";

    }
}
