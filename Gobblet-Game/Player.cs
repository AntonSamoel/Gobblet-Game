using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobblet_Game
{
	public class Player(string name, bool isMyTurn, string color, List<Stack<Piece>> pieces)
    {
        public string Name { get; set; } = name;
        public bool IsMyTurn { get; set; } = isMyTurn;

        public bool IsComputer {  get; set; }
        public PreviousMoves previousMoves { get; set; } = new();
        public string Color { get; set; } = color;
        public List<Stack<Piece>> Pieces { get; set; } = pieces;
    }
}

